using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;

namespace net_poc_dynamodb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var config = new AmazonDynamoDBConfig() { RegionEndpoint = RegionEndpoint.EUWest1 };
                AmazonDynamoDBClient client = new AmazonDynamoDBClient();

                DynamoDBContext context = new DynamoDBContext(client);

                CrudThatFoo.Add(context);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("To continue, press Enter");
            Console.ReadLine();
        }
    }
}
