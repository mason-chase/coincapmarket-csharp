using Azihub.Appstract.ApiClient;
using Mc2.CoinMarketCap.NetStandard.ClientEndpoints.ClientProperties;
using Mc2.CoinMarketCap.NetStandard.ClientEndpoints.CryptoIdMap;
using Mc2.CoinMarketCap.NetStandard.ClientEndpoints.CryptoInfo;

namespace Mc2.CoinMarketCap.NetStandard.ClientEndpoints
{
    public interface ICoinMarketCapClient
    {
        /// <summary>
        /// Returns a paginated list of all cryptocurrencies by CoinMarketCap ID.
        /// We recommend using this convenience endpoint to lookup and utilize our unique cryptocurrency id across all endpoints as typical identifiers like ticker symbols can match multiple cryptocurrencies and change over time. As a convenience you may pass a comma-separated list of cryptocurrency symbols as symbol to filter this list to only those you require.
        /// </summary>
        IdMapResponse GetCryptocurrencyIdMap(IdMapRequest request);

        /// <summary>
        /// Returns all static metadata for one or more cryptocurrencies including name, symbol, logo, and its various registered URLs.
        /// <see href="https://coinmarketcap.com/api/documentation/v1/#operation/getV1CryptocurrencyInfo" />
        /// </summary>
        CryptoInfoResponse GetCryptocurrencyInfo(CryptoInfoRequest request);

    }
}