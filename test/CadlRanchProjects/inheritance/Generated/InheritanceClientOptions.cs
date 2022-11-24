// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Models.Inheritance
{
    /// <summary> Client options for InheritanceClient. </summary>
    public partial class InheritanceClientOptions : ClientOptions
    {
        private const ServiceVersion LatestVersion = ServiceVersion.V2021_03_25;

        /// <summary> The version of the service to use. </summary>
        public enum ServiceVersion
        {
            /// <summary> Service version "2021-03-25". </summary>
            V2021_03_25 = 1,
        }

        internal string Version { get; }

        /// <summary> Initializes new instance of InheritanceClientOptions. </summary>
        public InheritanceClientOptions(ServiceVersion version = LatestVersion)
        {
            Version = version switch
            {
                ServiceVersion.V2021_03_25 => "2021-03-25",
                _ => throw new NotSupportedException()
            };
        }
    }
}