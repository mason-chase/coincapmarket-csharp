using System.Collections.Generic;
using System.Net.Http;
using Mc2.CoinMarketCap.NetStandard.ClientEndpoints.ClientProperties;
using Mc2.CoinMarketCap.NetStandard.ClientEndpoints.CryptoIdMap;
using Mc2.CoinMarketCap.NetStandard.ClientEndpoints.CryptoIdMap.ResponseProperties;

namespace Mc2.CoinMarketCap.NetStandard.ClientEndpoints
{
    public partial class CoinMarketCapClient
    {
        /// <summary>
        /// Returns a paginated list of all cryptocurrencies by CoinMarketCap ID.
        /// We recommend using this convenience endpoint to lookup and utilize our unique cryptocurrency id across all endpoints as typical identifiers like ticker symbols can match multiple cryptocurrencies and change over time. As a convenience you may pass a comma-separated list of cryptocurrency symbols as symbol to filter this list to only those you require.
        /// </summary>
        public IdMapResponse GetCryptocurrencyIdMap(IdMapRequest request)
        {
            var response = SendJsonRequest<IdMapResponse, CoinResponse<List<IdMap>>, CoinErrorResponse>(HttpMethod.Get, request, "cryptocurrency/map");
            return response;
        }
    }
}