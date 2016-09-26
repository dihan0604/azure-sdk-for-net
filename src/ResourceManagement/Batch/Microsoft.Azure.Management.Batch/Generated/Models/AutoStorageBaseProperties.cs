// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Batch.Models
{
    using System.Linq;

    /// <summary>
    /// The properties related to auto storage account.
    /// </summary>
    public partial class AutoStorageBaseProperties
    {
        /// <summary>
        /// Initializes a new instance of the AutoStorageBaseProperties class.
        /// </summary>
        public AutoStorageBaseProperties() { }

        /// <summary>
        /// Initializes a new instance of the AutoStorageBaseProperties class.
        /// </summary>
        /// <param name="storageAccountId">The resource id of the storage
        /// account to be used for auto storage account.</param>
        public AutoStorageBaseProperties(string storageAccountId)
        {
            StorageAccountId = storageAccountId;
        }

        /// <summary>
        /// Gets or sets the resource id of the storage account to be used for
        /// auto storage account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "storageAccountId")]
        public string StorageAccountId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (StorageAccountId == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "StorageAccountId");
            }
        }
    }
}
