using System;
using Newtonsoft.Json;

namespace CoinMarketCap.NetStandard.ClientEndpoints.CryptoInfo.ResponseProperties
{
    public class UrlLinks
    {
        [JsonProperty("website")]
        public Uri[] Website { get; set; }

        [JsonProperty("source_code")]
        public Uri[] SourceCode { get; set; }
        
        [JsonProperty("twitter")]
        public Uri[] Twitter { get; set; }
        
        [JsonProperty("explorer")]
        public Uri[] Explorer { get; set; }

        [JsonProperty("message_board")]
        public Uri[] MessageBoard { get; set; }

        [JsonProperty("chat")]
        public object[] Chat { get; set; }

        [JsonProperty("announcement")]
        public object[] Announcement { get; set; }

        [JsonProperty("reddit")]
        public Uri[] Reddit { get; set; }

    }
}
