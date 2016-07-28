using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using iFood.Models;

namespace iFood.Controllers
{
    public class RestaurantManagerController : Controller
    {
        private RestaurantContext db = new RestaurantContext();

        // GET: RestaurantManager
        public ActionResult Index()
        {
            //var fooditem = db.FoodItems.Include(a => a.FoodType);
            return View(/*fooditem.ToList()*/);
        }
    }
}