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
            Response<Dictionary<string, Metadata>> response = JsonConvert.DeserializeObject<Response<Dictionary<string, Metadata>>> (sample) ;

            Output.WriteLine($"Parsed count: {response?.Data.Count} "+
                $"First's name: {response?.Data.First().Value.Name}");
            Assert.Equal("Bitcoin", response?.Data.First().Value.Name);
        }
    }
}