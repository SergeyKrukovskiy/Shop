using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.View_Models
{
    public class CarsListViewModel
    {
        public IEnumerable<Cars> AllCars { get; set; }
        public string currCategory { get; set; }
    }
}
