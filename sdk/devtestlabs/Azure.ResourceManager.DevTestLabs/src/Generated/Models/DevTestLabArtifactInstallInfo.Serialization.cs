// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabArtifactInstallInfo : IUtf8JsonSerializable, IJsonModel<DevTestLabArtifactInstallInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevTestLabArtifactInstallInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DevTestLabArtifactInstallInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabArtifactInstallInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabArtifactInstallInfo)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ArtifactId))
            {
                writer.WritePropertyName("artifactId"u8);
                writer.WriteStringValue(ArtifactId);
            }
            if (Optional.IsDefined(ArtifactTitle))
            {
                writer.WritePropertyName("artifactTitle"u8);
                writer.WriteStringValue(ArtifactTitle);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartArray();
                foreach (var item in Parameters)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (Optional.IsDefined(DeploymentStatusMessage))
            {
                writer.WritePropertyName("deploymentStatusMessage"u8);
                writer.WriteStringValue(DeploymentStatusMessage);
            }
            if (Optional.IsDefined(VmExtensionStatusMessage))
            {
                writer.WritePropertyName("vmExtensionStatusMessage"u8);
                writer.WriteStringValue(VmExtensionStatusMessage);
            }
            if (Optional.IsDefined(InstallOn))
            {
                writer.WritePropertyName("installTime"u8);
                writer.WriteStringValue(InstallOn.Value, "O");
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

        DevTestLabArtifactInstallInfo IJsonModel<DevTestLabArtifactInstallInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabArtifactInstallInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabArtifactInstallInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabArtifactInstallInfo(document.RootElement, options);
        }

        internal static DevTestLabArtifactInstallInfo DeserializeDevTestLabArtifactInstallInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string artifactId = default;
            string artifactTitle = default;
            IList<DevTestLabArtifactParameter> parameters = default;
            string status = default;
            string deploymentStatusMessage = default;
            string vmExtensionStatusMessage = default;
            DateTimeOffset? installTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("artifactId"u8))
                {
                    artifactId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("artifactTitle"u8))
                {
                    artifactTitle = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DevTestLabArtifactParameter> array = new List<DevTestLabArtifactParameter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DevTestLabArtifactParameter.DeserializeDevTestLabArtifactParameter(item, options));
                    }
                    parameters = array;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deploymentStatusMessage"u8))
                {
                    deploymentStatusMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmExtensionStatusMessage"u8))
                {
                    vmExtensionStatusMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("installTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    installTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DevTestLabArtifactInstallInfo(
                artifactId,
                artifactTitle,
                parameters ?? new ChangeTrackingList<DevTestLabArtifactParameter>(),
                status,
                deploymentStatusMessage,
                vmExtensionStatusMessage,
                installTime,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevTestLabArtifactInstallInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabArtifactInstallInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDevTestLabsContext.Default);
                default:
                    throw new FormatException($"The model {nameof(DevTestLabArtifactInstallInfo)} does not support writing '{options.Format}' format.");
            }
        }

        DevTestLabArtifactInstallInfo IPersistableModel<DevTestLabArtifactInstallInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabArtifactInstallInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDevTestLabArtifactInstallInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevTestLabArtifactInstallInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevTestLabArtifactInstallInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
