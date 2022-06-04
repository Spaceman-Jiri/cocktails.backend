using CocktailsJiri.Backend.Domain.Models;
using CocktailsJiri.Domain.Dto.IngredientDto;
using CocktailsJiri.Domain.Dto.RecipeDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailsJiri.Domain.Dto
{
    public class GetCocktailDto
    {
        public int CocktailId { get; set; }
        public string Name { get; set; }
        public ICollection<GetIngredientDto> Ingredients { get; set; }
        public bool CanMake { get; set; }
    }
}
