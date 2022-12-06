using DataContracts;
using ServicesContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class MeteoService : IMeteoService
    {
        public int GetTemperature(string city)
        {
            if (city.ToUpper() == "CORTI")

                return 10;
            else
                return 20;
        } 
        
        public List<Temperature> GetTemperatures()
        {
            var temperatures = new List<Temperature>();

            temperatures.Add(new Temperature() { City = "Lyon", Temp = 20});    
            temperatures.Add(new Temperature() { City = "Touloyse", Temp = 30 });    
            temperatures.Add(new Temperature() { City = "Corte", Temp = 15 });    
            temperatures.Add(new Temperature() { City = "Milan", Temp = 10 });

            return temperatures;
        }

        
    }
}
