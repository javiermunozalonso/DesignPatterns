namespace DesignPattern.Builder.Test
{
    using DesignPattern.Creational.Builder.Builders;
    using DesignPattern.Creational.Builder.Models.Ingredients;
    using DesignPattern.Creational.Builder.Models.Pizzas;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PizzaBuilderTest
    {
        [TestMethod]
        public void given_a_pizzaBuilder_build_pizza_then_we_got_a_pizza()
        {
            var builder = new PizzaBuilder();
            Pizza pizza = builder.Build();
            Assert.IsNotNull(pizza);
        }

        [TestMethod]
        public void given_a_pizzaBuilder_add_7_ingredients_and_build_pizza_then_we_got_a_pizza_with_7_ingredients()
        {
            const int ingredientsExpected = 7;
            const bool hasIngredientsExpected = true;

            var builder = new PizzaBuilder();
            builder.AddIngredient(new Mozzarella());
            builder.AddIngredient(new Peperoni());
            builder.AddIngredient(new Oregano());
            builder.AddIngredient(new Bacon());
            builder.AddIngredient(new Ham());
            builder.AddIngredient(new Meat());
            builder.AddIngredient(new Onion());

            Pizza pizza = builder.Build();

            Assert.IsNotNull(pizza);
            Assert.AreEqual(ingredientsExpected, pizza.GetIngredients().Count);
            Assert.AreEqual(hasIngredientsExpected, pizza.HasIngredients());
        }

        [TestMethod]
        public void given_a_pizzaBuilder_add_3_ingredients_and_build_pizza_then_we_got_a_pizza_with_3_ingredients_and_its_names()
        {
            const int ingredientsExpected = 3;
            const string ingredientsNamesExpected = "Mozzarella, Oregano, Peperoni";
            const bool hasIngredientsExpected = true;

            var builder = new PizzaBuilder();
            builder.AddIngredient(new Mozzarella());
            builder.AddIngredient(new Peperoni());
            builder.AddIngredient(new Oregano());

            Pizza pizza = builder.Build();

            Assert.IsNotNull(pizza);
            Assert.AreEqual(ingredientsExpected, pizza.GetIngredients().Count);
            Assert.AreEqual(ingredientsNamesExpected, pizza.GetIngredientsNames());
            Assert.AreEqual(hasIngredientsExpected, pizza.HasIngredients());
        }        

        [TestMethod]
        public void given_a_pizzaBuilder_build_pizza_then_we_got_a_pizza_with_0_ingredients()
        {
            const int ingredientsExpected = 0;
            string ingredientsNamesExpected = string.Empty;
            const bool hasIngredientsExpected = false;

            var builder = new PizzaBuilder();

            Pizza pizza = builder.Build();

            Assert.IsNotNull(pizza);
            Assert.AreEqual(ingredientsExpected, pizza.GetIngredients().Count);
            Assert.AreEqual(ingredientsNamesExpected, pizza.GetIngredientsNames());
            Assert.AreEqual(hasIngredientsExpected, pizza.HasIngredients());
        }
    }
}