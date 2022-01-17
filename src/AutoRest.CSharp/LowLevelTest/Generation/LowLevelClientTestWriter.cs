// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using AutoRest.CSharp.Generation.Types;
using AutoRest.CSharp.Generation.Writers;
using AutoRest.CSharp.Mgmt.AutoRest;
using AutoRest.CSharp.Input;
using AutoRest.CSharp.Mgmt.Output;
using AutoRest.CSharp.Output.Models.Shared;
using AutoRest.CSharp.Output.Models.Types;
using AutoRest.CSharp.Mgmt.Models;
using AutoRest.CSharp.Utilities;
using System.Diagnostics.CodeAnalysis;
using AutoRest.CSharp.Output.Models;
using AutoRest.CSharp.Output.Models.Requests;

namespace AutoRest.CSharp.LowLevelTest.Generation
{
    /// <summary>
    /// Code writer for resource test.
    /// </summary>
    internal class LowLevelClientTestWriter : LowLevelBaseTestWriter
    {
        public LowLevelClient client;
        protected string TestNamespace => client.Type.Namespace + ".Tests.Mock";
        protected string TypeNameOfThis => client.Type.Name + "MockTests";

        protected string TestBaseName => $"RecordedTestBase<PurviewAccountTestEnvironment>";

        public LowLevelClientTestWriter(CodeWriter writer, LowLevelClient client, BuildContext<LowLevelOutputLibrary> context) : base(writer, context)
        {
            this.client = client;
        }

        public void WriteClientTest()
        {
            WriteUsings(writer);

            using (writer.Namespace(TestNamespace))
            {
                writer.WriteXmlDocumentationSummary($"Test for {client.Type}");
                writer.Append($"public partial class {TypeNameOfThis:D} : ");
                writer.Line($"{TestBaseName}");
                using (writer.Scope())
                {
                    writer.Line($"private PurviewAccountClientOptions options;");
                    WriteTesterCtors();
                    foreach (var clientMethod in client.ClientMethods)
                    {
                        WriteMethodTest(clientMethod);
                    }
                }
            }
        }

        private void WriteMethodTest(LowLevelClientMethod method, bool async = true)
        {
            var methodName = method.RequestMethod.Name;

            // BuildParameters(clientOperation, out var operationMappings, out var parameterMappings, out var methodParameters);
            int exampleIdx = 0;

            var exampleGroup = LowLevelBaseTestWriter.FindExampleGroup(this.context, method.RequestMethod);
            if (exampleGroup is null || exampleGroup.Examples.Count() == 0)
                return;
            var testMethodName = CreateMethodName(method.RequestMethod.Name, async);

            foreach (var exampleModel in exampleGroup?.Examples ?? Enumerable.Empty<ExampleModel>())
            {
                writer.Line();
                WriteTestDecorator();
                var testCaseSuffix = exampleIdx > 0 ? (exampleIdx + 1).ToString() : String.Empty;
                writer.Append($"public async {LowLevelBaseTestWriter.GetTaskOrVoid(async)} {methodName}{testCaseSuffix}()");

                using (writer.Scope())
                {
                    writer.LineRaw($"// Example: {exampleModel.Name}");
                    clearVariableNames();
                    WritDeclareClientVariable(exampleModel);

                    var parameters = method.IsLongRunning
                        ? method.RequestMethod.Parameters.Prepend(KnownParameters.WaitForCompletion).ToArray()
                        : method.RequestMethod.Parameters;


                    WritBodyVariableIfExists(method, exampleModel);
                    WritTestInvocation(method);
                    //string resourceIdentifierParams = ComposeResourceIdentifierParams(resource.RequestPaths.First(), exampleModel);
                    //var resourceVariableName = WriteGetResource(resource, resourceIdentifierParams, exampleModel);
                    //// List<string> paramNames = WriteOperationParameters(methodParameters, Enumerable.Empty<Parameter> (), exampleModel);
                    //writer.Line();
                    //// WriteMethodTestInvocation(async, clientOperation, isLroOperation, $"{resourceVariableName}.{testMethodName}", paramNames);
                    ///
                    if (method.IsLongRunning)
                    {
                        WriteLongRunningOperationMethod(writer, method, client.Fields);
                    }
                    else if (method.PagingInfo != null)
                    {
                        WritePagingMethod(writer, method, client.Fields);
                    }
                    else
                    {
                        // WriteClientMethod(writer, client, clientMethod, context.Configuration);
                    }
                }

                exampleIdx++;
            }
        }

