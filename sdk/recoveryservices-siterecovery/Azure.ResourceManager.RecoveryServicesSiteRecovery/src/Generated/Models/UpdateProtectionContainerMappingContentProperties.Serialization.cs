// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    internal partial class UpdateProtectionContainerMappingContentProperties : IUtf8JsonSerializable, IJsonModel<UpdateProtectionContainerMappingContentProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UpdateProtectionContainerMappingContentProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<UpdateProtectionContainerMappingContentProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateProtectionContainerMappingContentProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpdateProtectionContainerMappingContentProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ProviderSpecificContent))
            {
                writer.WritePropertyName("providerSpecificInput"u8);
                writer.WriteObjectValue(ProviderSpecificContent, options);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        UpdateProtectionContainerMappingContentProperties IJsonModel<UpdateProtectionContainerMappingContentProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateProtectionContainerMappingContentProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpdateProtectionContainerMappingContentProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUpdateProtectionContainerMappingContentProperties(document.RootElement, options);
        }

        internal static UpdateProtectionContainerMappingContentProperties DeserializeUpdateProtectionContainerMappingContentProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ReplicationProviderSpecificUpdateContainerMappingContent providerSpecificContent = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("providerSpecificInput"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    providerSpecificContent = ReplicationProviderSpecificUpdateContainerMappingContent.DeserializeReplicationProviderSpecificUpdateContainerMappingContent(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UpdateProtectionContainerMappingContentProperties(providerSpecificContent, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UpdateProtectionContainerMappingContentProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateProtectionContainerMappingContentProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerRecoveryServicesSiteRecoveryContext.Default);
                default:
                    throw new FormatException($"The model {nameof(UpdateProtectionContainerMappingContentProperties)} does not support writing '{options.Format}' format.");
            }
        }

        UpdateProtectionContainerMappingContentProperties IPersistableModel<UpdateProtectionContainerMappingContentProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateProtectionContainerMappingContentProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeUpdateProtectionContainerMappingContentProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UpdateProtectionContainerMappingContentProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<UpdateProtectionContainerMappingContentProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
