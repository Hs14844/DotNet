using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSPA_CRUD.Models
{
    public class ConfigurationModel
    {
            public class API
            {
                public string BaseUrl { get; set; }
                public string StringContentMediaType { get; set; }

            }

            public class APIEndPoints
            {
                public string GetContractDetails { get; set; }
                public string GetNatureOfContractList { get; set; }
                public string GetPincodeDetails { get; set; }
                public string GetCityDetails { get; set; }
            }
        }

    }
