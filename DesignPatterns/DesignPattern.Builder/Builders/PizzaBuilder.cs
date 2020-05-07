namespace DesignPattern.Creational.Builder.Builders
{
    using DesignPattern.Creational.Builder.Models.Ingredients;
    using DesignPattern.Creational.Builder.Models.Pizzas;
    using DesignPattern.Creational.Builder.Models.State;
    using System.Collections.Generic;

    public class PizzaBuilder
    {
        private List<Ingredient> _ingredients { get; set; } = new List<Ingredient>();
        private Heat _heat { get; set; } = Heat.Low;

        public PizzaBuilder()
        {
        }

        public void AddIngredient(Ingredient newIngredient)
        {
            _ingredients.Add(newIngredient);
        }

        public void AddHeat(Heat heat)
        {
            _heat = heat;
        }

        public List<Ingredient> GetIngredient()
        {
            return _ingredients;
        }
        public Heat GetHeat()
        {
            return _heat;
        }

        public Pizza Build()
        {
            return new Pizza(this);
        }
    }
}