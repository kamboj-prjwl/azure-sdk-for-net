// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class MobileNetworkIPv4Route : IUtf8JsonSerializable, IJsonModel<MobileNetworkIPv4Route>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MobileNetworkIPv4Route>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MobileNetworkIPv4Route>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkIPv4Route>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MobileNetworkIPv4Route)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Destination))
            {
                writer.WritePropertyName("destination"u8);
                writer.WriteStringValue(Destination);
            }
            if (Optional.IsCollectionDefined(NextHops))
            {
                writer.WritePropertyName("nextHops"u8);
                writer.WriteStartArray();
                foreach (var item in NextHops)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        MobileNetworkIPv4Route IJsonModel<MobileNetworkIPv4Route>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkIPv4Route>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MobileNetworkIPv4Route)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMobileNetworkIPv4Route(document.RootElement, options);
        }

        internal static MobileNetworkIPv4Route DeserializeMobileNetworkIPv4Route(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string destination = default;
            IList<MobileNetworkIPv4RouteNextHop> nextHops = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("destination"u8))
                {
                    destination = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nextHops"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MobileNetworkIPv4RouteNextHop> array = new List<MobileNetworkIPv4RouteNextHop>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MobileNetworkIPv4RouteNextHop.DeserializeMobileNetworkIPv4RouteNextHop(item, options));
                    }
                    nextHops = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MobileNetworkIPv4Route(destination, nextHops ?? new ChangeTrackingList<MobileNetworkIPv4RouteNextHop>(), serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Destination), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  destination: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Destination))
                {
                    builder.Append("  destination: ");
                    if (Destination.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Destination}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Destination}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NextHops), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  nextHops: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(NextHops))
                {
                    if (NextHops.Any())
                    {
                        builder.Append("  nextHops: ");
                        builder.AppendLine("[");
                        foreach (var item in NextHops)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  nextHops: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<MobileNetworkIPv4Route>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkIPv4Route>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMobileNetworkContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MobileNetworkIPv4Route)} does not support writing '{options.Format}' format.");
            }
        }

        MobileNetworkIPv4Route IPersistableModel<MobileNetworkIPv4Route>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MobileNetworkIPv4Route>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMobileNetworkIPv4Route(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MobileNetworkIPv4Route)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MobileNetworkIPv4Route>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
