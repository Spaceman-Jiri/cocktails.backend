using AutoMapper;
using CocktailsJiri.Backend.Domain.Models;
using CocktailsJiri.Database.Context;
using CocktailsJiri.Database.Services.IServices;
using CocktailsJiri.Domain.Dto;
using CocktailsJiri.Domain.Dto.CocktailDto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailsJiri.Database.Services
{
    public class CocktailService : ICocktailService
    {
        private readonly CocktailsContext _context;
        private readonly IMapper _mapper;

        public CocktailService(CocktailsContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetCocktailDto> CreateCocktail(CreateCocktailDto cocktail) 
        {
            if (cocktail == null)
                return null;

            var newCocktail = _mapper.Map<Cocktail>(cocktail);

            await _context.Cocktails.AddAsync(newCocktail);
            await _context.SaveChangesAsync();

            return _mapper.Map<GetCocktailDto>(newCocktail);
        }

        public async Task<bool> DeleteCocktail(int cocktailId) 
        {
            var cocktail = await _context.Cocktails.FindAsync(cocktailId);

            if (cocktail == null)
                return false;

            _context.Cocktails.Remove(cocktail);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<GetCocktailDto> EditCocktail(EditCocktailDto changedCocktail, int cocktailId)
        {
            var cocktail = await _context.Cocktails.Include(c => c.Ingredients).Include(c => c.Recipe).FirstOrDefaultAsync(c => c.CocktailId == cocktailId);
            var ingredients = await _context.Ingredients.Where(i => i.CocktailId == cocktailId).ToListAsync();
            var recipe = await _context.Recipes.Where(r => r.CocktailId == cocktailId).FirstOrDefaultAsync();

            if (cocktail == null)
                return null;

            changedCocktail.Ingredients.ToList().ForEach(newIngredient =>
            {
                ingredients.Where(i => i.IngredientId == newIngredient.IngredientId).Select(i =>
                {
                    i.Name = newIngredient.Name;
                    i.Amount = newIngredient.Amount;
                    return i;
                });
            });
            await _context.SaveChangesAsync();
            var x = await _context.Ingredients.Where(i => i.CocktailId == cocktailId).ToListAsync();

            //recipe.Steps = changedCocktail.Recipe.Steps;

            _mapper.Map(changedCocktail, cocktail);
            await _context.SaveChangesAsync();

            return _mapper.Map<GetCocktailDto>(cocktail);
        }

        public async Task<bool> EditMenu(List<EditMenuCocktailDto> cocktailsForMenu)
        {
            var cocktails = await _context.Cocktails.ToListAsync();

            cocktails.ForEach(cocktail =>
            {
                var updatedCocktail = cocktailsForMenu.SingleOrDefault(c => c.CocktailId == cocktail.CocktailId);
                if(updatedCocktail != null)
                {
                    cocktail.CanMake = updatedCocktail.CanMake;
                }   
            });

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<ICollection<GetCocktailDto>> GetAllCocktails()
        {
            var cocktails = await _context.Cocktails.Include(c => c.Ingredients).ToListAsync();
            return _mapper.Map<ICollection<GetCocktailDto>>(cocktails);
        }

        public async Task<GetCocktailDto> GetCocktail(int cocktailId)
        {
            var cocktail = await _context.Cocktails.Include(c => c.Ingredients).FirstOrDefaultAsync(c => c.CocktailId == cocktailId);
            return _mapper.Map<GetCocktailDto>(cocktail);
        }

        public async Task<ICollection<GetCocktailDto>> GetCocktailsByFilter(string filter)
        {
            var cocktails = await _context.Cocktails.Include(c => c.Ingredients)
                .Where(c => c.Ingredients.Any(i => i.Name.ToLower().Contains(filter)) || c.Name.ToLower().Contains(filter))
                .ToListAsync();

            return _mapper.Map<ICollection<GetCocktailDto>>(cocktails);
        }

        public async Task<ICollection<GetCocktailDto>> GetMenu()
        {
            var cocktails = await _context.Cocktails.Where(c => c.CanMake == true).Include(c => c.Ingredients).ToListAsync();
            return _mapper.Map<ICollection<GetCocktailDto>>(cocktails);
        }
    }
}
