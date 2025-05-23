// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Defender.Easm
{
    public partial class AzureDataExplorerDataConnectionPayload : IUtf8JsonSerializable, IJsonModel<AzureDataExplorerDataConnectionPayload>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureDataExplorerDataConnectionPayload>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AzureDataExplorerDataConnectionPayload>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureDataExplorerDataConnectionPayload>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureDataExplorerDataConnectionPayload)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteObjectValue(Properties, options);
        }

        AzureDataExplorerDataConnectionPayload IJsonModel<AzureDataExplorerDataConnectionPayload>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureDataExplorerDataConnectionPayload>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureDataExplorerDataConnectionPayload)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureDataExplorerDataConnectionPayload(document.RootElement, options);
        }

        internal static AzureDataExplorerDataConnectionPayload DeserializeAzureDataExplorerDataConnectionPayload(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureDataExplorerDataConnectionProperties properties = default;
            string kind = default;
            string name = default;
            DataConnectionContent? content = default;
            DataConnectionFrequency? frequency = default;
            int? frequencyOffset = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    properties = AzureDataExplorerDataConnectionProperties.DeserializeAzureDataExplorerDataConnectionProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("content"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    content = new DataConnectionContent(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("frequency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    frequency = new DataConnectionFrequency(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("frequencyOffset"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    frequencyOffset = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AzureDataExplorerDataConnectionPayload(
                kind,
                name,
                content,
                frequency,
                frequencyOffset,
                serializedAdditionalRawData,
                properties);
        }

        BinaryData IPersistableModel<AzureDataExplorerDataConnectionPayload>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureDataExplorerDataConnectionPayload>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureAnalyticsDefenderEasmContext.Default);
                default:
                    throw new FormatException($"The model {nameof(AzureDataExplorerDataConnectionPayload)} does not support writing '{options.Format}' format.");
            }
        }

        AzureDataExplorerDataConnectionPayload IPersistableModel<AzureDataExplorerDataConnectionPayload>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureDataExplorerDataConnectionPayload>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAzureDataExplorerDataConnectionPayload(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureDataExplorerDataConnectionPayload)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureDataExplorerDataConnectionPayload>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new AzureDataExplorerDataConnectionPayload FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeAzureDataExplorerDataConnectionPayload(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
