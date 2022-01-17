// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using AutoRest.CSharp.Generation.Writers;
using AutoRest.CSharp.Input;
using AutoRest.CSharp.Input.Source;
using AutoRest.CSharp.Mgmt.AutoRest;
using AutoRest.CSharp.MgmtTest.Generation;
using AutoRest.CSharp.Output.Models.Types;
using AutoRest.CSharp.LowLevelTest.Generation;

namespace AutoRest.CSharp.AutoRest.Plugins
{
    internal class LowLevelTestTarget
    {
        public static void Execute(GeneratedCodeWorkspace project, CodeModel codeModel, SourceInputModel? sourceInputModel, Configuration configuration)
        {
            var context = new BuildContext<LowLevelOutputLibrary>(codeModel, configuration, sourceInputModel);
            foreach (var client in context.Library.RestClients)
            {
                var codeWriter = new CodeWriter();
                var lowLevelClientWriter = new LowLevelClientTestWriter(codeWriter, client, context);
                lowLevelClientWriter.WriteClientTest();
                project.AddGeneratedFile($"{client.Type.Name}Test.cs", codeWriter.ToString());
            }

            //if (hasCollectionTest)
            //{
            //    var mockExtensionWriter = new TestHelperWriter(extensionsWriter, context);
            //    mockExtensionWriter.WriteMockExtension();
            //    project.AddGeneratedFile($"Mock/TestHelper.cs", extensionsWriter.ToString());
            //}

            //foreach (var resource in context.Library.ArmResources)
            //{
            //    var codeWriter = new CodeWriter();
            //    var resourceTestWriter = new ResourceTestWriter(codeWriter, resource, context);
            //    resourceTestWriter.WriteCollectionTest();

            //    project.AddGeneratedFile($"Mock/{resource.Type.Name}Test.cs", codeWriter.ToString());
            //}
        }
    }
}
