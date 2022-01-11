// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace TenantOnly
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region BillingAccount
        /// <summary> Gets an object representing a BillingAccount along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BillingAccount" /> object. </returns>
        public static BillingAccount GetBillingAccount(this ArmClient armClient, ResourceIdentifier id)
        {
            BillingAccount.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new BillingAccount(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region Agreement
        /// <summary> Gets an object representing a Agreement along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="Agreement" /> object. </returns>
        public static Agreement GetAgreement(this ArmClient armClient, ResourceIdentifier id)
        {
            Agreement.ValidateResourceId(id);
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new Agreement(clientOptions, credential, uri, pipeline, id));
        }
        #endregion
    }
}
