using System.Collections.Generic;
using System.Linq;
using Azihub.Appstract.ApiClient;
using Azihub.Utilities.Base.Tests;
using Mc2.CoinMarketCap.NetStandard.ClientEndpoints;
using Mc2.CoinMarketCap.NetStandard.ClientEndpoints.ClientProperties;
using Mc2.CoinMarketCap.NetStandard.ClientEndpoints.CryptoIdMap;
using Mc2.CoinMarketCap.NetStandard.ClientEndpoints.CryptoInfo;
using Mc2.CoinMarketCap.NetStandard.Options;
using Xunit;
using Xunit.Abstractions;
using static Mc2.CoinMarketCap.NetStandard.Tests.Settings.AppSettings;

namespace CoinMarketCap.NetStandard.Tests
{
    public class CoinMarketCapTests : TestBase
    {
        public CoinMarketCapTests(ITestOutputHelper output) : base(output) { }
        [Fact]
        public void CryptoInfoSuccess()
        {
            CoinMarketCapClient client = new CoinMarketCapClient(Global.CoinmarketcapApiKey);
            long[] ids = {
                CryptocurrencyId.BITCOIN,
                CryptocurrencyId.LITECOIN,
                CryptocurrencyId.MONERO,
                CryptocurrencyId.ETHEREUM,
                CryptocurrencyId.NANO,
                CryptocurrencyId.IOTA,
                CryptocurrencyId.EOS,
                CryptocurrencyId.BINANCE_COIN,
                CryptocurrencyId.CHAIN_LINK,
            };
            
            CryptoInfoRequest request = new CryptoInfoRequest(ids);

            CryptoInfoResponse response = client.GetCryptocurrencyInfo(request);

            // Assumes the response is successful: DataSuccess
            Output.WriteLine( $"Usage: {response.DataSuccess.Status.ErrorMessage}"+
                string.Join(",\n", response.DataSuccess.CoinData.Values.Select(c => string.Concat(c.Id, ":", c.Name, ":", c.Symbol,":Logo=",c.Logo)).ToArray())
            );
            //var listingsResponse = await client.GetCryptocurrencyIdMapAsync(new IdMapParameters { Symbol = "LINK" }, CancellationToken.None);

        }

        [Fact]
        public void CryptoInfoFailed()
        {
            CoinMarketCapClient client = new CoinMarketCapClient(Global.CoinmarketcapApiKey);
            long[] ids = { 0 };

            CryptoInfoRequest request = new CryptoInfoRequest(ids);

            CryptoInfoResponse response = client.GetCryptocurrencyInfo(request);

            Output.WriteLine("Error message: " + response.DataFailed.Status.ErrorMessage);
            Assert.Equal("Invalid value for \"id\": \"0\"",response.DataFailed.Status.ErrorMessage);
            //var listingsResponse = await client.GetCryptocurrencyIdMapAsync(new IdMapParameters { Symbol = "LINK" }, CancellationToken.None);

        }

        [Fact]
        public void CryptoIdMapSuccess()
        {
            CoinMarketCapClient client = new CoinMarketCapClient(Global.CoinmarketcapApiKey);
            
            IdMapRequest request = new IdMapRequest{Limit = 5000, Sort = "id"};

            IdMapResponse response = client.GetCryptocurrencyIdMap(request);
            Output.WriteLine( $"Usage: {response.DataSuccess.Status.ErrorMessage}"+
                              string.Join(",\n", response.DataSuccess.CoinData.Select(c => string.Concat(c.Id, ":", c.Name, ":", c.Symbol,":Logo=",c.IsActive)).ToArray())
            );
        }
    }
}
