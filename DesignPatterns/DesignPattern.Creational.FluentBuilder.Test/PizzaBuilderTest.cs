namespace DesignPattern.FluentBuilder.Test
{
    using DesignPattern.Creational.FluentBuilder.Builders;
    using DesignPattern.Creational.FluentBuilder.Models.Ingredients;
    using DesignPattern.Creational.FluentBuilder.Models.Pizzas;
    using DesignPattern.Creational.FluentBuilder.Models.State;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PizzaBuilderTest
    {
        [TestMethod]
        public void given_a_pizzaBuilder_build_pizza_then_we_got_a_pizza_with_low_heat()
        {
            Heat expectedHeat = Heat.Low;

            Pizza pizza = new PizzaBuilder()
                .Build();

            Assert.IsNotNull(pizza);
            Assert.AreEqual(expectedHeat, pizza.GetHeat());
        }

        [TestMethod]
        public void given_a_pizzaBuilder_build_pizza_with_high_heat_then_we_got_a_pizza_with_high_heat()
        {
            Heat expectedHeat = Heat.High;

            Pizza pizza = new PizzaBuilder()
                .AddHeat(Heat.High)
                .Build();

            Assert.IsNotNull(pizza);
            Assert.AreEqual(expectedHeat, pizza.GetHeat());
        }

        [TestMethod]
        public void given_a_pizzaBuilder_add_3_ingredients_medium_heat_and_build_pizza_then_we_got_a_pizza_with_3_ingredients_and_medium_heat()
        {
            Heat expectedHeat = Heat.Medium;
            const int expectedIngredientsCount = 3;
            const bool expectedHasIngredients = true;

            Pizza pizza = new PizzaBuilder()
                .AddIngredient(new Mozzarella())
                .AddIngredient(new Oregano())
                .AddIngredient(new Meat())
                .AddHeat(Heat.Medium)
                .Build();

            Assert.IsNotNull(pizza);
            Assert.AreEqual(expectedIngredientsCount, pizza.GetIngredients().Count);
            Assert.AreEqual(expectedHasIngredients, pizza.HasIngredients());
            Assert.AreEqual(expectedHeat, pizza.GetHeat());
        }

        [TestMethod]
        public void given_a_pizzaBuilder_add_2_ingredients_and_build_pizza_then_we_got_a_pizza_with_2_ingredients_low_heat_and_its_names()
        {
            Heat expectedHeat = Heat.Low;
            const int expectedIngredientsCount = 2;
            const string expectedIngredientsNames = "Mozzarella, Oregano";
            const bool expectedHasIngredients = true;

            Pizza pizza = new PizzaBuilder()
                .AddIngredient(new Mozzarella())
                .AddIngredient(new Oregano())
                .Build();


            Assert.IsNotNull(pizza);
            Assert.AreEqual(expectedIngredientsCount, pizza.GetIngredients().Count);
            Assert.AreEqual(expectedIngredientsNames, pizza.GetIngredientsNames());
            Assert.AreEqual(expectedHasIngredients, pizza.HasIngredients());
            Assert.AreEqual(expectedHeat, pizza.GetHeat());
        }

        [TestMethod]
        public void given_a_pizzaBuilder_build_pizza_then_we_got_a_pizza_with_0_ingredients()
        {
            const int expectedIngredientsCount = 0;
            string expectedIngredientsNames = string.Empty;
            const bool expectedHasIngredients = false;

            Pizza pizza = new PizzaBuilder()
                .Build();

            Assert.IsNotNull(pizza);
            Assert.AreEqual(expectedIngredientsCount, pizza.GetIngredients().Count);
            Assert.AreEqual(expectedIngredientsNames, pizza.GetIngredientsNames());
            Assert.AreEqual(expectedHasIngredients, pizza.HasIngredients());
        }
    }
}