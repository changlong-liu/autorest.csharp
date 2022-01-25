﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoRest.CSharp.Generation.Writers;
using AutoRest.CSharp.Input;
using Newtonsoft.Json;

namespace AutoRest.CSharp.MgmtTest.Generation
{
    internal class CodeWriterOavVariableScope : IDisposable
    {
        private readonly CodeWriter writer;
        private IEnumerable<string> existedVariables;
        private OavVariableScope ovs;
        private Dictionary<string, CodeWriterDeclaration> backupDeclarations = new Dictionary<string, CodeWriterDeclaration>();

        public CodeWriterOavVariableScope(CodeWriter writer, OavVariableScope ovs, IEnumerable<string> existedVariables)
        {
            this.writer = writer;
            this.ovs = ovs;
            this.existedVariables = existedVariables;
            var variables = ovs.Variables ?? new Dictionary<string, object?>();
            foreach (var variable in variables.Keys)
            {
                if (existedVariables.Contains(variable))
                {
                    var declaration = new CodeWriterDeclaration($"{variable}Backup");
                    writer.Line($"string {declaration:D} = {variable};");
                    backupDeclarations[variable] = declaration;
                }
            }
        }

        public void Dispose()
        {
            var variables = ovs.Variables ?? new Dictionary<string, object?>();
            foreach (var variable in variables.Keys)
            {
                if (existedVariables.Contains(variable))
                {
                    writer.Line($"{variable} = {backupDeclarations[variable]};");
                }
            }
        }
    }
}
