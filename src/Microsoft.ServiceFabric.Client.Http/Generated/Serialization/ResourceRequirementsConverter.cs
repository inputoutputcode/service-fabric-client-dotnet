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
    /// Converter for <see cref="ResourceRequirements" />.
    /// </summary>
    internal class ResourceRequirementsConverter
    {
        /// <summary>
        /// Deserializes the JSON representation of the object.
        /// </summary>
        /// <param name="reader">The <see cref="T: Newtonsoft.Json.JsonReader" /> to read from.</param>
        /// <returns>The object Value.</returns>
        internal static ResourceRequirements Deserialize(JsonReader reader)
        {
            return reader.Deserialize(GetFromJsonProperties);
        }

        /// <summary>
        /// Gets the object from Json properties.
        /// </summary>
        /// <param name="reader">The <see cref="T: Newtonsoft.Json.JsonReader" /> to read from, reader must be placed at first property.</param>
        /// <returns>The object Value.</returns>
        internal static ResourceRequirements GetFromJsonProperties(JsonReader reader)
        {
            var requests = default(ResourceRequests);
            var limits = default(ResourceLimits);

            do
            {
                var propName = reader.ReadPropertyName();
                if (string.Compare("requests", propName, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    requests = ResourceRequestsConverter.Deserialize(reader);
                }
                else if (string.Compare("limits", propName, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    limits = ResourceLimitsConverter.Deserialize(reader);
                }
                else
                {
                    reader.SkipPropertyValue();
                }
            }
            while (reader.TokenType != JsonToken.EndObject);

            return new ResourceRequirements(
                requests: requests,
                limits: limits);
        }

        /// <summary>
        /// Serializes the object to JSON.
        /// </summary>
        /// <param name="writer">The <see cref="T: Newtonsoft.Json.JsonWriter" /> to write to.</param>
        /// <param name="obj">The object to serialize to JSON.</param>
        internal static void Serialize(JsonWriter writer, ResourceRequirements obj)
        {
            // Required properties are always serialized, optional properties are serialized when not null.
            writer.WriteStartObject();
            writer.WriteProperty(obj.Requests, "requests", ResourceRequestsConverter.Serialize);
            if (obj.Limits != null)
            {
                writer.WriteProperty(obj.Limits, "limits", ResourceLimitsConverter.Serialize);
            }

            writer.WriteEndObject();
        }
    }
}
