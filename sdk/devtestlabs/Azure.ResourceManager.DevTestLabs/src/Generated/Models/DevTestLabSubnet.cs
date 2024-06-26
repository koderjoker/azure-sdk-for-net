// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Subnet information. </summary>
    public partial class DevTestLabSubnet
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

        /// <summary> Initializes a new instance of <see cref="DevTestLabSubnet"/>. </summary>
        public DevTestLabSubnet()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DevTestLabSubnet"/>. </summary>
        /// <param name="resourceId"> The resource ID of the subnet. </param>
        /// <param name="labSubnetName"> The name of the subnet as seen in the lab. </param>
        /// <param name="allowPublicIP"> The permission policy of the subnet for allowing public IP addresses (i.e. Allow, Deny)). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DevTestLabSubnet(ResourceIdentifier resourceId, string labSubnetName, DevTestLabUsagePermissionType? allowPublicIP, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResourceId = resourceId;
            LabSubnetName = labSubnetName;
            AllowPublicIP = allowPublicIP;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The resource ID of the subnet. </summary>
        public ResourceIdentifier ResourceId { get; set; }
        /// <summary> The name of the subnet as seen in the lab. </summary>
        public string LabSubnetName { get; set; }
        /// <summary> The permission policy of the subnet for allowing public IP addresses (i.e. Allow, Deny)). </summary>
        public DevTestLabUsagePermissionType? AllowPublicIP { get; set; }
    }
}
