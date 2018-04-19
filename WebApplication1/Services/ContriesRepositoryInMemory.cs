using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Services
{
    public class ContriesRepositoryInMemory : ICountriesRepositoryInMemory
    {
        public List<string> getCountries()
        {
            List<string> hardCodedContries = new List<string>() { "US", "Mexico", "Colombia" };
            return hardCodedContries;
        }
    }
}
