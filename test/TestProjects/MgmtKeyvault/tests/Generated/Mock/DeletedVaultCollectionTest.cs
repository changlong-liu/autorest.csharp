// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.TestFramework;
using MgmtKeyvault.Models;

namespace MgmtKeyvault.Tests.Mock
{
    /// <summary> Test for DeletedVault. </summary>
    public partial class DeletedVaultCollectionMockTests : MockTestBase
    {
        public DeletedVaultCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Retrieve a deleted vault
            string location = "westus";
            string vaultName = "sample-vault";

            var collection = GetArmClient().GetSubscription(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000")).GetDeletedVaults();
            await collection.GetAsync(location, vaultName);
        }
    }
}
