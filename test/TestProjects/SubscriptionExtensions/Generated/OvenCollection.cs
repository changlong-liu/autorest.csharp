// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;
using SubscriptionExtensions.Models;

namespace SubscriptionExtensions
{
    /// <summary> A class representing collection of Oven and their operations over its parent. </summary>
    public partial class OvenCollection : ArmCollection, IEnumerable<Oven>, IAsyncEnumerable<Oven>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly OvensRestOperations _ovensRestClient;

        /// <summary> Initializes a new instance of the <see cref="OvenCollection"/> class for mocking. </summary>
        protected OvenCollection()
        {
        }

        /// <summary> Initializes a new instance of OvenCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal OvenCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _ovensRestClient = new OvensRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/ovens/{ovenName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Ovens_CreateOrUpdate
        /// <summary> The operation to create or update a virtual machine. Please note some properties can be set only during virtual machine creation. </summary>
        /// <param name="ovenName"> The name of the virtual machine. </param>
        /// <param name="parameters"> Parameters supplied to the Create Virtual Machine operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ovenName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual OvenCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string ovenName, OvenData parameters, CancellationToken cancellationToken = default)
        {
            if (ovenName == null)
            {
                throw new ArgumentNullException(nameof(ovenName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("OvenCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _ovensRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, ovenName, parameters, cancellationToken);
                var operation = new OvenCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _ovensRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, ovenName, parameters).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/ovens/{ovenName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Ovens_CreateOrUpdate
        /// <summary> The operation to create or update a virtual machine. Please note some properties can be set only during virtual machine creation. </summary>
        /// <param name="ovenName"> The name of the virtual machine. </param>
        /// <param name="parameters"> Parameters supplied to the Create Virtual Machine operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ovenName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<OvenCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string ovenName, OvenData parameters, CancellationToken cancellationToken = default)
        {
            if (ovenName == null)
            {
                throw new ArgumentNullException(nameof(ovenName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("OvenCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _ovensRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, ovenName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new OvenCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _ovensRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, ovenName, parameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/ovens/{ovenName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Ovens_Get
        /// <param name="ovenName"> The name of the virtual machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ovenName"/> is null. </exception>
        public virtual Response<Oven> Get(string ovenName, CancellationToken cancellationToken = default)
        {
            if (ovenName == null)
            {
                throw new ArgumentNullException(nameof(ovenName));
            }

            using var scope = _clientDiagnostics.CreateScope("OvenCollection.Get");
            scope.Start();
            try
            {
                var response = _ovensRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ovenName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Oven(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/ovens/{ovenName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Ovens_Get
        /// <param name="ovenName"> The name of the virtual machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ovenName"/> is null. </exception>
        public async virtual Task<Response<Oven>> GetAsync(string ovenName, CancellationToken cancellationToken = default)
        {
            if (ovenName == null)
            {
                throw new ArgumentNullException(nameof(ovenName));
            }

            using var scope = _clientDiagnostics.CreateScope("OvenCollection.Get");
            scope.Start();
            try
            {
                var response = await _ovensRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ovenName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new Oven(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ovenName"> The name of the virtual machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ovenName"/> is null. </exception>
        public virtual Response<Oven> GetIfExists(string ovenName, CancellationToken cancellationToken = default)
        {
            if (ovenName == null)
            {
                throw new ArgumentNullException(nameof(ovenName));
            }

            using var scope = _clientDiagnostics.CreateScope("OvenCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _ovensRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ovenName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<Oven>(null, response.GetRawResponse())
                    : Response.FromValue(new Oven(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ovenName"> The name of the virtual machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ovenName"/> is null. </exception>
        public async virtual Task<Response<Oven>> GetIfExistsAsync(string ovenName, CancellationToken cancellationToken = default)
        {
            if (ovenName == null)
            {
                throw new ArgumentNullException(nameof(ovenName));
            }

            using var scope = _clientDiagnostics.CreateScope("OvenCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _ovensRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ovenName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<Oven>(null, response.GetRawResponse())
                    : Response.FromValue(new Oven(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ovenName"> The name of the virtual machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ovenName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string ovenName, CancellationToken cancellationToken = default)
        {
            if (ovenName == null)
            {
                throw new ArgumentNullException(nameof(ovenName));
            }

            using var scope = _clientDiagnostics.CreateScope("OvenCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(ovenName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ovenName"> The name of the virtual machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ovenName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string ovenName, CancellationToken cancellationToken = default)
        {
            if (ovenName == null)
            {
                throw new ArgumentNullException(nameof(ovenName));
            }

            using var scope = _clientDiagnostics.CreateScope("OvenCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(ovenName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/ovens
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Ovens_ListAll
        /// <summary> Lists all of the virtual machines in the specified subscription. Use the nextLink property in the response to get the next page of virtual machines. </summary>
        /// <param name="statusOnly"> statusOnly=true enables fetching run time status of all Virtual Machines in the subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Oven" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Oven> GetAll(string statusOnly = null, CancellationToken cancellationToken = default)
        {
            Page<Oven> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OvenCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _ovensRestClient.ListAll(Id.SubscriptionId, Id.ResourceGroupName, statusOnly, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Oven(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Oven> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OvenCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _ovensRestClient.ListAllNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, statusOnly, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Oven(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/ovens
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Ovens_ListAll
        /// <summary> Lists all of the virtual machines in the specified subscription. Use the nextLink property in the response to get the next page of virtual machines. </summary>
        /// <param name="statusOnly"> statusOnly=true enables fetching run time status of all Virtual Machines in the subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Oven" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Oven> GetAllAsync(string statusOnly = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<Oven>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OvenCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _ovensRestClient.ListAllAsync(Id.SubscriptionId, Id.ResourceGroupName, statusOnly, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Oven(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Oven>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("OvenCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _ovensRestClient.ListAllNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, statusOnly, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Oven(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="Oven" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OvenCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(Oven.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="Oven" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("OvenCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(Oven.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<Oven> IEnumerable<Oven>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<Oven> IAsyncEnumerable<Oven>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, Oven, OvenData> Construct() { }
    }
}
