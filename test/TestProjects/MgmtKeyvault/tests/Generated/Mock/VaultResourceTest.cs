// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;
using System.Threading.Tasks;
using Azure;
using Azure.Core.TestFramework;
using Azure.ResourceManager.TestFramework;
using MgmtKeyvault;
using MgmtKeyvault.Models;

namespace MgmtKeyvault.Tests.Mock
{
    /// <summary> Test for Vault. </summary>
    public partial class VaultResourceMockTests : MockTestBase
    {
        public VaultResourceMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: Retrieve a vault
            var vaultResourceId = MgmtKeyvault.VaultResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sample-resource-group", "sample-vault");
            var vaultResource = GetArmClient().GetVaultResource(vaultResourceId);

            await vaultResource.GetAsync();
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: Delete a vault
            var vaultResourceId = MgmtKeyvault.VaultResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sample-resource-group", "sample-vault");
            var vaultResource = GetArmClient().GetVaultResource(vaultResourceId);

            await vaultResource.DeleteAsync(WaitUntil.Completed);
        }

        [RecordedTest]
        public async Task Update()
        {
            // Example: Update an existing vault
            var vaultResourceId = MgmtKeyvault.VaultResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sample-resource-group", "sample-vault");
            var vaultResource = GetArmClient().GetVaultResource(vaultResourceId);
            MgmtKeyvault.Models.PatchableVaultData data = new MgmtKeyvault.Models.PatchableVaultData()
            {
                Properties = new MgmtKeyvault.Models.VaultPatchProperties()
                {
                    TenantId = Guid.Parse("00000000-0000-0000-0000-000000000000"),
                    Sku = new MgmtKeyvault.Models.MgmtKeyvaultSku(family: new MgmtKeyvault.Models.MgmtKeyvaultSkuFamily("A"), name: MgmtKeyvault.Models.MgmtKeyvaultSkuName.Standard),
                    EnabledForDeployment = true,
                    EnabledForDiskEncryption = true,
                    EnabledForTemplateDeployment = true,
                },
            };
            data.Properties.AccessPolicies.Add(new MgmtKeyvault.Models.AccessPolicyEntry(tenantId: Guid.Parse("00000000-0000-0000-0000-000000000000"), objectId: "00000000-0000-0000-0000-000000000000", permissions: new MgmtKeyvault.Models.Permissions()));
            data.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("encrypt"));
            data.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("decrypt"));
            data.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("wrapKey"));
            data.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("unwrapKey"));
            data.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("sign"));
            data.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("verify"));
            data.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("get"));
            data.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("list"));
            data.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("create"));
            data.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("update"));
            data.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("import"));
            data.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("delete"));
            data.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("backup"));
            data.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("restore"));
            data.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("recover"));
            data.Properties.AccessPolicies[0].Permissions.Keys.Add(new MgmtKeyvault.Models.KeyPermissions("purge"));
            data.Properties.AccessPolicies[0].Permissions.Secrets.Add(new MgmtKeyvault.Models.SecretPermissions("get"));
            data.Properties.AccessPolicies[0].Permissions.Secrets.Add(new MgmtKeyvault.Models.SecretPermissions("list"));
            data.Properties.AccessPolicies[0].Permissions.Secrets.Add(new MgmtKeyvault.Models.SecretPermissions("set"));
            data.Properties.AccessPolicies[0].Permissions.Secrets.Add(new MgmtKeyvault.Models.SecretPermissions("delete"));
            data.Properties.AccessPolicies[0].Permissions.Secrets.Add(new MgmtKeyvault.Models.SecretPermissions("backup"));
            data.Properties.AccessPolicies[0].Permissions.Secrets.Add(new MgmtKeyvault.Models.SecretPermissions("restore"));
            data.Properties.AccessPolicies[0].Permissions.Secrets.Add(new MgmtKeyvault.Models.SecretPermissions("recover"));
            data.Properties.AccessPolicies[0].Permissions.Secrets.Add(new MgmtKeyvault.Models.SecretPermissions("purge"));
            data.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("get"));
            data.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("list"));
            data.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("delete"));
            data.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("create"));
            data.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("import"));
            data.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("update"));
            data.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("managecontacts"));
            data.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("getissuers"));
            data.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("listissuers"));
            data.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("setissuers"));
            data.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("deleteissuers"));
            data.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("manageissuers"));
            data.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("recover"));
            data.Properties.AccessPolicies[0].Permissions.Certificates.Add(new MgmtKeyvault.Models.CertificatePermissions("purge"));

            await vaultResource.UpdateAsync(data);
        }

        [RecordedTest]
        public async Task UpdateAccessPolicy()
        {
            // Example: Add an access policy, or update an access policy with new permissions
            var vaultResourceId = MgmtKeyvault.VaultResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sample-group", "sample-vault");
            var vaultResource = GetArmClient().GetVaultResource(vaultResourceId);
            MgmtKeyvault.Models.AccessPolicyUpdateKind operationKind = MgmtKeyvault.Models.AccessPolicyUpdateKind.Add;
            MgmtKeyvault.Models.VaultAccessPolicyParameters parameters = new MgmtKeyvault.Models.VaultAccessPolicyParameters(properties: new MgmtKeyvault.Models.VaultAccessPolicyProperties(accessPolicies: null));

            await vaultResource.UpdateAccessPolicyAsync(operationKind, vaultAccessPolicyParameters);
        }

        [RecordedTest]
        public async Task GetPrivateLinkResources()
        {
            // Example: KeyVaultListPrivateLinkResources
            var vaultResourceId = MgmtKeyvault.VaultResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "sample-group", "sample-vault");
            var vaultResource = GetArmClient().GetVaultResource(vaultResourceId);

            await foreach (var _ in vaultResource.GetPrivateLinkResourcesAsync())
            {
            }
        }
    }
}
