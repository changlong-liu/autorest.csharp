// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MgmtSignalR.Models
{
    /// <summary> Contains information about an API error. </summary>
    internal partial class ErrorResponse
    {
        /// <summary> Initializes a new instance of ErrorResponse. </summary>
        internal ErrorResponse()
        {
        }

        /// <summary> Initializes a new instance of ErrorResponse. </summary>
        /// <param name="error"> Describes a particular API error with an error code and a message. </param>
        internal ErrorResponse(ErrorResponseBody error)
        {
            Error = error;
        }

        /// <summary> Describes a particular API error with an error code and a message. </summary>
        public ErrorResponseBody Error { get; }
    }
}
