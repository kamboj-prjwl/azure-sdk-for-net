// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    public partial class SessionHostHealthCheckReport : IUtf8JsonSerializable, IJsonModel<SessionHostHealthCheckReport>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SessionHostHealthCheckReport>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SessionHostHealthCheckReport>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SessionHostHealthCheckReport>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SessionHostHealthCheckReport)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(HealthCheckName))
            {
                writer.WritePropertyName("healthCheckName"u8);
                writer.WriteStringValue(HealthCheckName.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(HealthCheckResult))
            {
                writer.WritePropertyName("healthCheckResult"u8);
                writer.WriteStringValue(HealthCheckResult.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(AdditionalFailureDetails))
            {
                writer.WritePropertyName("additionalFailureDetails"u8);
                writer.WriteObjectValue(AdditionalFailureDetails, options);
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

        SessionHostHealthCheckReport IJsonModel<SessionHostHealthCheckReport>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SessionHostHealthCheckReport>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SessionHostHealthCheckReport)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSessionHostHealthCheckReport(document.RootElement, options);
        }

        internal static SessionHostHealthCheckReport DeserializeSessionHostHealthCheckReport(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SessionHostHealthCheckName? healthCheckName = default;
            SessionHostHealthCheckResult? healthCheckResult = default;
            SessionHostHealthCheckFailureDetails additionalFailureDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("healthCheckName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    healthCheckName = new SessionHostHealthCheckName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("healthCheckResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    healthCheckResult = new SessionHostHealthCheckResult(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("additionalFailureDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    additionalFailureDetails = SessionHostHealthCheckFailureDetails.DeserializeSessionHostHealthCheckFailureDetails(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SessionHostHealthCheckReport(healthCheckName, healthCheckResult, additionalFailureDetails, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(HealthCheckName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  healthCheckName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(HealthCheckName))
                {
                    builder.Append("  healthCheckName: ");
                    builder.AppendLine($"'{HealthCheckName.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(HealthCheckResult), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  healthCheckResult: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(HealthCheckResult))
                {
                    builder.Append("  healthCheckResult: ");
                    builder.AppendLine($"'{HealthCheckResult.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AdditionalFailureDetails), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  additionalFailureDetails: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AdditionalFailureDetails))
                {
                    builder.Append("  additionalFailureDetails: ");
                    BicepSerializationHelpers.AppendChildObject(builder, AdditionalFailureDetails, options, 2, false, "  additionalFailureDetails: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<SessionHostHealthCheckReport>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SessionHostHealthCheckReport>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDesktopVirtualizationContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SessionHostHealthCheckReport)} does not support writing '{options.Format}' format.");
            }
        }

        SessionHostHealthCheckReport IPersistableModel<SessionHostHealthCheckReport>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SessionHostHealthCheckReport>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSessionHostHealthCheckReport(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SessionHostHealthCheckReport)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SessionHostHealthCheckReport>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
