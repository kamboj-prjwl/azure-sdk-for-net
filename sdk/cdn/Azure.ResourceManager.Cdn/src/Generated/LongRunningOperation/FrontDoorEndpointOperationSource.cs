// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Cdn
{
    internal class FrontDoorEndpointOperationSource : IOperationSource<FrontDoorEndpointResource>
    {
        private readonly ArmClient _client;

        internal FrontDoorEndpointOperationSource(ArmClient client)
        {
            _client = client;
        }

        FrontDoorEndpointResource IOperationSource<FrontDoorEndpointResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<FrontDoorEndpointData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerCdnContext.Default);
            return new FrontDoorEndpointResource(_client, data);
        }

        async ValueTask<FrontDoorEndpointResource> IOperationSource<FrontDoorEndpointResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<FrontDoorEndpointData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerCdnContext.Default);
            return await Task.FromResult(new FrontDoorEndpointResource(_client, data)).ConfigureAwait(false);
        }
    }
}
