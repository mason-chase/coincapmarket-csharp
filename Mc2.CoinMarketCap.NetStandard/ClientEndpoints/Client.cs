using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Azihub.Utilities.Base.Extensions.Object;
using Mc2.CoinMarketCap.NetStandard.ClientEndpoints.CryptoIdMap;
using Mc2.CoinMarketCap.NetStandard.ClientEndpoints.CryptoIdMap.ResponseProperties;
using Mc2.CoinMarketCap.NetStandard.ClientEndpoints.CryptoInfo;
using Mc2.CoinMarketCap.NetStandard.ClientEndpoints.ClientProperties;
using Mc2.CoinMarketCap.NetStandard.ClientEndpoints.Exceptions;
using Mc2.CoinMarketCap.NetStandard.Models.Cryptocurrency;
using Mc2.CoinMarketCap.NetStandard.Models.Global;
using Newtonsoft.Json;
using Azihub.Appstract.ApiClient;
#if DEBUG
#endif

namespace Mc2.CoinMarketCap.NetStandard.ClientEndpoints
{

    public partial class CoinMarketCapClient : ApiClientBase, ICoinMarketCapClient
    {


        public CoinMarketCapClient(string apiKey) : base(new Uri("https://pro-api.coinmarketcap.com/v1/"))
        {
            DefaultRequestHeaders.Add("X-CMC_PRO_API_KEY", apiKey);
            DefaultRequestHeaders.Add("Accept", "application/json");
        }


        /// <summary>
        /// Get a paginated list of all cryptocurrencies with latest market data. You can configure this call to sort by market cap or another market ranking field. Use the "convert" option to return market values in multiple fiat and cryptocurrency conversions in the same call.
        /// </summary>
        //public CoinResponse<List<CryptocurrencyWithLatestQuote>> GetLatestListings(ListingLatestParameters request)
        //{
        //    return SendApiRequest<List<CryptocurrencyWithLatestQuote>, CoinResponse>(request, "cryptocurrency/listings/latest");
        //}

        /// <summary>
        /// Get a paginated list of all cryptocurrencies with market data for a given historical time. Use the "convert" option to return market values in multiple fiat and cryptocurrency conversions in the same call.
        /// </summary>
        //public CoinResponse<List<CryptocurrencyWithHistoricalQuote>> GetHistoricalListings(ListingHistoricalParameters request)
        //{
        //    return SendApiRequest<List<CryptocurrencyWithHistoricalQuote>>(request, "cryptocurrency/listings/historical");
        //}

        /// <summary>
        /// Lists all market pairs for the specified cryptocurrency with associated stats. Use the "convert" option to return market values in multiple fiat and cryptocurrency conversions in the same call.
        /// </summary>
        //public CoinResponse<MarketPairLatestResponse> GetMarketPairLatest(MarketPairsLatestParameters request)
        //{
        //    return SendApiRequest<MarketPairLatestResponse>(request, "cryptocurrency/market-pairs/latest");
        //}

        /// <summary>
        /// Return an interval of historic OHLCV (Open, High, Low, Close, Volume) market quotes for a cryptocurrency. Currently daily and hourly OHLCV periods are supported.
        /// </summary>
        //public CoinResponse<OhlcvHistoricalResponse> GetOhlcvHistorical(OhlcvHistoricalParameters request)
        //{
        //    return SendApiRequest<OhlcvHistoricalResponse>(request, "cryptocurrency/ohlcv/historical");
        //}

        /// <summary>
        /// Get the latest market quote for 1 or more cryptocurrencies. Use the "convert" option to return market values in multiple fiat and cryptocurrency conversions in the same call.
        /// </summary>
        //public CoinResponse<Dictionary<string, CryptocurrencyWithLatestQuote>> GetLatestQuote(LatestQuoteParameters request)
        //{
        //    return SendApiRequest<Dictionary<string, CryptocurrencyWithLatestQuote>>(request, "cryptocurrency/quotes/latest");
        //}

        /// <summary>
        /// Returns an interval of historic market quotes for any cryptocurrency based on time and interval parameters.
        /// </summary>
        //public CoinResponse<CryptocurrencyWithHistoricalQuote> GetHistoricalQuote(HistoricalQuoteParameters request)
        //{
        //    return SendApiRequest<CryptocurrencyWithHistoricalQuote>(request, "cryptocurrency/quotes/historical");
        //}

        /// <summary>
        /// Get the latest quote of aggregate market metrics. Use the "convert" option to return market values in multiple fiat and cryptocurrency conversions in the same call.
        /// </summary>
        //public CoinResponse<AggregateMarketMetrics> GetAggregateMarketMetrics(AggregateMarketMetricsParams request)
        //{
        //    return SendApiRequest<AggregateMarketMetrics>(request, "global-metrics/quotes/latest");
        //}

//        private Response<T> SendApiRequest<T>(object requestParams, string endpoint)
//        {
//            string queryParams = requestParams.GetQueryString(SelectCase.PascalToSnakeCase);
//            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, $"{endpoint}?{queryParams}");
//            HttpResponseMessage responseMessage = HttpClient.SendAsync(requestMessage).GetAwaiter().GetResult();
//            string body = responseMessage.Content.ReadAsStringAsync().GetAwaiter().GetResult();

//            try
//            {
//                if (responseMessage.IsSuccessStatusCode)
//                    return JsonConvert.DeserializeObject<Response<T>>(body);

//            }
//            catch (JsonSerializationException ex)
//            {
//#if DEBUG
//                Debugger.Log(1, "Error", ex.Message);
//                Debugger.Break();

//#else
//                throw new BadServerResponseException(responseMessage, body);
//#endif
//            }

//            Response<T> response = JsonConvert.DeserializeObject<Response<T>>(body);

//            if (response is null)
//            {
//                throw new BadServerResponseException(responseMessage);
//            }
//            else if (response.Status is null)
//            {
//                throw new BadServerResponseException(responseMessage, body);
//            }
//            else
//                throw new BadRequestException(response?.Status);
//        }
    }
}