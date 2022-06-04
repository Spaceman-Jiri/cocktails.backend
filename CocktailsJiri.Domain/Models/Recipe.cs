using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CocktailsJiri.Backend.Domain.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public Cocktail Cocktail { get; set; }
        public int CocktailId { get; set; }
        public string Steps { get; set; }
    }
}