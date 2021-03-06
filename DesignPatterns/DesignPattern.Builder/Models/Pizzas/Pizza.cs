﻿namespace DesignPattern.Creational.Builder.Models.Pizzas
{
    using DesignPattern.Creational.Builder.Builders;
    using DesignPattern.Creational.Builder.Models.Ingredients;
    using DesignPattern.Creational.Builder.Models.State;
    using System.Collections.Generic;
    using System.Linq;

    public class Pizza
    {
        private readonly List<Ingredient> _ingredients;
        private readonly Heat _heat;

        public Pizza(PizzaBuilder builder)
        {
            _ingredients = builder.GetIngredient();
            _heat = builder.GetHeat();
        }

        public List<Ingredient> GetIngredients()
        {
            return _getIngredients();
        }
        
        public Heat GetHeat()
        {
            return _heat;
        }

        public string GetHeatName()
        {
            return _heat.ToString();
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