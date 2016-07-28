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
        public FoodItemModels()
        {

        }

        public FoodItemModels(string Name)
        {
            this.Name = Name;
        }
        [Display(Name ="Food Item")]
        public virtual int FoodItemModelsId { get; set; }
        [Display(Name ="Food Type")]
        public virtual int FoodTypeId { get; set; }
        public virtual FoodTypeModels FoodType { get; set; }
        public virtual string Name { get; set; }
        public virtual string description { get; set; }
        public virtual decimal Price { get; set; }
        [Display(Name ="Album Art Url")]
        public virtual string FoodArtUrl { get; set; }
    }
}