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

namespace Azure.ResourceManager.EventHubs.Models
{
    public partial class EventHubsAccessKeys : IUtf8JsonSerializable, IJsonModel<EventHubsAccessKeys>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EventHubsAccessKeys>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EventHubsAccessKeys>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubsAccessKeys>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventHubsAccessKeys)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(PrimaryConnectionString))
            {
                writer.WritePropertyName("primaryConnectionString"u8);
                writer.WriteStringValue(PrimaryConnectionString);
            }
            if (options.Format != "W" && Optional.IsDefined(SecondaryConnectionString))
            {
                writer.WritePropertyName("secondaryConnectionString"u8);
                writer.WriteStringValue(SecondaryConnectionString);
            }
            if (options.Format != "W" && Optional.IsDefined(AliasPrimaryConnectionString))
            {
                writer.WritePropertyName("aliasPrimaryConnectionString"u8);
                writer.WriteStringValue(AliasPrimaryConnectionString);
            }
            if (options.Format != "W" && Optional.IsDefined(AliasSecondaryConnectionString))
            {
                writer.WritePropertyName("aliasSecondaryConnectionString"u8);
                writer.WriteStringValue(AliasSecondaryConnectionString);
            }
            if (options.Format != "W" && Optional.IsDefined(PrimaryKey))
            {
                writer.WritePropertyName("primaryKey"u8);
                writer.WriteStringValue(PrimaryKey);
            }
            if (options.Format != "W" && Optional.IsDefined(SecondaryKey))
            {
                writer.WritePropertyName("secondaryKey"u8);
                writer.WriteStringValue(SecondaryKey);
            }
            if (options.Format != "W" && Optional.IsDefined(KeyName))
            {
                writer.WritePropertyName("keyName"u8);
                writer.WriteStringValue(KeyName);
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

        EventHubsAccessKeys IJsonModel<EventHubsAccessKeys>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubsAccessKeys>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventHubsAccessKeys)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEventHubsAccessKeys(document.RootElement, options);
        }

        internal static EventHubsAccessKeys DeserializeEventHubsAccessKeys(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string primaryConnectionString = default;
            string secondaryConnectionString = default;
            string aliasPrimaryConnectionString = default;
            string aliasSecondaryConnectionString = default;
            string primaryKey = default;
            string secondaryKey = default;
            string keyName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryConnectionString"u8))
                {
                    primaryConnectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryConnectionString"u8))
                {
                    secondaryConnectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aliasPrimaryConnectionString"u8))
                {
                    aliasPrimaryConnectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("aliasSecondaryConnectionString"u8))
                {
                    aliasSecondaryConnectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryKey"u8))
                {
                    primaryKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryKey"u8))
                {
                    secondaryKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyName"u8))
                {
                    keyName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new EventHubsAccessKeys(
                primaryConnectionString,
                secondaryConnectionString,
                aliasPrimaryConnectionString,
                aliasSecondaryConnectionString,
                primaryKey,
                secondaryKey,
                keyName,
                serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PrimaryConnectionString), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  primaryConnectionString: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PrimaryConnectionString))
                {
                    builder.Append("  primaryConnectionString: ");
                    if (PrimaryConnectionString.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PrimaryConnectionString}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PrimaryConnectionString}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SecondaryConnectionString), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  secondaryConnectionString: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SecondaryConnectionString))
                {
                    builder.Append("  secondaryConnectionString: ");
                    if (SecondaryConnectionString.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SecondaryConnectionString}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SecondaryConnectionString}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AliasPrimaryConnectionString), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  aliasPrimaryConnectionString: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AliasPrimaryConnectionString))
                {
                    builder.Append("  aliasPrimaryConnectionString: ");
                    if (AliasPrimaryConnectionString.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AliasPrimaryConnectionString}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AliasPrimaryConnectionString}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AliasSecondaryConnectionString), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  aliasSecondaryConnectionString: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AliasSecondaryConnectionString))
                {
                    builder.Append("  aliasSecondaryConnectionString: ");
                    if (AliasSecondaryConnectionString.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AliasSecondaryConnectionString}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AliasSecondaryConnectionString}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(PrimaryKey), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  primaryKey: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(PrimaryKey))
                {
                    builder.Append("  primaryKey: ");
                    if (PrimaryKey.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{PrimaryKey}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{PrimaryKey}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SecondaryKey), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  secondaryKey: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SecondaryKey))
                {
                    builder.Append("  secondaryKey: ");
                    if (SecondaryKey.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SecondaryKey}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SecondaryKey}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(KeyName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  keyName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(KeyName))
                {
                    builder.Append("  keyName: ");
                    if (KeyName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{KeyName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{KeyName}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<EventHubsAccessKeys>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubsAccessKeys>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerEventHubsContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(EventHubsAccessKeys)} does not support writing '{options.Format}' format.");
            }
        }

        EventHubsAccessKeys IPersistableModel<EventHubsAccessKeys>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubsAccessKeys>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeEventHubsAccessKeys(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EventHubsAccessKeys)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EventHubsAccessKeys>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
