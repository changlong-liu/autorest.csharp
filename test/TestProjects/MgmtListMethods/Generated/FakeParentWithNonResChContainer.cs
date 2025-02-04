// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;
using MgmtListMethods.Models;

namespace MgmtListMethods
{
    /// <summary> A class representing collection of FakeParentWithNonResCh and their operations over a Fake. </summary>
    public partial class FakeParentWithNonResChContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly FakeParentWithNonResChesRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="FakeParentWithNonResChContainer"/> class for mocking. </summary>
        protected FakeParentWithNonResChContainer()
        {
        }

        /// <summary> Initializes a new instance of FakeParentWithNonResChContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal FakeParentWithNonResChContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new FakeParentWithNonResChesRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => Fake.ResourceType;

        // Container level operations.

        /// <summary> Create or update. </summary>
        /// <param name="fakeParentWithNonResChName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeParentWithNonResChName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<FakeParentWithNonResCh> CreateOrUpdate(string fakeParentWithNonResChName, FakeParentWithNonResChData parameters, CancellationToken cancellationToken = default)
        {
            if (fakeParentWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(fakeParentWithNonResChName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FakeParentWithNonResChContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(fakeParentWithNonResChName, parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update. </summary>
        /// <param name="fakeParentWithNonResChName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeParentWithNonResChName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<FakeParentWithNonResCh>> CreateOrUpdateAsync(string fakeParentWithNonResChName, FakeParentWithNonResChData parameters, CancellationToken cancellationToken = default)
        {
            if (fakeParentWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(fakeParentWithNonResChName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FakeParentWithNonResChContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(fakeParentWithNonResChName, parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update. </summary>
        /// <param name="fakeParentWithNonResChName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeParentWithNonResChName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual FakeParentWithNonResChCreateOrUpdateOperation StartCreateOrUpdate(string fakeParentWithNonResChName, FakeParentWithNonResChData parameters, CancellationToken cancellationToken = default)
        {
            if (fakeParentWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(fakeParentWithNonResChName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FakeParentWithNonResChContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.Name, fakeParentWithNonResChName, parameters, cancellationToken);
                return new FakeParentWithNonResChCreateOrUpdateOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update. </summary>
        /// <param name="fakeParentWithNonResChName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeParentWithNonResChName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<FakeParentWithNonResChCreateOrUpdateOperation> StartCreateOrUpdateAsync(string fakeParentWithNonResChName, FakeParentWithNonResChData parameters, CancellationToken cancellationToken = default)
        {
            if (fakeParentWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(fakeParentWithNonResChName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FakeParentWithNonResChContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.Name, fakeParentWithNonResChName, parameters, cancellationToken).ConfigureAwait(false);
                return new FakeParentWithNonResChCreateOrUpdateOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="fakeParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<FakeParentWithNonResCh> Get(string fakeParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FakeParentWithNonResChContainer.Get");
            scope.Start();
            try
            {
                if (fakeParentWithNonResChName == null)
                {
                    throw new ArgumentNullException(nameof(fakeParentWithNonResChName));
                }

                var response = _restClient.Get(Id.Name, fakeParentWithNonResChName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FakeParentWithNonResCh(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="fakeParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<FakeParentWithNonResCh>> GetAsync(string fakeParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FakeParentWithNonResChContainer.Get");
            scope.Start();
            try
            {
                if (fakeParentWithNonResChName == null)
                {
                    throw new ArgumentNullException(nameof(fakeParentWithNonResChName));
                }

                var response = await _restClient.GetAsync(Id.Name, fakeParentWithNonResChName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new FakeParentWithNonResCh(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="fakeParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<FakeParentWithNonResCh> GetIfExists(string fakeParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FakeParentWithNonResChContainer.GetIfExists");
            scope.Start();
            try
            {
                if (fakeParentWithNonResChName == null)
                {
                    throw new ArgumentNullException(nameof(fakeParentWithNonResChName));
                }

                var response = _restClient.Get(Id.Name, fakeParentWithNonResChName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<FakeParentWithNonResCh>(null, response.GetRawResponse())
                    : Response.FromValue(new FakeParentWithNonResCh(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="fakeParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<FakeParentWithNonResCh>> GetIfExistsAsync(string fakeParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FakeParentWithNonResChContainer.GetIfExists");
            scope.Start();
            try
            {
                if (fakeParentWithNonResChName == null)
                {
                    throw new ArgumentNullException(nameof(fakeParentWithNonResChName));
                }

                var response = await _restClient.GetAsync(Id.Name, fakeParentWithNonResChName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<FakeParentWithNonResCh>(null, response.GetRawResponse())
                    : Response.FromValue(new FakeParentWithNonResCh(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="fakeParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string fakeParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FakeParentWithNonResChContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (fakeParentWithNonResChName == null)
                {
                    throw new ArgumentNullException(nameof(fakeParentWithNonResChName));
                }

                var response = GetIfExists(fakeParentWithNonResChName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="fakeParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string fakeParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FakeParentWithNonResChContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (fakeParentWithNonResChName == null)
                {
                    throw new ArgumentNullException(nameof(fakeParentWithNonResChName));
                }

                var response = await GetIfExistsAsync(fakeParentWithNonResChName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FakeParentWithNonResCh" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FakeParentWithNonResCh> GetAll(CancellationToken cancellationToken = default)
        {
            Page<FakeParentWithNonResCh> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FakeParentWithNonResChContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetTest(Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FakeParentWithNonResCh(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<FakeParentWithNonResCh> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FakeParentWithNonResChContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetTestNextPage(nextLink, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FakeParentWithNonResCh(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FakeParentWithNonResCh" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FakeParentWithNonResCh> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<FakeParentWithNonResCh>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FakeParentWithNonResChContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetTestAsync(Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FakeParentWithNonResCh(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<FakeParentWithNonResCh>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FakeParentWithNonResChContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetTestNextPageAsync(nextLink, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FakeParentWithNonResCh(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="FakeParentWithNonResCh" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FakeParentWithNonResChContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(FakeParentWithNonResCh.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="FakeParentWithNonResCh" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FakeParentWithNonResChContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(FakeParentWithNonResCh.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, FakeParentWithNonResCh, FakeParentWithNonResChData> Construct() { }
    }
}
