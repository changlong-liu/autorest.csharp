// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Storage.Models;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.Management.Storage
{
    /// <summary> A Class representing a FileShare along with the instance operations that can be performed on it. </summary>
    public partial class FileShare : ArmResource
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly FileSharesRestOperations _fileSharesRestClient;
        private readonly FileShareData _data;

        /// <summary> Initializes a new instance of the <see cref="FileShare"/> class for mocking. </summary>
        protected FileShare()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "FileShare"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal FileShare(ArmResource options, FileShareData resource) : base(options, resource.Id)
        {
            HasData = true;
            _data = resource;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _fileSharesRestClient = new FileSharesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="FileShare"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal FileShare(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _fileSharesRestClient = new FileSharesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="FileShare"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal FileShare(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _fileSharesRestClient = new FileSharesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Storage/storageAccounts/fileServices/shares";

        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual FileShareData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}
        /// OperationId: FileShares_Get
        /// <summary> Gets properties of a specified share. </summary>
        /// <param name="expand"> Optional, used to expand the properties within share&apos;s properties. Valid values are: stats. Should be passed as a string with delimiter &apos;,&apos;. </param>
        /// <param name="xMsSnapshot"> Optional, used to retrieve properties of a snapshot. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<FileShare>> GetAsync(string expand = null, string xMsSnapshot = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FileShare.Get");
            scope.Start();
            try
            {
                var response = await _fileSharesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, expand, xMsSnapshot, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new FileShare(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}
        /// OperationId: FileShares_Get
        /// <summary> Gets properties of a specified share. </summary>
        /// <param name="expand"> Optional, used to expand the properties within share&apos;s properties. Valid values are: stats. Should be passed as a string with delimiter &apos;,&apos;. </param>
        /// <param name="xMsSnapshot"> Optional, used to retrieve properties of a snapshot. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FileShare> Get(string expand = null, string xMsSnapshot = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FileShare.Get");
            scope.Start();
            try
            {
                var response = _fileSharesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, expand, xMsSnapshot, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FileShare(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<Location>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<Location> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}
        /// OperationId: FileShares_Delete
        /// <summary> Deletes specified share under its account. </summary>
        /// <param name="xMsSnapshot"> Optional, used to delete a snapshot. </param>
        /// <param name="include"> Optional. Valid values are: snapshots, leased-snapshots, none. The default value is snapshots. For &apos;snapshots&apos;, the file share is deleted including all of its file share snapshots. If the file share contains leased-snapshots, the deletion fails. For &apos;leased-snapshots&apos;, the file share is deleted included all of its file share snapshots (leased/unleased). For &apos;none&apos;, the file share is deleted if it has no share snapshots. If the file share contains any snapshots (leased or unleased), the deletion fails. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<FileShareDeleteOperation> DeleteAsync(bool waitForCompletion, string xMsSnapshot = null, string include = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FileShare.Delete");
            scope.Start();
            try
            {
                var response = await _fileSharesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, xMsSnapshot, include, cancellationToken).ConfigureAwait(false);
                var operation = new FileShareDeleteOperation(response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}
        /// OperationId: FileShares_Delete
        /// <summary> Deletes specified share under its account. </summary>
        /// <param name="xMsSnapshot"> Optional, used to delete a snapshot. </param>
        /// <param name="include"> Optional. Valid values are: snapshots, leased-snapshots, none. The default value is snapshots. For &apos;snapshots&apos;, the file share is deleted including all of its file share snapshots. If the file share contains leased-snapshots, the deletion fails. For &apos;leased-snapshots&apos;, the file share is deleted included all of its file share snapshots (leased/unleased). For &apos;none&apos;, the file share is deleted if it has no share snapshots. If the file share contains any snapshots (leased or unleased), the deletion fails. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual FileShareDeleteOperation Delete(bool waitForCompletion, string xMsSnapshot = null, string include = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FileShare.Delete");
            scope.Start();
            try
            {
                var response = _fileSharesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, xMsSnapshot, include, cancellationToken);
                var operation = new FileShareDeleteOperation(response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}
        /// OperationId: FileShares_Update
        /// <summary> Updates share properties as specified in request body. Properties not mentioned in the request will not be changed. Update fails if the specified share does not already exist. </summary>
        /// <param name="fileShare"> Properties to update for the file share. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileShare"/> is null. </exception>
        public async virtual Task<Response<FileShare>> UpdateAsync(FileShareData fileShare, CancellationToken cancellationToken = default)
        {
            if (fileShare == null)
            {
                throw new ArgumentNullException(nameof(fileShare));
            }

            using var scope = _clientDiagnostics.CreateScope("FileShare.Update");
            scope.Start();
            try
            {
                var response = await _fileSharesRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, fileShare, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new FileShare(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}
        /// OperationId: FileShares_Update
        /// <summary> Updates share properties as specified in request body. Properties not mentioned in the request will not be changed. Update fails if the specified share does not already exist. </summary>
        /// <param name="fileShare"> Properties to update for the file share. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fileShare"/> is null. </exception>
        public virtual Response<FileShare> Update(FileShareData fileShare, CancellationToken cancellationToken = default)
        {
            if (fileShare == null)
            {
                throw new ArgumentNullException(nameof(fileShare));
            }

            using var scope = _clientDiagnostics.CreateScope("FileShare.Update");
            scope.Start();
            try
            {
                var response = _fileSharesRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, fileShare, cancellationToken);
                return Response.FromValue(new FileShare(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}/restore
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}
        /// OperationId: FileShares_Restore
        /// <summary> Restore a file share within a valid retention days if share soft delete is enabled. </summary>
        /// <param name="deletedShare"> The DeletedShare to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deletedShare"/> is null. </exception>
        public async virtual Task<Response> RestoreAsync(DeletedShare deletedShare, CancellationToken cancellationToken = default)
        {
            if (deletedShare == null)
            {
                throw new ArgumentNullException(nameof(deletedShare));
            }

            using var scope = _clientDiagnostics.CreateScope("FileShare.Restore");
            scope.Start();
            try
            {
                var response = await _fileSharesRestClient.RestoreAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, deletedShare, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}/restore
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}
        /// OperationId: FileShares_Restore
        /// <summary> Restore a file share within a valid retention days if share soft delete is enabled. </summary>
        /// <param name="deletedShare"> The DeletedShare to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deletedShare"/> is null. </exception>
        public virtual Response Restore(DeletedShare deletedShare, CancellationToken cancellationToken = default)
        {
            if (deletedShare == null)
            {
                throw new ArgumentNullException(nameof(deletedShare));
            }

            using var scope = _clientDiagnostics.CreateScope("FileShare.Restore");
            scope.Start();
            try
            {
                var response = _fileSharesRestClient.Restore(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, deletedShare, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}/lease
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}
        /// OperationId: FileShares_Lease
        /// <summary> The Lease Share operation establishes and manages a lock on a share for delete operations. The lock duration can be 15 to 60 seconds, or can be infinite. </summary>
        /// <param name="xMsSnapshot"> Optional. Specify the snapshot time to lease a snapshot. </param>
        /// <param name="parameters"> Lease Share request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<LeaseShareResponse>> LeaseAsync(string xMsSnapshot = null, LeaseShareRequest parameters = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FileShare.Lease");
            scope.Start();
            try
            {
                var response = await _fileSharesRestClient.LeaseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, xMsSnapshot, parameters, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}/lease
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/fileServices/default/shares/{shareName}
        /// OperationId: FileShares_Lease
        /// <summary> The Lease Share operation establishes and manages a lock on a share for delete operations. The lock duration can be 15 to 60 seconds, or can be infinite. </summary>
        /// <param name="xMsSnapshot"> Optional. Specify the snapshot time to lease a snapshot. </param>
        /// <param name="parameters"> Lease Share request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<LeaseShareResponse> Lease(string xMsSnapshot = null, LeaseShareRequest parameters = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FileShare.Lease");
            scope.Start();
            try
            {
                var response = _fileSharesRestClient.Lease(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Name, xMsSnapshot, parameters, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
