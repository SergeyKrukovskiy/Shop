using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.interfaces
{
    public interface IAllCars
    {
        IEnumerable<Cars> Cars { get; }
        IEnumerable<Cars> GetFavCars { get; set; }
        Cars getObjectCar(int CarId);
    }
}
