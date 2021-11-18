using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiTesting.Requests
{
    public static class ClientReqRes
    {
        public static IRestClient WithURL(string url)
        {
            return new RestClient(url);
        }

    }
}
