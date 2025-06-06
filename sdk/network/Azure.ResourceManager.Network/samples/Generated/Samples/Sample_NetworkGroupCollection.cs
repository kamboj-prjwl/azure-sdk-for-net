// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.Network.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_NetworkGroupCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_NetworkGroupsPut()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/NetworkManagerGroupPut.json
            // this example is just showing the usage of "NetworkGroups_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkManagerResource created on azure
            // for more information of creating NetworkManagerResource, please refer to the document of NetworkManagerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            ResourceIdentifier networkManagerResourceId = NetworkManagerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName);
            NetworkManagerResource networkManager = client.GetNetworkManagerResource(networkManagerResourceId);

            // get the collection of this NetworkGroupResource
            NetworkGroupCollection collection = networkManager.GetNetworkGroups();

            // invoke the operation
            string networkGroupName = "testNetworkGroup";
            NetworkGroupData data = new NetworkGroupData
            {
                Description = "A sample group",
                MemberType = NetworkGroupMemberType.VirtualNetwork,
            };
            ArmOperation<NetworkGroupResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, networkGroupName, data);
            NetworkGroupResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_NetworkGroupsGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/NetworkManagerGroupGet.json
            // this example is just showing the usage of "NetworkGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkManagerResource created on azure
            // for more information of creating NetworkManagerResource, please refer to the document of NetworkManagerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            ResourceIdentifier networkManagerResourceId = NetworkManagerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName);
            NetworkManagerResource networkManager = client.GetNetworkManagerResource(networkManagerResourceId);

            // get the collection of this NetworkGroupResource
            NetworkGroupCollection collection = networkManager.GetNetworkGroups();

            // invoke the operation
            string networkGroupName = "testNetworkGroup";
            NetworkGroupResource result = await collection.GetAsync(networkGroupName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkGroupData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_NetworkGroupsList()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/NetworkManagerGroupList.json
            // this example is just showing the usage of "NetworkGroups_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkManagerResource created on azure
            // for more information of creating NetworkManagerResource, please refer to the document of NetworkManagerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            ResourceIdentifier networkManagerResourceId = NetworkManagerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName);
            NetworkManagerResource networkManager = client.GetNetworkManagerResource(networkManagerResourceId);

            // get the collection of this NetworkGroupResource
            NetworkGroupCollection collection = networkManager.GetNetworkGroups();

            // invoke the operation and iterate over the result
            await foreach (NetworkGroupResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkGroupData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_NetworkGroupsGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/NetworkManagerGroupGet.json
            // this example is just showing the usage of "NetworkGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkManagerResource created on azure
            // for more information of creating NetworkManagerResource, please refer to the document of NetworkManagerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            ResourceIdentifier networkManagerResourceId = NetworkManagerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName);
            NetworkManagerResource networkManager = client.GetNetworkManagerResource(networkManagerResourceId);

            // get the collection of this NetworkGroupResource
            NetworkGroupCollection collection = networkManager.GetNetworkGroups();

            // invoke the operation
            string networkGroupName = "testNetworkGroup";
            bool result = await collection.ExistsAsync(networkGroupName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_NetworkGroupsGet()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-05-01/examples/NetworkManagerGroupGet.json
            // this example is just showing the usage of "NetworkGroups_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkManagerResource created on azure
            // for more information of creating NetworkManagerResource, please refer to the document of NetworkManagerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string networkManagerName = "testNetworkManager";
            ResourceIdentifier networkManagerResourceId = NetworkManagerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkManagerName);
            NetworkManagerResource networkManager = client.GetNetworkManagerResource(networkManagerResourceId);

            // get the collection of this NetworkGroupResource
            NetworkGroupCollection collection = networkManager.GetNetworkGroups();

            // invoke the operation
            string networkGroupName = "testNetworkGroup";
            NullableResponse<NetworkGroupResource> response = await collection.GetIfExistsAsync(networkGroupName);
            NetworkGroupResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkGroupData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
