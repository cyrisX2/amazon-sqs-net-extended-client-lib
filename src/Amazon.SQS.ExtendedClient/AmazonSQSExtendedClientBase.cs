﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.SQS.Model;

namespace Amazon.SQS.ExtendedClient
{
    public abstract class AmazonSQSExtendedClientBase : IAmazonSQS
    {
        private readonly IAmazonSQS _amazonSqsToBeExtended;

        protected AmazonSQSExtendedClientBase(IAmazonSQS sqsClient)
        {
            _amazonSqsToBeExtended = sqsClient;
        }

        public void Dispose()
        {
            _amazonSqsToBeExtended.Dispose();
        }

#if NET45
        public Dictionary<string, string> GetAttributes(string queueUrl)
        {
            return amazonSqsToBeExtended.GetAttributes(queueUrl);
        }
#endif

        public Task<Dictionary<string, string>> GetAttributesAsync(string queueUrl)
        {
            return _amazonSqsToBeExtended.GetAttributesAsync(queueUrl);
        }

#if NET45
        public void SetAttributes(string queueUrl, Dictionary<string, string> attributes)
        {
            amazonSqsToBeExtended.SetAttributes(queueUrl, attributes);
        }
#endif

        public Task SetAttributesAsync(string queueUrl, Dictionary<string, string> attributes)
        {
            return _amazonSqsToBeExtended.SetAttributesAsync(queueUrl, attributes);
        }

#if NET45
        public string AuthorizeS3ToSendMessage(string queueUrl, string bucket)
        {
            return amazonSqsToBeExtended.AuthorizeS3ToSendMessage(queueUrl, bucket);
        }
#endif

        public Task<string> AuthorizeS3ToSendMessageAsync(string queueUrl, string bucket)
        {
            return _amazonSqsToBeExtended.AuthorizeS3ToSendMessageAsync(queueUrl, bucket);
        }

#if NET45
        public AddPermissionResponse AddPermission(string queueUrl, string label, List<string> awsAccountIds, List<string> actions)
        {
            return amazonSqsToBeExtended.AddPermission(queueUrl, label, awsAccountIds, actions);
        }

        public AddPermissionResponse AddPermission(AddPermissionRequest request)
        {
            return amazonSqsToBeExtended.AddPermission(request);
        }
#endif

        public Task<AddPermissionResponse> AddPermissionAsync(string queueUrl, string label, List<string> awsAccountIds,
            List<string> actions, CancellationToken cancellationToken = default(CancellationToken))
        {
            return _amazonSqsToBeExtended.AddPermissionAsync(queueUrl, label, awsAccountIds, actions,
                cancellationToken);
        }

        public Task<AddPermissionResponse> AddPermissionAsync(AddPermissionRequest request,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return _amazonSqsToBeExtended.AddPermissionAsync(request, cancellationToken);
        }

#if NET45
        public ChangeMessageVisibilityResponse ChangeMessageVisibility(string queueUrl, string receiptHandle, int visibilityTimeout)
        {
            return amazonSqsToBeExtended.ChangeMessageVisibility(queueUrl, receiptHandle, visibilityTimeout);
        }

        public ChangeMessageVisibilityResponse ChangeMessageVisibility(ChangeMessageVisibilityRequest request)
        {
            return amazonSqsToBeExtended.ChangeMessageVisibility(request);
        }
#endif

        public Task<ChangeMessageVisibilityResponse> ChangeMessageVisibilityAsync(string queueUrl, string receiptHandle,
            int visibilityTimeout, CancellationToken cancellationToken = default(CancellationToken))
        {
            return _amazonSqsToBeExtended.ChangeMessageVisibilityAsync(queueUrl, receiptHandle, visibilityTimeout,
                cancellationToken);
        }

        public Task<ChangeMessageVisibilityResponse> ChangeMessageVisibilityAsync(
            ChangeMessageVisibilityRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            return _amazonSqsToBeExtended.ChangeMessageVisibilityAsync(request, cancellationToken);
        }

#if NET45
        public ChangeMessageVisibilityBatchResponse ChangeMessageVisibilityBatch(string queueUrl, List<ChangeMessageVisibilityBatchRequestEntry> entries)
        {
            return amazonSqsToBeExtended.ChangeMessageVisibilityBatch(queueUrl, entries);
        }

        public ChangeMessageVisibilityBatchResponse ChangeMessageVisibilityBatch(ChangeMessageVisibilityBatchRequest request)
        {
            return amazonSqsToBeExtended.ChangeMessageVisibilityBatch(request);
        }
        
#endif

