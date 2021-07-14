using Newtonsoft.Json;

namespace CoinMarketCap.NetStandard.Models.Global
{
    public class AggregateMarketMetricsParams
    {
        [JsonProperty("convert")]
        public string Convert { get; set; }
    }
}