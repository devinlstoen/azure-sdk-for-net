// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier : IUtf8JsonSerializable, IJsonModel<ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (KeyId != null)
            {
                writer.WritePropertyName("keyId"u8);
                writer.WriteStringValue(KeyId.Value);
            }
            else
            {
                writer.WriteNull("keyId");
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
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

        ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier IJsonModel<ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier(document.RootElement, options);
        }

        internal static ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier DeserializeContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid? keyId = default;
            string odataType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        keyId = null;
                        continue;
                    }
                    keyId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier(odataType, serializedAdditionalRawData, keyId);
        }

        BinaryData IPersistableModel<ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier)} does not support writing '{options.Format}' format.");
            }
        }

        ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier IPersistableModel<ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
