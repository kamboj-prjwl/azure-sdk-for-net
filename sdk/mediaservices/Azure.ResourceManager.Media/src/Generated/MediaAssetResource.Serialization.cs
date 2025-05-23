// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Media
{
    public partial class MediaAssetResource : IJsonModel<MediaAssetData>
    {
        void IJsonModel<MediaAssetData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<MediaAssetData>)Data).Write(writer, options);

        MediaAssetData IJsonModel<MediaAssetData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<MediaAssetData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<MediaAssetData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<MediaAssetData>(Data, options, AzureResourceManagerMediaContext.Default);

        MediaAssetData IPersistableModel<MediaAssetData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<MediaAssetData>(data, options, AzureResourceManagerMediaContext.Default);

        string IPersistableModel<MediaAssetData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<MediaAssetData>)Data).GetFormatFromOptions(options);
    }
}
