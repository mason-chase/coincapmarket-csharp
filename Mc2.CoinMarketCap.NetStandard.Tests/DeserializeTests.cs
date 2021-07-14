using Azihub.Utilities.Base.Tests;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using Xunit;
using Xunit.Abstractions;
using System.Collections.Generic;
using Mc2.CoinMarketCap.NetStandard.ClientEndpoints.ClientProperties;
using Mc2.CoinMarketCap.NetStandard.ClientEndpoints.CryptoInfo.ResponseProperties;

namespace CoinMarketCap.NetStandard.Tests
{
    public class DeserializeTests : TestBase
    {
        public DeserializeTests(ITestOutputHelper output) : base(output) { }

        private static char Ds => Path.DirectorySeparatorChar;

        [Fact]
        public void ParseCryptoCurrencyInfoTest()
        {
            string fullJsonPath = $"Samples{Ds}CryptocurrencyInfo.json";
            string sample = File.ReadAllText(fullJsonPath);
            CoinResponse<Dictionary<string, Metadata>> response = JsonConvert.DeserializeObject<CoinResponse<Dictionary<string, Metadata>>> (sample) ;

            Output.WriteLine($"Parsed count: {response?.CoinData.Count} "+
                $"First's name: {response?.CoinData.First().Value.Name}");
            Assert.Equal("Bitcoin", response?.CoinData.First().Value.Name);
        }
    }
}