        public Task<ChangeMessageVisibilityBatchResponse> ChangeMessageVisibilityBatchAsync(string queueUrl,
            List<ChangeMessageVisibilityBatchRequestEntry> entries,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return _amazonSqsToBeExtended.ChangeMessageVisibilityBatchAsync(queueUrl, entries, cancellationToken);
        }

        public Task<ChangeMessageVisibilityBatchResponse> ChangeMessageVisibilityBatchAsync(
            ChangeMessageVisibilityBatchRequest request,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return _amazonSqsToBeExtended.ChangeMessageVisibilityBatchAsync(request, cancellationToken);
        }

#if NET45
        public CreateQueueResponse CreateQueue(string queueName)
        {
            return amazonSqsToBeExtended.CreateQueue(queueName);
        }

        public CreateQueueResponse CreateQueue(CreateQueueRequest request)
        {
            return amazonSqsToBeExtended.CreateQueue(request);
        }
#endif

        public Task<CreateQueueResponse> CreateQueueAsync(string queueName,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return _amazonSqsToBeExtended.CreateQueueAsync(queueName, cancellationToken);
        }

        public Task<CreateQueueResponse> CreateQueueAsync(CreateQueueRequest request,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return _amazonSqsToBeExtended.CreateQueueAsync(request, cancellationToken);
        }

#if NET45
        public virtual DeleteMessageResponse DeleteMessage(string queueUrl, string receiptHandle)
        {
            return amazonSqsToBeExtended.DeleteMessage(queueUrl, receiptHandle);
        }

        public virtual DeleteMessageResponse DeleteMessage(DeleteMessageRequest request)
        {
            return amazonSqsToBeExtended.DeleteMessage(request);
        }
#endif
        public virtual Task<DeleteMessageResponse> DeleteMessageAsync(string queueUrl, string receiptHandle,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return _amazonSqsToBeExtended.DeleteMessageAsync(queueUrl, receiptHandle, cancellationToken);
        }

        public virtual Task<DeleteMessageResponse> DeleteMessageAsync(DeleteMessageRequest request,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return _amazonSqsToBeExtended.DeleteMessageAsync(request, cancellationToken);
        }

#if NET45
        public virtual DeleteMessageBatchResponse DeleteMessageBatch(string queueUrl, List<DeleteMessageBatchRequestEntry> entries)
        {
            return amazonSqsToBeExtended.DeleteMessageBatch(queueUrl, entries);
        }

        public virtual DeleteMessageBatchResponse DeleteMessageBatch(DeleteMessageBatchRequest request)
        {
            return amazonSqsToBeExtended.DeleteMessageBatch(request);
        }
#endif

        public virtual Task<DeleteMessageBatchResponse> DeleteMessageBatchAsync(string queueUrl,
            List<DeleteMessageBatchRequestEntry> entries,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return _amazonSqsToBeExtended.DeleteMessageBatchAsync(queueUrl, entries, cancellationToken);
        }

        public virtual Task<DeleteMessageBatchResponse> DeleteMessageBatchAsync(DeleteMessageBatchRequest request,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return _amazonSqsToBeExtended.DeleteMessageBatchAsync(request, cancellationToken);
        }

#if NET45
        public DeleteQueueResponse DeleteQueue(string queueUrl)
        {
            return amazonSqsToBeExtended.DeleteQueue(queueUrl);
        }

        public DeleteQueueResponse DeleteQueue(DeleteQueueRequest request)
        {
            return amazonSqsToBeExtended.DeleteQueue(request);
        }
#endif

        public Task<DeleteQueueResponse> DeleteQueueAsync(string queueUrl,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return _amazonSqsToBeExtended.DeleteQueueAsync(queueUrl, cancellationToken);
        }

        public Task<DeleteQueueResponse> DeleteQueueAsync(DeleteQueueRequest request,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return _amazonSqsToBeExtended.DeleteQueueAsync(request, cancellationToken);
        }

#if NET45
        public GetQueueAttributesResponse GetQueueAttributes(string queueUrl, List<string> attributeNames)
        {
            return amazonSqsToBeExtended.GetQueueAttributes(queueUrl, attributeNames);
        }

        public GetQueueAttributesResponse GetQueueAttributes(GetQueueAttributesRequest request)
        {
            return amazonSqsToBeExtended.GetQueueAttributes(request);
        }
#endif

