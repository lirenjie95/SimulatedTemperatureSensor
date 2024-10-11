// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Newtonsoft.Json;

namespace SimulatedTemperatureSensorModule
{
    public class MessageBody
    {
        [JsonProperty("orders")]
        public Orders orders { get; set; }
        [JsonProperty("defects")]
        public Defects defects { get; set; }
        [JsonProperty("timeCreated")]
        public string TimeCreated { get; set; }
    }

    [JsonObject("orders")]
    public class Orders
    {
        [JsonProperty("typeA")]
        public int typeA { get; set; }
        [JsonProperty("typeB")]
        public int typeB { get; set; }
        [JsonProperty("typeC")]
        public int typeC { get; set; }
    }

    [JsonObject("defects")]
    public class Defects
    {
        [JsonProperty("typeA")]
        public int typeA { get; set; }
        [JsonProperty("typeB")]
        public int typeB { get; set; }
        [JsonProperty("typeC")]
        public int typeC { get; set; }
    }
}