using Amazon.Runtime;
using Amazon.S3;

namespace Amazon.SQS.ExtendedClient
{
    public class ExtendedClientConfiguration
    {
        public ExtendedClientConfiguration()
        {
            S3 = null;
            S3BucketName = null;
            AlwaysThroughS3 = false;
            MessageSizeThreshold = SQSExtendedClientConstants.DEFAULT_MESSAGE_SIZE_THRESHOLD;
            S3KeyProvider = new GuidS3KeyProvider();
        }

        public ExtendedClientConfiguration(ExtendedClientConfiguration other)
        {
            S3 = other.S3;
            S3BucketName = other.S3BucketName;
            IsLargePayloadSupportEnabled = other.IsLargePayloadSupportEnabled;
            AlwaysThroughS3 = other.AlwaysThroughS3;
            MessageSizeThreshold = other.MessageSizeThreshold;
        }

        public IAmazonS3 S3 { get; private set; }

        public string S3BucketName { get; private set; }

        public bool AlwaysThroughS3 { get; set; }

        public int MessageSizeThreshold { get; set; }

        public bool IsLargePayloadSupportEnabled { get; private set; }

        public IS3KeyProvider S3KeyProvider { get; private set; }

        public bool RetainS3Messages { get; set; }

        public ExtendedClientConfiguration WithLargePayloadSupportEnabled(IAmazonS3 s3, string s3BucketName)
        {
            if (string.IsNullOrWhiteSpace(s3BucketName))
                throw new AmazonClientException("S3 bucket name cannot be null or empty");

            S3 = s3 ?? throw new AmazonClientException("S3 client cannot be null");
            S3BucketName = s3BucketName;
            IsLargePayloadSupportEnabled = true;

            return this;
        }

        public void SetLargePayloadSupportDisabled()
        {
            S3 = null;
            S3BucketName = null;
            IsLargePayloadSupportEnabled = false;
        }

        public ExtendedClientConfiguration WithLargePayloadSupportDisabled()
        {
            SetLargePayloadSupportDisabled();
            return this;
        }

        public ExtendedClientConfiguration WithMessageSizeThreshold(int messageSizeThreshold)
        {
            MessageSizeThreshold = messageSizeThreshold;
            return this;
        }

        public ExtendedClientConfiguration WithAlwaysThroughS3(bool alwaysThroughS3)
        {
            AlwaysThroughS3 = alwaysThroughS3;
            return this;
        }

        public ExtendedClientConfiguration WithS3KeyProvider(IS3KeyProvider provider)
        {
            S3KeyProvider = provider ?? throw new AmazonClientException("provider cannot be null");
            return this;
        }

        public ExtendedClientConfiguration WithRetainS3Messages(bool value)
        {
            RetainS3Messages = value;
            return this;
        }
    }
}