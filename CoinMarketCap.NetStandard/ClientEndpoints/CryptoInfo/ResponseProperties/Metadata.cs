using System;
using Newtonsoft.Json;

namespace CoinMarketCap.NetStandard.ClientEndpoints.CryptoInfo.ResponseProperties
{
    public class Metadata
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("logo")]
        public Uri Logo { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("urls")]
        public UrlLinks UrlLinks { get; set; }
    }
}
