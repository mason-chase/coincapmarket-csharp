using Newtonsoft.Json;

namespace Mc2.CoinMarketCap.NetStandard.ClientEndpoints.ClientProperties
{
    public class CoinResponse<T>
    {

        [JsonProperty("data")]
        public T CoinData { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }
    }
}
