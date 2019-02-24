using System;
using System.Collections.Generic;
using RestSharp;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Configuration;

namespace RoadStatus
{
    public class TfLRoadStatus_ErrorDTO
    {
        [JsonProperty("$type")]
        public string Type { get; set; }

        [JsonProperty("timestampUtc")]
        public DateTimeOffset TimestampUtc { get; set; }

        [JsonProperty("exceptionType")]
        public string ExceptionType { get; set; }

        [JsonProperty("httpStatusCode")]
        public long HttpStatusCode { get; set; }

        [JsonProperty("httpStatus")]
        public string HttpStatus { get; set; }

        [JsonProperty("relativeUri")]
        public string RelativeUri { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        public static TfLRoadStatus_ErrorDTO FromJson(string json) => JsonConvert.DeserializeObject<TfLRoadStatus_ErrorDTO>(json, RoadStatus.Utils.Converter.Settings);
    }
}

