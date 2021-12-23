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
using TenantOnly.Models;

namespace TenantOnly
{
    /// <summary> A class representing collection of BillingAccount and their operations over its parent. </summary>
    public partial class BillingAccountCollection : ArmCollection, IEnumerable<BillingAccount>, IAsyncEnumerable<BillingAccount>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly BillingAccountsRestOperations _billingAccountsRestClient;

        /// <summary> Initializes a new instance of the <see cref="BillingAccountCollection"/> class for mocking. </summary>
        protected BillingAccountCollection()
        {
        }

        /// <summary> Initializes a new instance of BillingAccountCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal BillingAccountCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _billingAccountsRestClient = new BillingAccountsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => Tenant.ResourceType;

        // Collection level operations.

        /// RequestPath: /providers/Microsoft.Billing/billingAccounts/{billingAccountName}
        /// ContextualPath: /
        /// OperationId: BillingAccounts_Create
        /// <summary> Updates the properties of a billing account. Currently, displayName and address can be updated. The operation is supported only for billing accounts with agreement type Microsoft Customer Agreement. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="parameters"> Request parameters that are provided to the update billing account operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual BillingAccountCreateOperation CreateOrUpdate(string billingAccountName, BillingAccountData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (billingAccountName == null)
            {
                throw new ArgumentNullException(nameof(billingAccountName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("BillingAccountCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _billingAccountsRestClient.Create(billingAccountName, parameters, cancellationToken);
                var operation = new BillingAccountCreateOperation(Parent, _clientDiagnostics, Pipeline, _billingAccountsRestClient.CreateCreateRequest(billingAccountName, parameters).Request, response);
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

        /// RequestPath: /providers/Microsoft.Billing/billingAccounts/{billingAccountName}
        /// ContextualPath: /
        /// OperationId: BillingAccounts_Create
        /// <summary> Updates the properties of a billing account. Currently, displayName and address can be updated. The operation is supported only for billing accounts with agreement type Microsoft Customer Agreement. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="parameters"> Request parameters that are provided to the update billing account operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<BillingAccountCreateOperation> CreateOrUpdateAsync(string billingAccountName, BillingAccountData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (billingAccountName == null)
            {
                throw new ArgumentNullException(nameof(billingAccountName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("BillingAccountCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _billingAccountsRestClient.CreateAsync(billingAccountName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new BillingAccountCreateOperation(Parent, _clientDiagnostics, Pipeline, _billingAccountsRestClient.CreateCreateRequest(billingAccountName, parameters).Request, response);
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

        /// RequestPath: /providers/Microsoft.Billing/billingAccounts/{billingAccountName}
        /// ContextualPath: /
        /// OperationId: BillingAccounts_Get
        /// <summary> Gets a billing account by its ID. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="expand"> May be used to expand the soldTo, invoice sections and billing profiles. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/> is null. </exception>
        public virtual Response<BillingAccount> Get(string billingAccountName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (billingAccountName == null)
            {
                throw new ArgumentNullException(nameof(billingAccountName));
            }

            using var scope = _clientDiagnostics.CreateScope("BillingAccountCollection.Get");
            scope.Start();
            try
            {
                var response = _billingAccountsRestClient.Get(billingAccountName, expand, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingAccount(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Billing/billingAccounts/{billingAccountName}
        /// ContextualPath: /
        /// OperationId: BillingAccounts_Get
        /// <summary> Gets a billing account by its ID. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="expand"> May be used to expand the soldTo, invoice sections and billing profiles. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/> is null. </exception>
        public async virtual Task<Response<BillingAccount>> GetAsync(string billingAccountName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (billingAccountName == null)
            {
                throw new ArgumentNullException(nameof(billingAccountName));
            }

            using var scope = _clientDiagnostics.CreateScope("BillingAccountCollection.Get");
            scope.Start();
            try
            {
                var response = await _billingAccountsRestClient.GetAsync(billingAccountName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new BillingAccount(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="expand"> May be used to expand the soldTo, invoice sections and billing profiles. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/> is null. </exception>
        public virtual Response<BillingAccount> GetIfExists(string billingAccountName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (billingAccountName == null)
            {
                throw new ArgumentNullException(nameof(billingAccountName));
            }

            using var scope = _clientDiagnostics.CreateScope("BillingAccountCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _billingAccountsRestClient.Get(billingAccountName, expand, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<BillingAccount>(null, response.GetRawResponse())
                    : Response.FromValue(new BillingAccount(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="expand"> May be used to expand the soldTo, invoice sections and billing profiles. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/> is null. </exception>
        public async virtual Task<Response<BillingAccount>> GetIfExistsAsync(string billingAccountName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (billingAccountName == null)
            {
                throw new ArgumentNullException(nameof(billingAccountName));
            }

            using var scope = _clientDiagnostics.CreateScope("BillingAccountCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _billingAccountsRestClient.GetAsync(billingAccountName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<BillingAccount>(null, response.GetRawResponse())
                    : Response.FromValue(new BillingAccount(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="expand"> May be used to expand the soldTo, invoice sections and billing profiles. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/> is null. </exception>
        public virtual Response<bool> Exists(string billingAccountName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (billingAccountName == null)
            {
                throw new ArgumentNullException(nameof(billingAccountName));
            }

            using var scope = _clientDiagnostics.CreateScope("BillingAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(billingAccountName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="expand"> May be used to expand the soldTo, invoice sections and billing profiles. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string billingAccountName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (billingAccountName == null)
            {
                throw new ArgumentNullException(nameof(billingAccountName));
            }

            using var scope = _clientDiagnostics.CreateScope("BillingAccountCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(billingAccountName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Billing/billingAccounts
        /// ContextualPath: /
        /// OperationId: BillingAccounts_List
        /// <summary> Gets a billing account by its ID. </summary>
        /// <param name="expand"> May be used to expand the soldTo, invoice sections and billing profiles. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BillingAccount" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BillingAccount> GetAll(string expand = null, CancellationToken cancellationToken = default)
        {
            Page<BillingAccount> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BillingAccountCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _billingAccountsRestClient.List(expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new BillingAccount(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /providers/Microsoft.Billing/billingAccounts
        /// ContextualPath: /
        /// OperationId: BillingAccounts_List
        /// <summary> Gets a billing account by its ID. </summary>
        /// <param name="expand"> May be used to expand the soldTo, invoice sections and billing profiles. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BillingAccount" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BillingAccount> GetAllAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<BillingAccount>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BillingAccountCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _billingAccountsRestClient.ListAsync(expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new BillingAccount(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        IEnumerator<BillingAccount> IEnumerable<BillingAccount>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BillingAccount> IAsyncEnumerable<BillingAccount>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, BillingAccount, BillingAccountData> Construct() { }
    }
}
