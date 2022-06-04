using CocktailsJiri.Backend.Domain.Models;
using CocktailsJiri.Database.Services.IServices;
using CocktailsJiri.Domain.Dto;
using CocktailsJiri.Domain.Dto.CocktailDto;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CocktailsJiri.API.Controllers
{
    [ApiController]
    [EnableCors]
    [Route("api/cocktails")]
    public class CocktailsController : Controller
    {
        private readonly ICocktailService _cocktailService;

        public CocktailsController(ICocktailService cocktailService )
        {
            _cocktailService = cocktailService;
        }

        [HttpGet]
        public async Task<ICollection<GetCocktailDto>> GetAllCocktails()
        {
            return await _cocktailService.GetAllCocktails();
        }

        [HttpGet("{cocktailId}")]
        public async Task<GetCocktailDto> GetCocktail(string cocktailId)
        {
            return await _cocktailService.GetCocktail(Int32.Parse(cocktailId));
        }

        [HttpGet]
        [Route("getByFilter")]
        public async Task<ICollection<GetCocktailDto>> GetCocktailsByFilter(string filter)
        {
            return await _cocktailService.GetCocktailsByFilter(filter);
        }

        [HttpGet]
        [Route("getMenu")]
        public async Task<ICollection<GetCocktailDto>> GetMenu()
        {
            return await _cocktailService.GetMenu();
        }

        [HttpPost]
        public async Task<GetCocktailDto> CreateCocktail(CreateCocktailDto cocktail)
        {
            return await _cocktailService.CreateCocktail(cocktail);
        }

        [HttpPut("{cocktailId}")]
        public async Task<GetCocktailDto> EditCocktail(EditCocktailDto changedCocktail, int cocktailId)
        {
            return await _cocktailService.EditCocktail(changedCocktail, cocktailId);
        }

        [HttpPut("setMenu")]
        public async Task<bool> EditMenu(List<EditMenuCocktailDto> cocktails)
        {
            return await _cocktailService.EditMenu(cocktails);
        }

        [HttpDelete("{cocktailId}")]
        public async Task<ActionResult> DeleteCocktail(int cocktailId)
        {
            var result = await _cocktailService.DeleteCocktail(cocktailId);

            if (!result)
                return NotFound();

            return Ok();
        }
    }
}
