using System.Collections.Generic;
using System.Net.Http;
using Azihub.Appstract.ApiClient;
using Mc2.CoinMarketCap.NetStandard.ClientEndpoints.ClientProperties;
using Mc2.CoinMarketCap.NetStandard.ClientEndpoints.CryptoIdMap.ResponseProperties;

namespace Mc2.CoinMarketCap.NetStandard.ClientEndpoints.CryptoIdMap
{
    public class IdMapResponse : HttpResponse<CoinResponse<List<IdMap>>, CoinErrorResponse>, 
                                 IHttpResponse<CoinResponse<List<IdMap>>, CoinErrorResponse>
    {
        public IdMapResponse(CoinResponse<List<IdMap>> dataSuccess, HttpRequestMessage request, HttpResponseMessage response) : 
            base(dataSuccess, request, response)
        {
        }

        public IdMapResponse(CoinErrorResponse dataFailed, HttpRequestMessage request, HttpResponseMessage response) : 
            base(dataFailed, request, response)
        {
        }
    }
}