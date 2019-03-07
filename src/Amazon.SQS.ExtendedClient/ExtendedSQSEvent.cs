#if NETSTANDARD
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Lambda.SQSEvents;
using Amazon.Runtime;
using Amazon.S3;

namespace Amazon.SQS.ExtendedClient
{
    public static class ExtendedSQSEvent
    {
        /// <summary>
        ///     Read a list of messages from the queue. If the message was a pointer to S3 because the file was too big
        ///     take the data from S3 and place it into the body of the message. This allows the same processing
        ///     to be used for extended SQS and traditional SQS models
        /// </summary>
        /// <param name="s3Client">Client to read from S3</param>
        /// <param name="messages">The list of SQS messages from the queue</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<List<SQSEvent.SQSMessage>> ProcessMessagesAsync(IAmazonS3 s3Client,
            List<SQSEvent.SQSMessage> messages, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (messages == null) throw new AmazonClientException("Messages cannot be null");

            for (var i = 0; i < messages.Count; i++)
                messages[i] = await ProcessMessageAsync(s3Client, messages[i], cancellationToken).ConfigureAwait(false);

            return messages;
        }

        /// <summary>
        ///     Read a message from the queue. If the message was a pointer to S3 because the file was too big
        ///     take the data from S3 and place it into the body of the message. This allows the same processing
        ///     to be used for extended SQS and traditional SQS models
        /// </summary>
        /// <param name="s3Client">Client to read from S3</param>
        /// <param name="message">The SQS message from the queue</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<SQSEvent.SQSMessage> ProcessMessageAsync(IAmazonS3 s3Client,
            SQSEvent.SQSMessage message, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (message == null) throw new AmazonClientException("Message cannot be null");

            if (message.MessageAttributes == null || !message.MessageAttributes.TryGetValue(SQSExtendedClientConstants.RESERVED_ATTRIBUTE_NAME, out _))
                return message;

            MessageS3Pointer messageS3Pointer = AmazonSQSExtendedClient.ReadMessageS3PointerFromJson(message.Body);

            var originalMessageBody = await AmazonSQSExtendedClient.GetTextFromS3Async(s3Client, messageS3Pointer.S3BucketName, messageS3Pointer.S3Key, cancellationToken).ConfigureAwait(false);

            message.Body = originalMessageBody;
            message.ReceiptHandle = AmazonSQSExtendedClient.EmbedS3PointerInReceiptHandle(message.ReceiptHandle, messageS3Pointer.S3BucketName, messageS3Pointer.S3Key);
            message.MessageAttributes.Remove(SQSExtendedClientConstants.RESERVED_ATTRIBUTE_NAME);

            return message;
        }
    }
}
#endif