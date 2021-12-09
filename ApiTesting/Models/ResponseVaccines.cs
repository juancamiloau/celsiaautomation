using System;
using System.Collections.Generic;
using System.Text;

namespace ApiTesting.Models
{
    public class ResponseVaccines
    {
        public string codError { get; set; }
        public string mensaje { get; set; }
        public int total { get; set; }

        public VaccinesPerCity[] datosResp;

    }


    public class VaccinesPerCity
    {
        public string vacunados { get; set; }   
        public string municipio { get; set; }   
        public string departamento { get; set; }
    }
}
