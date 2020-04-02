namespace DesignPattern.Builder.Test
{
    using DesignPattern.Builder.Ingredients;
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
        public void given_a_pizzaBuilder_add_3_ingredients_and_build_pizza_then_we_got_a_pizza_with_3_ingredients_and_its_names()
        {
            const int ingredientsExpected = 3;
            const string ingredientsNamesExpected = "Mozzarella, Oregano, Peperoni";
            const bool hasIngredientsExpected = true;

            var mozzarella = new Mozzarella();
            var oregano = new Oregano();
            var peperoni = new Peperoni();

            var builder = new PizzaBuilder();
            builder.AddIngredient(mozzarella);
            builder.AddIngredient(peperoni);
            builder.AddIngredient(oregano);

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