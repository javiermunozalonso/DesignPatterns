namespace DesignPattern.Creational.Builder.Models.Pizzas
{
    using DesignPattern.Creational.Builder.Builders;
    using DesignPattern.Creational.Builder.Models.Ingredients;
    using System.Collections.Generic;
    using System.Linq;

    public class Pizza
    {
        public Pizza(PizzaBuilder builder)
        {
            _ingredients = builder.GetIngredient();
        }

        private List<Ingredient> _ingredients { get; set; } = new List<Ingredient>();

        public List<Ingredient> GetIngredients()
        {
            return _getIngredients();
        }

        public string GetIngredientsNames()
        {
            if (!HasIngredients())
            {
                return string.Empty;
            }
            return string.Join(", ", _getIngredients().Select(ingredient => ingredient.Name));
        }
        public bool HasIngredients()
        {
            return _ingredients.Count != 0;
        }

        private List<Ingredient> _getIngredients()
        {
            if (HasIngredients())
            {
                return _ingredients.OrderBy(ingredient => ingredient.Name).ToList();
            }
            return new List<Ingredient>();
        }
    }
}