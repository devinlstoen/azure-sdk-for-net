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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class WebAppMajorVersion : IUtf8JsonSerializable, IJsonModel<WebAppMajorVersion>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebAppMajorVersion>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WebAppMajorVersion>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebAppMajorVersion>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebAppMajorVersion)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(DisplayText))
            {
                writer.WritePropertyName("displayText"u8);
                writer.WriteStringValue(DisplayText);
            }
            if (options.Format != "W" && Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStringValue(Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(MinorVersions))
            {
                writer.WritePropertyName("minorVersions"u8);
                writer.WriteStartArray();
                foreach (var item in MinorVersions)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
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

        WebAppMajorVersion IJsonModel<WebAppMajorVersion>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebAppMajorVersion>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebAppMajorVersion)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebAppMajorVersion(document.RootElement, options);
        }

        internal static WebAppMajorVersion DeserializeWebAppMajorVersion(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string displayText = default;
            string value = default;
            IReadOnlyList<WebAppMinorVersion> minorVersions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayText"u8))
                {
                    displayText = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("minorVersions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WebAppMinorVersion> array = new List<WebAppMinorVersion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WebAppMinorVersion.DeserializeWebAppMinorVersion(item, options));
                    }
                    minorVersions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new WebAppMajorVersion(displayText, value, minorVersions ?? new ChangeTrackingList<WebAppMinorVersion>(), serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DisplayText), out propertyOverride);
            if (Optional.IsDefined(DisplayText) || hasPropertyOverride)
            {
                builder.Append("  displayText: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (DisplayText.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DisplayText}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DisplayText}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Value), out propertyOverride);
            if (Optional.IsDefined(Value) || hasPropertyOverride)
            {
                builder.Append("  value: ");
                if (hasPropertyOverride)
                {
                    builder.AppendLine($"{propertyOverride}");
                }
                else
                {
                    if (Value.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Value}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Value}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MinorVersions), out propertyOverride);
            if (Optional.IsCollectionDefined(MinorVersions) || hasPropertyOverride)
            {
                if (MinorVersions.Any() || hasPropertyOverride)
                {
                    builder.Append("  minorVersions: ");
                    if (hasPropertyOverride)
                    {
                        builder.AppendLine($"{propertyOverride}");
                    }
                    else
                    {
                        builder.AppendLine("[");
                        foreach (var item in MinorVersions)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  minorVersions: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<WebAppMajorVersion>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebAppMajorVersion>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(WebAppMajorVersion)} does not support writing '{options.Format}' format.");
            }
        }

        WebAppMajorVersion IPersistableModel<WebAppMajorVersion>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebAppMajorVersion>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWebAppMajorVersion(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WebAppMajorVersion)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<WebAppMajorVersion>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
