// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core.Extensions;
using Azure.Language.Authoring;

namespace Microsoft.Extensions.Azure
{
    /// <summary> Extension methods to add <see cref="AuthoringClient"/> to client builder. </summary>
    public static partial class AzureLanguageAuthoringClientBuilderExtensions
    {
        /// <summary> Registers a <see cref="AuthoringClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="endpoint"> The Uri to use. </param>
        public static IAzureClientBuilder<AuthoringClient, AuthoringClientOptions> AddAuthoringClient<TBuilder>(this TBuilder builder, Uri endpoint)
        where TBuilder : IAzureClientFactoryBuilder
        {
            return builder.RegisterClientFactory<AuthoringClient, AuthoringClientOptions>((options) => new AuthoringClient(endpoint, options));
        }

        /// <summary> Registers a <see cref="AuthoringClient"/> instance. </summary>
        /// <param name="builder"> The builder to register with. </param>
        /// <param name="configuration"> The configuration values. </param>
        public static IAzureClientBuilder<AuthoringClient, AuthoringClientOptions> AddAuthoringClient<TBuilder, TConfiguration>(this TBuilder builder, TConfiguration configuration)
        where TBuilder : IAzureClientFactoryBuilderWithConfiguration<TConfiguration>
        {
            return builder.RegisterClientFactory<AuthoringClient, AuthoringClientOptions>(configuration);
        }
    }
}