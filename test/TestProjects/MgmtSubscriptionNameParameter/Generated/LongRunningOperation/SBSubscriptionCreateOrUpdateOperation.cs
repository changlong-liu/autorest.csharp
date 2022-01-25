// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using MgmtSubscriptionNameParameter;

namespace MgmtSubscriptionNameParameter.Models
{
    /// <summary> Creates a topic subscription. </summary>
    public partial class SBSubscriptionCreateOrUpdateOperation : Operation<SBSubscription>
    {
        private readonly OperationOrResponseInternals<SBSubscription> _operation;

        /// <summary> Initializes a new instance of SBSubscriptionCreateOrUpdateOperation for mocking. </summary>
        protected SBSubscriptionCreateOrUpdateOperation()
        {
        }

        internal SBSubscriptionCreateOrUpdateOperation(ArmClient armClient, Response<SBSubscriptionData> response)
        {
            _operation = new OperationOrResponseInternals<SBSubscription>(Response.FromValue(new SBSubscription(armClient, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override SBSubscription Value => _operation.Value;

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
        public override ValueTask<Response<SBSubscription>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<SBSubscription>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}