// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace MgmtSignalR
{
    /// <summary> A class representing collection of SignalRResource and their operations over its parent. </summary>
    public partial class SignalRResourceCollection : ArmCollection, IEnumerable<SignalRResource>, IAsyncEnumerable<SignalRResource>
    {
        private readonly ClientDiagnostics _signalRResourceSignalRClientDiagnostics;
        private readonly SignalRRestOperations _signalRResourceSignalRRestClient;

        /// <summary> Initializes a new instance of the <see cref="SignalRResourceCollection"/> class for mocking. </summary>
        protected SignalRResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SignalRResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SignalRResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _signalRResourceSignalRClientDiagnostics = new ClientDiagnostics("MgmtSignalR", SignalRResource.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(SignalRResource.ResourceType, out string signalRResourceSignalRApiVersion);
            _signalRResourceSignalRRestClient = new SignalRRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, signalRResourceSignalRApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}
        /// Operation Id: SignalR_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="resourceName"> The name of the SignalR resource. </param>
        /// <param name="parameters"> Parameters for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual async Task<ArmOperation<SignalRResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string resourceName, SignalRResourceData parameters = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _signalRResourceSignalRClientDiagnostics.CreateScope("SignalRResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _signalRResourceSignalRRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, resourceName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtSignalRArmOperation<SignalRResource>(new SignalRResourceOperationSource(Client), _signalRResourceSignalRClientDiagnostics, Pipeline, _signalRResourceSignalRRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, resourceName, parameters).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update a resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}
        /// Operation Id: SignalR_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="resourceName"> The name of the SignalR resource. </param>
        /// <param name="parameters"> Parameters for the create or update operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual ArmOperation<SignalRResource> CreateOrUpdate(WaitUntil waitUntil, string resourceName, SignalRResourceData parameters = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _signalRResourceSignalRClientDiagnostics.CreateScope("SignalRResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _signalRResourceSignalRRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, resourceName, parameters, cancellationToken);
                var operation = new MgmtSignalRArmOperation<SignalRResource>(new SignalRResourceOperationSource(Client), _signalRResourceSignalRClientDiagnostics, Pipeline, _signalRResourceSignalRRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, resourceName, parameters).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the resource and its properties.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}
        /// Operation Id: SignalR_Get
        /// </summary>
        /// <param name="resourceName"> The name of the SignalR resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual async Task<Response<SignalRResource>> GetAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _signalRResourceSignalRClientDiagnostics.CreateScope("SignalRResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _signalRResourceSignalRRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, resourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SignalRResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the resource and its properties.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}
        /// Operation Id: SignalR_Get
        /// </summary>
        /// <param name="resourceName"> The name of the SignalR resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual Response<SignalRResource> Get(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _signalRResourceSignalRClientDiagnostics.CreateScope("SignalRResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _signalRResourceSignalRRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, resourceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SignalRResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Handles requests to list all resources in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR
        /// Operation Id: SignalR_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SignalRResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SignalRResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SignalRResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _signalRResourceSignalRClientDiagnostics.CreateScope("SignalRResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _signalRResourceSignalRRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SignalRResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SignalRResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _signalRResourceSignalRClientDiagnostics.CreateScope("SignalRResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _signalRResourceSignalRRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SignalRResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Handles requests to list all resources in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR
        /// Operation Id: SignalR_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SignalRResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SignalRResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SignalRResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _signalRResourceSignalRClientDiagnostics.CreateScope("SignalRResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _signalRResourceSignalRRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SignalRResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SignalRResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _signalRResourceSignalRClientDiagnostics.CreateScope("SignalRResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _signalRResourceSignalRRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SignalRResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}
        /// Operation Id: SignalR_Get
        /// </summary>
        /// <param name="resourceName"> The name of the SignalR resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _signalRResourceSignalRClientDiagnostics.CreateScope("SignalRResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(resourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}
        /// Operation Id: SignalR_Get
        /// </summary>
        /// <param name="resourceName"> The name of the SignalR resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _signalRResourceSignalRClientDiagnostics.CreateScope("SignalRResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(resourceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}
        /// Operation Id: SignalR_Get
        /// </summary>
        /// <param name="resourceName"> The name of the SignalR resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual async Task<Response<SignalRResource>> GetIfExistsAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _signalRResourceSignalRClientDiagnostics.CreateScope("SignalRResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _signalRResourceSignalRRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, resourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SignalRResource>(null, response.GetRawResponse());
                return Response.FromValue(new SignalRResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SignalRService/signalR/{resourceName}
        /// Operation Id: SignalR_Get
        /// </summary>
        /// <param name="resourceName"> The name of the SignalR resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual Response<SignalRResource> GetIfExists(string resourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceName, nameof(resourceName));

            using var scope = _signalRResourceSignalRClientDiagnostics.CreateScope("SignalRResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _signalRResourceSignalRRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, resourceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SignalRResource>(null, response.GetRawResponse());
                return Response.FromValue(new SignalRResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SignalRResource> IEnumerable<SignalRResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SignalRResource> IAsyncEnumerable<SignalRResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
