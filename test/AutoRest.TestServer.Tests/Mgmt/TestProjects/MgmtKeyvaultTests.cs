using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Linq;
using NUnit.Framework;

namespace AutoRest.TestServer.Tests.Mgmt.TestProjects
{
    public class MgmtKeyvaultTestsTests : TestProjectTests
    {
        public MgmtKeyvaultTestsTests() : base("MgmtKeyvault", "tests") { }

        [TestCase("CreateOrUpdateExampleInstance", "VaultContainer", "String")]
        [TestCase("CreateOrUpdateExampleInstanceAsync", "VaultContainer", "String")]
        [TestCase("GetExampleInstance", "VaultContainer", "String")]
        [TestCase("GetExampleInstanceAsync", "VaultContainer", "String")]
        [TestCase("GetExampleInstance", "DeletedVaultContainer", "String")]
        [TestCase("GetExampleInstanceAsync", "DeletedVaultContainer", "String")]
        [TestCase("GetExampleInstance", "PrivateEndpointConnectionContainer", "String")]
        [TestCase("GetExampleInstanceAsync", "PrivateEndpointConnectionContainer", "String")]
        [TestCase("CreateOrUpdateExampleInstance", "ManagedHsmContainer", "String")]
        [TestCase("CreateOrUpdateExampleInstanceAsync", "ManagedHsmContainer", "String")]
        [TestCase("GetExampleInstance", "ManagedHsmContainer", "String")]
        [TestCase("GetExampleInstanceAsync", "ManagedHsmContainer", "String")]
        [TestCase("CreateResourceGroupAsync", "String", "ArmClient")]
        [TestCase("CreateResourceGroup", "String", "ArmClient")]
        [TestCase("ReplaceWith")]
        public void validateHelperMethods(string methodName, params string[] argTypes)
        {
            this.ValidateMethodExist("MgmtKeyvault.Tests.TestHelper", methodName, argTypes);
        }

        [TestCase("GetAsync")]
        [TestCase("Get")]
        public void validateDeletedVaultContainerMockTests(string methodName, params string[] argTypes)
        {
            this.ValidateMethodExist("MgmtKeyvault.Tests.Mock.DeletedVaultContainerMockTests", methodName, argTypes);
        }

        [TestCase("CreateOrUpdateAsync")]
        [TestCase("CreateOrUpdate")]
        [TestCase("GetAsync")]
        [TestCase("Get")]
        public void validateManagedHsmContainerMockTests(string methodName, params string[] argTypes)
        {
            this.ValidateMethodExist("MgmtKeyvault.Tests.Mock.ManagedHsmContainerMockTests", methodName, argTypes);
        }

        [TestCase("CreateOrUpdateAsync")]
        [TestCase("CreateOrUpdate")]
        [TestCase("GetAsync")]
        [TestCase("Get")]
        public void validatePrivateEndpointConnectionContainerMockTests(string methodName, params string[] argTypes)
        {
            this.ValidateMethodExist("MgmtKeyvault.Tests.Mock.PrivateEndpointConnectionContainerMockTests", methodName, argTypes);
        }

        [TestCase("CreateOrUpdateAsync")]
        [TestCase("CreateOrUpdate")]
        [TestCase("GetAsync")]
        [TestCase("Get")]
        public void validateVaultContainerMockTests(string methodName, params string[] argTypes)
        {
            this.ValidateMethodExist("MgmtKeyvault.Tests.Mock.VaultContainerMockTests", methodName, argTypes);
        }
    }
}
