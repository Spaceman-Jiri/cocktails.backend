using AutoMapper;
using CocktailsJiri.Backend.Domain.Models;
using CocktailsJiri.Domain.Dto.IngredientDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailsJiri.Database.Profiles.IngredientProfiles
{
    public class IngredientProfile : Profile
    {

        public IngredientProfile()
        {
            CreateMap<Ingredient, GetIngredientDto>();
            CreateMap<CreateIngredientDto, Ingredient>();
            CreateMap<EditIngredientDto, Ingredient>();
        }
    }
}
