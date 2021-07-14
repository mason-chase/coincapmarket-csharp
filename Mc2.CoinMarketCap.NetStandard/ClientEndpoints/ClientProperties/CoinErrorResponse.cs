using Newtonsoft.Json;

namespace Mc2.CoinMarketCap.NetStandard.ClientEndpoints.ClientProperties
{
    public class CoinErrorResponse 
    {
        [JsonProperty("status")]
        public Status Status { get; set; }
    }
}
