using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiTesting.Models
{
    public class User
    {
        public Data data { get; set; }
    }
    
    public class Data
    {
        public string id { get; set; }
        public string email { get; set; }
        public string last_name { get; set; }
        public string first_name { get; set; }
        public string avatar { get; set; }
    }

}
