using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory kategoryCars = new MockCategory();
        public IEnumerable<Cars> Cars 
        {
            get
            {
                return new List<Cars>
                {
                    new Cars {Name = "Tesla", 
                        shortdesc = "", 
                        longdesc = "", 
                        img = "/img/5ea6dd8dec05c41134000004.jpg", 
                        price = 45000, 
                        IsFavourite = true, 
                        available = true, 
                        Category = kategoryCars.AllCategories.First()},
                    new Cars {Name = "BMW",
                        shortdesc = "",
                        longdesc = "", 
                        img = "/img/BM_001.jpg",
                        price = 46500,
                        IsFavourite = false,
                        available = true,
                        Category = kategoryCars.AllCategories.Last()},
                    new Cars {Name = "Ford",
                        shortdesc = "",
                        longdesc = "",
                        img = "/img/crop_blobserver.jpg",
                        price = 30000,
                        IsFavourite = true,
                        available = true,
                        Category = kategoryCars.AllCategories.Last()},
                    new Cars {Name = "Audi E-tron",
                        shortdesc = "",
                        longdesc = "",
                        img = "/img/audi-e-tron-sportback.jpg",
                        price = 35000,
                        IsFavourite = true,
                        available = false,
                        Category = kategoryCars.AllCategories.First()}
                };
            }
        }
        public IEnumerable<Cars> GetFavCars { get; set; }

        public Cars getObjectCar(int CarId)
        {
            throw new NotImplementedException();
        }
    }
}
