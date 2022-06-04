using CocktailsJiri.Backend.Domain.Models;
using CocktailsJiri.Domain.Dto;
using CocktailsJiri.Domain.Dto.CocktailDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailsJiri.Database.Services.IServices
{
    public interface ICocktailService
    {
        Task<ICollection<GetCocktailDto>> GetAllCocktails();
        Task<GetCocktailDto> GetCocktail(int cocktailId);
        Task<ICollection<GetCocktailDto>> GetCocktailsByFilter(string filter);
        Task<ICollection<GetCocktailDto>> GetMenu();

        Task<GetCocktailDto> CreateCocktail(CreateCocktailDto cocktail);
        Task<GetCocktailDto> EditCocktail(EditCocktailDto changedCocktail, int cocktailId);

        Task<bool> EditMenu(List<EditMenuCocktailDto> cocktailsForMenu);

        Task<bool> DeleteCocktail(int cocktailid);
    }
}
