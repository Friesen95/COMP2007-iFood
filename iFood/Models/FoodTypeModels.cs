using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace iFood.Models
{
    public class FoodTypeModels
    {
        /// <summary>
        /// Empty constructor
        /// </summary>
        public FoodTypeModels()
        {

        }

        public FoodTypeModels(string name)
        {
            this.Name = name;
        }
        [Key]
        public int FoodTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<FoodItemModels> FoodItem { get; set; }
        

    }
}