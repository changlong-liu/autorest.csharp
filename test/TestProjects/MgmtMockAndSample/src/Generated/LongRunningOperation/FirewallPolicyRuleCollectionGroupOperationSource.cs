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

namespace MgmtMockAndSample
{
    internal class FirewallPolicyRuleCollectionGroupOperationSource : IOperationSource<FirewallPolicyRuleCollectionGroupResource>
    {
        private readonly ArmClient _client;

        internal FirewallPolicyRuleCollectionGroupOperationSource(ArmClient client)
        {
            _client = client;
        }

        FirewallPolicyRuleCollectionGroupResource IOperationSource<FirewallPolicyRuleCollectionGroupResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = FirewallPolicyRuleCollectionGroupData.DeserializeFirewallPolicyRuleCollectionGroupData(document.RootElement);
            return new FirewallPolicyRuleCollectionGroupResource(_client, data);
        }

        async ValueTask<FirewallPolicyRuleCollectionGroupResource> IOperationSource<FirewallPolicyRuleCollectionGroupResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = FirewallPolicyRuleCollectionGroupData.DeserializeFirewallPolicyRuleCollectionGroupData(document.RootElement);
            return new FirewallPolicyRuleCollectionGroupResource(_client, data);
        }
    }
}