// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The provider registration definition. </summary>
    public partial class ProviderRegistrationContent
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

        /// <summary> Initializes a new instance of <see cref="ProviderRegistrationContent"/>. </summary>
        public ProviderRegistrationContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ProviderRegistrationContent"/>. </summary>
        /// <param name="thirdPartyProviderConsent"> The provider consent. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ProviderRegistrationContent(ProviderConsentDefinition thirdPartyProviderConsent, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ThirdPartyProviderConsent = thirdPartyProviderConsent;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The provider consent. </summary>
        internal ProviderConsentDefinition ThirdPartyProviderConsent { get; set; }
        /// <summary> A value indicating whether authorization is consented or not. </summary>
        [WirePath("thirdPartyProviderConsent.consentToAuthorization")]
        public bool? ConsentToAuthorization
        {
            get => ThirdPartyProviderConsent is null ? default : ThirdPartyProviderConsent.ConsentToAuthorization;
            set
            {
                if (ThirdPartyProviderConsent is null)
                    ThirdPartyProviderConsent = new ProviderConsentDefinition();
                ThirdPartyProviderConsent.ConsentToAuthorization = value;
            }
        }
    }
}
