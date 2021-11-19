// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventHub.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A Event Hub REST API operation
    /// </summary>
    public partial class Operation
    {
        /// <summary>
        /// Initializes a new instance of the Operation class.
        /// </summary>
        public Operation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Operation class.
        /// </summary>
        /// <param name="name">Operation name:
        /// {provider}/{resource}/{operation}</param>
        /// <param name="isDataAction">Indicates whether the operation is a
        /// data action</param>
        /// <param name="display">Display of the operation</param>
        /// <param name="origin">Origin of the operation</param>
        /// <param name="properties">Properties of the operation</param>
        public Operation(string name = default(string), bool? isDataAction = default(bool?), OperationDisplay display = default(OperationDisplay), string origin = default(string), object properties = default(object))
        {
            Name = name;
            IsDataAction = isDataAction;
            Display = display;
            Origin = origin;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets operation name: {provider}/{resource}/{operation}
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets or sets indicates whether the operation is a data action
        /// </summary>
        [JsonProperty(PropertyName = "isDataAction")]
        public bool? IsDataAction { get; set; }

        /// <summary>
        /// Gets or sets display of the operation
        /// </summary>
        [JsonProperty(PropertyName = "display")]
        public OperationDisplay Display { get; set; }

        /// <summary>
        /// Gets or sets origin of the operation
        /// </summary>
        [JsonProperty(PropertyName = "origin")]
        public string Origin { get; set; }

        /// <summary>
        /// Gets or sets properties of the operation
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public object Properties { get; set; }

    }
}
