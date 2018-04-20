using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class ContriesRepositoryEF : ICountriesRepository
    {
        public ApplicationDbContext DBContext { get; private set; }

        public ContriesRepositoryEF(ApplicationDbContext dbContext)
        {
            DBContext = dbContext;
        }

        public List<Country> getCountries()
        {
            return DBContext.Countries.ToList();
        }
    }
}
