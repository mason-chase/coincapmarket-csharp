using Azihub.Appstract.ApiClient;
using System.Collections.Generic;
using Mc2.CoinMarketCap.NetStandard.ClientEndpoints.CryptoInfo.ResponseProperties;
using Mc2.CoinMarketCap.NetStandard.ClientEndpoints.ClientProperties;
using System.Net.Http;

namespace Mc2.CoinMarketCap.NetStandard.ClientEndpoints.CryptoInfo
{
    /// <summary>
    /// CoinMarketCap is returning improperty dictionary of <string,Metadata> in "data" field:
    /// string is CMC's ID for a crypto , which is same as CryptoInfo.Id
    /// </summary>
    public class CryptoInfoResponse : HttpResponse<CoinResponse<Dictionary<string, Metadata>>, CoinErrorResponse>, IHttpResponse<CoinResponse<Dictionary<string, Metadata>>, CoinErrorResponse>
    {
        public CryptoInfoResponse(CoinResponse<Dictionary<string, Metadata>> dataSuccess, HttpRequestMessage request, HttpResponseMessage response) :
            base(dataSuccess, request, response)
        {
        }

        public CryptoInfoResponse(CoinErrorResponse dataFailed, HttpRequestMessage request, HttpResponseMessage response) :
            base(dataFailed, request, response)
        {
        }
    }
}
