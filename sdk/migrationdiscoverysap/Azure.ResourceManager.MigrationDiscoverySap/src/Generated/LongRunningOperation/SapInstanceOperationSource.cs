// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.MigrationDiscoverySap
{
    internal class SapInstanceOperationSource : IOperationSource<SapInstanceResource>
    {
        private readonly ArmClient _client;

        internal SapInstanceOperationSource(ArmClient client)
        {
            _client = client;
        }

        SapInstanceResource IOperationSource<SapInstanceResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<SapInstanceData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerMigrationDiscoverySapContext.Default);
            return new SapInstanceResource(_client, data);
        }

        async ValueTask<SapInstanceResource> IOperationSource<SapInstanceResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<SapInstanceData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerMigrationDiscoverySapContext.Default);
            return await Task.FromResult(new SapInstanceResource(_client, data)).ConfigureAwait(false);
        }
    }
}
