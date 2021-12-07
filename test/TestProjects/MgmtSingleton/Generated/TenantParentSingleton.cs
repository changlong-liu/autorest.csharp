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
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources.Models;
using MgmtSingleton.Models;

namespace MgmtSingleton
{
    /// <summary> A Class representing a TenantParentSingleton along with the instance operations that can be performed on it. </summary>
    public partial class TenantParentSingleton : ArmResource
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly TenantParentSingletonRestOperations _tenantParentSingletonRestClient;
        private readonly TenantParentSingletonData _data;

        /// <summary> Initializes a new instance of the <see cref="TenantParentSingleton"/> class for mocking. </summary>
        protected TenantParentSingleton()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "TenantParentSingleton"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal TenantParentSingleton(ArmResource options, TenantParentSingletonData resource) : base(options, resource.Id)
        {
            HasData = true;
            _data = resource;
            Parent = options;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _tenantParentSingletonRestClient = new TenantParentSingletonRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="TenantParentSingleton"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TenantParentSingleton(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            Parent = options;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _tenantParentSingletonRestClient = new TenantParentSingletonRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="TenantParentSingleton"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TenantParentSingleton(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _tenantParentSingletonRestClient = new TenantParentSingletonRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Billing/TenantParentSingleton";

        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual TenantParentSingletonData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// <summary> Gets the parent resource of this resource. </summary>
        public ArmResource Parent { get; }

        /// RequestPath: /providers/Microsoft.Billing/TenantParentSingleton/default
        /// ContextualPath: /providers/Microsoft.Billing/TenantParentSingleton/default
        /// OperationId: TenantParentSingleton_GetDefault
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<TenantParentSingleton>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TenantParentSingleton.Get");
            scope.Start();
            try
            {
                var response = await _tenantParentSingletonRestClient.GetDefaultAsync(cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new TenantParentSingleton(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Billing/TenantParentSingleton/default
        /// ContextualPath: /providers/Microsoft.Billing/TenantParentSingleton/default
        /// OperationId: TenantParentSingleton_GetDefault
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TenantParentSingleton> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TenantParentSingleton.Get");
            scope.Start();
            try
            {
                var response = _tenantParentSingletonRestClient.GetDefault(cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantParentSingleton(this, response.Value), response.GetRawResponse());
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

        /// RequestPath: /providers/Microsoft.Billing/TenantParentSingleton/default
        /// ContextualPath: /providers/Microsoft.Billing/TenantParentSingleton/default
        /// OperationId: TenantParentSingleton_Delete
        /// <summary> Delete an TenantParentSingleton. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<TenantParentSingletonDeleteOperation> DeleteAsync(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TenantParentSingleton.Delete");
            scope.Start();
            try
            {
                var response = await _tenantParentSingletonRestClient.DeleteAsync(cancellationToken).ConfigureAwait(false);
                var operation = new TenantParentSingletonDeleteOperation(response);
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

        /// RequestPath: /providers/Microsoft.Billing/TenantParentSingleton/default
        /// ContextualPath: /providers/Microsoft.Billing/TenantParentSingleton/default
        /// OperationId: TenantParentSingleton_Delete
        /// <summary> Delete an TenantParentSingleton. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual TenantParentSingletonDeleteOperation Delete(bool waitForCompletion, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TenantParentSingleton.Delete");
            scope.Start();
            try
            {
                var response = _tenantParentSingletonRestClient.Delete(cancellationToken);
                var operation = new TenantParentSingletonDeleteOperation(response);
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

        /// RequestPath: /providers/Microsoft.Billing/TenantParentSingleton/default
        /// ContextualPath: /providers/Microsoft.Billing/TenantParentSingleton/default
        /// OperationId: TenantParentSingleton_CreateOrUpdate
        /// <param name="parameters"> The TenantParentSingleton to use. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<TenantParentSingletonCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, TenantParentSingletonData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("TenantParentSingleton.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _tenantParentSingletonRestClient.CreateOrUpdateAsync(parameters, cancellationToken).ConfigureAwait(false);
                var operation = new TenantParentSingletonCreateOrUpdateOperation(this, response);
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

        /// RequestPath: /providers/Microsoft.Billing/TenantParentSingleton/default
        /// ContextualPath: /providers/Microsoft.Billing/TenantParentSingleton/default
        /// OperationId: TenantParentSingleton_CreateOrUpdate
        /// <param name="parameters"> The TenantParentSingleton to use. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual TenantParentSingletonCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, TenantParentSingletonData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("TenantParentSingleton.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _tenantParentSingletonRestClient.CreateOrUpdate(parameters, cancellationToken);
                var operation = new TenantParentSingletonCreateOrUpdateOperation(this, response);
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

        /// RequestPath: /providers/Microsoft.Billing/TenantParentSingleton/default
        /// ContextualPath: /providers/Microsoft.Billing/TenantParentSingleton/default
        /// OperationId: TenantParentSingleton_Update
        /// <summary> Update an TenantParentSingleton. </summary>
        /// <param name="parameters"> The TenantParentSingleton to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<TenantParentSingleton>> UpdateAsync(TenantParentSingletonData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("TenantParentSingleton.Update");
            scope.Start();
            try
            {
                var response = await _tenantParentSingletonRestClient.UpdateAsync(parameters, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new TenantParentSingleton(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Billing/TenantParentSingleton/default
        /// ContextualPath: /providers/Microsoft.Billing/TenantParentSingleton/default
        /// OperationId: TenantParentSingleton_Update
        /// <summary> Update an TenantParentSingleton. </summary>
        /// <param name="parameters"> The TenantParentSingleton to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual Response<TenantParentSingleton> Update(TenantParentSingletonData parameters, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("TenantParentSingleton.Update");
            scope.Start();
            try
            {
                var response = _tenantParentSingletonRestClient.Update(parameters, cancellationToken);
                return Response.FromValue(new TenantParentSingleton(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Billing/TenantParentSingleton/default
        /// ContextualPath: /providers/Microsoft.Billing/TenantParentSingleton/default
        /// OperationId: TenantParentSingleton_PostTest
        /// <summary> The operation to do POST request. </summary>
        /// <param name="postParameter"> The Boolean to use. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<TenantParentSingletonPostTestOperation> PostTestAsync(bool waitForCompletion, bool? postParameter = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TenantParentSingleton.PostTest");
            scope.Start();
            try
            {
                var response = await _tenantParentSingletonRestClient.PostTestAsync(postParameter, cancellationToken).ConfigureAwait(false);
                var operation = new TenantParentSingletonPostTestOperation(_clientDiagnostics, Pipeline, _tenantParentSingletonRestClient.CreatePostTestRequest(postParameter).Request, response);
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

        /// RequestPath: /providers/Microsoft.Billing/TenantParentSingleton/default
        /// ContextualPath: /providers/Microsoft.Billing/TenantParentSingleton/default
        /// OperationId: TenantParentSingleton_PostTest
        /// <summary> The operation to do POST request. </summary>
        /// <param name="postParameter"> The Boolean to use. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual TenantParentSingletonPostTestOperation PostTest(bool waitForCompletion, bool? postParameter = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("TenantParentSingleton.PostTest");
            scope.Start();
            try
            {
                var response = _tenantParentSingletonRestClient.PostTest(postParameter, cancellationToken);
                var operation = new TenantParentSingletonPostTestOperation(_clientDiagnostics, Pipeline, _tenantParentSingletonRestClient.CreatePostTestRequest(postParameter).Request, response);
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
    }
}
