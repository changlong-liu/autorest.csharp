// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace MgmtSignalR
{
    /// <summary> A Class representing a PrivateEndpointConnection along with the instance operations that can be performed on it. </summary>
    public partial class PrivateEndpointConnection : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="PrivateEndpointConnection"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName, string privateEndpointConnectionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}/privateEndpointConnections/{privateEndpointConnectionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _privateEndpointConnectionSignalRPrivateEndpointConnectionsClientDiagnostics;
        private readonly SignalRPrivateEndpointConnectionsRestOperations _privateEndpointConnectionSignalRPrivateEndpointConnectionsRestClient;
        private readonly PrivateEndpointConnectionData _data;

        /// <summary> Initializes a new instance of the <see cref="PrivateEndpointConnection"/> class for mocking. </summary>
        protected PrivateEndpointConnection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "PrivateEndpointConnection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal PrivateEndpointConnection(ArmClient client, PrivateEndpointConnectionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="PrivateEndpointConnection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal PrivateEndpointConnection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _privateEndpointConnectionSignalRPrivateEndpointConnectionsClientDiagnostics = new ClientDiagnostics("MgmtSignalR", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string privateEndpointConnectionSignalRPrivateEndpointConnectionsApiVersion);
            _privateEndpointConnectionSignalRPrivateEndpointConnectionsRestClient = new SignalRPrivateEndpointConnectionsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, privateEndpointConnectionSignalRPrivateEndpointConnectionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.SignalRService/signalR/privateEndpointConnections";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual PrivateEndpointConnectionData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get the specified private endpoint connection associated with a SignalR resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: SignalRPrivateEndpointConnections_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PrivateEndpointConnection>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _privateEndpointConnectionSignalRPrivateEndpointConnectionsClientDiagnostics.CreateScope("PrivateEndpointConnection.Get");
            scope.Start();
            try
            {
                var response = await _privateEndpointConnectionSignalRPrivateEndpointConnectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateEndpointConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified private endpoint connection associated with a SignalR resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: SignalRPrivateEndpointConnections_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PrivateEndpointConnection> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _privateEndpointConnectionSignalRPrivateEndpointConnectionsClientDiagnostics.CreateScope("PrivateEndpointConnection.Get");
            scope.Start();
            try
            {
                var response = _privateEndpointConnectionSignalRPrivateEndpointConnectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateEndpointConnection(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete the specified private endpoint connection associated with a SignalR resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: SignalRPrivateEndpointConnections_Delete
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _privateEndpointConnectionSignalRPrivateEndpointConnectionsClientDiagnostics.CreateScope("PrivateEndpointConnection.Delete");
            scope.Start();
            try
            {
                var response = await _privateEndpointConnectionSignalRPrivateEndpointConnectionsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtSignalRArmOperation(_privateEndpointConnectionSignalRPrivateEndpointConnectionsClientDiagnostics, Pipeline, _privateEndpointConnectionSignalRPrivateEndpointConnectionsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete the specified private endpoint connection associated with a SignalR resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}/privateEndpointConnections/{privateEndpointConnectionName}
        /// Operation Id: SignalRPrivateEndpointConnections_Delete
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _privateEndpointConnectionSignalRPrivateEndpointConnectionsClientDiagnostics.CreateScope("PrivateEndpointConnection.Delete");
            scope.Start();
            try
            {
                var response = _privateEndpointConnectionSignalRPrivateEndpointConnectionsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new MgmtSignalRArmOperation(_privateEndpointConnectionSignalRPrivateEndpointConnectionsClientDiagnostics, Pipeline, _privateEndpointConnectionSignalRPrivateEndpointConnectionsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}