using Amazon.DynamoDBv2.DataModel;

namespace net_poc_dynamodb.Documents
{
    [DynamoDBTable("restocking-automation")]
    public class Automation
    {
        [DynamoDBHashKey] public int ProductGroupId { get; set; }

        [DynamoDBRangeKey] public int ProductTypeId { get; set; }

        public override string ToString()
        {
            return $"Automation: [ProductGroupId: {ProductGroupId}] [ProductTypeId: {ProductTypeId}]";
        }
    }
}