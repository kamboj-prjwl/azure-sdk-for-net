// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DataBoxEdge
{
    public partial class DataBoxEdgeStorageContainerResource : IJsonModel<DataBoxEdgeStorageContainerData>
    {
        void IJsonModel<DataBoxEdgeStorageContainerData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<DataBoxEdgeStorageContainerData>)Data).Write(writer, options);

        DataBoxEdgeStorageContainerData IJsonModel<DataBoxEdgeStorageContainerData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<DataBoxEdgeStorageContainerData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<DataBoxEdgeStorageContainerData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<DataBoxEdgeStorageContainerData>(Data, options, AzureResourceManagerDataBoxEdgeContext.Default);

        DataBoxEdgeStorageContainerData IPersistableModel<DataBoxEdgeStorageContainerData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<DataBoxEdgeStorageContainerData>(data, options, AzureResourceManagerDataBoxEdgeContext.Default);

        string IPersistableModel<DataBoxEdgeStorageContainerData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<DataBoxEdgeStorageContainerData>)Data).GetFormatFromOptions(options);
    }
}
