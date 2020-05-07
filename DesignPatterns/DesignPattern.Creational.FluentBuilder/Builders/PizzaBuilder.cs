namespace DesignPattern.Creational.FluentBuilder.Builders
{
    using DesignPattern.Creational.FluentBuilder.Models.Ingredients;
    using DesignPattern.Creational.FluentBuilder.Models.Pizzas;
    using DesignPattern.Creational.FluentBuilder.Models.State;
    using System.Collections.Generic;

    public class PizzaBuilder
    {
        public List<Ingredient> Ingredients { get; private set; } = new List<Ingredient>();
        public Heat Heat { get; private set; } = Heat.Low;

        public PizzaBuilder()
        {
        }

        public PizzaBuilder AddIngredient(Ingredient newIngredient)
        {
            Ingredients.Add(newIngredient);
            return this;
        }

        public PizzaBuilder AddHeat(Heat heat)
        {
            Heat = heat;
            return this;
        }

        public Pizza Build()
        {
            return new Pizza(this);
        }
    }
}