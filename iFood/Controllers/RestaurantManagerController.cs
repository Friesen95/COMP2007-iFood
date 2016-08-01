using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using iFood.Models;
using System.Data;
using System.Data.Entity;

namespace iFood.Controllers
{
    [Authorize]
    public class RestaurantManagerController : Controller
    {
        private RestaurantContext db = new RestaurantContext();

        // GET: RestaurantManager
        public ActionResult Index()
        {
            List<FoodItemModels>fooditem = db.FoodItems.ToList();
            return View(fooditem.ToList());
        }
        //
        // GET: /StoreManager/Details/5

        public ViewResult Details(int id)
        {
            FoodItemModels FoodItem = db.FoodItems.Find(id);
            return View(FoodItem);
        }

        //
        // GET: /StoreManager/Create

        public ActionResult Create()
        {
            ViewBag.FoodTypeId = new SelectList(db.FoodTypes, "FoodTypeModelsId", "Name");
            return View();
        }

        //
        // POST: /StoreManager/Create

        [HttpPost]
        public ActionResult Create(FoodItemModels FoodItem)
        {
            if (ModelState.IsValid)
            {
                db.FoodItems.Add(FoodItem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FoodTypeId = new SelectList(db.FoodTypes, "FoodTypeModelsId", "Name", FoodItem.FoodTypeId);
            return View(FoodItem);
        }

        //
        // GET: /StoreManager/Edit/5

        public ActionResult Edit(int id)
        {
            FoodItemModels FoodItem = db.FoodItems.Find(id);
            ViewBag.FoodTypeId = new SelectList(db.FoodTypes, "FoodTypeModelsId", "Name", FoodItem.FoodTypeId);
            return View(FoodItem);
        }

        //
        // POST: /StoreManager/Edit/5

        [HttpPost]
        public ActionResult Edit(FoodItemModels FoodItem)
        {

            
            if (ModelState.IsValid)
            {
                FoodItem.FoodType.Name = db.FoodTypes.Find(FoodItem.FoodTypeId).Name;
                db.Entry(FoodItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FoodTypeId = new SelectList(db.FoodTypes, "FoodTypeModelsId", "Name", FoodItem.FoodTypeId);
            return View(FoodItem);
        }

        //
        // GET: /StoreManager/Delete/5

        public ActionResult Delete(int id)
        {
            FoodItemModels FoodItem = db.FoodItems.Find(id);
            return View(FoodItem);
        }

        //
        // POST: /StoreManager/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            FoodItemModels FoodItem = db.FoodItems.Find(id);
            db.FoodItems.Remove(FoodItem);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}