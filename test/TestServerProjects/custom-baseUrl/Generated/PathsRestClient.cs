// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace custom_baseUrl
{
    internal partial class PathsRestClient
    {
        private string host;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of PathsRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="host"> A string value that is used as a global part of the parameterized host. </param>
        /// <exception cref="ArgumentNullException"> This occurs when one of the required arguments is null. </exception>
        public PathsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string host = "host")
        {
            if (host == null)
            {
                throw new ArgumentNullException(nameof(host));
            }

            this.host = host;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateGetEmptyRequest(string accountName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw("http://", false);
            uri.AppendRaw(accountName, false);
            uri.AppendRaw(host, false);
            uri.AppendPath("/customuri", false);
            request.Uri = uri;
            return message;
        }

        /// <summary> Get a 200 to test a valid base uri. </summary>
        /// <param name="accountName"> Account Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> GetEmptyAsync(string accountName, CancellationToken cancellationToken = default)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            using var message = CreateGetEmptyRequest(accountName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Get a 200 to test a valid base uri. </summary>
        /// <param name="accountName"> Account Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response GetEmpty(string accountName, CancellationToken cancellationToken = default)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            using var message = CreateGetEmptyRequest(accountName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
