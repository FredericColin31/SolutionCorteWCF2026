using ServicesContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class MeteoServices : IMeteoServices
    {
        public int GetTemperature(string city)
        {
            if (city.ToLower() == "corte") return 5; 
            
            return 12;
        }
    }
}
