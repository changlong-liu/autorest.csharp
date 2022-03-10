// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.TestFramework;
using MgmtSignalR;
using MgmtSignalR.Models;

namespace MgmtSignalR.Tests.Mock
{
    /// <summary> Test for SignalRResource. </summary>
    public partial class SignalRResourceMockTests : MockTestBase
    {
        public SignalRResourceMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            Environment.SetEnvironmentVariable("RESOURCE_MANAGER_URL", $"https://localhost:8443");
        }

        [RecordedTest]
        public async Task Get()
        {
            // Example: SignalR_Get
            var signalRResourceId = MgmtSignalR.SignalRResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "mySignalRService");
            var signalRResource = GetArmClient().GetSignalRResource(signalRResourceId);

            await signalRResource.GetAsync();
        }

        [RecordedTest]
        public async Task Delete()
        {
            // Example: SignalR_Delete
            var signalRResourceId = MgmtSignalR.SignalRResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "mySignalRService");
            var signalRResource = GetArmClient().GetSignalRResource(signalRResourceId);

            await signalRResource.DeleteAsync(WaitUntil.Completed);
        }

        [RecordedTest]
        public async Task Update()
        {
            // Example: SignalR_Update
            var signalRResourceId = MgmtSignalR.SignalRResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "mySignalRService");
            var signalRResource = GetArmClient().GetSignalRResource(signalRResourceId);
            MgmtSignalR.SignalRResourceData data = new MgmtSignalR.SignalRResourceData(location: new AzureLocation("eastus"))
            {
                Sku = new MgmtSignalR.Models.ResourceSku(name: "Standard_S1")
                {
                    Tier = new MgmtSignalR.Models.SignalRSkuTier("Standard"),
                    Capacity = 1,
                },
                Kind = new MgmtSignalR.Models.ServiceKind("SignalR"),
                Identity = new MgmtSignalR.Models.ManagedIdentity()
                {
                    ManagedIdentityType = new MgmtSignalR.Models.ManagedIdentityType("SystemAssigned"),
                },
                NetworkACLs = new MgmtSignalR.Models.SignalRNetworkACLs()
                {
                    DefaultAction = new MgmtSignalR.Models.ACLAction("Deny"),
                    PublicNetwork = new MgmtSignalR.Models.NetworkACL(),
                },
            };
            data.NetworkACLs.PublicNetwork.Allow.Add(new MgmtSignalR.Models.SignalRRequestType("ClientConnection"));
            data.NetworkACLs.PrivateEndpoints.Add(new MgmtSignalR.Models.PrivateEndpointACL(name: "mySignalRService.1fa229cd-bf3f-47f0-8c49-afb36723997e"));
            data.Tags.ReplaceWith(new Dictionary<string, string>()
            {
                ["key1"] = "value1",
            });
            data.Features.Add(new MgmtSignalR.Models.SignalRFeature(flag: new MgmtSignalR.Models.FeatureFlags("ServiceMode"), value: "Serverless"));
            data.Features.Add(new MgmtSignalR.Models.SignalRFeature(flag: new MgmtSignalR.Models.FeatureFlags("EnableConnectivityLogs"), value: "True"));
            data.Features.Add(new MgmtSignalR.Models.SignalRFeature(flag: new MgmtSignalR.Models.FeatureFlags("EnableMessagingLogs"), value: "False"));
            data.NetworkACLs.PrivateEndpoints[0].Allow.Add(new MgmtSignalR.Models.SignalRRequestType("ServerConnection"));

            await signalRResource.UpdateAsync(WaitUntil.Completed, data);
        }

        [RecordedTest]
        public async Task GetKeys()
        {
            // Example: SignalR_ListKeys
            var signalRResourceId = MgmtSignalR.SignalRResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "mySignalRService");
            var signalRResource = GetArmClient().GetSignalRResource(signalRResourceId);

            await signalRResource.GetKeysAsync();
        }

        [RecordedTest]
        public async Task RegenerateKey()
        {
            // Example: SignalR_RegenerateKey
            var signalRResourceId = MgmtSignalR.SignalRResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "mySignalRService");
            var signalRResource = GetArmClient().GetSignalRResource(signalRResourceId);
            MgmtSignalR.Models.RegenerateKeyParameters regenerateKeyParameters = new MgmtSignalR.Models.RegenerateKeyParameters()
            {
                KeyType = new MgmtSignalR.Models.KeyType("Primary"),
            };

            await signalRResource.RegenerateKeyAsync(WaitUntil.Completed, regenerateKeyParameters);
        }

        [RecordedTest]
        public async Task Restart()
        {
            // Example: SignalR_Restart
            var signalRResourceId = MgmtSignalR.SignalRResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "mySignalRService");
            var signalRResource = GetArmClient().GetSignalRResource(signalRResourceId);

            await signalRResource.RestartAsync(WaitUntil.Completed);
        }

        [RecordedTest]
        public async Task GetSignalRPrivateLinkResources()
        {
            // Example: SignalRPrivateLinkResources_List
            var signalRResourceId = MgmtSignalR.SignalRResource.CreateResourceIdentifier("00000000-0000-0000-0000-000000000000", "myResourceGroup", "mySignalRService");
            var signalRResource = GetArmClient().GetSignalRResource(signalRResourceId);

            await foreach (var _ in signalRResource.GetSignalRPrivateLinkResourcesAsync())
            {
            }
        }
    }
}
