// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MgmtKeyvault.Models
{
    /// <summary> Private endpoint object properties. </summary>
    public partial class MhsmPrivateEndpoint
    {
        /// <summary> Initializes a new instance of MhsmPrivateEndpoint. </summary>
        public MhsmPrivateEndpoint()
        {
        }

        /// <summary> Initializes a new instance of MhsmPrivateEndpoint. </summary>
        /// <param name="id"> Full identifier of the private endpoint resource. </param>
        internal MhsmPrivateEndpoint(string id)
        {
            Id = id;
        }

        /// <summary> Full identifier of the private endpoint resource. </summary>
        public string Id { get; }
    }
}
