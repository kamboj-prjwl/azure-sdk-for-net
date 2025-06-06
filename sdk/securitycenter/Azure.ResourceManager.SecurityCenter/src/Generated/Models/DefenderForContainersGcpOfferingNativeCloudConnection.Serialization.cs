// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class DefenderForContainersGcpOfferingNativeCloudConnection : IUtf8JsonSerializable, IJsonModel<DefenderForContainersGcpOfferingNativeCloudConnection>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DefenderForContainersGcpOfferingNativeCloudConnection>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DefenderForContainersGcpOfferingNativeCloudConnection>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForContainersGcpOfferingNativeCloudConnection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderForContainersGcpOfferingNativeCloudConnection)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ServiceAccountEmailAddress))
            {
                writer.WritePropertyName("serviceAccountEmailAddress"u8);
                writer.WriteStringValue(ServiceAccountEmailAddress);
            }
            if (Optional.IsDefined(WorkloadIdentityProviderId))
            {
                writer.WritePropertyName("workloadIdentityProviderId"u8);
                writer.WriteStringValue(WorkloadIdentityProviderId);
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

        DefenderForContainersGcpOfferingNativeCloudConnection IJsonModel<DefenderForContainersGcpOfferingNativeCloudConnection>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForContainersGcpOfferingNativeCloudConnection>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderForContainersGcpOfferingNativeCloudConnection)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDefenderForContainersGcpOfferingNativeCloudConnection(document.RootElement, options);
        }

        internal static DefenderForContainersGcpOfferingNativeCloudConnection DeserializeDefenderForContainersGcpOfferingNativeCloudConnection(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string serviceAccountEmailAddress = default;
            string workloadIdentityProviderId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceAccountEmailAddress"u8))
                {
                    serviceAccountEmailAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workloadIdentityProviderId"u8))
                {
                    workloadIdentityProviderId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DefenderForContainersGcpOfferingNativeCloudConnection(serviceAccountEmailAddress, workloadIdentityProviderId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DefenderForContainersGcpOfferingNativeCloudConnection>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForContainersGcpOfferingNativeCloudConnection>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerSecurityCenterContext.Default);
                default:
                    throw new FormatException($"The model {nameof(DefenderForContainersGcpOfferingNativeCloudConnection)} does not support writing '{options.Format}' format.");
            }
        }

        DefenderForContainersGcpOfferingNativeCloudConnection IPersistableModel<DefenderForContainersGcpOfferingNativeCloudConnection>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForContainersGcpOfferingNativeCloudConnection>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDefenderForContainersGcpOfferingNativeCloudConnection(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DefenderForContainersGcpOfferingNativeCloudConnection)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DefenderForContainersGcpOfferingNativeCloudConnection>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
