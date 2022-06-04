using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CocktailsJiri.Backend.Domain.Models
{
    public class Cocktail
    {
        public int CocktailId { get; set; }
        public string Name { get; set; }
        public Recipe Recipe { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
        public bool CanMake { get; set; }

    }
}
