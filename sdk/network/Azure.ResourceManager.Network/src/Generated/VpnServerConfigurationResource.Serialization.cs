// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Network
{
    public partial class VpnServerConfigurationResource : IJsonModel<VpnServerConfigurationData>
    {
        void IJsonModel<VpnServerConfigurationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<VpnServerConfigurationData>)Data).Write(writer, options);

        VpnServerConfigurationData IJsonModel<VpnServerConfigurationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<VpnServerConfigurationData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<VpnServerConfigurationData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<VpnServerConfigurationData>(Data, options, AzureResourceManagerNetworkContext.Default);

        VpnServerConfigurationData IPersistableModel<VpnServerConfigurationData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<VpnServerConfigurationData>(data, options, AzureResourceManagerNetworkContext.Default);

        string IPersistableModel<VpnServerConfigurationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<VpnServerConfigurationData>)Data).GetFormatFromOptions(options);
    }
}
