using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using iFood.Models;

namespace iFood.Controllers
{
    public class RestaurantController : Controller
    {
        restaurantContext storeDB = new restaurantContext();
        // GET: Restaurant
        public ActionResult Index()
        {
            List<FoodTypeModels> FoodType = storeDB.FoodType.ToList();
            return View(FoodType);
        }

        public ActionResult Browse(string type= "Appetizer")
        {
            FoodTypeModels foodTypesModel = storeDB.FoodType.Include("FoodItem").Single(g => g.Name == type);
            return View(foodTypesModel);
        }

        public ActionResult Details(int id =1)
        {
            var item = storeDB.FoodItems.Find(id);
            return View(item);
        }
    }
}