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
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;
using NoTypeReplacement.Models;

namespace NoTypeReplacement
{
    /// <summary> A class representing collection of NoTypeReplacementModel3 and their operations over its parent. </summary>
    public partial class NoTypeReplacementModel3Collection : ArmCollection, IEnumerable<NoTypeReplacementModel3>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly NoTypeReplacementModel3SRestOperations _noTypeReplacementModel3sRestClient;

        /// <summary> Initializes a new instance of the <see cref="NoTypeReplacementModel3Collection"/> class for mocking. </summary>
        protected NoTypeReplacementModel3Collection()
        {
        }

        /// <summary> Initializes a new instance of NoTypeReplacementModel3Collection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal NoTypeReplacementModel3Collection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _noTypeReplacementModel3sRestClient = new NoTypeReplacementModel3SRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Collection level operations.

        /// <param name="noTypeReplacementModel3SName"> The String to use. </param>
        /// <param name="parameters"> The NoTypeReplacementModel3 to use. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="noTypeReplacementModel3SName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual NoTypeReplacementModel3PutOperation CreateOrUpdate(bool waitForCompletion, string noTypeReplacementModel3SName, NoTypeReplacementModel3Data parameters, CancellationToken cancellationToken = default)
        {
            if (noTypeReplacementModel3SName == null)
            {
                throw new ArgumentNullException(nameof(noTypeReplacementModel3SName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("NoTypeReplacementModel3Collection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _noTypeReplacementModel3sRestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, noTypeReplacementModel3SName, parameters, cancellationToken);
                var operation = new NoTypeReplacementModel3PutOperation(Parent, response);
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

        /// <param name="noTypeReplacementModel3SName"> The String to use. </param>
        /// <param name="parameters"> The NoTypeReplacementModel3 to use. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="noTypeReplacementModel3SName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<NoTypeReplacementModel3PutOperation> CreateOrUpdateAsync(bool waitForCompletion, string noTypeReplacementModel3SName, NoTypeReplacementModel3Data parameters, CancellationToken cancellationToken = default)
        {
            if (noTypeReplacementModel3SName == null)
            {
                throw new ArgumentNullException(nameof(noTypeReplacementModel3SName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("NoTypeReplacementModel3Collection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _noTypeReplacementModel3sRestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, noTypeReplacementModel3SName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new NoTypeReplacementModel3PutOperation(Parent, response);
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

        /// <param name="noTypeReplacementModel3SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="noTypeReplacementModel3SName"/> is null. </exception>
        public virtual Response<NoTypeReplacementModel3> Get(string noTypeReplacementModel3SName, CancellationToken cancellationToken = default)
        {
            if (noTypeReplacementModel3SName == null)
            {
                throw new ArgumentNullException(nameof(noTypeReplacementModel3SName));
            }

            using var scope = _clientDiagnostics.CreateScope("NoTypeReplacementModel3Collection.Get");
            scope.Start();
            try
            {
                var response = _noTypeReplacementModel3sRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, noTypeReplacementModel3SName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NoTypeReplacementModel3(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="noTypeReplacementModel3SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="noTypeReplacementModel3SName"/> is null. </exception>
        public async virtual Task<Response<NoTypeReplacementModel3>> GetAsync(string noTypeReplacementModel3SName, CancellationToken cancellationToken = default)
        {
            if (noTypeReplacementModel3SName == null)
            {
                throw new ArgumentNullException(nameof(noTypeReplacementModel3SName));
            }

            using var scope = _clientDiagnostics.CreateScope("NoTypeReplacementModel3Collection.Get");
            scope.Start();
            try
            {
                var response = await _noTypeReplacementModel3sRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, noTypeReplacementModel3SName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new NoTypeReplacementModel3(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="noTypeReplacementModel3SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="noTypeReplacementModel3SName"/> is null. </exception>
        public virtual Response<NoTypeReplacementModel3> GetIfExists(string noTypeReplacementModel3SName, CancellationToken cancellationToken = default)
        {
            if (noTypeReplacementModel3SName == null)
            {
                throw new ArgumentNullException(nameof(noTypeReplacementModel3SName));
            }

            using var scope = _clientDiagnostics.CreateScope("NoTypeReplacementModel3Collection.GetIfExists");
            scope.Start();
            try
            {
                var response = _noTypeReplacementModel3sRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, noTypeReplacementModel3SName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<NoTypeReplacementModel3>(null, response.GetRawResponse())
                    : Response.FromValue(new NoTypeReplacementModel3(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="noTypeReplacementModel3SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="noTypeReplacementModel3SName"/> is null. </exception>
        public async virtual Task<Response<NoTypeReplacementModel3>> GetIfExistsAsync(string noTypeReplacementModel3SName, CancellationToken cancellationToken = default)
        {
            if (noTypeReplacementModel3SName == null)
            {
                throw new ArgumentNullException(nameof(noTypeReplacementModel3SName));
            }

            using var scope = _clientDiagnostics.CreateScope("NoTypeReplacementModel3Collection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _noTypeReplacementModel3sRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, noTypeReplacementModel3SName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<NoTypeReplacementModel3>(null, response.GetRawResponse())
                    : Response.FromValue(new NoTypeReplacementModel3(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="noTypeReplacementModel3SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="noTypeReplacementModel3SName"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string noTypeReplacementModel3SName, CancellationToken cancellationToken = default)
        {
            if (noTypeReplacementModel3SName == null)
            {
                throw new ArgumentNullException(nameof(noTypeReplacementModel3SName));
            }

            using var scope = _clientDiagnostics.CreateScope("NoTypeReplacementModel3Collection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(noTypeReplacementModel3SName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="noTypeReplacementModel3SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="noTypeReplacementModel3SName"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string noTypeReplacementModel3SName, CancellationToken cancellationToken = default)
        {
            if (noTypeReplacementModel3SName == null)
            {
                throw new ArgumentNullException(nameof(noTypeReplacementModel3SName));
            }

            using var scope = _clientDiagnostics.CreateScope("NoTypeReplacementModel3Collection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(noTypeReplacementModel3SName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IReadOnlyList<NoTypeReplacementModel3>> GetAll(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NoTypeReplacementModel3Collection.GetAll");
            scope.Start();
            try
            {
                var response = _noTypeReplacementModel3sRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken);
                return Response.FromValue(response.Value.Value.Select(value => new NoTypeReplacementModel3(Parent, value)).ToArray() as IReadOnlyList<NoTypeReplacementModel3>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<IReadOnlyList<NoTypeReplacementModel3>>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NoTypeReplacementModel3Collection.GetAll");
            scope.Start();
            try
            {
                var response = await _noTypeReplacementModel3sRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value.Value.Select(value => new NoTypeReplacementModel3(Parent, value)).ToArray() as IReadOnlyList<NoTypeReplacementModel3>, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="NoTypeReplacementModel3" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NoTypeReplacementModel3Collection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(NoTypeReplacementModel3.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="NoTypeReplacementModel3" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NoTypeReplacementModel3Collection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(NoTypeReplacementModel3.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NoTypeReplacementModel3> IEnumerable<NoTypeReplacementModel3>.GetEnumerator()
        {
            return GetAll().Value.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().Value.GetEnumerator();
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, NoTypeReplacementModel3, NoTypeReplacementModel3Data> Construct() { }
    }
}
