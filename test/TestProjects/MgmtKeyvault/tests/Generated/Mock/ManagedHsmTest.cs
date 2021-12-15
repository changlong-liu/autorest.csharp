// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.TestFramework;
using MgmtKeyvault;
using MgmtKeyvault.Models;
using NUnit.Framework;

namespace MgmtKeyvault.Tests.Mock
{
    /// <summary> Test for ManagedHsm. </summary>
    public partial class ManagedHsmMockTests : MockTestBase
    {
        public ManagedHsmMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        [Ignore("Generated TestCase")]
        public async Task GetAsync()
        {
            // Example: Retrieve a managed HSM Pool
            var managedHsm = GetArmClient().GetManagedHsm(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/hsm-group/providers/Microsoft.KeyVault/managedHSMs/hsm1"));

            await managedHsm.GetAsync();
        }

        [RecordedTest]
        [Ignore("Generated TestCase")]
        public async Task DeleteAsync()
        {
            // Example: Delete a managed HSM Pool
            var managedHsm = GetArmClient().GetManagedHsm(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/hsm-group/providers/Microsoft.KeyVault/managedHSMs/hsm1"));

            await managedHsm.DeleteAsync();
        }

        [RecordedTest]
        [Ignore("Generated TestCase")]
        public async Task UpdateAsync()
        {
            // Example: Update an existing managed HSM Pool
            var managedHsm = GetArmClient().GetManagedHsm(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/hsm-group/providers/Microsoft.KeyVault/managedHSMs/hsm1"));
            MgmtKeyvault.ManagedHsmData parameters = new MgmtKeyvault.ManagedHsmData("westus")
            {
            };
            parameters.Tags.ReplaceWith(new Dictionary<string, string>() { ["Dept"] = "hsm", ["Environment"] = "dogfood", ["Slice"] = "A", });
            await managedHsm.UpdateAsync(parameters);
        }

        [RecordedTest]
        [Ignore("Generated TestCase")]
        public async Task GetMHSMPrivateLinkResourcesByMhsmResourceAsync()
        {
            // Example: KeyVaultListPrivateLinkResources
            var managedHsm = GetArmClient().GetManagedHsm(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/sample-group/providers/Microsoft.KeyVault/managedHSMs/sample-mhsm"));

            await managedHsm.GetMHSMPrivateLinkResourcesByMhsmResourceAsync();
        }
    }
}
