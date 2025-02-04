// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary> Specifies the type of the proximity placement group. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **Standard** : Co-locate resources within an Azure region or Availability Zone. &lt;br&gt;&lt;br&gt; **Ultra** : For future use. </summary>
    public readonly partial struct ProximityPlacementGroupType : IEquatable<ProximityPlacementGroupType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ProximityPlacementGroupType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ProximityPlacementGroupType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StandardValue = "Standard";
        private const string UltraValue = "Ultra";

        /// <summary> Standard. </summary>
        public static ProximityPlacementGroupType Standard { get; } = new ProximityPlacementGroupType(StandardValue);
        /// <summary> Ultra. </summary>
        public static ProximityPlacementGroupType Ultra { get; } = new ProximityPlacementGroupType(UltraValue);
        /// <summary> Determines if two <see cref="ProximityPlacementGroupType"/> values are the same. </summary>
        public static bool operator ==(ProximityPlacementGroupType left, ProximityPlacementGroupType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ProximityPlacementGroupType"/> values are not the same. </summary>
        public static bool operator !=(ProximityPlacementGroupType left, ProximityPlacementGroupType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ProximityPlacementGroupType"/>. </summary>
        public static implicit operator ProximityPlacementGroupType(string value) => new ProximityPlacementGroupType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ProximityPlacementGroupType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ProximityPlacementGroupType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
