using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Services;

namespace WebApplication1.ViewComponents
{
    public class CountriesViewComponent : ViewComponent
    {
        public CountriesViewComponent(ICountriesRepository countriesRepository)
        {
                
        }
    }
}
