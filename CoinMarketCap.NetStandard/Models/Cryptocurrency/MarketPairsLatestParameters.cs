using Newtonsoft.Json;

namespace CoinMarketCap.NetStandard.Models.Cryptocurrency
{
    public class MarketPairsLatestParameters
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("start")]
        public long? Start { get; set; }

        /// <summary>
        /// 1-5000
        /// </summary>
        [JsonProperty("limit")]
        public long? Limit { get; set; }

        [JsonProperty("convert")]
        public string Convert { get; set; }
    }
}
