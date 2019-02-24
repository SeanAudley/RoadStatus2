using System;
using System.Collections.Generic;
using RestSharp;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Configuration;


namespace RoadStatus.Utils
{


    internal static class Serialize
    {
        public static string ToJson(this List<TflRoadStatus_DTO> self) => JsonConvert.SerializeObject(self, RoadStatus.Utils.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
