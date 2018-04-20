using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class ContriesRepositoryInMemory : ICountriesRepository
    {
        public List<Country> getCountries()
        {
            List<Country> hardCodedCountries = new List<Country>() {
            new Country("US"),
            new Country("Mexico"),
            new Country("Colombia") };
            return hardCodedCountries;
        }
    }
}
