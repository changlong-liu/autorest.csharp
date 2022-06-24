// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace MgmtOptionalConstant.Models
{
    public partial class ModelWithRequiredConstant : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("passName");
            writer.WriteStringValue(PassName.ToString());
            if (Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol");
                writer.WriteStringValue(Protocol.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }

        internal static ModelWithRequiredConstant DeserializeModelWithRequiredConstant(JsonElement element)
        {
            PassName passName = default;
            Optional<ProtocolType> protocol = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("passName"))
                {
                    passName = new PassName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protocol"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    protocol = property.Value.GetString().ToProtocolType();
                    continue;
                }
            }
            return new ModelWithRequiredConstant(passName, Optional.ToNullable(protocol));
        }
    }
}