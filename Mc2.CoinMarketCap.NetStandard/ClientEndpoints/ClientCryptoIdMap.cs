using System.Collections.Generic;
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
        public Response<IdMapResponse> GetCryptocurrencyIdMap(IdMapRequest request)
        {
            Response<List<IdMap>> response = SendApiRequest<List<IdMap>>(request, "cryptocurrency/map");
            return new Response<IdMapResponse>
            {
                Status = response.Status,
                Data = new IdMapResponse{ IdMaps = response.Data }
            };
        }
    }
}