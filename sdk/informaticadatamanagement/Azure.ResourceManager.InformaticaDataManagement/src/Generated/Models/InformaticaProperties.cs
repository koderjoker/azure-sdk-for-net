// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.InformaticaDataManagement.Models
{
    /// <summary> Properties of the Informatica organization. </summary>
    public partial class InformaticaProperties
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

        /// <summary> Initializes a new instance of <see cref="InformaticaProperties"/>. </summary>
        public InformaticaProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="InformaticaProperties"/>. </summary>
        /// <param name="organizationId"> Organization id. </param>
        /// <param name="organizationName"> Organization name. </param>
        /// <param name="informaticaRegion"> Informatica organization region. </param>
        /// <param name="singleSignOnUri"> Single sing on URL for informatica organization. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InformaticaProperties(string organizationId, string organizationName, string informaticaRegion, Uri singleSignOnUri, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OrganizationId = organizationId;
            OrganizationName = organizationName;
            InformaticaRegion = informaticaRegion;
            SingleSignOnUri = singleSignOnUri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Organization id. </summary>
        public string OrganizationId { get; set; }
        /// <summary> Organization name. </summary>
        public string OrganizationName { get; set; }
        /// <summary> Informatica organization region. </summary>
        public string InformaticaRegion { get; set; }
        /// <summary> Single sing on URL for informatica organization. </summary>
        public Uri SingleSignOnUri { get; set; }
    }
}
