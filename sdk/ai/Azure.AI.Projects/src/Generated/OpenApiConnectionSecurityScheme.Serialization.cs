// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Projects
{
    public partial class OpenApiConnectionSecurityScheme : IUtf8JsonSerializable, IJsonModel<OpenApiConnectionSecurityScheme>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OpenApiConnectionSecurityScheme>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<OpenApiConnectionSecurityScheme>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenApiConnectionSecurityScheme>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OpenApiConnectionSecurityScheme)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("connection_id"u8);
            writer.WriteStringValue(ConnectionId);
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

        OpenApiConnectionSecurityScheme IJsonModel<OpenApiConnectionSecurityScheme>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenApiConnectionSecurityScheme>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OpenApiConnectionSecurityScheme)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOpenApiConnectionSecurityScheme(document.RootElement, options);
        }

        internal static OpenApiConnectionSecurityScheme DeserializeOpenApiConnectionSecurityScheme(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string connectionId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connection_id"u8))
                {
                    connectionId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new OpenApiConnectionSecurityScheme(connectionId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OpenApiConnectionSecurityScheme>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenApiConnectionSecurityScheme>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureAIProjectsContext.Default);
                default:
                    throw new FormatException($"The model {nameof(OpenApiConnectionSecurityScheme)} does not support writing '{options.Format}' format.");
            }
        }

        OpenApiConnectionSecurityScheme IPersistableModel<OpenApiConnectionSecurityScheme>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenApiConnectionSecurityScheme>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeOpenApiConnectionSecurityScheme(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OpenApiConnectionSecurityScheme)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<OpenApiConnectionSecurityScheme>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static OpenApiConnectionSecurityScheme FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeOpenApiConnectionSecurityScheme(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
