using System.Collections.Generic;
using System.Linq;
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
            
            Response<CryptoInfoResponse> response = client.GetCryptocurrencyInfo(request);
            Output.WriteLine( $"Usage: {response.Status.ErrorMessage}"+
                string.Join(",\n", response.Data.MetadataDict.Values.Select(c => string.Concat(c.Id, ":", c.Name, ":", c.Symbol,":Logo=",c.Logo)).ToArray())
            );
            //var listingsResponse = await client.GetCryptocurrencyIdMapAsync(new IdMapParameters { Symbol = "LINK" }, CancellationToken.None);

        }

        [Fact]
        public void CryptoIdMapSuccess()
        {
            CoinMarketCapClient client = new CoinMarketCapClient(Global.CoinmarketcapApiKey);
            
            IdMapRequest request = new IdMapRequest{Limit = 5000, Sort = "id"};
            
            Response<IdMapResponse> response = client.GetCryptocurrencyIdMap(request);
            Output.WriteLine( $"Usage: {response.Status.ErrorMessage}"+
                              string.Join(",\n", response.Data.IdMaps.Select(c => string.Concat(c.Id, ":", c.Name, ":", c.Symbol,":Logo=",c.IsActive)).ToArray())
            );
        }
        
    }
}
