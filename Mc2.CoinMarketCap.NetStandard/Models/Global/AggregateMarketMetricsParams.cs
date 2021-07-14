using Newtonsoft.Json;

namespace Mc2.CoinMarketCap.NetStandard.Models.Global
{
    public class AggregateMarketMetricsParams
    {
        [JsonProperty("convert")]
        public string Convert { get; set; }
    }
}