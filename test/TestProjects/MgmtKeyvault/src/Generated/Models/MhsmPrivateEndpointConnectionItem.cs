// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MgmtKeyvault.Models
{
    /// <summary> Private endpoint connection item. </summary>
    public partial class MhsmPrivateEndpointConnectionItem
    {
        /// <summary> Initializes a new instance of MhsmPrivateEndpointConnectionItem. </summary>
        internal MhsmPrivateEndpointConnectionItem()
        {
        }

        /// <summary> Initializes a new instance of MhsmPrivateEndpointConnectionItem. </summary>
        /// <param name="privateEndpoint"> Properties of the private endpoint object. </param>
        /// <param name="privateLinkServiceConnectionState"> Approval state of the private link connection. </param>
        /// <param name="provisioningState"> Provisioning state of the private endpoint connection. </param>
        internal MhsmPrivateEndpointConnectionItem(MhsmPrivateEndpoint privateEndpoint, MhsmPrivateLinkServiceConnectionState privateLinkServiceConnectionState, PrivateEndpointConnectionProvisioningState? provisioningState)
        {
            PrivateEndpoint = privateEndpoint;
            PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
            ProvisioningState = provisioningState;
        }

        /// <summary> Properties of the private endpoint object. </summary>
        public MhsmPrivateEndpoint PrivateEndpoint { get; }
        /// <summary> Approval state of the private link connection. </summary>
        public MhsmPrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get; }
        /// <summary> Provisioning state of the private endpoint connection. </summary>
        public PrivateEndpointConnectionProvisioningState? ProvisioningState { get; }
    }
}
