using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailsJiri.Domain.Dto.CocktailDto
{
    public class EditMenuCocktailDto
    {
        public int CocktailId { get; set; }
        public bool CanMake { get; set; }
    }
}
