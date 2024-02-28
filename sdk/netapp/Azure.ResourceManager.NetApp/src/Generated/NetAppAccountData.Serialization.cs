// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetApp.Models;

namespace Azure.ResourceManager.NetApp
{
    public partial class NetAppAccountData : IUtf8JsonSerializable, IJsonModel<NetAppAccountData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetAppAccountData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetAppAccountData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppAccountData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetAppAccountData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ETag.HasValue)
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Identity != null)
            {
                writer.WritePropertyName("identity"u8);
                var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                JsonSerializer.Serialize(writer, Identity, serializeOptions);
            }
            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (!(ActiveDirectories is ChangeTrackingList<NetAppAccountActiveDirectory> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("activeDirectories"u8);
                writer.WriteStartArray();
                foreach (var item in ActiveDirectories)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Encryption != null)
            {
                writer.WritePropertyName("encryption"u8);
                writer.WriteObjectValue(Encryption);
            }
            if (options.Format != "W" && DisableShowmount.HasValue)
            {
                if (DisableShowmount != null)
                {
                    writer.WritePropertyName("disableShowmount"u8);
                    writer.WriteBooleanValue(DisableShowmount.Value);
                }
                else
                {
                    writer.WriteNull("disableShowmount");
                }
            }
            if (NfsV4IdDomain != null)
            {
                if (NfsV4IdDomain != null)
                {
                    writer.WritePropertyName("nfsV4IDDomain"u8);
                    writer.WriteStringValue(NfsV4IdDomain);
                }
                else
                {
                    writer.WriteNull("nfsV4IDDomain");
                }
            }
            if (options.Format != "W" && IsMultiAdEnabled.HasValue)
            {
                if (IsMultiAdEnabled != null)
                {
                    writer.WritePropertyName("isMultiAdEnabled"u8);
                    writer.WriteBooleanValue(IsMultiAdEnabled.Value);
                }
                else
                {
                    writer.WriteNull("isMultiAdEnabled");
                }
            }
            writer.WriteEndObject();
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

        NetAppAccountData IJsonModel<NetAppAccountData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppAccountData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetAppAccountData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetAppAccountData(document.RootElement, options);
        }

        internal static NetAppAccountData DeserializeNetAppAccountData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            Optional<ManagedServiceIdentity> identity = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> provisioningState = default;
            IList<NetAppAccountActiveDirectory> activeDirectories = default;
            Optional<NetAppAccountEncryption> encryption = default;
            Optional<bool?> disableShowmount = default;
            Optional<string> nfsV4IdDomain = default;
            Optional<bool?> isMultiAdEnabled = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText(), serializeOptions);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("activeDirectories"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NetAppAccountActiveDirectory> array = new List<NetAppAccountActiveDirectory>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetAppAccountActiveDirectory.DeserializeNetAppAccountActiveDirectory(item, options));
                            }
                            activeDirectories = array;
                            continue;
                        }
                        if (property0.NameEquals("encryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryption = NetAppAccountEncryption.DeserializeNetAppAccountEncryption(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("disableShowmount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                disableShowmount = null;
                                continue;
                            }
                            disableShowmount = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("nfsV4IDDomain"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                nfsV4IdDomain = null;
                                continue;
                            }
                            nfsV4IdDomain = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isMultiAdEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                isMultiAdEnabled = null;
                                continue;
                            }
                            isMultiAdEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetAppAccountData(
                id,
                name,
                type,
                systemData.Value,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                Optional.ToNullable(etag),
                identity,
                provisioningState.Value,
                activeDirectories ?? new ChangeTrackingList<NetAppAccountActiveDirectory>(),
                encryption.Value,
                Optional.ToNullable(disableShowmount),
                nfsV4IdDomain.Value,
                Optional.ToNullable(isMultiAdEnabled),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetAppAccountData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppAccountData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetAppAccountData)} does not support '{options.Format}' format.");
            }
        }

        NetAppAccountData IPersistableModel<NetAppAccountData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetAppAccountData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetAppAccountData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetAppAccountData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetAppAccountData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
