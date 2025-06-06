// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.SecurityInsights
{
    public partial class SecurityInsightsAutomationRuleResource : IJsonModel<SecurityInsightsAutomationRuleData>
    {
        void IJsonModel<SecurityInsightsAutomationRuleData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SecurityInsightsAutomationRuleData>)Data).Write(writer, options);

        SecurityInsightsAutomationRuleData IJsonModel<SecurityInsightsAutomationRuleData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SecurityInsightsAutomationRuleData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SecurityInsightsAutomationRuleData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<SecurityInsightsAutomationRuleData>(Data, options, AzureResourceManagerSecurityInsightsContext.Default);

        SecurityInsightsAutomationRuleData IPersistableModel<SecurityInsightsAutomationRuleData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SecurityInsightsAutomationRuleData>(data, options, AzureResourceManagerSecurityInsightsContext.Default);

        string IPersistableModel<SecurityInsightsAutomationRuleData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SecurityInsightsAutomationRuleData>)Data).GetFormatFromOptions(options);
    }
}
