using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace iFood.Models
{
    public class RestaurantEntities : DbContext
    {
        public DbSet<FoodItemModels> FoodItem { get; set; }
        public DbSet<FoodTypeModels> FoodType { get; set; }
    }
}