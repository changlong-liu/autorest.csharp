// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace Azure.Management.Storage
{
    /// <summary> Extension methods for convenient access on SubscriptionOperations in a client. </summary>
    public static partial class SubscriptionExtensions
    {
        #region Sku
        /// <summary> Gets an object representing a SkuContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        public static SkuContainer GetSkuContainer(this SubscriptionOperations subscription)
        {
            return new SkuContainer(subscription);
        }
        #endregion

        #region Usage
        /// <summary> Gets an object representing a UsageContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        public static UsageContainer GetUsageContainer(this SubscriptionOperations subscription)
        {
            return new UsageContainer(subscription);
        }
        #endregion
    }
}