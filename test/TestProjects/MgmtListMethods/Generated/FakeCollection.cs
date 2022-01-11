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
using MgmtListMethods.Models;

namespace MgmtListMethods
{
    /// <summary> A class representing collection of Fake and their operations over its parent. </summary>
    public partial class FakeCollection : ArmCollection, IEnumerable<Fake>, IAsyncEnumerable<Fake>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly FakesRestOperations _fakesRestClient;

        /// <summary> Initializes a new instance of the <see cref="FakeCollection"/> class for mocking. </summary>
        protected FakeCollection()
        {
        }

        /// <summary> Initializes a new instance of FakeCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal FakeCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _fakesRestClient = new FakesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Subscription.ResourceType)
                throw new ArgumentException(nameof(id), string.Format("Invalid resource type {0} expected {1}", id.ResourceType, Subscription.ResourceType));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: Fakes_CreateOrUpdate
        /// <summary> Create or update an fake. </summary>
        /// <param name="fakeName"> The name of the fake. </param>
        /// <param name="parameters"> Parameters supplied to the Create Availability Set operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual FakeCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string fakeName, FakeData parameters, CancellationToken cancellationToken = default)
        {
            if (fakeName == null)
            {
                throw new ArgumentNullException(nameof(fakeName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FakeCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _fakesRestClient.CreateOrUpdate(Id.SubscriptionId, fakeName, parameters, cancellationToken);
                var operation = new FakeCreateOrUpdateOperation(Parent, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: Fakes_CreateOrUpdate
        /// <summary> Create or update an fake. </summary>
        /// <param name="fakeName"> The name of the fake. </param>
        /// <param name="parameters"> Parameters supplied to the Create Availability Set operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<FakeCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string fakeName, FakeData parameters, CancellationToken cancellationToken = default)
        {
            if (fakeName == null)
            {
                throw new ArgumentNullException(nameof(fakeName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FakeCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _fakesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, fakeName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new FakeCreateOrUpdateOperation(Parent, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: Fakes_Get
        /// <summary> Retrieves information about an fake. </summary>
        /// <param name="fakeName"> The name of the fake. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeName"/> is null. </exception>
        public virtual Response<Fake> Get(string fakeName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (fakeName == null)
            {
                throw new ArgumentNullException(nameof(fakeName));
            }

            using var scope = _clientDiagnostics.CreateScope("FakeCollection.Get");
            scope.Start();
            try
            {
                var response = _fakesRestClient.Get(Id.SubscriptionId, fakeName, expand, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Fake(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: Fakes_Get
        /// <summary> Retrieves information about an fake. </summary>
        /// <param name="fakeName"> The name of the fake. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeName"/> is null. </exception>
        public async virtual Task<Response<Fake>> GetAsync(string fakeName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (fakeName == null)
            {
                throw new ArgumentNullException(nameof(fakeName));
            }

            using var scope = _clientDiagnostics.CreateScope("FakeCollection.Get");
            scope.Start();
            try
            {
                var response = await _fakesRestClient.GetAsync(Id.SubscriptionId, fakeName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new Fake(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="fakeName"> The name of the fake. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeName"/> is null. </exception>
        public virtual Response<Fake> GetIfExists(string fakeName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (fakeName == null)
            {
                throw new ArgumentNullException(nameof(fakeName));
            }

            using var scope = _clientDiagnostics.CreateScope("FakeCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _fakesRestClient.Get(Id.SubscriptionId, fakeName, expand, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<Fake>(null, response.GetRawResponse())
                    : Response.FromValue(new Fake(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="fakeName"> The name of the fake. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeName"/> is null. </exception>
        public async virtual Task<Response<Fake>> GetIfExistsAsync(string fakeName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (fakeName == null)
            {
                throw new ArgumentNullException(nameof(fakeName));
            }

            using var scope = _clientDiagnostics.CreateScope("FakeCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _fakesRestClient.GetAsync(Id.SubscriptionId, fakeName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<Fake>(null, response.GetRawResponse())
                    : Response.FromValue(new Fake(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="fakeName"> The name of the fake. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeName"/> is null. </exception>
        public virtual Response<bool> Exists(string fakeName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (fakeName == null)
            {
                throw new ArgumentNullException(nameof(fakeName));
            }

            using var scope = _clientDiagnostics.CreateScope("FakeCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(fakeName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="fakeName"> The name of the fake. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string fakeName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (fakeName == null)
            {
                throw new ArgumentNullException(nameof(fakeName));
            }

            using var scope = _clientDiagnostics.CreateScope("FakeCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(fakeName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: Fakes_List
        /// <summary> Lists all fakes in a resource group. </summary>
        /// <param name="optionalParam"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Fake" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Fake> GetAll(string optionalParam = null, CancellationToken cancellationToken = default)
        {
            Page<Fake> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FakeCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _fakesRestClient.List(Id.SubscriptionId, optionalParam, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Fake(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Fake> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FakeCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _fakesRestClient.ListNextPage(nextLink, Id.SubscriptionId, optionalParam, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Fake(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: Fakes_List
        /// <summary> Lists all fakes in a resource group. </summary>
        /// <param name="optionalParam"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Fake" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Fake> GetAllAsync(string optionalParam = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<Fake>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FakeCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _fakesRestClient.ListAsync(Id.SubscriptionId, optionalParam, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Fake(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Fake>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FakeCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _fakesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, optionalParam, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Fake(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="Fake" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FakeCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(Fake.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="Fake" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FakeCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(Fake.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<Fake> IEnumerable<Fake>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<Fake> IAsyncEnumerable<Fake>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, Fake, FakeData> Construct() { }
    }
}
