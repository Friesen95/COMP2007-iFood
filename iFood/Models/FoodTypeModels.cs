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
        public FoodTypeModels()
        {

        }

        public FoodTypeModels(string Name)
        {
            this.Name = Name;
        }

        public virtual int FoodTypeModelsId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual List<FoodItemModels> FoodItems { get; set; }
    }
}