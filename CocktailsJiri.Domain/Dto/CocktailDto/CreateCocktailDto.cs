using CocktailsJiri.Domain.Dto.IngredientDto;
using CocktailsJiri.Domain.Dto.RecipeDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailsJiri.Domain.Dto.CocktailDto
{
    public class CreateCocktailDto
    {
        public string Name { get; set; }
        public CreateRecipeDto Recipe { get; set; }
        public ICollection<CreateIngredientDto> Ingredients { get; set; }
        public bool CanMake = true;
    }
}
