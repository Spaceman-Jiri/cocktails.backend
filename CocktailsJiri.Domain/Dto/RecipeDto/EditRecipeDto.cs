using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailsJiri.Domain.Dto.RecipeDto
{
    public class EditRecipeDto
    {
        public int RecipeId { get; set; }
        public string Steps { get; set; }
    }
}
