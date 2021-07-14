using System.Collections.Generic;
using Mc2.CoinMarketCap.NetStandard.ClientEndpoints.ClientProperties;
using Mc2.CoinMarketCap.NetStandard.ClientEndpoints.CryptoInfo;
using Mc2.CoinMarketCap.NetStandard.ClientEndpoints.CryptoInfo.ResponseProperties;

namespace Mc2.CoinMarketCap.NetStandard.ClientEndpoints
{
    public partial class CoinMarketCapClient
    {


        /// <summary>
        /// Returns all static metadata for one or more cryptocurrencies including name, symbol, logo, and its various registered URLs.
        /// <see href="https://coinmarketcap.com/api/documentation/v1/#operation/getV1CryptocurrencyInfo" />
        /// </summary>
        public Response<CryptoInfoResponse> GetCryptocurrencyInfo(CryptoInfoRequest request)
        {
            Response<Dictionary<string, Metadata>> responseDict = SendApiRequest<Dictionary<string, Metadata>>(request, "cryptocurrency/info");
            // Adapt Dictionary<string, CryptoInfo> to InfoResponse Object's 
            return new Response<CryptoInfoResponse>
            {
                Status = responseDict.Status,
                Data = new CryptoInfoResponse {  MetadataDict = responseDict.Data }
            };
        }
    }
}
