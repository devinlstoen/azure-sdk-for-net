// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class RedistributeThroughputPropertiesResource : IUtf8JsonSerializable, IJsonModel<RedistributeThroughputPropertiesResource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RedistributeThroughputPropertiesResource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RedistributeThroughputPropertiesResource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedistributeThroughputPropertiesResource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RedistributeThroughputPropertiesResource)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("throughputPolicy"u8);
            writer.WriteStringValue(ThroughputPolicy.ToString());
            writer.WritePropertyName("targetPhysicalPartitionThroughputInfo"u8);
            writer.WriteStartArray();
            foreach (var item in TargetPhysicalPartitionThroughputInfo)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("sourcePhysicalPartitionThroughputInfo"u8);
            writer.WriteStartArray();
            foreach (var item in SourcePhysicalPartitionThroughputInfo)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        RedistributeThroughputPropertiesResource IJsonModel<RedistributeThroughputPropertiesResource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedistributeThroughputPropertiesResource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RedistributeThroughputPropertiesResource)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRedistributeThroughputPropertiesResource(document.RootElement, options);
        }

        internal static RedistributeThroughputPropertiesResource DeserializeRedistributeThroughputPropertiesResource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ThroughputPolicyType throughputPolicy = default;
            IList<PhysicalPartitionThroughputInfoResource> targetPhysicalPartitionThroughputInfo = default;
            IList<PhysicalPartitionThroughputInfoResource> sourcePhysicalPartitionThroughputInfo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("throughputPolicy"u8))
                {
                    throughputPolicy = new ThroughputPolicyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetPhysicalPartitionThroughputInfo"u8))
                {
                    List<PhysicalPartitionThroughputInfoResource> array = new List<PhysicalPartitionThroughputInfoResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PhysicalPartitionThroughputInfoResource.DeserializePhysicalPartitionThroughputInfoResource(item, options));
                    }
                    targetPhysicalPartitionThroughputInfo = array;
                    continue;
                }
                if (property.NameEquals("sourcePhysicalPartitionThroughputInfo"u8))
                {
                    List<PhysicalPartitionThroughputInfoResource> array = new List<PhysicalPartitionThroughputInfoResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PhysicalPartitionThroughputInfoResource.DeserializePhysicalPartitionThroughputInfoResource(item, options));
                    }
                    sourcePhysicalPartitionThroughputInfo = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RedistributeThroughputPropertiesResource(throughputPolicy, targetPhysicalPartitionThroughputInfo, sourcePhysicalPartitionThroughputInfo, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ThroughputPolicy), out propertyOverride);
            builder.Append("  throughputPolicy: ");
            if (hasPropertyOverride)
            {
                builder.AppendLine($"{propertyOverride}");
            }
            else
            {
                builder.AppendLine($"'{ThroughputPolicy.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TargetPhysicalPartitionThroughputInfo), out propertyOverride);
            if (Optional.IsCollectionDefined(TargetPhysicalPartitionThroughputInfo) || hasPropertyOverride)
            {
                if (TargetPhysicalPartitionThroughputInfo.Any() || hasPropertyOverride)
                {
                    builder.Append("  targetPhysicalPartitionThroughputInfo: ");
                    if (hasPropertyOverride)
                    {
                        builder.AppendLine($"{propertyOverride}");
                    }
                    else
                    {
                        builder.AppendLine("[");
                        foreach (var item in TargetPhysicalPartitionThroughputInfo)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  targetPhysicalPartitionThroughputInfo: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SourcePhysicalPartitionThroughputInfo), out propertyOverride);
            if (Optional.IsCollectionDefined(SourcePhysicalPartitionThroughputInfo) || hasPropertyOverride)
            {
                if (SourcePhysicalPartitionThroughputInfo.Any() || hasPropertyOverride)
                {
                    builder.Append("  sourcePhysicalPartitionThroughputInfo: ");
                    if (hasPropertyOverride)
                    {
                        builder.AppendLine($"{propertyOverride}");
                    }
                    else
                    {
                        builder.AppendLine("[");
                        foreach (var item in SourcePhysicalPartitionThroughputInfo)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  sourcePhysicalPartitionThroughputInfo: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<RedistributeThroughputPropertiesResource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedistributeThroughputPropertiesResource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(RedistributeThroughputPropertiesResource)} does not support writing '{options.Format}' format.");
            }
        }

        RedistributeThroughputPropertiesResource IPersistableModel<RedistributeThroughputPropertiesResource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedistributeThroughputPropertiesResource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRedistributeThroughputPropertiesResource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RedistributeThroughputPropertiesResource)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RedistributeThroughputPropertiesResource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
