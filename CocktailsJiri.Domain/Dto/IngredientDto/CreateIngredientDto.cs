using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailsJiri.Domain.Dto.IngredientDto
{
   public class CreateIngredientDto
    {
        public string Name { get; set; }
        public double? Amount { get; set; }
        public string? Unit { get; set; }
    }
}
