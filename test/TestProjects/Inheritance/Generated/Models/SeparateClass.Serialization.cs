// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Inheritance.Models
{
    [JsonConverter(typeof(SeparateClassConverter))]
    public partial class SeparateClass : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(StringProperty))
            {
                writer.WritePropertyName("StringProperty"u8);
                writer.WriteStringValue(StringProperty);
            }
            if (Optional.IsDefined(ModelProperty))
            {
                writer.WritePropertyName("ModelProperty"u8);
                writer.WriteObjectValue(ModelProperty);
            }
            writer.WriteEndObject();
        }

        internal static SeparateClass DeserializeSeparateClass(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> stringProperty = default;
            Optional<BaseClassWithExtensibleEnumDiscriminator> modelProperty = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("StringProperty"u8))
                {
                    stringProperty = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ModelProperty"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    modelProperty = BaseClassWithExtensibleEnumDiscriminator.DeserializeBaseClassWithExtensibleEnumDiscriminator(property.Value);
                    continue;
                }
            }
            return new SeparateClass(stringProperty.Value, modelProperty.Value);
        }

        internal partial class SeparateClassConverter : JsonConverter<SeparateClass>
        {
            public override void Write(Utf8JsonWriter writer, SeparateClass model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SeparateClass Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSeparateClass(document.RootElement);
            }
        }
    }
}
