using CocktailsJiri.Backend.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailsJiri.Database.Context
{
    public static class DataSeeder
    {

        public static void Seed(CocktailsContext context)
        {
            //if (!context.Cocktails.Any())
            //{

            context.Database.EnsureDeleted();
            if (context.Database.EnsureCreated())
            {
                var cocktails = new List<Cocktail>()
                {
                        new Cocktail()
                        {
                            Name = "Dark & stormy",
                            Ingredients = new List<Ingredient>()
                            {
                                new Ingredient()
                                {
                                    Name = "Bruine rum",
                                    Amount = 60,
                                    Unit = "ml"
                                },
                                new Ingredient()
                                {
                                    Name = "Ginger beer",
                                    Amount = 180,
                                    Unit = "ml"
                                },
                                new Ingredient()
                                {
                                    Name = "schijfje limoen",
                                }
                            },
                            Recipe = new Recipe()
                            {
                                Steps = "Doe dit en ook dat"
                            }
                        },
                        new Cocktail()
                        {
                            Name = "Gin tonic",
                            Ingredients = new List<Ingredient>()
                            {
                                new Ingredient()
                                {
                                    Name = "Gin",
                                    Amount = 60,
                                    Unit = "ml"
                                },
                                new Ingredient()
                                {
                                    Name = "Tonic",
                                    Amount = 180,
                                    Unit = "ml"
                                },
                                new Ingredient()
                                {
                                    Name = "schijfje komkommer",
                                }
                            },
                            Recipe = new Recipe()
                            {
                                Steps = "Vanalles bij elkaar gieten"
                            }
                        },
                        new Cocktail()
                        {
                            Name = "Rum sour",
                            Ingredients = new List<Ingredient>()
                            {
                                new Ingredient()
                                {
                                    Name = "Bruine rum",
                                    Amount = 60,
                                    Unit = "ml"
                                },
                                new Ingredient()
                                {
                                    Name = "Citroensap",
                                    Amount = 30,
                                    Unit = "ml"
                                },
                                new Ingredient()
                                {
                                    Name = "Eiwit",
                                    Amount = 0.75
                                },
                                new Ingredient()
                                {
                                    Name = "Suikersiroop",
                                    Amount = 25,
                                    Unit = "ml"
                                },
                                new Ingredient()
                                {
                                    Name = "Angostura bitters",
                                    Amount = 5,
                                    Unit = "dashes"
                                }
                            },
                            Recipe = new Recipe()
                            {
                                Steps = "Alles samen en schudden"
                            }
                        },
                };
                context.Cocktails.AddRange(cocktails);

                context.SaveChanges();
            }
        }
    }
}
