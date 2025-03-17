using Amazon.CDK;
using Amazon.CDK.AWS.EC2;
using Amazon.CDK.AWS.S3;
using Constructs;

namespace CdkCSharpTest2
{
    public class CdkCSharpTest2Stack : Stack
    {
        internal CdkCSharpTest2Stack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {

            var vpc = new Vpc(this, "myVpc")
            {
                
            };
            
            // The code that defines your stack goes here
            var bucket = new MimeBucket(this, "amzn-s3-demo-bucket", new MimeBucketProps
            {
                Versioned = true,
                MimeType = "image/jpeg"
            });

            bucket.ApplyRemovalPolicy(RemovalPolicy.RETAIN);
        }
    }

    class MimeBucketProps : BucketProps
    {
        public string MimeType { get; set; }
    }

    // hypothetical bucket that enforces MIME type of objects inside it
    class MimeBucket : Bucket
    {
        public MimeBucket(Construct scope, string id, MimeBucketProps props = null) : base(scope, id, props)
        {
            // ...
        }
    }
}
