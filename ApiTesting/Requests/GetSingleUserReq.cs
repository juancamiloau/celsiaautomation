using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiTesting.Requests
{
    public static class GetSingleUserReq
    {
        public static IRestRequest WithID(string id)
        {
            return new RestRequest("/api/users/" + id, Method.GET);
        }
    }
}
