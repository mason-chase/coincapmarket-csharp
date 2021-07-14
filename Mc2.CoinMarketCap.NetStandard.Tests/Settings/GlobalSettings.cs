using Azihub.Utilities.Base.Settings.Interfaces;

namespace Mc2.CoinMarketCap.NetStandard.Tests.Settings
{
    public class GlobalSettings : IGlobalSettings
    {
        public string CoinmarketcapApiKey { get; set; }
    }
}
