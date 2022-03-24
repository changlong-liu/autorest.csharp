// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.TestFramework;
using MgmtKeyvault.Models;

namespace MgmtKeyvault.Tests.Mock
{
    /// <summary> Test for Vault. </summary>
    public partial class VaultCollectionMockTests : MockTestBase
    {
        public VaultCollectionMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            // Example: Create a new vault or update an existing vault
            string vaultName = "sample-vault";
            MgmtKeyvault.Models.VaultCreateOrUpdateContent content = new MgmtKeyvault.Models.VaultCreateOrUpdateContent(location: "westus", properties: new MgmtKeyvault.Models.VaultProperties(tenantId: Guid.Parse("00000000-0000-0000-0000-000000000000"), sku: new MgmtKeyvault.Models.MgmtKeyvaultSku(family: new MgmtKeyvault.Models.MgmtKeyvaultSkuFamily("A"), name: MgmtKeyvault.Models.MgmtKeyvaultSkuName.Standard))
            {
                EnabledForDeployment = true,
                EnabledForDiskEncryption = true,
                EnabledForTemplateDeployment = true,
            });
            parameters.Properties.AccessPolicies.Add(new MgmtKeyvault.Models.AccessPolicyEntry(tenantId: Guid.Parse("00000000-0000-0000-0000-000000000000"), objectId: "00000000-0000-0000-0000-000000000000", permissions: new MgmtKeyvault.Models.Permissions()));
            parameters.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("encrypt"));
            parameters.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("decrypt"));
            parameters.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("wrapKey"));
            parameters.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("unwrapKey"));
            parameters.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("sign"));
            parameters.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("verify"));
            parameters.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("get"));
            parameters.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("list"));
            parameters.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("create"));
            parameters.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("update"));
            parameters.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("import"));
            parameters.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("delete"));
            parameters.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("backup"));
            parameters.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("restore"));
            parameters.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("recover"));
            parameters.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("purge"));
            parameters.Properties.AccessPolicies[0].Permissions.Secrets.Add(new MgmtKeyvault.Models.SecretPermissions("get"));
            parameters.Properties.AccessPolicies[0].Permissions.Secrets.Add(new MgmtKeyvault.Models.SecretPermissions("list"));
            parameters.Properties.AccessPolicies[0].Permissions.Secrets.Add(new MgmtKeyvault.Models.SecretPermissions("set"));
            parameters.Properties.AccessPolicies[0].Permissions.Secrets.Add(new MgmtKeyvault.Models.SecretPermissions("delete"));
            parameters.Properties.AccessPolicies[0].Permissions.Secrets.Add(new MgmtKeyvault.Models.SecretPermissions("backup"));
            parameters.Properties.AccessPolicies[0].Permissions.Secrets.Add(new MgmtKeyvault.Models.SecretPermissions("restore"));
            parameters.Properties.AccessPolicies[0].Permissions.Secrets.Add(new MgmtKeyvault.Models.SecretPermissions("recover"));
            parameters.Properties.AccessPolicies[0].Permissions.Secrets.Add(new MgmtKeyvault.Models.SecretPermissions("purge"));
            parameters.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("get"));
            parameters.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("list"));
            parameters.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("delete"));
            parameters.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("create"));
            parameters.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("import"));
            parameters.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("update"));
            parameters.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("managecontacts"));
            parameters.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("getissuers"));
            parameters.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("listissuers"));
            parameters.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("setissuers"));
            parameters.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("deleteissuers"));
            parameters.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("manageissuers"));
            parameters.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("recover"));
            parameters.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("purge"));

            var collection = GetArmClient().GetResourceGroupResource(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/sample-resource-group")).GetVaults();
            await collection.CreateOrUpdateAsync(WaitUntil.Completed, vaultName, content);
        }

        [RecordedTest]
        public async Task CreateOrUpdate2()
        {
            // Example: Create or update a vault with network acls
            string vaultName = "sample-vault";
            MgmtKeyvault.Models.VaultCreateOrUpdateContent content = new MgmtKeyvault.Models.VaultCreateOrUpdateContent(location: "westus", properties: new MgmtKeyvault.Models.VaultProperties(tenantId: Guid.Parse("00000000-0000-0000-0000-000000000000"), sku: new MgmtKeyvault.Models.MgmtKeyvaultSku(family: new MgmtKeyvault.Models.MgmtKeyvaultSkuFamily("A"), name: MgmtKeyvault.Models.MgmtKeyvaultSkuName.Standard))
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
            parameters.Properties.NetworkAcls.IpRules.Add(new MgmtKeyvault.Models.IPRule(value: "124.56.78.91"));
            parameters.Properties.NetworkAcls.IpRules.Add(new MgmtKeyvault.Models.IPRule(value: "'10.91.4.0/24'"));
            parameters.Properties.NetworkAcls.VirtualNetworkRules.Add(new MgmtKeyvault.Models.VirtualNetworkRule(id: "/subscriptions/subid/resourceGroups/rg1/providers/Microsoft.Network/virtualNetworks/test-vnet/subnets/subnet1"));

            var collection = GetArmClient().GetResourceGroupResource(new ResourceIdentifier("/subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/sample-resource-group")).GetVaults();
            await collection.CreateOrUpdateAsync(WaitUntil.Completed, vaultName, content);
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Retrieve a vault
            string vaultName = "sample-vault";

            var collection = GetArmClient().GetResourceGroupResource(ResourceGroupResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sample-resource-group")).GetVaults();
            await collection.GetAsync(vaultName);
        }

        [RecordedTest]
        public async Task GetAll()
        {
            // Example: List vaults in the specified resource group
            int? top = 1;

            var collection = GetArmClient().GetResourceGroupResource(ResourceGroupResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sample-group")).GetVaults();
            await foreach (var _ in collection.GetAllAsync(top))
            {
            }
        }
    }
}
