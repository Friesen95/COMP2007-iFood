using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iFood.Models
{
    public class FoodItemModels
    {
        /// <summary>
        /// EMpty constructor
        /// </summary>
        public FoodItemModels()
        {

        }

        public FoodItemModels(String Name)
        {
            this.Name = Name;
        }

        public int FoodId { get; set; }
        public int FoodTypeId { get; set; }
        public string Name { get; set; }
        public string description { get; set; }
        public decimal Price { get; set; }
        public string FoodArtUrl { get; set; }
        public FoodTypeModels FoodType { get; set; }

    }
}