        private void WritDeclareClientVariable(ExampleModel exampleModel)
        {
            writer.Append($"{client.Type} client = new {client.Type}(new Uri(\"https://localhost:8443\"), ");
            foreach (var param in client.PublicConstructors.First().Parameters)
            {
                if (param.Name == "endpoint" || param.Name == "credential" || param.Name == "options")
                {
                    continue;
                }
                WriteParameterValue(param, exampleModel);
                writer.Append($", ");
            }
            writer.Line($"new MockCredential(), options);");
        }

        private bool HasContentParameter(LowLevelClientMethod method)
        {
            return method.RequestMethod.Parameters.Any((p) => p.Name == "content");
        }

        private void WritBodyVariableIfExists(LowLevelClientMethod method, ExampleModel exampleModel)
        {
            if (HasContentParameter(method))
            {
                WriteBodyParameter(exampleModel);
            }
        }

        private void WritTestInvocation(LowLevelClientMethod method)
        {
            var testMethodName = CreateMethodName(method.RequestMethod.Name, true);

            var arguments = new List<string>();
            if (HasContentParameter(method))
            {
                arguments.Add($"RequestContent.Create(data)");
            }

            writer.Append($"await ");
            if (method.PagingInfo != null)
            {
                using (writer.Scope($"foreach (var _ in {WriteMethodInvocation($"client.{testMethodName}", arguments)})"))
                { }
            }
            else
            {
                writer.Line($"client.{WriteMethodInvocation(testMethodName, arguments)};");
            }
        }

        private void WriteBodyParameter(ExampleModel exampleModel)
        {
            foreach (var parameter in exampleModel.AllParameter)
            {
                if (parameter.Parameter.Protocol.Http is HttpParameter httpParameter && httpParameter.In == ParameterLocation.Body)
                {
                    writer.Append($"var data = ");
                    WriteAsAnonymousType(parameter.ExampleValue);
                    writer.Line($";");

                }
            }
        }

        private void WriteAsAnonymousType(ExampleValue exampleValue)
        {
            if (exampleValue.Properties is not null)
            {
                using (writer.Scope($"new "))
                {
                    foreach (var property in exampleValue.Properties)
                    {
                        if (property.Value.RawValue is null && property.Value.Properties is null && property.Value.Elements is null)
                        {
                            continue;
                        }
                        writer.Append($"{property.Key} = ");
                        WriteAsAnonymousType(property.Value);
                        writer.Line($", ");
                    }
                }
            }
            else if (exampleValue.Elements is not null)
            {
                using (writer.Scope($"new object[{exampleValue.Elements.Count}]"))
                {
                    foreach (var element in exampleValue.Elements)
                    {
                        WriteAsAnonymousType(element);
                        writer.Line($", ");
                    }
                }
            }
            else
            {
                if (exampleValue.RawValue is string)
                {
                    writer.Append($"{exampleValue.RawValue:L}");
                }
                else
                if (exampleValue.RawValue is null)
                {
                    writer.Append($"null");
                }
                else
                {
                    writer.Append($"{exampleValue.RawValue}");
                }
            }
        }

        private void WriteLongRunningOperationMethod(CodeWriter writer, LowLevelClientMethod clientMethod, ClientFields fields)
        {
        }

        private void WritePagingMethod(CodeWriter writer, LowLevelClientMethod clientMethod, ClientFields fields)
        {
        }

