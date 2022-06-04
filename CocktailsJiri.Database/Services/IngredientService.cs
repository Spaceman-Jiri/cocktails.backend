using AutoMapper;
using CocktailsJiri.Database.Context;
using CocktailsJiri.Database.Services.IServices;
using CocktailsJiri.Domain.Dto.IngredientDto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailsJiri.Database.Services
{
    public class IngredientService : IIngredientService
    {
        private readonly CocktailsContext _context;
        private readonly IMapper _mapper;

        public IngredientService(CocktailsContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ICollection<GetIngredientDto>> GetIngredientsOfCocktail(int cocktailId)
        {
            var ingredients = await _context.Ingredients.Where(i => i.CocktailId == cocktailId).ToListAsync();
            return _mapper.Map<ICollection<GetIngredientDto>>(ingredients);
        }
    }
}
