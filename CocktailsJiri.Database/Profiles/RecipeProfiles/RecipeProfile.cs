using AutoMapper;
using CocktailsJiri.Backend.Domain.Models;
using CocktailsJiri.Domain.Dto.RecipeDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailsJiri.Database.Profiles.RecipeProfiles
{
    public class RecipeProfile : Profile 
    {
        public RecipeProfile()
        {
            CreateMap<Recipe, GetRecipeDto>();
            CreateMap<CreateRecipeDto, Recipe>();
            CreateMap<EditRecipeDto, Recipe>();
        }
    }
}
