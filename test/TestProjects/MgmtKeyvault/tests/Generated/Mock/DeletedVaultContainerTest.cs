// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.TestFramework;
using MgmtKeyvault;
using NUnit.Framework;

namespace MgmtKeyvault.Tests.Mock
{
    /// <summary> Test for DeletedVault. </summary>
    public partial class DeletedVaultContainerMockTests : MockTestBase
    {
        public DeletedVaultContainerMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
        }

        private async Task<MgmtKeyvault.DeletedVaultContainer> GetDeletedVaultContainerAsync()
        {
            DeletedVaultContainer deletedVaultContainer = GetArmClient().DefaultSubscription.GetDeletedVaults();
            return await Task.FromResult(deletedVaultContainer);
        }

        private MgmtKeyvault.DeletedVaultContainer GetDeletedVaultContainer()
        {
            DeletedVaultContainer deletedVaultContainer = GetArmClient().DefaultSubscription.GetDeletedVaults();
            return deletedVaultContainer;
        }

        [TestCase]
        [RecordedTest]
        public async Task GetAsync()
        {
            // Example: Retrieve a deleted vault
            var container = await GetDeletedVaultContainerAsync();
            await TestHelper.GetExampleInstanceAsync(container, "sample-vault");
        }

        [TestCase]
        [RecordedTest]
        public void Get()
        {
            // Example: Retrieve a deleted vault
            var container = GetDeletedVaultContainer();
            TestHelper.GetExampleInstance(container, "sample-vault");
        }
    }
}
