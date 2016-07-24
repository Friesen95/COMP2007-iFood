namespace iFood.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class restaurantContext : DbContext
    {
        public restaurantContext()
            : base("name=restaurantConnection")
        {
        }
        public virtual DbSet<FoodItemModels> FoodItems { get; set; }
        public virtual DbSet<FoodTypeModels> FoodType { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
