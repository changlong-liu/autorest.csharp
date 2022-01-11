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
using Azure.ResourceManager.Core;
using MgmtListMethods.Models;

namespace MgmtListMethods
{
    /// <summary> A class representing collection of TenantParentWithNonResChWithLoc and their operations over its parent. </summary>
    public partial class TenantParentWithNonResChWithLocCollection : ArmCollection, IEnumerable<TenantParentWithNonResChWithLoc>, IAsyncEnumerable<TenantParentWithNonResChWithLoc>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly TenantParentWithNonResChWithLocsRestOperations _tenantParentWithNonResChWithLocsRestClient;

        /// <summary> Initializes a new instance of the <see cref="TenantParentWithNonResChWithLocCollection"/> class for mocking. </summary>
        protected TenantParentWithNonResChWithLocCollection()
        {
        }

        /// <summary> Initializes a new instance of TenantParentWithNonResChWithLocCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal TenantParentWithNonResChWithLocCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _tenantParentWithNonResChWithLocsRestClient = new TenantParentWithNonResChWithLocsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != TenantTest.ResourceType)
                throw new ArgumentException(nameof(id), string.Format("Invalid resource type {0} expected {1}", id.ResourceType, TenantTest.ResourceType));
        }

        // Collection level operations.

        /// RequestPath: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}/tenantParentWithNonResChWithLocs/{tenantParentWithNonResChWithLocName}
        /// ContextualPath: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}
        /// OperationId: TenantParentWithNonResChWithLocs_CreateOrUpdate
        /// <summary> Create or update. </summary>
        /// <param name="tenantParentWithNonResChWithLocName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantParentWithNonResChWithLocName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual TenantParentWithNonResChWithLocCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string tenantParentWithNonResChWithLocName, TenantParentWithNonResChWithLocData parameters, CancellationToken cancellationToken = default)
        {
            if (tenantParentWithNonResChWithLocName == null)
            {
                throw new ArgumentNullException(nameof(tenantParentWithNonResChWithLocName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("TenantParentWithNonResChWithLocCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _tenantParentWithNonResChWithLocsRestClient.CreateOrUpdate(Id.Name, tenantParentWithNonResChWithLocName, parameters, cancellationToken);
                var operation = new TenantParentWithNonResChWithLocCreateOrUpdateOperation(Parent, response);
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

        /// RequestPath: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}/tenantParentWithNonResChWithLocs/{tenantParentWithNonResChWithLocName}
        /// ContextualPath: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}
        /// OperationId: TenantParentWithNonResChWithLocs_CreateOrUpdate
        /// <summary> Create or update. </summary>
        /// <param name="tenantParentWithNonResChWithLocName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantParentWithNonResChWithLocName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<TenantParentWithNonResChWithLocCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string tenantParentWithNonResChWithLocName, TenantParentWithNonResChWithLocData parameters, CancellationToken cancellationToken = default)
        {
            if (tenantParentWithNonResChWithLocName == null)
            {
                throw new ArgumentNullException(nameof(tenantParentWithNonResChWithLocName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("TenantParentWithNonResChWithLocCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _tenantParentWithNonResChWithLocsRestClient.CreateOrUpdateAsync(Id.Name, tenantParentWithNonResChWithLocName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new TenantParentWithNonResChWithLocCreateOrUpdateOperation(Parent, response);
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

        /// RequestPath: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}/tenantParentWithNonResChWithLocs/{tenantParentWithNonResChWithLocName}
        /// ContextualPath: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}
        /// OperationId: TenantParentWithNonResChWithLocs_Get
        /// <summary> Retrieves information. </summary>
        /// <param name="tenantParentWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantParentWithNonResChWithLocName"/> is null. </exception>
        public virtual Response<TenantParentWithNonResChWithLoc> Get(string tenantParentWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            if (tenantParentWithNonResChWithLocName == null)
            {
                throw new ArgumentNullException(nameof(tenantParentWithNonResChWithLocName));
            }

            using var scope = _clientDiagnostics.CreateScope("TenantParentWithNonResChWithLocCollection.Get");
            scope.Start();
            try
            {
                var response = _tenantParentWithNonResChWithLocsRestClient.Get(Id.Name, tenantParentWithNonResChWithLocName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantParentWithNonResChWithLoc(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}/tenantParentWithNonResChWithLocs/{tenantParentWithNonResChWithLocName}
        /// ContextualPath: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}
        /// OperationId: TenantParentWithNonResChWithLocs_Get
        /// <summary> Retrieves information. </summary>
        /// <param name="tenantParentWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantParentWithNonResChWithLocName"/> is null. </exception>
        public async virtual Task<Response<TenantParentWithNonResChWithLoc>> GetAsync(string tenantParentWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            if (tenantParentWithNonResChWithLocName == null)
            {
                throw new ArgumentNullException(nameof(tenantParentWithNonResChWithLocName));
            }

            using var scope = _clientDiagnostics.CreateScope("TenantParentWithNonResChWithLocCollection.Get");
            scope.Start();
            try
            {
                var response = await _tenantParentWithNonResChWithLocsRestClient.GetAsync(Id.Name, tenantParentWithNonResChWithLocName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new TenantParentWithNonResChWithLoc(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tenantParentWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantParentWithNonResChWithLocName"/> is null. </exception>
        public virtual Response<TenantParentWithNonResChWithLoc> GetIfExists(string tenantParentWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            if (tenantParentWithNonResChWithLocName == null)
            {
                throw new ArgumentNullException(nameof(tenantParentWithNonResChWithLocName));
            }

            using var scope = _clientDiagnostics.CreateScope("TenantParentWithNonResChWithLocCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _tenantParentWithNonResChWithLocsRestClient.Get(Id.Name, tenantParentWithNonResChWithLocName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<TenantParentWithNonResChWithLoc>(null, response.GetRawResponse())
                    : Response.FromValue(new TenantParentWithNonResChWithLoc(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tenantParentWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantParentWithNonResChWithLocName"/> is null. </exception>
        public async virtual Task<Response<TenantParentWithNonResChWithLoc>> GetIfExistsAsync(string tenantParentWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            if (tenantParentWithNonResChWithLocName == null)
            {
                throw new ArgumentNullException(nameof(tenantParentWithNonResChWithLocName));
            }

            using var scope = _clientDiagnostics.CreateScope("TenantParentWithNonResChWithLocCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _tenantParentWithNonResChWithLocsRestClient.GetAsync(Id.Name, tenantParentWithNonResChWithLocName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<TenantParentWithNonResChWithLoc>(null, response.GetRawResponse())
                    : Response.FromValue(new TenantParentWithNonResChWithLoc(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tenantParentWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantParentWithNonResChWithLocName"/> is null. </exception>
        public virtual Response<bool> Exists(string tenantParentWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            if (tenantParentWithNonResChWithLocName == null)
            {
                throw new ArgumentNullException(nameof(tenantParentWithNonResChWithLocName));
            }

            using var scope = _clientDiagnostics.CreateScope("TenantParentWithNonResChWithLocCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(tenantParentWithNonResChWithLocName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="tenantParentWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantParentWithNonResChWithLocName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string tenantParentWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            if (tenantParentWithNonResChWithLocName == null)
            {
                throw new ArgumentNullException(nameof(tenantParentWithNonResChWithLocName));
            }

            using var scope = _clientDiagnostics.CreateScope("TenantParentWithNonResChWithLocCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(tenantParentWithNonResChWithLocName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}/tenantParentWithNonResChWithLocs
        /// ContextualPath: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}
        /// OperationId: TenantParentWithNonResChWithLocs_List
        /// <summary> Lists all in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="TenantParentWithNonResChWithLoc" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<TenantParentWithNonResChWithLoc> GetAll(CancellationToken cancellationToken = default)
        {
            Page<TenantParentWithNonResChWithLoc> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("TenantParentWithNonResChWithLocCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _tenantParentWithNonResChWithLocsRestClient.List(Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new TenantParentWithNonResChWithLoc(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<TenantParentWithNonResChWithLoc> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("TenantParentWithNonResChWithLocCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _tenantParentWithNonResChWithLocsRestClient.ListNextPage(nextLink, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new TenantParentWithNonResChWithLoc(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}/tenantParentWithNonResChWithLocs
        /// ContextualPath: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}
        /// OperationId: TenantParentWithNonResChWithLocs_List
        /// <summary> Lists all in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="TenantParentWithNonResChWithLoc" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<TenantParentWithNonResChWithLoc> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<TenantParentWithNonResChWithLoc>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("TenantParentWithNonResChWithLocCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _tenantParentWithNonResChWithLocsRestClient.ListAsync(Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new TenantParentWithNonResChWithLoc(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<TenantParentWithNonResChWithLoc>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("TenantParentWithNonResChWithLocCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _tenantParentWithNonResChWithLocsRestClient.ListNextPageAsync(nextLink, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new TenantParentWithNonResChWithLoc(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<TenantParentWithNonResChWithLoc> IEnumerable<TenantParentWithNonResChWithLoc>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<TenantParentWithNonResChWithLoc> IAsyncEnumerable<TenantParentWithNonResChWithLoc>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, TenantParentWithNonResChWithLoc, TenantParentWithNonResChWithLocData> Construct() { }
    }
}
