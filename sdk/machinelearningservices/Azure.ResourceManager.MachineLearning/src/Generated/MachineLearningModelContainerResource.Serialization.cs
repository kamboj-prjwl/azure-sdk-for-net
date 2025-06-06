// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.MachineLearning
{
    public partial class MachineLearningModelContainerResource : IJsonModel<MachineLearningModelContainerData>
    {
        void IJsonModel<MachineLearningModelContainerData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<MachineLearningModelContainerData>)Data).Write(writer, options);

        MachineLearningModelContainerData IJsonModel<MachineLearningModelContainerData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<MachineLearningModelContainerData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<MachineLearningModelContainerData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<MachineLearningModelContainerData>(Data, options, AzureResourceManagerMachineLearningContext.Default);

        MachineLearningModelContainerData IPersistableModel<MachineLearningModelContainerData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<MachineLearningModelContainerData>(data, options, AzureResourceManagerMachineLearningContext.Default);

        string IPersistableModel<MachineLearningModelContainerData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<MachineLearningModelContainerData>)Data).GetFormatFromOptions(options);
    }
}
