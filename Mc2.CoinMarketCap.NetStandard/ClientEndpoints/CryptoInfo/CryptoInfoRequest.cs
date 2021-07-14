using System;
using Mc2.CoinMarketCap.NetStandard.ClientEndpoints.CryptoInfo.RequestProperties;

namespace Mc2.CoinMarketCap.NetStandard.ClientEndpoints.CryptoInfo
{
    /// <summary>
    /// Aka: Metadata
    /// <see href="https://coinmarketcap.com/api/documentation/v1/#operation/getV1CryptocurrencyInfo" />
    /// </summary>
    public class CryptoInfoRequest
    {
        /// <summary>
        /// Metadata query by id[]
        /// </summary>
        /// <param name="id"></param>
        public CryptoInfoRequest(long[] id)
        {
            Id = string.Join(",", id);
        }

        /// <summary>
        /// Metadata query by Slug or Symbol
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value"></param>
        public CryptoInfoRequest(RequestType type, string[] value)
        {
            if (type == RequestType.Symbol)
                Id = string.Join(",", value);

            else if (type == RequestType.Slug)
                Slug = string.Join(",", value);
            else
                throw new ArgumentException($"Bad MetadataQueryType value: {type}");
        }

        public string Id { get; set; }
        public string Symbols { get; set; }
        public string Slug { get; set; }
    }

}
