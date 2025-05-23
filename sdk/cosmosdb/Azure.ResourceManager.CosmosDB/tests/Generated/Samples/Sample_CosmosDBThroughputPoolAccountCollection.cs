// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.CosmosDB.Samples
{
    public partial class Sample_CosmosDBThroughputPoolAccountCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CosmosDBThroughputPoolAccountCreate()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/throughputPool/CosmosDBThroughputPoolAccountCreate.json
            // this example is just showing the usage of "ThroughputPoolAccount_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBThroughputPoolResource created on azure
            // for more information of creating CosmosDBThroughputPoolResource, please refer to the document of CosmosDBThroughputPoolResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "rg1";
            string throughputPoolName = "tp1";
            ResourceIdentifier cosmosDBThroughputPoolResourceId = CosmosDBThroughputPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, throughputPoolName);
            CosmosDBThroughputPoolResource cosmosDBThroughputPool = client.GetCosmosDBThroughputPoolResource(cosmosDBThroughputPoolResourceId);

            // get the collection of this CosmosDBThroughputPoolAccountResource
            CosmosDBThroughputPoolAccountCollection collection = cosmosDBThroughputPool.GetCosmosDBThroughputPoolAccounts();

            // invoke the operation
            string throughputPoolAccountName = "db1";
            CosmosDBThroughputPoolAccountData data = new CosmosDBThroughputPoolAccountData
            {
                AccountResourceIdentifier = new ResourceIdentifier("/subscriptions/ffffffff-ffff-ffff-ffff-ffffffffffff/providers/Microsoft.DocumentDB/resourceGroup/rg1/databaseAccounts/db1/"),
                AccountLocation = new AzureLocation("West US"),
            };
            ArmOperation<CosmosDBThroughputPoolAccountResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, throughputPoolAccountName, data);
            CosmosDBThroughputPoolAccountResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBThroughputPoolAccountData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_CosmosDBThroughputPoolAccountGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/throughputPool/CosmosDBThroughputPoolAccountGet.json
            // this example is just showing the usage of "ThroughputPoolAccount_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBThroughputPoolResource created on azure
            // for more information of creating CosmosDBThroughputPoolResource, please refer to the document of CosmosDBThroughputPoolResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "rgName";
            string throughputPoolName = "tp1";
            ResourceIdentifier cosmosDBThroughputPoolResourceId = CosmosDBThroughputPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, throughputPoolName);
            CosmosDBThroughputPoolResource cosmosDBThroughputPool = client.GetCosmosDBThroughputPoolResource(cosmosDBThroughputPoolResourceId);

            // get the collection of this CosmosDBThroughputPoolAccountResource
            CosmosDBThroughputPoolAccountCollection collection = cosmosDBThroughputPool.GetCosmosDBThroughputPoolAccounts();

            // invoke the operation
            string throughputPoolAccountName = "db1";
            CosmosDBThroughputPoolAccountResource result = await collection.GetAsync(throughputPoolAccountName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            CosmosDBThroughputPoolAccountData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_CosmosDBThroughputPoolAccountList()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/throughputPool/CosmosDBThroughputPoolAccountsList.json
            // this example is just showing the usage of "ThroughputPoolAccounts_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBThroughputPoolResource created on azure
            // for more information of creating CosmosDBThroughputPoolResource, please refer to the document of CosmosDBThroughputPoolResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "rgName";
            string throughputPoolName = "tp1";
            ResourceIdentifier cosmosDBThroughputPoolResourceId = CosmosDBThroughputPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, throughputPoolName);
            CosmosDBThroughputPoolResource cosmosDBThroughputPool = client.GetCosmosDBThroughputPoolResource(cosmosDBThroughputPoolResourceId);

            // get the collection of this CosmosDBThroughputPoolAccountResource
            CosmosDBThroughputPoolAccountCollection collection = cosmosDBThroughputPool.GetCosmosDBThroughputPoolAccounts();

            // invoke the operation and iterate over the result
            await foreach (CosmosDBThroughputPoolAccountResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CosmosDBThroughputPoolAccountData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_CosmosDBThroughputPoolAccountGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/throughputPool/CosmosDBThroughputPoolAccountGet.json
            // this example is just showing the usage of "ThroughputPoolAccount_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBThroughputPoolResource created on azure
            // for more information of creating CosmosDBThroughputPoolResource, please refer to the document of CosmosDBThroughputPoolResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "rgName";
            string throughputPoolName = "tp1";
            ResourceIdentifier cosmosDBThroughputPoolResourceId = CosmosDBThroughputPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, throughputPoolName);
            CosmosDBThroughputPoolResource cosmosDBThroughputPool = client.GetCosmosDBThroughputPoolResource(cosmosDBThroughputPoolResourceId);

            // get the collection of this CosmosDBThroughputPoolAccountResource
            CosmosDBThroughputPoolAccountCollection collection = cosmosDBThroughputPool.GetCosmosDBThroughputPoolAccounts();

            // invoke the operation
            string throughputPoolAccountName = "db1";
            bool result = await collection.ExistsAsync(throughputPoolAccountName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_CosmosDBThroughputPoolAccountGet()
        {
            // Generated from example definition: specification/cosmos-db/resource-manager/Microsoft.DocumentDB/preview/2024-12-01-preview/examples/throughputPool/CosmosDBThroughputPoolAccountGet.json
            // this example is just showing the usage of "ThroughputPoolAccount_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this CosmosDBThroughputPoolResource created on azure
            // for more information of creating CosmosDBThroughputPoolResource, please refer to the document of CosmosDBThroughputPoolResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "rgName";
            string throughputPoolName = "tp1";
            ResourceIdentifier cosmosDBThroughputPoolResourceId = CosmosDBThroughputPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, throughputPoolName);
            CosmosDBThroughputPoolResource cosmosDBThroughputPool = client.GetCosmosDBThroughputPoolResource(cosmosDBThroughputPoolResourceId);

            // get the collection of this CosmosDBThroughputPoolAccountResource
            CosmosDBThroughputPoolAccountCollection collection = cosmosDBThroughputPool.GetCosmosDBThroughputPoolAccounts();

            // invoke the operation
            string throughputPoolAccountName = "db1";
            NullableResponse<CosmosDBThroughputPoolAccountResource> response = await collection.GetIfExistsAsync(throughputPoolAccountName);
            CosmosDBThroughputPoolAccountResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                CosmosDBThroughputPoolAccountData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
