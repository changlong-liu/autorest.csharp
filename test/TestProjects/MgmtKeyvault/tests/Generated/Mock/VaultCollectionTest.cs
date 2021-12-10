// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.TestFramework;
using MgmtKeyvault;
using MgmtKeyvault.Models;
using NUnit.Framework;

namespace MgmtKeyvault.Tests.Mock
{
    /// <summary> Test for Vault. </summary>
    public partial class VaultCollectionMockTests : MockTestBase
    {
        public VaultCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            System.Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        private async Task<MgmtKeyvault.VaultCollection> GetVaultCollectionAsync(string resourceGroupName)
        {
            ResourceGroup resourceGroup = await TestHelper.CreateResourceGroupAsync(resourceGroupName, GetArmClient());
            VaultCollection vaultCollection = resourceGroup.GetVaults();
            return vaultCollection;
        }

        [RecordedTest]
        [Ignore("Generated TestCase")]
        public async Task CreateOrUpdateAsync()
        {
            // Example: Create a new vault or update an existing vault
            var collection = await GetVaultCollectionAsync("sample-resource-group");
            await TestHelper.CreateOrUpdateExampleInstanceAsync(collection, "sample-vault");
        }

        [RecordedTest]
        [Ignore("Generated TestCase")]
        public async Task CreateOrUpdateAsync2()
        {
            // Example: Create or update a vault with network acls
            var collection = await GetVaultCollectionAsync("sample-resource-group");
            string vaultName = "sample-vault";
            MgmtKeyvault.Models.VaultCreateOrUpdateParameters parameters = new MgmtKeyvault.Models.VaultCreateOrUpdateParameters("westus", new MgmtKeyvault.Models.VaultProperties(System.Guid.Parse("00000000-0000-0000-0000-000000000000"), new MgmtKeyvault.Models.Sku(new MgmtKeyvault.Models.SkuFamily("A"), MgmtKeyvault.Models.SkuName.Standard))
            {
                EnabledForDeployment = true,
                EnabledForDiskEncryption = true,
                EnabledForTemplateDeployment = true,
                NetworkAcls = new MgmtKeyvault.Models.NetworkRuleSet()
                {
                    Bypass = new MgmtKeyvault.Models.NetworkRuleBypassOptions("AzureServices"),
                    DefaultAction = new MgmtKeyvault.Models.NetworkRuleAction("Deny"),
                },
            });

            await collection.CreateOrUpdateAsync(vaultName, parameters);
        }

        [RecordedTest]
        [Ignore("Generated TestCase")]
        public async Task GetAsync()
        {
            // Example: Retrieve a vault
            var collection = await GetVaultCollectionAsync("sample-resource-group");
            await TestHelper.GetExampleInstanceAsync(collection, "sample-vault");
        }

        [RecordedTest]
        [Ignore("Generated TestCase")]
        public async Task GetAllAsync()
        {
            // Example: List vaults in the specified resource group
            var collection = await GetVaultCollectionAsync("sample-group");
            TestHelper.GetAllExampleInstanceAsync(collection).AsPages();
        }
    }
}
