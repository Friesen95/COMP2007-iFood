using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

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
        [Key]
        public int FoodId { get; set; }
        public int FoodTypeId { get; set; }
        public string Name { get; set; }
        public string description { get; set; }
        public Decimal Price { get; set; }
        public string FoodArtUrl { get; set; }
        public FoodTypeModels FoodType { get; set; }

    }
}