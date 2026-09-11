using DataContracts;
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

        public List<CityTemp> GetTemperatures()
        {
            return new List<CityTemp>()
            {
                new CityTemp() { City = "Corte", Temperature = 5 },
                new CityTemp() { City = "Paris", Temperature = 12 }
            };
        }
    }
}
