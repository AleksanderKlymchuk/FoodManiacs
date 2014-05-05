using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FoodManiacs.Models
{
    public class Recipe
    {
        public int ID { get; set; }
        public int cont_id { get; set; }
        public string origin { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string image_id { get; set; }
        public string ingredients { get; set; }
        public string how_to { get; set; }
        
        public virtual ICollection<ApplicationUser> User { get; set; }
        
    }
    public class RecipeDBContext : DbContext
    {
        public DbSet<Recipe> Recipe { get; set; }
    }
}