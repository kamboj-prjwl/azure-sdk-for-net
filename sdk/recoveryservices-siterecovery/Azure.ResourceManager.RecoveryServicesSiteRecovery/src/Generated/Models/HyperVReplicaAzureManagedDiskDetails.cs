// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Hyper-V Managed disk details. </summary>
    public partial class HyperVReplicaAzureManagedDiskDetails
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="HyperVReplicaAzureManagedDiskDetails"/>. </summary>
        internal HyperVReplicaAzureManagedDiskDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HyperVReplicaAzureManagedDiskDetails"/>. </summary>
        /// <param name="diskId"> The disk Id. </param>
        /// <param name="seedManagedDiskId"> Seed managed disk Id. </param>
        /// <param name="replicaDiskType"> The replica disk type. </param>
        /// <param name="diskEncryptionSetId"> The disk encryption set ARM Id. </param>
        /// <param name="targetDiskAccountType"> The disk type. </param>
        /// <param name="sectorSizeInBytes"> The logical sector size (in bytes), 512 by default. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HyperVReplicaAzureManagedDiskDetails(string diskId, string seedManagedDiskId, string replicaDiskType, ResourceIdentifier diskEncryptionSetId, SiteRecoveryDiskAccountType? targetDiskAccountType, int? sectorSizeInBytes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DiskId = diskId;
            SeedManagedDiskId = seedManagedDiskId;
            ReplicaDiskType = replicaDiskType;
            DiskEncryptionSetId = diskEncryptionSetId;
            TargetDiskAccountType = targetDiskAccountType;
            SectorSizeInBytes = sectorSizeInBytes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The disk Id. </summary>
        public string DiskId { get; }
        /// <summary> Seed managed disk Id. </summary>
        public string SeedManagedDiskId { get; }
        /// <summary> The replica disk type. </summary>
        public string ReplicaDiskType { get; }
        /// <summary> The disk encryption set ARM Id. </summary>
        public ResourceIdentifier DiskEncryptionSetId { get; }
        /// <summary> The disk type. </summary>
        public SiteRecoveryDiskAccountType? TargetDiskAccountType { get; }
        /// <summary> The logical sector size (in bytes), 512 by default. </summary>
        public int? SectorSizeInBytes { get; }
    }
}