        public Task<GetQueueAttributesResponse> GetQueueAttributesAsync(string queueUrl, List<string> attributeNames,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return _amazonSqsToBeExtended.GetQueueAttributesAsync(queueUrl, attributeNames, cancellationToken);
        }

        public Task<GetQueueAttributesResponse> GetQueueAttributesAsync(GetQueueAttributesRequest request,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return _amazonSqsToBeExtended.GetQueueAttributesAsync(request, cancellationToken);
        }

#if NET45
        public GetQueueUrlResponse GetQueueUrl(string queueName)
        {
            return amazonSqsToBeExtended.GetQueueUrl(queueName);
        }

        public GetQueueUrlResponse GetQueueUrl(GetQueueUrlRequest request)
        {
            return amazonSqsToBeExtended.GetQueueUrl(request);
        }
#endif

        public Task<GetQueueUrlResponse> GetQueueUrlAsync(string queueName,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return _amazonSqsToBeExtended.GetQueueUrlAsync(queueName, cancellationToken);
        }

        public Task<GetQueueUrlResponse> GetQueueUrlAsync(GetQueueUrlRequest request,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return _amazonSqsToBeExtended.GetQueueUrlAsync(request, cancellationToken);
        }

#if NET45
        public ListDeadLetterSourceQueuesResponse ListDeadLetterSourceQueues(ListDeadLetterSourceQueuesRequest request)
        {
            return amazonSqsToBeExtended.ListDeadLetterSourceQueues(request);
        }
#endif

        public Task<ListDeadLetterSourceQueuesResponse> ListDeadLetterSourceQueuesAsync(
            ListDeadLetterSourceQueuesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            return _amazonSqsToBeExtended.ListDeadLetterSourceQueuesAsync(request, cancellationToken);
        }

#if NET45
        public ListQueuesResponse ListQueues(string queueNamePrefix)
        {
            return amazonSqsToBeExtended.ListQueues(queueNamePrefix);
        }

        public ListQueuesResponse ListQueues(ListQueuesRequest request)
        {
            return amazonSqsToBeExtended.ListQueues(request);
        }
#endif

        public Task<ListQueuesResponse> ListQueuesAsync(string queueNamePrefix,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return _amazonSqsToBeExtended.ListQueuesAsync(queueNamePrefix, cancellationToken);
        }

        public Task<ListQueuesResponse> ListQueuesAsync(ListQueuesRequest request,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return _amazonSqsToBeExtended.ListQueuesAsync(request, cancellationToken);
        }

#if NET45
        public ListQueueTagsResponse ListQueueTags(ListQueueTagsRequest request)
        {
            return amazonSqsToBeExtended.ListQueueTags(request);
        }
#endif

        public Task<ListQueueTagsResponse> ListQueueTagsAsync(ListQueueTagsRequest request,
            CancellationToken cancellationToken = new CancellationToken())
        {
            return _amazonSqsToBeExtended.ListQueueTagsAsync(request, cancellationToken);
        }

#if NET45
        public PurgeQueueResponse PurgeQueue(string queueUrl)
        {
            return amazonSqsToBeExtended.PurgeQueue(queueUrl);
        }

        public PurgeQueueResponse PurgeQueue(PurgeQueueRequest request)
        {
            return amazonSqsToBeExtended.PurgeQueue(request);
        }
#endif

        public Task<PurgeQueueResponse> PurgeQueueAsync(string queueUrl,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return _amazonSqsToBeExtended.PurgeQueueAsync(queueUrl, cancellationToken);
        }

        public Task<PurgeQueueResponse> PurgeQueueAsync(PurgeQueueRequest request,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return _amazonSqsToBeExtended.PurgeQueueAsync(request, cancellationToken);
        }

#if NET45
        public virtual ReceiveMessageResponse ReceiveMessage(string queueUrl)
        {
            return amazonSqsToBeExtended.ReceiveMessage(queueUrl);
        }

        public virtual ReceiveMessageResponse ReceiveMessage(ReceiveMessageRequest request)
        {
            return amazonSqsToBeExtended.ReceiveMessage(request);
        }
#endif

        public virtual Task<ReceiveMessageResponse> ReceiveMessageAsync(string queueUrl,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return _amazonSqsToBeExtended.ReceiveMessageAsync(queueUrl, cancellationToken);
        }

