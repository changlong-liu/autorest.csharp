// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using MgmtKeyvault;
using MgmtKeyvault.Models;

namespace MgmtKeyvault.Tests
{
    /// <summary> Test Extension for MgmtKeyvault. </summary>
    public static partial class TestHelper
    {
        public static async Task<MgmtKeyvault.Models.VaultCreateOrUpdateOperation> CreateOrUpdateExampleInstanceAsync(VaultCollection collection, string vaultName)
        {
            // Example: Create a new vault or update an existing vault
            var parameters = new MgmtKeyvault.Models.VaultCreateOrUpdateParameters("westus", new MgmtKeyvault.Models.VaultProperties(Guid.Parse("00000000-0000-0000-0000-000000000000"), new MgmtKeyvault.Models.Sku(new MgmtKeyvault.Models.SkuFamily("A"), SkuName.Standard))
            {
                EnabledForDeployment = true,
                EnabledForDiskEncryption = true,
                EnabledForTemplateDeployment = true,
            });

            return await collection.CreateOrUpdateAsync(vaultName, parameters);
        }

        public static AsyncPageable<MgmtKeyvault.Vault> GetAllExampleInstanceAsync(VaultCollection collection)
        {
            // Example: List vaults in the specified resource group
            var top = 1;

            return collection.GetAllAsync(top);
        }

        public static async Task<MgmtKeyvault.Models.PrivateEndpointConnectionPutOperation> CreateOrUpdateExampleInstanceAsync(PrivateEndpointConnectionCollection collection, string privateEndpointConnectionName)
        {
            // Example: KeyVaultPutPrivateEndpointConnection
            var properties = new MgmtKeyvault.PrivateEndpointConnectionData()
            {
                Etag = "",
                PrivateLinkServiceConnectionState = new MgmtKeyvault.Models.PrivateLinkServiceConnectionState()
                {
                    Status = new MgmtKeyvault.Models.PrivateEndpointServiceConnectionStatus("Approved"),
                    Description = "My name is Joe and I'm approving this.",
                },
            };

            return await collection.CreateOrUpdateAsync(privateEndpointConnectionName, properties);
        }

        public static AsyncPageable<MgmtKeyvault.PrivateEndpointConnection> GetAllExampleInstanceAsync(PrivateEndpointConnectionCollection collection)
        {
            // Example: KeyVaultListPrivateEndpointConnection

            return collection.GetAllAsync();
        }

        public static async Task<MgmtKeyvault.Models.ManagedHsmCreateOrUpdateOperation> CreateOrUpdateExampleInstanceAsync(ManagedHsmCollection collection, string name)
        {
            // Example: Create a new managed HSM Pool or update an existing managed HSM Pool
            var parameters = new MgmtKeyvault.ManagedHsmData("westus")
            {
                Properties = new MgmtKeyvault.Models.ManagedHsmProperties()
                {
                    TenantId = Guid.Parse("00000000-0000-0000-0000-000000000000"),
                    EnableSoftDelete = true,
                    SoftDeleteRetentionInDays = 90,
                    EnablePurgeProtection = true,
                },
                Sku = new MgmtKeyvault.Models.ManagedHsmSku(new MgmtKeyvault.Models.ManagedHsmSkuFamily("B"), ManagedHsmSkuName.StandardB1),
            };
            parameters.Tags.ReplaceWith(new Dictionary<string, string>() { { "Dept", "hsm" }, { "Environment", "dogfood" }, });
            return await collection.CreateOrUpdateAsync(name, parameters);
        }

        public static AsyncPageable<MgmtKeyvault.ManagedHsm> GetAllExampleInstanceAsync(ManagedHsmCollection collection)
        {
            // Example: List managed HSM Pools in a resource group
            int? top = null;

            return collection.GetAllAsync(top);
        }

        public static async Task<MgmtKeyvault.Models.MhsmPrivateEndpointConnectionPutOperation> CreateOrUpdateExampleInstanceAsync(MhsmPrivateEndpointConnectionCollection collection, string privateEndpointConnectionName)
        {
            // Example: ManagedHsmPutPrivateEndpointConnection
            var properties = new MgmtKeyvault.MhsmPrivateEndpointConnectionData("westus")
            {
                PrivateLinkServiceConnectionState = new MgmtKeyvault.Models.MhsmPrivateLinkServiceConnectionState()
                {
                    Status = new MgmtKeyvault.Models.PrivateEndpointServiceConnectionStatus("Approved"),
                    Description = "My name is Joe and I'm approving this.",
                },
            };

            return await collection.CreateOrUpdateAsync(privateEndpointConnectionName, properties);
        }

        public static AsyncPageable<MgmtKeyvault.MhsmPrivateEndpointConnection> GetAllExampleInstanceAsync(MhsmPrivateEndpointConnectionCollection collection)
        {
            // Example: List managed HSM Pools in a subscription

            return collection.GetAllAsync();
        }

        public static async Task<ResourceGroup> CreateResourceGroupAsync(string resourceGroupName, ArmClient client)
        {
            var defaultSubscription = await client.GetDefaultSubscriptionAsync();
            var rgop = await defaultSubscription.GetResourceGroups().CreateOrUpdateAsync
            (
            resourceGroupName,
            new ResourceGroupData(defaultSubscription.ToString()) { Tags = { { "test", "env" } } }
            );
            return rgop.Value;
        }

        public static IDictionary<string, string> ReplaceWith(this IDictionary<string, string> dest, IDictionary<string, string> src)
        {
            dest.Clear();
            foreach (var kv in src)
            {
                dest.Add(kv);
            }
            return dest;
        }
    }
}