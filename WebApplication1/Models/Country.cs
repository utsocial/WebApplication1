using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string name { get; set; }

        public Country()
        {

        }

        public Country(string nameParam)
        {
            name = nameParam;
        }
    }
}
