using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiTesting.Requests
{
    public class GetVaccinesPerCity
    {
        public static IRestRequest WithTokenAndClientHashId(string token, string userHashId)
        {
            return new RestRequest("api/gestionvacunas/vs1/cosultaVacunacionesPorCiudad", Method.GET).AddHeader("token",token).AddHeader("userHashid", userHashId)
                .AddHeader("Content-Type", "application/json");
        }

    }
}
