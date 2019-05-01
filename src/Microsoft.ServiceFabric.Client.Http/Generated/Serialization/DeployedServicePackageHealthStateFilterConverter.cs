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
    /// Converter for <see cref="DeployedServicePackageHealthStateFilter" />.
    /// </summary>
    internal class DeployedServicePackageHealthStateFilterConverter
    {
        /// <summary>
        /// Deserializes the JSON representation of the object.
        /// </summary>
        /// <param name="reader">The <see cref="T: Newtonsoft.Json.JsonReader" /> to read from.</param>
        /// <returns>The object Value.</returns>
        internal static DeployedServicePackageHealthStateFilter Deserialize(JsonReader reader)
        {
            return reader.Deserialize(GetFromJsonProperties);
        }

        /// <summary>
        /// Gets the object from Json properties.
        /// </summary>
        /// <param name="reader">The <see cref="T: Newtonsoft.Json.JsonReader" /> to read from, reader must be placed at first property.</param>
        /// <returns>The object Value.</returns>
        internal static DeployedServicePackageHealthStateFilter GetFromJsonProperties(JsonReader reader)
        {
            var serviceManifestNameFilter = default(string);
            var servicePackageActivationIdFilter = default(string);
            var healthStateFilter = default(int?);

            do
            {
                var propName = reader.ReadPropertyName();
                if (string.Compare("ServiceManifestNameFilter", propName, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    serviceManifestNameFilter = reader.ReadValueAsString();
                }
                else if (string.Compare("ServicePackageActivationIdFilter", propName, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    servicePackageActivationIdFilter = reader.ReadValueAsString();
                }
                else if (string.Compare("HealthStateFilter", propName, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    healthStateFilter = reader.ReadValueAsInt();
                }
                else
                {
                    reader.SkipPropertyValue();
                }
            }
            while (reader.TokenType != JsonToken.EndObject);

            return new DeployedServicePackageHealthStateFilter(
                serviceManifestNameFilter: serviceManifestNameFilter,
                servicePackageActivationIdFilter: servicePackageActivationIdFilter,
                healthStateFilter: healthStateFilter);
        }

        /// <summary>
        /// Serializes the object to JSON.
        /// </summary>
        /// <param name="writer">The <see cref="T: Newtonsoft.Json.JsonWriter" /> to write to.</param>
        /// <param name="obj">The object to serialize to JSON.</param>
        internal static void Serialize(JsonWriter writer, DeployedServicePackageHealthStateFilter obj)
        {
            // Required properties are always serialized, optional properties are serialized when not null.
            writer.WriteStartObject();
            if (obj.ServiceManifestNameFilter != null)
            {
                writer.WriteProperty(obj.ServiceManifestNameFilter, "ServiceManifestNameFilter", JsonWriterExtensions.WriteStringValue);
            }

            if (obj.ServicePackageActivationIdFilter != null)
            {
                writer.WriteProperty(obj.ServicePackageActivationIdFilter, "ServicePackageActivationIdFilter", JsonWriterExtensions.WriteStringValue);
            }

            if (obj.HealthStateFilter != null)
            {
                writer.WriteProperty(obj.HealthStateFilter, "HealthStateFilter", JsonWriterExtensions.WriteIntValue);
            }

            writer.WriteEndObject();
        }
    }
}
