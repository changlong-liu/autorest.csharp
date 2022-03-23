// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Fake.Models
{
    internal static partial class ReferenceTypesSkuTierExtensions
    {
        public static string ToSerialString(this ReferenceTypesSkuTier value) => value switch
        {
            ReferenceTypesSkuTier.Free => "Free",
            ReferenceTypesSkuTier.Basic => "Basic",
            ReferenceTypesSkuTier.Standard => "Standard",
            ReferenceTypesSkuTier.Premium => "Premium",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ReferenceTypesSkuTier value.")
        };

        public static ReferenceTypesSkuTier ToReferenceTypesSkuTier(this string value)
        {
            if (string.Equals(value, "Free", StringComparison.InvariantCultureIgnoreCase)) return ReferenceTypesSkuTier.Free;
            if (string.Equals(value, "Basic", StringComparison.InvariantCultureIgnoreCase)) return ReferenceTypesSkuTier.Basic;
            if (string.Equals(value, "Standard", StringComparison.InvariantCultureIgnoreCase)) return ReferenceTypesSkuTier.Standard;
            if (string.Equals(value, "Premium", StringComparison.InvariantCultureIgnoreCase)) return ReferenceTypesSkuTier.Premium;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ReferenceTypesSkuTier value.");
        }
    }
}