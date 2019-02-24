using System;
using System.Collections.Generic;
using RestSharp;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Configuration;

namespace RoadStatus
{

    public class TflRoadStatus_DTO
    {
        [JsonProperty("$type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("statusSeverity")]
        public string StatusSeverity { get; set; }

        [JsonProperty("statusSeverityDescription")]
        public string StatusSeverityDescription { get; set; }

        [JsonProperty("bounds")]
        public string Bounds { get; set; }

        [JsonProperty("envelope")]
        public string Envelope { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        public static List<TflRoadStatus_DTO> FromJson(string json) => JsonConvert.DeserializeObject<List<TflRoadStatus_DTO>>(json, RoadStatus.Utils.Converter.Settings);
    }
}

