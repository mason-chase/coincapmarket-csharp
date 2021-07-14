using System;
using CoinMarketCap.NetStandard.ClientEndpoints.ClientProperties;

namespace CoinMarketCap.NetStandard.ClientEndpoints.Exceptions
{
    public class BadRequestException : Exception
    {
        public BadRequestException(Status status) : base ($"Server error code: {status.ErrorCode}, message: {status.ErrorMessage}")
        {
            Status = status;
        }
        public Status Status { get; }
    }
}