// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Net;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Compute.Tests.Helpers;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.TestFramework;
using MgmtTest;
using MgmtTest.Models;
using MgmtTest.Tests;
using NUnit.Framework;

namespace MgmtTest.Tests.Mock
{
    /// <summary> Test for PolicyAssignment. </summary>
    public partial class PolicyAssignmentContainerMockTests : MockTestBase
    {
        public PolicyAssignmentContainerMockTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
        }

        private async Task<MgmtTest.PolicyAssignmentContainer> GetPolicyAssignmentContainerAsync()
        {
            PolicyAssignmentContainer policyAssignmentContainer = GetArmClient().GetTenants().GetAll().GetEnumerator().Current.GetPolicyAssignments();
            return await Task.FromResult(policyAssignmentContainer);
        }

        private MgmtTest.PolicyAssignmentContainer GetPolicyAssignmentContainer()
        {
            PolicyAssignmentContainer policyAssignmentContainer = GetArmClient().GetTenants().GetAll().GetEnumerator().Current.GetPolicyAssignments();
            return policyAssignmentContainer;
        }
    }
}
