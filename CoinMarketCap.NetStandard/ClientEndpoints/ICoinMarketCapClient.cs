using CoinMarketCap.NetStandard.ClientEndpoints.ClientProperties;
using CoinMarketCap.NetStandard.ClientEndpoints.CryptoInfo;

namespace CoinMarketCap.NetStandard.ClientEndpoints
{
    public interface ICoinMarketCapClient
    {
        /// <summary>
        /// Returns all static metadata for one or more cryptocurrencies including name, symbol, logo, and its various registered URLs.
        /// <see href="https://coinmarketcap.com/api/documentation/v1/#operation/getV1CryptocurrencyInfo" />
        /// </summary>
        Response<CryptoInfoResponse> GetCryptocurrencyInfo(CryptoInfoRequest request);
    }
}