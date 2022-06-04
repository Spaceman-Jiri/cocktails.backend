using CocktailsJiri.Backend.Domain.Models;
using CocktailsJiri.Domain.Dto.IngredientDto;
using CocktailsJiri.Domain.Dto.RecipeDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailsJiri.Domain.Dto.CocktailDto
{
    public class EditCocktailDto
    {
        public string Name { get; set; }
        public ICollection<EditIngredientDto> Ingredients { get; set; }
        public EditRecipeDto Recipe { get; set; }
    }
}
