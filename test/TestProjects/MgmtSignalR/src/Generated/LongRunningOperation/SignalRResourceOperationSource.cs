// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace MgmtSignalR
{
    internal class SignalRResourceOperationSource : IOperationSource<SignalRResource>
    {
        private readonly ArmClient _client;

        internal SignalRResourceOperationSource(ArmClient client)
        {
            _client = client;
        }

        SignalRResource IOperationSource<SignalRResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SignalRResourceData.DeserializeSignalRResourceData(document.RootElement);
            return new SignalRResource(_client, data);
        }

        async ValueTask<SignalRResource> IOperationSource<SignalRResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SignalRResourceData.DeserializeSignalRResourceData(document.RootElement);
            return new SignalRResource(_client, data);
        }
    }
}