        private void WriteClientMethod(CodeWriter writer, LowLevelClientMethod clientMethod, ClientFields fields)
        {
        }

        protected void WriteUsings(CodeWriter writer)
        {
            writer.UseNamespace("System");
            writer.UseNamespace("System.Threading.Tasks");
            writer.UseNamespace("Azure.Core.TestFramework");
            writer.UseNamespace("System.Text.Json");
            writer.UseNamespace("Azure.Core");
            writer.UseNamespace("System.IO");
            writer.UseNamespace("NUnit.Framework");
            writer.UseNamespace("System.Net.Http");
            writer.UseNamespace("Azure.Core.Pipeline");
        }

        protected void WriteTesterCtors()
        {
            // write protected default constructor
            writer.Line();
            using (writer.Scope($"public {TypeNameOfThis}(bool isAsync): base(isAsync, RecordedTestMode.Record)"))
            {
                writer.Line($"var httpHandler = new HttpClientHandler();");
                using (writer.Scope($"httpHandler.ServerCertificateCustomValidationCallback = (_, _, _, _) =>"))
                {
                    writer.Line($"return true;");
                };
                writer.Line($";");
                writer.Line($"this.options = new PurviewAccountClientOptions {{ Transport = new HttpClientTransport(httpHandler) }};");
            }
        }

        public string WriteGetResource(Resource resource, string resourceIdentifierParams, ExampleModel exampleModel)
        {
            var resourceVariableName = useVariableName(resource.Type.Name.FirstCharToLowerCase());
            var idVar = useVariableName($"{resource.Type.Name.FirstCharToLowerCase()}Id");
            writer.Line($"var {idVar} = {resource.Type}.CreateResourceIdentifier({resourceIdentifierParams});");
            writer.Line($"var {resourceVariableName} = GetArmClient().Get{resource.Type.Name}({idVar});");
            return resourceVariableName;
        }

        //protected void WriteMethodTest(Resource resource, MgmtClientOperation clientOperation, bool async, bool isLroOperation)
        //{
        //    Debug.Assert(clientOperation != null);
        //    var methodName = clientOperation.Name;

        //    // BuildParameters(clientOperation, out var operationMappings, out var parameterMappings, out var methodParameters);
        //    int exampleIdx = 0;
        //    foreach ((var branch, var operation) in GetSortedOperationMappings(clientOperation))
        //    {
        //        var exampleGroup = LowLevelBaseTestWriter.FindExampleGroup(this.context, operation);
        //        if (exampleGroup is null || exampleGroup.Examples.Count() == 0)
        //            return;
        //        var testMethodName = CreateMethodName(methodName, async);

        //        foreach (var exampleModel in exampleGroup?.Examples ?? Enumerable.Empty<ExampleModel>())
        //        {
        //            if (resource.RequestPaths is null || resource.RequestPaths.Count()==0)
        //            {
        //                continue;
        //            }

        //            WriteTestDecorator();
        //            var testCaseSuffix = exampleIdx > 0 ? (exampleIdx + 1).ToString() : String.Empty;
        //            writer.Append($"public async {LowLevelBaseTestWriter.GetTaskOrVoid(async)} {methodName}{testCaseSuffix}()");

        //            using (writer.Scope())
        //            {
        //                writer.LineRaw($"// Example: {exampleModel.Name}");
        //                clearVariableNames();
        //                string resourceIdentifierParams = ComposeResourceIdentifierParams(resource.RequestPaths.First(), exampleModel);
        //                var resourceVariableName = WriteGetResource(resource, resourceIdentifierParams, exampleModel);
        //                // List<string> paramNames = WriteOperationParameters(methodParameters, Enumerable.Empty<Parameter> (), exampleModel);
        //                writer.Line();
        //                // WriteMethodTestInvocation(async, clientOperation, isLroOperation, $"{resourceVariableName}.{testMethodName}", paramNames);
        //            }
        //            writer.Line();
        //            exampleIdx++;
        //        }
        //    }
        //}
    }
}
