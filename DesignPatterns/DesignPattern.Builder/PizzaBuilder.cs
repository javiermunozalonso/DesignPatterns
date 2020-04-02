namespace DesignPattern.Builder
{
    using DesignPattern.Builder.Ingredients;
    using System.Collections.Generic;

    public class PizzaBuilder
    {
        private ICollection<Ingredient> _ingredients { get; set; }

        public PizzaBuilder()
        {
            _ingredients = new List<Ingredient>();
        }

        public void AddIngredient(Ingredient newIngredient)
        {
            _ingredients.Add(newIngredient);
        }

        public Pizza Build()
        {
            return new Pizza(_ingredients);
        }
    }
}