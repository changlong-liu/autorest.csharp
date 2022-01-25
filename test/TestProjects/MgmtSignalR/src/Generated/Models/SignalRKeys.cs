// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MgmtSignalR.Models
{
    /// <summary> A class represents the access keys of the resource. </summary>
    public partial class SignalRKeys
    {
        /// <summary> Initializes a new instance of SignalRKeys. </summary>
        internal SignalRKeys()
        {
        }

        /// <summary> Initializes a new instance of SignalRKeys. </summary>
        /// <param name="primaryKey"> The primary access key. </param>
        /// <param name="secondaryKey"> The secondary access key. </param>
        /// <param name="primaryConnectionString"> Connection string constructed via the primaryKey. </param>
        /// <param name="secondaryConnectionString"> Connection string constructed via the secondaryKey. </param>
        internal SignalRKeys(string primaryKey, string secondaryKey, string primaryConnectionString, string secondaryConnectionString)
        {
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
            PrimaryConnectionString = primaryConnectionString;
            SecondaryConnectionString = secondaryConnectionString;
        }

        /// <summary> The primary access key. </summary>
        public string PrimaryKey { get; }
        /// <summary> The secondary access key. </summary>
        public string SecondaryKey { get; }
        /// <summary> Connection string constructed via the primaryKey. </summary>
        public string PrimaryConnectionString { get; }
        /// <summary> Connection string constructed via the secondaryKey. </summary>
        public string SecondaryConnectionString { get; }
    }
}
