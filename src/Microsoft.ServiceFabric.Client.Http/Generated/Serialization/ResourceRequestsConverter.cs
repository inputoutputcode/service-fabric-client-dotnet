// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.ServiceFabric.Client.Http.Serialization
{
    using System;
    using System.Collections.Generic;
    using Microsoft.ServiceFabric.Common;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Converter for <see cref="ResourceRequests" />.
    /// </summary>
    internal class ResourceRequestsConverter
    {
        /// <summary>
        /// Deserializes the JSON representation of the object.
        /// </summary>
        /// <param name="reader">The <see cref="T: Newtonsoft.Json.JsonReader" /> to read from.</param>
        /// <returns>The object Value.</returns>
        internal static ResourceRequests Deserialize(JsonReader reader)
        {
            return reader.Deserialize(GetFromJsonProperties);
        }

        /// <summary>
        /// Gets the object from Json properties.
        /// </summary>
        /// <param name="reader">The <see cref="T: Newtonsoft.Json.JsonReader" /> to read from, reader must be placed at first property.</param>
        /// <returns>The object Value.</returns>
        internal static ResourceRequests GetFromJsonProperties(JsonReader reader)
        {
            var memoryInGB = default(double?);
            var cpu = default(double?);

            do
            {
                var propName = reader.ReadPropertyName();
                if (string.Compare("memoryInGB", propName, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    memoryInGB = reader.ReadValueAsDouble();
                }
                else if (string.Compare("cpu", propName, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    cpu = reader.ReadValueAsDouble();
                }
                else
                {
                    reader.SkipPropertyValue();
                }
            }
            while (reader.TokenType != JsonToken.EndObject);

            return new ResourceRequests(
                memoryInGB: memoryInGB,
                cpu: cpu);
        }

        /// <summary>
        /// Serializes the object to JSON.
        /// </summary>
        /// <param name="writer">The <see cref="T: Newtonsoft.Json.JsonWriter" /> to write to.</param>
        /// <param name="obj">The object to serialize to JSON.</param>
        internal static void Serialize(JsonWriter writer, ResourceRequests obj)
        {
            // Required properties are always serialized, optional properties are serialized when not null.
            writer.WriteStartObject();
            writer.WriteProperty(obj.MemoryInGB, "memoryInGB", JsonWriterExtensions.WriteDoubleValue);
            writer.WriteProperty(obj.Cpu, "cpu", JsonWriterExtensions.WriteDoubleValue);
            writer.WriteEndObject();
        }
    }
}
