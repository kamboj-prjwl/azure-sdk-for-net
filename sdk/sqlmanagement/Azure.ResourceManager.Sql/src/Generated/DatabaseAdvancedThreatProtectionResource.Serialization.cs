// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Sql
{
    public partial class DatabaseAdvancedThreatProtectionResource : IJsonModel<DatabaseAdvancedThreatProtectionData>
    {
        void IJsonModel<DatabaseAdvancedThreatProtectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<DatabaseAdvancedThreatProtectionData>)Data).Write(writer, options);

        DatabaseAdvancedThreatProtectionData IJsonModel<DatabaseAdvancedThreatProtectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<DatabaseAdvancedThreatProtectionData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<DatabaseAdvancedThreatProtectionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<DatabaseAdvancedThreatProtectionData>(Data, options, AzureResourceManagerSqlContext.Default);

        DatabaseAdvancedThreatProtectionData IPersistableModel<DatabaseAdvancedThreatProtectionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<DatabaseAdvancedThreatProtectionData>(data, options, AzureResourceManagerSqlContext.Default);

        string IPersistableModel<DatabaseAdvancedThreatProtectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<DatabaseAdvancedThreatProtectionData>)Data).GetFormatFromOptions(options);
    }
}
