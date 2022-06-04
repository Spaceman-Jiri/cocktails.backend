using AutoMapper;
using CocktailsJiri.Backend.Domain.Models;
using CocktailsJiri.Domain.Dto;
using CocktailsJiri.Domain.Dto.CocktailDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailsJiri.Database.Profiles.CocktailProfiles
{
    public class CocktailProfile : Profile
    {
        public CocktailProfile()
        {
            CreateMap<Cocktail, GetCocktailDto>();
            CreateMap<CreateCocktailDto, Cocktail>();
            CreateMap<EditCocktailDto, Cocktail>();
        }
    }
}
