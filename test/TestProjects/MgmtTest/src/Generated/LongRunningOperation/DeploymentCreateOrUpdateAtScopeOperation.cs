// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using MgmtTest;

namespace MgmtTest.Models
{
    /// <summary> You can provide the template and parameters directly in the request or link to JSON files. </summary>
    public partial class DeploymentCreateOrUpdateAtScopeOperation : Operation<DeploymentExtended>, IOperationSource<DeploymentExtended>
    {
        private readonly OperationInternals<DeploymentExtended> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of DeploymentCreateOrUpdateAtScopeOperation for mocking. </summary>
        protected DeploymentCreateOrUpdateAtScopeOperation()
        {
        }

        internal DeploymentCreateOrUpdateAtScopeOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<DeploymentExtended>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "DeploymentCreateOrUpdateAtScopeOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override DeploymentExtended Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<DeploymentExtended>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<DeploymentExtended>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        DeploymentExtended IOperationSource<DeploymentExtended>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new DeploymentExtended(_operationBase, DeploymentExtendedData.DeserializeDeploymentExtendedData(document.RootElement));
        }

        async ValueTask<DeploymentExtended> IOperationSource<DeploymentExtended>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new DeploymentExtended(_operationBase, DeploymentExtendedData.DeserializeDeploymentExtendedData(document.RootElement));
        }
    }
}
