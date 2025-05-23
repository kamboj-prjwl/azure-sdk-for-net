// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    internal partial class AcsRouterCommunicationError
    {
        internal static AcsRouterCommunicationError DeserializeAcsRouterCommunicationError(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string code = default;
            string message = default;
            string target = default;
            AcsRouterCommunicationError innererror = default;
            IReadOnlyList<AcsRouterCommunicationError> details = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("innererror"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    innererror = DeserializeAcsRouterCommunicationError(property.Value);
                    continue;
                }
                if (property.NameEquals("details"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AcsRouterCommunicationError> array = new List<AcsRouterCommunicationError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeAcsRouterCommunicationError(item));
                    }
                    details = array;
                    continue;
                }
            }
            return new AcsRouterCommunicationError(code, message, target, innererror, details ?? new ChangeTrackingList<AcsRouterCommunicationError>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AcsRouterCommunicationError FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeAcsRouterCommunicationError(document.RootElement);
        }
    }
}
