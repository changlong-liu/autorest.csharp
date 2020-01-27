// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class StopwordsTokenFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Stopwords != null)
            {
                writer.WritePropertyName("stopwords");
                writer.WriteStartArray();
                foreach (var item in Stopwords)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (StopwordsList != null)
            {
                writer.WritePropertyName("stopwordsList");
                writer.WriteStringValue(StopwordsList.Value.ToSerialString());
            }
            if (IgnoreCase != null)
            {
                writer.WritePropertyName("ignoreCase");
                writer.WriteBooleanValue(IgnoreCase.Value);
            }
            if (RemoveTrailingStopWords != null)
            {
                writer.WritePropertyName("removeTrailing");
                writer.WriteBooleanValue(RemoveTrailingStopWords.Value);
            }
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(OdataType);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }
        internal static StopwordsTokenFilter DeserializeStopwordsTokenFilter(JsonElement element)
        {
            StopwordsTokenFilter result = new StopwordsTokenFilter();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("stopwords"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Stopwords = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Stopwords.Add(item.GetString());
                    }
                    continue;
                }
                if (property.NameEquals("stopwordsList"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.StopwordsList = property.Value.GetString().ToStopwordsList();
                    continue;
                }
                if (property.NameEquals("ignoreCase"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.IgnoreCase = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("removeTrailing"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.RemoveTrailingStopWords = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("@odata.type"))
                {
                    result.OdataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    result.Name = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}