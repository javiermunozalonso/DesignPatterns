
namespace DesignPattern.Creational.Builder.Builders
{
    using DesignPattern.Creational.Builder.Models.Ingredients;
    using DesignPattern.Creational.Builder.Models.Pizzas;
    using System.Collections.Generic;

    public class PizzaBuilder
    {
        private List<Ingredient> _ingredients { get; set; }

        public PizzaBuilder()
        {
            _ingredients = new List<Ingredient>();
        }

        public void AddIngredient(Ingredient newIngredient)
        {
            _ingredients.Add(newIngredient);
        }
        public List<Ingredient> GetIngredient()
        {
            return _ingredients;
        }

        public Pizza Build()
        {
            return new Pizza(this);
        }
    }
}