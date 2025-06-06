﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Test.Perf;

namespace Azure.Storage.Blobs.Perf
{
    public abstract class ServiceTest<TOptions> : PerfTest<TOptions> where TOptions : PerfOptions
    {
        protected BlobServiceClient BlobServiceClient { get; private set; }
        protected StorageSharedKeyCredential StorageSharedKeyCredential { get; private set; }

        public ServiceTest(TOptions options) : base(options)
        {
            BlobClientOptions clientOptions = options is Options.IBlobClientOptionsProvider clientOptionsOptions
                ? clientOptionsOptions.ClientOptions
                : new BlobClientOptions();
            BlobServiceClient = new BlobServiceClient(
                PerfTestEnvironment.Instance.StorageEndpoint,
                PerfTestEnvironment.Instance.Credential,
                ConfigureClientOptions(clientOptions));

            // Can't do shared key tests if shared key wasn't provided
            if (PerfTestEnvironment.Instance.StorageAccountKey != null)
            {
                StorageSharedKeyCredential = new StorageSharedKeyCredential(
                    PerfTestEnvironment.Instance.StorageAccountName, PerfTestEnvironment.Instance.StorageAccountKey);
            }
        }
    }
}
