// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Migration.Assessment.Models
{
    public partial class SqlAssessmentMigrationIssue : IUtf8JsonSerializable, IJsonModel<SqlAssessmentMigrationIssue>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlAssessmentMigrationIssue>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SqlAssessmentMigrationIssue>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlAssessmentMigrationIssue>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlAssessmentMigrationIssue)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(IssueId))
            {
                writer.WritePropertyName("issueId"u8);
                writer.WriteStringValue(IssueId);
            }
            if (options.Format != "W" && Optional.IsDefined(IssueCategory))
            {
                writer.WritePropertyName("issueCategory"u8);
                writer.WriteStringValue(IssueCategory.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ImpactedObjects))
            {
                writer.WritePropertyName("impactedObjects"u8);
                writer.WriteStartArray();
                foreach (var item in ImpactedObjects)
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

        SqlAssessmentMigrationIssue IJsonModel<SqlAssessmentMigrationIssue>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlAssessmentMigrationIssue>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlAssessmentMigrationIssue)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlAssessmentMigrationIssue(document.RootElement, options);
        }

        internal static SqlAssessmentMigrationIssue DeserializeSqlAssessmentMigrationIssue(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string issueId = default;
            SqlAssessmentMigrationIssueCategory? issueCategory = default;
            IReadOnlyList<ImpactedAssessmentObject> impactedObjects = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("issueId"u8))
                {
                    issueId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("issueCategory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    issueCategory = new SqlAssessmentMigrationIssueCategory(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("impactedObjects"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ImpactedAssessmentObject> array = new List<ImpactedAssessmentObject>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ImpactedAssessmentObject.DeserializeImpactedAssessmentObject(item, options));
                    }
                    impactedObjects = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SqlAssessmentMigrationIssue(issueId, issueCategory, impactedObjects ?? new ChangeTrackingList<ImpactedAssessmentObject>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SqlAssessmentMigrationIssue>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlAssessmentMigrationIssue>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMigrationAssessmentContext.Default);
                default:
                    throw new FormatException($"The model {nameof(SqlAssessmentMigrationIssue)} does not support writing '{options.Format}' format.");
            }
        }

        SqlAssessmentMigrationIssue IPersistableModel<SqlAssessmentMigrationIssue>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlAssessmentMigrationIssue>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeSqlAssessmentMigrationIssue(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SqlAssessmentMigrationIssue)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlAssessmentMigrationIssue>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
