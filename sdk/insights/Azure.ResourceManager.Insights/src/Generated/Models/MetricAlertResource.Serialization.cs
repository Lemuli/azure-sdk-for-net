// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Insights.Models
{
    public partial class MetricAlertResource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WritePropertyName("description");
            writer.WriteStringValue(Description);
            writer.WritePropertyName("severity");
            writer.WriteNumberValue(Severity);
            writer.WritePropertyName("enabled");
            writer.WriteBooleanValue(Enabled);
            if (Optional.IsCollectionDefined(Scopes))
            {
                writer.WritePropertyName("scopes");
                writer.WriteStartArray();
                foreach (var item in Scopes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("evaluationFrequency");
            writer.WriteStringValue(EvaluationFrequency, "P");
            writer.WritePropertyName("windowSize");
            writer.WriteStringValue(WindowSize, "P");
            if (Optional.IsDefined(TargetResourceType))
            {
                writer.WritePropertyName("targetResourceType");
                writer.WriteStringValue(TargetResourceType);
            }
            if (Optional.IsDefined(TargetResourceRegion))
            {
                writer.WritePropertyName("targetResourceRegion");
                writer.WriteStringValue(TargetResourceRegion);
            }
            writer.WritePropertyName("criteria");
            writer.WriteObjectValue(Criteria);
            if (Optional.IsDefined(AutoMitigate))
            {
                writer.WritePropertyName("autoMitigate");
                writer.WriteBooleanValue(AutoMitigate.Value);
            }
            if (Optional.IsCollectionDefined(Actions))
            {
                writer.WritePropertyName("actions");
                writer.WriteStartArray();
                foreach (var item in Actions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static MetricAlertResource DeserializeMetricAlertResource(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            string location = default;
            Optional<IDictionary<string, string>> tags = default;
            string description = default;
            int severity = default;
            bool enabled = default;
            Optional<IList<string>> scopes = default;
            TimeSpan evaluationFrequency = default;
            TimeSpan windowSize = default;
            Optional<string> targetResourceType = default;
            Optional<string> targetResourceRegion = default;
            MetricAlertCriteria criteria = default;
            Optional<bool> autoMitigate = default;
            Optional<IList<MetricAlertAction>> actions = default;
            Optional<DateTimeOffset> lastUpdatedTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("description"))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("severity"))
                        {
                            severity = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("enabled"))
                        {
                            enabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("scopes"))
                        {
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            scopes = array;
                            continue;
                        }
                        if (property0.NameEquals("evaluationFrequency"))
                        {
                            evaluationFrequency = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("windowSize"))
                        {
                            windowSize = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("targetResourceType"))
                        {
                            targetResourceType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetResourceRegion"))
                        {
                            targetResourceRegion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("criteria"))
                        {
                            criteria = MetricAlertCriteria.DeserializeMetricAlertCriteria(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("autoMitigate"))
                        {
                            autoMitigate = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("actions"))
                        {
                            List<MetricAlertAction> array = new List<MetricAlertAction>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MetricAlertAction.DeserializeMetricAlertAction(item));
                            }
                            actions = array;
                            continue;
                        }
                        if (property0.NameEquals("lastUpdatedTime"))
                        {
                            lastUpdatedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new MetricAlertResource(id.Value, name.Value, type.Value, location, Optional.ToDictionary(tags), description, severity, enabled, Optional.ToList(scopes), evaluationFrequency, windowSize, targetResourceType.Value, targetResourceRegion.Value, criteria, Optional.ToNullable(autoMitigate), Optional.ToList(actions), Optional.ToNullable(lastUpdatedTime));
        }
    }
}
