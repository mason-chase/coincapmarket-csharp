using System.Collections.Generic;
using System.Net.Http;
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
        public CryptoInfoResponse GetCryptocurrencyInfo(CryptoInfoRequest request)
        {
            CryptoInfoResponse httpResponse = SendJsonRequest<CryptoInfoResponse, CoinResponse<Dictionary<string, Metadata>>, CoinErrorResponse>(HttpMethod.Get, request, "cryptocurrency/info");
            // Adapt Dictionary<string, CryptoInfo> to InfoResponse Object's 
            //return new CoinResponse<CryptoInfoResponse>
            //{
            //    Status = responseDict.Status,
            //    Data = new CryptoInfoResponse {  MetadataDict = responseDict.Data }
            //};
            return httpResponse;
        }
    }
}
