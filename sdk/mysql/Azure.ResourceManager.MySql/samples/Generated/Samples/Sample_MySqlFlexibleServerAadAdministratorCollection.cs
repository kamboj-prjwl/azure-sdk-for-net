// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.MySql.FlexibleServers.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.MySql.FlexibleServers.Samples
{
    public partial class Sample_MySqlFlexibleServerAadAdministratorCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateAnAzureAdAdministrator()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/AAD/stable/2023-12-30/examples/AzureADAdministratorCreate.json
            // this example is just showing the usage of "AzureADAdministrators_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServerResource created on azure
            // for more information of creating MySqlFlexibleServerResource, please refer to the document of MySqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            string serverName = "mysqltestsvc4";
            ResourceIdentifier mySqlFlexibleServerResourceId = MySqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlFlexibleServerResource mySqlFlexibleServer = client.GetMySqlFlexibleServerResource(mySqlFlexibleServerResourceId);

            // get the collection of this MySqlFlexibleServerAadAdministratorResource
            MySqlFlexibleServerAadAdministratorCollection collection = mySqlFlexibleServer.GetMySqlFlexibleServerAadAdministrators();

            // invoke the operation
            MySqlFlexibleServerAdministratorName administratorName = MySqlFlexibleServerAdministratorName.ActiveDirectory;
            MySqlFlexibleServerAadAdministratorData data = new MySqlFlexibleServerAadAdministratorData
            {
                AdministratorType = MySqlFlexibleServerAdministratorType.ActiveDirectory,
                Login = "bob@contoso.com",
                Sid = "c6b82b90-a647-49cb-8a62-0d2d3cb7ac7c",
                TenantId = Guid.Parse("c12b7025-bfe2-46c1-b463-993b5e4cd467"),
                IdentityResourceId = new ResourceIdentifier("/subscriptions/ffffffff-ffff-ffff-ffff-ffffffffffff/resourceGroups/test-group/providers/Microsoft.ManagedIdentity/userAssignedIdentities/test-umi"),
            };
            ArmOperation<MySqlFlexibleServerAadAdministratorResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, administratorName, data);
            MySqlFlexibleServerAadAdministratorResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MySqlFlexibleServerAadAdministratorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAnAzureAdAdministrator()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/AAD/stable/2023-12-30/examples/AzureADAdministratorGet.json
            // this example is just showing the usage of "AzureADAdministrators_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServerResource created on azure
            // for more information of creating MySqlFlexibleServerResource, please refer to the document of MySqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            string serverName = "mysqltestsvc4";
            ResourceIdentifier mySqlFlexibleServerResourceId = MySqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlFlexibleServerResource mySqlFlexibleServer = client.GetMySqlFlexibleServerResource(mySqlFlexibleServerResourceId);

            // get the collection of this MySqlFlexibleServerAadAdministratorResource
            MySqlFlexibleServerAadAdministratorCollection collection = mySqlFlexibleServer.GetMySqlFlexibleServerAadAdministrators();

            // invoke the operation
            MySqlFlexibleServerAdministratorName administratorName = MySqlFlexibleServerAdministratorName.ActiveDirectory;
            MySqlFlexibleServerAadAdministratorResource result = await collection.GetAsync(administratorName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MySqlFlexibleServerAadAdministratorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListAzureADAdministratorsInAServer()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/AAD/stable/2023-12-30/examples/AzureADAdministratorsListByServer.json
            // this example is just showing the usage of "AzureADAdministrators_ListByServer" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServerResource created on azure
            // for more information of creating MySqlFlexibleServerResource, please refer to the document of MySqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            string serverName = "mysqltestsvc4";
            ResourceIdentifier mySqlFlexibleServerResourceId = MySqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlFlexibleServerResource mySqlFlexibleServer = client.GetMySqlFlexibleServerResource(mySqlFlexibleServerResourceId);

            // get the collection of this MySqlFlexibleServerAadAdministratorResource
            MySqlFlexibleServerAadAdministratorCollection collection = mySqlFlexibleServer.GetMySqlFlexibleServerAadAdministrators();

            // invoke the operation and iterate over the result
            await foreach (MySqlFlexibleServerAadAdministratorResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MySqlFlexibleServerAadAdministratorData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetAnAzureAdAdministrator()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/AAD/stable/2023-12-30/examples/AzureADAdministratorGet.json
            // this example is just showing the usage of "AzureADAdministrators_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServerResource created on azure
            // for more information of creating MySqlFlexibleServerResource, please refer to the document of MySqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            string serverName = "mysqltestsvc4";
            ResourceIdentifier mySqlFlexibleServerResourceId = MySqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlFlexibleServerResource mySqlFlexibleServer = client.GetMySqlFlexibleServerResource(mySqlFlexibleServerResourceId);

            // get the collection of this MySqlFlexibleServerAadAdministratorResource
            MySqlFlexibleServerAadAdministratorCollection collection = mySqlFlexibleServer.GetMySqlFlexibleServerAadAdministrators();

            // invoke the operation
            MySqlFlexibleServerAdministratorName administratorName = MySqlFlexibleServerAdministratorName.ActiveDirectory;
            bool result = await collection.ExistsAsync(administratorName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetAnAzureAdAdministrator()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/AAD/stable/2023-12-30/examples/AzureADAdministratorGet.json
            // this example is just showing the usage of "AzureADAdministrators_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlFlexibleServerResource created on azure
            // for more information of creating MySqlFlexibleServerResource, please refer to the document of MySqlFlexibleServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testrg";
            string serverName = "mysqltestsvc4";
            ResourceIdentifier mySqlFlexibleServerResourceId = MySqlFlexibleServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlFlexibleServerResource mySqlFlexibleServer = client.GetMySqlFlexibleServerResource(mySqlFlexibleServerResourceId);

            // get the collection of this MySqlFlexibleServerAadAdministratorResource
            MySqlFlexibleServerAadAdministratorCollection collection = mySqlFlexibleServer.GetMySqlFlexibleServerAadAdministrators();

            // invoke the operation
            MySqlFlexibleServerAdministratorName administratorName = MySqlFlexibleServerAdministratorName.ActiveDirectory;
            NullableResponse<MySqlFlexibleServerAadAdministratorResource> response = await collection.GetIfExistsAsync(administratorName);
            MySqlFlexibleServerAadAdministratorResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MySqlFlexibleServerAadAdministratorData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
