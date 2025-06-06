// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class ConnectorMappingCompleteOperation : IUtf8JsonSerializable, IJsonModel<ConnectorMappingCompleteOperation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectorMappingCompleteOperation>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConnectorMappingCompleteOperation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectorMappingCompleteOperation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectorMappingCompleteOperation)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(CompletionOperationType))
            {
                writer.WritePropertyName("completionOperationType"u8);
                writer.WriteStringValue(CompletionOperationType.Value.ToSerialString());
            }
            if (Optional.IsDefined(DestinationFolder))
            {
                writer.WritePropertyName("destinationFolder"u8);
                writer.WriteStringValue(DestinationFolder);
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

        ConnectorMappingCompleteOperation IJsonModel<ConnectorMappingCompleteOperation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectorMappingCompleteOperation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectorMappingCompleteOperation)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectorMappingCompleteOperation(document.RootElement, options);
        }

        internal static ConnectorMappingCompleteOperation DeserializeConnectorMappingCompleteOperation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CompletionOperationType? completionOperationType = default;
            string destinationFolder = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("completionOperationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    completionOperationType = property.Value.GetString().ToCompletionOperationType();
                    continue;
                }
                if (property.NameEquals("destinationFolder"u8))
                {
                    destinationFolder = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConnectorMappingCompleteOperation(completionOperationType, destinationFolder, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConnectorMappingCompleteOperation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectorMappingCompleteOperation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerCustomerInsightsContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ConnectorMappingCompleteOperation)} does not support writing '{options.Format}' format.");
            }
        }

        ConnectorMappingCompleteOperation IPersistableModel<ConnectorMappingCompleteOperation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectorMappingCompleteOperation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeConnectorMappingCompleteOperation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConnectorMappingCompleteOperation)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConnectorMappingCompleteOperation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
