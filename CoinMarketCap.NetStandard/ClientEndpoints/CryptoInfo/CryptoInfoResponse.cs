using System.Collections.Generic;
using CoinMarketCap.NetStandard.ClientEndpoints.CryptoInfo.ResponseProperties;

namespace CoinMarketCap.NetStandard.ClientEndpoints.CryptoInfo
{
    public class CryptoInfoResponse
    {
        /// <summary>
        /// string is CMC's ID for a crypto , which is same as CryptoInfo.Id
        /// </summary>
        public Dictionary<string,Metadata> MetadataDict { get; set; }
    }
}
