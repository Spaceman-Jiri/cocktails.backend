using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailsJiri.Dto.Cocktail
{
    public class GetCocktailDto
    {
        public int CocktailId { get; set; }
        public string Name { get; set; }
        public Recipe Recipe { get; set; }
        public int RecipeId { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
    }
}
