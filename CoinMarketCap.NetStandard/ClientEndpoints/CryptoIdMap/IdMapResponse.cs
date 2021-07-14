using System.Collections.Generic;
using CoinMarketCap.NetStandard.ClientEndpoints.CryptoIdMap.ResponseProperties;

namespace CoinMarketCap.NetStandard.ClientEndpoints.CryptoIdMap
{
    public class IdMapResponse
    {
        public List<IdMap> IdMaps { get; set; }
    }
}