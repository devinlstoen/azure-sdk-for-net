// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    internal partial class AzureSearchChatExtensionParameters : IUtf8JsonSerializable, IJsonModel<AzureSearchChatExtensionParameters>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureSearchChatExtensionParameters>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AzureSearchChatExtensionParameters>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureSearchChatExtensionParameters>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureSearchChatExtensionParameters)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Authentication))
            {
                writer.WritePropertyName("authentication"u8);
                writer.WriteObjectValue(Authentication, options);
            }
            if (Optional.IsDefined(DocumentCount))
            {
                writer.WritePropertyName("top_n_documents"u8);
                writer.WriteNumberValue(DocumentCount.Value);
            }
            if (Optional.IsDefined(ShouldRestrictResultScope))
            {
                writer.WritePropertyName("in_scope"u8);
                writer.WriteBooleanValue(ShouldRestrictResultScope.Value);
            }
            if (Optional.IsDefined(Strictness))
            {
                writer.WritePropertyName("strictness"u8);
                writer.WriteNumberValue(Strictness.Value);
            }
            if (Optional.IsDefined(RoleInformation))
            {
                writer.WritePropertyName("role_information"u8);
                writer.WriteStringValue(RoleInformation);
            }
            writer.WritePropertyName("endpoint"u8);
            writer.WriteStringValue(SearchEndpoint.AbsoluteUri);
            writer.WritePropertyName("index_name"u8);
            writer.WriteStringValue(IndexName);
            if (Optional.IsDefined(FieldMappingOptions))
            {
                writer.WritePropertyName("fields_mapping"u8);
                writer.WriteObjectValue(FieldMappingOptions, options);
            }
            if (Optional.IsDefined(QueryType))
            {
                writer.WritePropertyName("query_type"u8);
                writer.WriteStringValue(QueryType.Value.ToString());
            }
            if (Optional.IsDefined(SemanticConfiguration))
            {
                writer.WritePropertyName("semantic_configuration"u8);
                writer.WriteStringValue(SemanticConfiguration);
            }
            if (Optional.IsDefined(Filter))
            {
                writer.WritePropertyName("filter"u8);
                writer.WriteStringValue(Filter);
            }
            if (Optional.IsDefined(EmbeddingDependency))
            {
                writer.WritePropertyName("embedding_dependency"u8);
                writer.WriteObjectValue(EmbeddingDependency, options);
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

        AzureSearchChatExtensionParameters IJsonModel<AzureSearchChatExtensionParameters>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureSearchChatExtensionParameters>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureSearchChatExtensionParameters)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureSearchChatExtensionParameters(document.RootElement, options);
        }

        internal static AzureSearchChatExtensionParameters DeserializeAzureSearchChatExtensionParameters(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OnYourDataAuthenticationOptions authentication = default;
            int? topNDocuments = default;
            bool? inScope = default;
            int? strictness = default;
            string roleInformation = default;
            Uri endpoint = default;
            string indexName = default;
            AzureSearchIndexFieldMappingOptions fieldsMapping = default;
            AzureSearchQueryType? queryType = default;
            string semanticConfiguration = default;
            string filter = default;
            OnYourDataVectorizationSource embeddingDependency = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authentication"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authentication = OnYourDataAuthenticationOptions.DeserializeOnYourDataAuthenticationOptions(property.Value, options);
                    continue;
                }
                if (property.NameEquals("top_n_documents"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    topNDocuments = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("in_scope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    inScope = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("strictness"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    strictness = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("role_information"u8))
                {
                    roleInformation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpoint"u8))
                {
                    endpoint = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("index_name"u8))
                {
                    indexName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fields_mapping"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fieldsMapping = AzureSearchIndexFieldMappingOptions.DeserializeAzureSearchIndexFieldMappingOptions(property.Value, options);
                    continue;
                }
                if (property.NameEquals("query_type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queryType = new AzureSearchQueryType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("semantic_configuration"u8))
                {
                    semanticConfiguration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filter"u8))
                {
                    filter = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("embedding_dependency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    embeddingDependency = OnYourDataVectorizationSource.DeserializeOnYourDataVectorizationSource(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AzureSearchChatExtensionParameters(
                authentication,
                topNDocuments,
                inScope,
                strictness,
                roleInformation,
                endpoint,
                indexName,
                fieldsMapping,
                queryType,
                semanticConfiguration,
                filter,
                embeddingDependency,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AzureSearchChatExtensionParameters>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureSearchChatExtensionParameters>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureSearchChatExtensionParameters)} does not support writing '{options.Format}' format.");
            }
        }

        AzureSearchChatExtensionParameters IPersistableModel<AzureSearchChatExtensionParameters>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureSearchChatExtensionParameters>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureSearchChatExtensionParameters(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureSearchChatExtensionParameters)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureSearchChatExtensionParameters>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AzureSearchChatExtensionParameters FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAzureSearchChatExtensionParameters(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, new ModelReaderWriterOptions("W"));
            return content;
        }
    }
}
