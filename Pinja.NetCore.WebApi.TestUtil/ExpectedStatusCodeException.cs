using System;

namespace Pinja.NetCore.WebApi.TestUtil
{
    public class ExpectedStatusCodeException : Exception
    {
        public ExpectedStatusCodeException(string message) : base(message)
        {
        }
    }
}