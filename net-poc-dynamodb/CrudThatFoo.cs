using System;

using Amazon.DynamoDBv2.DataModel;

using net_poc_dynamodb.Documents;

namespace net_poc_dynamodb
{
    public class CrudThatFoo
    {
        public static void Add(DynamoDBContext context)
        {
            Automation automation = new Automation
                                    {
                                        ProductGroupId = 1337,
                                        ProductTypeId = 58008
                                    };

            Console.WriteLine("Saving the following data: " + automation);

            context.Save(automation);

            Automation loadedAutomation = context.Load<Automation>(automation.ProductGroupId,
                automation.ProductTypeId,
                new DynamoDBOperationConfig
                {
                    ConsistentRead = true
                });

            Console.WriteLine("Read back the following data: " + loadedAutomation);
        }
    }
}