using System.Collections.Generic;
using Mc2.CoinMarketCap.NetStandard.ClientEndpoints.CryptoIdMap.ResponseProperties;

namespace Mc2.CoinMarketCap.NetStandard.ClientEndpoints.CryptoIdMap
{
    public class IdMapResponse
    {
        public List<IdMap> IdMaps { get; set; }
    }
}