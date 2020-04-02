namespace DesignPattern.Builder
{
    using DesignPattern.Builder.Ingredients;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Pizza
    {
        public Pizza(ICollection<Ingredient> ingredients)
        {
            _ingredients = ingredients ?? throw new ArgumentNullException(nameof(ingredients));
        }

        private ICollection<Ingredient> _ingredients { get; set; }

        public ICollection<Ingredient> GetIngredients()
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

        private ICollection<Ingredient> _getIngredients()
        {
            if (HasIngredients())
            {
                return _ingredients.OrderBy(ingredient => ingredient.Name).ToList();
            }
            return new List<Ingredient>();
        }
    }
}