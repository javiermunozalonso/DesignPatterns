using System.Collections.Generic;

namespace DesignPattern.Builder
{
    public class Pizza
    {
        private ICollection<string> _ingredients { get; set; }

        public ICollection<string> GetIngredients()
        {
            return null;
        }

        public override string ToString()
        {

            if (_ingredients.Count == 0)
            {
                return "Pizza has no ingredients :(";
            }

            return base.ToString();
        }
    }
}
