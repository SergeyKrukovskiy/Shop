using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
using Shop.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _aLLCars;
        private readonly ICarsCategory carsCategory;

        public CarsController (IAllCars allCars, ICarsCategory CarsCategory)
        {
            _aLLCars = allCars;
            carsCategory = CarsCategory;
        }

        public ViewResult List ()
        {
            ViewBag.Title = "Страница с автомобилями";
            CarsListViewModel obj = new CarsListViewModel();
            obj.AllCars = _aLLCars.Cars;
            obj.currCategory = "Автомобили";
            return View(obj);
        }
    }
}
