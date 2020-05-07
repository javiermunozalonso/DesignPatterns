namespace DesignPattern.Builder.Test
{
    using DesignPattern.Creational.Builder.Builders;
    using DesignPattern.Creational.Builder.Models.Ingredients;
    using DesignPattern.Creational.Builder.Models.Pizzas;
    using DesignPattern.Creational.Builder.Models.State;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PizzaBuilderTest
    {
        [TestMethod]
        public void given_a_pizzaBuilder_build_pizza_then_we_got_a_pizza_with_low_heat()
        {
            Heat expectedHeat = Heat.Low;

            var builder = new PizzaBuilder();
            Pizza pizza = builder.Build();

            Assert.IsNotNull(pizza);
            Assert.AreEqual(expectedHeat, pizza.GetHeat());
        }

        [TestMethod]
        public void given_a_pizzaBuilder_build_pizza_with_high_heat_then_we_got_a_pizza_with_high_heat()
        {
            Heat expectedHeat = Heat.High;

            var builder = new PizzaBuilder();
            builder.AddHeat(Heat.High);
            Pizza pizza = builder.Build();

            Assert.IsNotNull(pizza);
            Assert.AreEqual(expectedHeat, pizza.GetHeat());
        }

        [TestMethod]
        public void given_a_pizzaBuilder_add_7_ingredients_and_build_pizza_then_we_got_a_pizza_with_7_ingredients_and_low_heat()
        {
            Heat expectedHeat = Heat.Low;
            const int expectedIngredientsCount = 7;
            const bool expectedHasIngredients = true;

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
            Assert.AreEqual(expectedIngredientsCount, pizza.GetIngredients().Count);
            Assert.AreEqual(expectedHasIngredients, pizza.HasIngredients());
            Assert.AreEqual(expectedHeat, pizza.GetHeat());
        }

        [TestMethod]
        public void given_a_pizzaBuilder_add_3_ingredients_and_build_pizza_then_we_got_a_pizza_with_3_ingredients_and_its_names()
        {
            const int expectedIngredientsCount = 3;
            const string expectedIngredientsNames = "Mozzarella, Oregano, Peperoni";
            const bool expectedHasIngredients = true;

            var builder = new PizzaBuilder();
            builder.AddIngredient(new Mozzarella());
            builder.AddIngredient(new Peperoni());
            builder.AddIngredient(new Oregano());

            Pizza pizza = builder.Build();

            Assert.IsNotNull(pizza);
            Assert.AreEqual(expectedIngredientsCount, pizza.GetIngredients().Count);
            Assert.AreEqual(expectedIngredientsNames, pizza.GetIngredientsNames());
            Assert.AreEqual(expectedHasIngredients, pizza.HasIngredients());
        }

        [TestMethod]
        public void given_a_pizzaBuilder_build_pizza_then_we_got_a_pizza_with_0_ingredients()
        {
            const int expectedIngredientsCount = 0;
            string expectedIngredientsNames = string.Empty;
            const bool expectedHasIngredients = false;

            var builder = new PizzaBuilder();

            Pizza pizza = builder.Build();

            Assert.IsNotNull(pizza);
            Assert.AreEqual(expectedIngredientsCount, pizza.GetIngredients().Count);
            Assert.AreEqual(expectedIngredientsNames, pizza.GetIngredientsNames());
            Assert.AreEqual(expectedHasIngredients, pizza.HasIngredients());
        }
    }
}