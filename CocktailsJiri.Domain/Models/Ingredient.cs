namespace CocktailsJiri.Backend.Domain.Models
{
    public class Ingredient
    {
        public int IngredientId { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
        public string Unit { get; set; }
        public int CocktailId { get; set; }

    }
}