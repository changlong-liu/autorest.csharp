// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using MgmtTest;

namespace MgmtTest.Models
{
    /// <summary> List of resource links. </summary>
    internal partial class ResourceLinkResult
    {
        /// <summary> Initializes a new instance of ResourceLinkResult. </summary>
        /// <param name="value"> An array of resource links. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ResourceLinkResult(IEnumerable<ResourceLinkData> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of ResourceLinkResult. </summary>
        /// <param name="value"> An array of resource links. </param>
        /// <param name="nextLink"> The URL to use for getting the next set of results. </param>
        internal ResourceLinkResult(IReadOnlyList<ResourceLinkData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> An array of resource links. </summary>
        public IReadOnlyList<ResourceLinkData> Value { get; }
        /// <summary> The URL to use for getting the next set of results. </summary>
        public string NextLink { get; }
    }
}
