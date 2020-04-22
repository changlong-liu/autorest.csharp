// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    public partial class ListContainerItem : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Etag != null)
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Type != null)
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (DefaultEncryptionScope != null)
            {
                writer.WritePropertyName("defaultEncryptionScope");
                writer.WriteStringValue(DefaultEncryptionScope);
            }
            if (DenyEncryptionScopeOverride != null)
            {
                writer.WritePropertyName("denyEncryptionScopeOverride");
                writer.WriteBooleanValue(DenyEncryptionScopeOverride.Value);
            }
            if (PublicAccess != null)
            {
                writer.WritePropertyName("publicAccess");
                writer.WriteStringValue(PublicAccess.Value.ToSerialString());
            }
            if (LastModifiedTime != null)
            {
                writer.WritePropertyName("lastModifiedTime");
                writer.WriteStringValue(LastModifiedTime.Value, "S");
            }
            if (LeaseStatus != null)
            {
                writer.WritePropertyName("leaseStatus");
                writer.WriteStringValue(LeaseStatus.Value.ToString());
            }
            if (LeaseState != null)
            {
                writer.WritePropertyName("leaseState");
                writer.WriteStringValue(LeaseState.Value.ToString());
            }
            if (LeaseDuration != null)
            {
                writer.WritePropertyName("leaseDuration");
                writer.WriteStringValue(LeaseDuration.Value.ToString());
            }
            if (Metadata != null)
            {
                writer.WritePropertyName("metadata");
                writer.WriteStartObject();
                foreach (var item in Metadata)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (ImmutabilityPolicy != null)
            {
                writer.WritePropertyName("immutabilityPolicy");
                writer.WriteObjectValue(ImmutabilityPolicy);
            }
            if (LegalHold != null)
            {
                writer.WritePropertyName("legalHold");
                writer.WriteObjectValue(LegalHold);
            }
            if (HasLegalHold != null)
            {
                writer.WritePropertyName("hasLegalHold");
                writer.WriteBooleanValue(HasLegalHold.Value);
            }
            if (HasImmutabilityPolicy != null)
            {
                writer.WritePropertyName("hasImmutabilityPolicy");
                writer.WriteBooleanValue(HasImmutabilityPolicy.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ListContainerItem DeserializeListContainerItem(JsonElement element)
        {
            string etag = default;
            string id = default;
            string name = default;
            string type = default;
            string defaultEncryptionScope = default;
            bool? denyEncryptionScopeOverride = default;
            PublicAccess? publicAccess = default;
            DateTimeOffset? lastModifiedTime = default;
            LeaseStatus? leaseStatus = default;
            LeaseState? leaseState = default;
            LeaseDuration? leaseDuration = default;
            IDictionary<string, string> metadata = default;
            ImmutabilityPolicyProperties immutabilityPolicy = default;
            LegalHoldProperties legalHold = default;
            bool? hasLegalHold = default;
            bool? hasImmutabilityPolicy = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("defaultEncryptionScope"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultEncryptionScope = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("denyEncryptionScopeOverride"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            denyEncryptionScopeOverride = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("publicAccess"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicAccess = property0.Value.GetString().ToPublicAccess();
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModifiedTime = property0.Value.GetDateTimeOffset("S");
                            continue;
                        }
                        if (property0.NameEquals("leaseStatus"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            leaseStatus = new LeaseStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("leaseState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            leaseState = new LeaseState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("leaseDuration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            leaseDuration = new LeaseDuration(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("metadata"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, property1.Value.GetString());
                                }
                            }
                            metadata = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("immutabilityPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            immutabilityPolicy = ImmutabilityPolicyProperties.DeserializeImmutabilityPolicyProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("legalHold"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            legalHold = LegalHoldProperties.DeserializeLegalHoldProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hasLegalHold"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hasLegalHold = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("hasImmutabilityPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hasImmutabilityPolicy = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ListContainerItem(id, name, type, etag, defaultEncryptionScope, denyEncryptionScopeOverride, publicAccess, lastModifiedTime, leaseStatus, leaseState, leaseDuration, metadata, immutabilityPolicy, legalHold, hasLegalHold, hasImmutabilityPolicy);
        }
    }
}