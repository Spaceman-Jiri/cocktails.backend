using CocktailsJiri.Domain.Dto.IngredientDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailsJiri.Database.Services.IServices
{
    public interface IIngredientService
    {
        Task<ICollection<GetIngredientDto>> GetIngredientsOfCocktail(int cocktailId);
    }
}
