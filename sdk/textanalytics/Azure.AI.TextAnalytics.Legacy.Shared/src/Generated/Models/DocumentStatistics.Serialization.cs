// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.AI.TextAnalytics.Legacy
{
    internal partial class DocumentStatistics
    {
        internal static DocumentStatistics DeserializeDocumentStatistics(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int charactersCount = default;
            int transactionsCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("charactersCount"u8))
                {
                    charactersCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("transactionsCount"u8))
                {
                    transactionsCount = property.Value.GetInt32();
                    continue;
                }
            }
            return new DocumentStatistics(charactersCount, transactionsCount);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DocumentStatistics FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeDocumentStatistics(document.RootElement);
        }
    }
}
