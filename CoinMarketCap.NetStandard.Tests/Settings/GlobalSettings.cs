using Azihub.Utilities.Base.Settings.Interfaces;

namespace CoinMarketCap.NetStandard.Tests.Settings
{
    public class GlobalSettings : IGlobalSettings
    {
        public string CoinmarketcapApiKey { get; set; }
    }
}
