// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A copy activity source for Microsoft Fabric Lakehouse Table. </summary>
    public partial class LakeHouseTableSource : CopySource
    {
        /// <summary> Initializes a new instance of <see cref="LakeHouseTableSource"/>. </summary>
        public LakeHouseTableSource()
        {
            Type = "LakeHouseTableSource";
        }

        /// <summary> Initializes a new instance of <see cref="LakeHouseTableSource"/>. </summary>
        /// <param name="type"> Copy source type. </param>
        /// <param name="sourceRetryCount"> Source retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sourceRetryWait"> Source retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="timestampAsOf"> Query an older snapshot by timestamp. Type: string (or Expression with resultType string). </param>
        /// <param name="versionAsOf"> Query an older snapshot by version. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalColumns"> Specifies the additional columns to be added to source data. Type: array of objects(AdditionalColumns) (or Expression with resultType array of objects). </param>
        internal LakeHouseTableSource(string type, object sourceRetryCount, object sourceRetryWait, object maxConcurrentConnections, IDictionary<string, object> additionalProperties, object timestampAsOf, object versionAsOf, object additionalColumns) : base(type, sourceRetryCount, sourceRetryWait, maxConcurrentConnections, additionalProperties)
        {
            TimestampAsOf = timestampAsOf;
            VersionAsOf = versionAsOf;
            AdditionalColumns = additionalColumns;
            Type = type ?? "LakeHouseTableSource";
        }

        /// <summary> Query an older snapshot by timestamp. Type: string (or Expression with resultType string). </summary>
        public object TimestampAsOf { get; set; }
        /// <summary> Query an older snapshot by version. Type: integer (or Expression with resultType integer). </summary>
        public object VersionAsOf { get; set; }
        /// <summary> Specifies the additional columns to be added to source data. Type: array of objects(AdditionalColumns) (or Expression with resultType array of objects). </summary>
        public object AdditionalColumns { get; set; }
    }
}
