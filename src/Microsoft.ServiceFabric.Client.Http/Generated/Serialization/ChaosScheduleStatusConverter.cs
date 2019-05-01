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
    /// Converter for <see cref="ChaosScheduleStatus" />.
    /// </summary>
    internal class ChaosScheduleStatusConverter
    {
        /// <summary>
        /// Gets the enum value by reading string value from reader.
        /// </summary>
        /// <param name="reader">The <see cref="T: Newtonsoft.Json.JsonReader" /> to read from, reader must be placed at first property.</param>
        /// <returns>The enum Value.</returns>
        public static ChaosScheduleStatus? Deserialize(JsonReader reader)
        {
            var value = reader.ReadValueAsString();
            var obj = default(ChaosScheduleStatus);

            if (string.Compare(value, "Invalid", StringComparison.OrdinalIgnoreCase) == 0)
            {
                obj = ChaosScheduleStatus.Invalid;
            }
            else if (string.Compare(value, "Stopped", StringComparison.OrdinalIgnoreCase) == 0)
            {
                obj = ChaosScheduleStatus.Stopped;
            }
            else if (string.Compare(value, "Active", StringComparison.OrdinalIgnoreCase) == 0)
            {
                obj = ChaosScheduleStatus.Active;
            }
            else if (string.Compare(value, "Expired", StringComparison.OrdinalIgnoreCase) == 0)
            {
                obj = ChaosScheduleStatus.Expired;
            }
            else if (string.Compare(value, "Pending", StringComparison.OrdinalIgnoreCase) == 0)
            {
                obj = ChaosScheduleStatus.Pending;
            }

            return obj;
        }

        /// <summary>
        /// Serializes the enum value.
        /// </summary>
        /// <param name="writer">The <see cref="T: Newtonsoft.Json.JsonWriter" /> to write to.</param>
        /// <param name="value">The object to serialize to JSON.</param>
        public static void Serialize(JsonWriter writer, ChaosScheduleStatus? value)
        {
            switch (value)
            {
                case ChaosScheduleStatus.Invalid:
                    writer.WriteStringValue("Invalid");
                    break;
                case ChaosScheduleStatus.Stopped:
                    writer.WriteStringValue("Stopped");
                    break;
                case ChaosScheduleStatus.Active:
                    writer.WriteStringValue("Active");
                    break;
                case ChaosScheduleStatus.Expired:
                    writer.WriteStringValue("Expired");
                    break;
                case ChaosScheduleStatus.Pending:
                    writer.WriteStringValue("Pending");
                    break;
                default:
                    throw new ArgumentException($"Invalid value {value.ToString()} for enum type ChaosScheduleStatus");
            }
        }
    }
}
