// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace body_complex.Models
{
    /// <summary> The Fish. </summary>
    public partial class Fish
    {
        /// <summary> Initializes a new instance of Fish. </summary>
        /// <param name="length"></param>
        public Fish(float length)
        {
            Length = length;
            Siblings = new ChangeTrackingList<Fish>();
        }

        /// <summary> Initializes a new instance of Fish. </summary>
        /// <param name="fishtype"></param>
        /// <param name="species"></param>
        /// <param name="length"></param>
        /// <param name="siblings"></param>
        internal Fish(string fishtype, string species, float length, IList<Fish> siblings)
        {
            Fishtype = fishtype;
            Species = species;
            Length = length;
            Siblings = siblings;
        }

        internal string Fishtype { get; set; }
        public string Species { get; set; }
        public float Length { get; set; }
        public IList<Fish> Siblings { get; }
    }
}