        public virtual Task<ReceiveMessageResponse> ReceiveMessageAsync(ReceiveMessageRequest request,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return _amazonSqsToBeExtended.ReceiveMessageAsync(request, cancellationToken);
        }

#if NET45
        public RemovePermissionResponse RemovePermission(string queueUrl, string label)
        {
            return amazonSqsToBeExtended.RemovePermission(queueUrl, label);
        }

        public RemovePermissionResponse RemovePermission(RemovePermissionRequest request)
        {
            return amazonSqsToBeExtended.RemovePermission(request);
        }
#endif

        public Task<RemovePermissionResponse> RemovePermissionAsync(string queueUrl, string label,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return _amazonSqsToBeExtended.RemovePermissionAsync(queueUrl, label, cancellationToken);
        }

        public Task<RemovePermissionResponse> RemovePermissionAsync(RemovePermissionRequest request,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return _amazonSqsToBeExtended.RemovePermissionAsync(request, cancellationToken);
        }

#if NET45
        public virtual SendMessageResponse SendMessage(string queueUrl, string messageBody)
        {
            return amazonSqsToBeExtended.SendMessage(queueUrl, messageBody);
        }

        public virtual SendMessageResponse SendMessage(SendMessageRequest request)
        {
            return amazonSqsToBeExtended.SendMessage(request);
        }
#endif

        public virtual Task<SendMessageResponse> SendMessageAsync(string queueUrl, string messageBody,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return _amazonSqsToBeExtended.SendMessageAsync(queueUrl, messageBody, cancellationToken);
        }

        public virtual Task<SendMessageResponse> SendMessageAsync(SendMessageRequest request,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return _amazonSqsToBeExtended.SendMessageAsync(request, cancellationToken);
        }

#if NET45
        public virtual SendMessageBatchResponse SendMessageBatch(string queueUrl, List<SendMessageBatchRequestEntry> entries)
        {
            return amazonSqsToBeExtended.SendMessageBatch(queueUrl, entries);
        }

        public virtual SendMessageBatchResponse SendMessageBatch(SendMessageBatchRequest request)
        {
            return amazonSqsToBeExtended.SendMessageBatch(request);
        }
#endif

        public virtual Task<SendMessageBatchResponse> SendMessageBatchAsync(string queueUrl,
            List<SendMessageBatchRequestEntry> entries,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return _amazonSqsToBeExtended.SendMessageBatchAsync(queueUrl, entries, cancellationToken);
        }

        public virtual Task<SendMessageBatchResponse> SendMessageBatchAsync(SendMessageBatchRequest request,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return _amazonSqsToBeExtended.SendMessageBatchAsync(request, cancellationToken);
        }

#if NET45
        public SetQueueAttributesResponse SetQueueAttributes(string queueUrl, Dictionary<string, string> attributes)
        {
            return amazonSqsToBeExtended.SetQueueAttributes(queueUrl, attributes);
        }

        public SetQueueAttributesResponse SetQueueAttributes(SetQueueAttributesRequest request)
        {
            return amazonSqsToBeExtended.SetQueueAttributes(request);
        }
#endif

        public Task<SetQueueAttributesResponse> SetQueueAttributesAsync(string queueUrl,
            Dictionary<string, string> attributes, CancellationToken cancellationToken = default(CancellationToken))
        {
            return _amazonSqsToBeExtended.SetQueueAttributesAsync(queueUrl, attributes, cancellationToken);
        }

        public Task<SetQueueAttributesResponse> SetQueueAttributesAsync(SetQueueAttributesRequest request,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return _amazonSqsToBeExtended.SetQueueAttributesAsync(request, cancellationToken);
        }

#if NET45
        public TagQueueResponse TagQueue(TagQueueRequest request)
        {
            return amazonSqsToBeExtended.TagQueue(request);
        }
#endif

        public Task<TagQueueResponse> TagQueueAsync(TagQueueRequest request,
            CancellationToken cancellationToken = new CancellationToken())
        {
            return _amazonSqsToBeExtended.TagQueueAsync(request, cancellationToken);
        }

#if NET45
        public UntagQueueResponse UntagQueue(UntagQueueRequest request)
        {
            return amazonSqsToBeExtended.UntagQueue(request);
        }
#endif

        public Task<UntagQueueResponse> UntagQueueAsync(UntagQueueRequest request,
            CancellationToken cancellationToken = new CancellationToken())
        {
            return _amazonSqsToBeExtended.UntagQueueAsync(request, cancellationToken);
        }

        public IClientConfig Config => _amazonSqsToBeExtended.Config;
    }
}