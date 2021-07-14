using Newtonsoft.Json;

namespace CoinMarketCap.NetStandard.ClientEndpoints.CryptoIdMap
{
    public class IdMapRequest
    {
        [JsonProperty("listing_status")]
        public string ListingStatus { get; set; }

        [JsonProperty("start")]
        public long? Start { get; set; }

        [JsonProperty("limit")]
        public uint Limit { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("sort")]
        public string Sort { get; set; }
    }
}
