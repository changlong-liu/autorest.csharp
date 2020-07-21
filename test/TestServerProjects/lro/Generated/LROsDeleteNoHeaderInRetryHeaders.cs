// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace lro
{
    internal class LROsDeleteNoHeaderInRetryHeaders
    {
        private readonly Response _response;
        public LROsDeleteNoHeaderInRetryHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> Location to poll for result status: will be set to /lro/put/noheader/202/204/operationresults. </summary>
        public string Location => _response.Headers.TryGetValue("Location", out string value) ? value : null;
    }
}