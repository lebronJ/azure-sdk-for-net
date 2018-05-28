// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An available operation for Data Lake Store
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
        /// <param name="name">the name of the operation.</param>
        /// <param name="display">the display information for the
        /// operation.</param>
        /// <param name="origin">the intended executor of the operation.
        /// Possible values include: 'user', 'system', 'user,system'</param>
        public Operation(string name = default(string), OperationDisplay display = default(OperationDisplay), string origin = default(string))
        {
            Name = name;
            Display = display;
            Origin = origin;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the name of the operation.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets or sets the display information for the operation.
        /// </summary>
        [JsonProperty(PropertyName = "display")]
        public OperationDisplay Display { get; set; }

        /// <summary>
        /// Gets the intended executor of the operation. Possible values
        /// include: 'user', 'system', 'user,system'
        /// </summary>
        [JsonProperty(PropertyName = "origin")]
        public string Origin { get; private set; }

    }
}
