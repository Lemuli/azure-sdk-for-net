// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class DetectionAnomalyFilterCondition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(DimensionFilter))
            {
                writer.WritePropertyName("dimensionFilter");
                writer.WriteStartArray();
                foreach (var item in DimensionFilter)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SeverityFilter))
            {
                writer.WritePropertyName("severityFilter");
                writer.WriteObjectValue(SeverityFilter);
            }
            writer.WriteEndObject();
        }
    }
}
