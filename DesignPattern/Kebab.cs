using System.Collections.Generic;

namespace DesignPattern
{
    class Kebab
    {

        public List<Ingredient> Ingredients { get; }
        public Sauce Sauce { get; }

        public Kebab(List<Ingredient> ingredients, Sauce sauce)
        {
            this.Ingredients = ingredients;
            this.Sauce = sauce;
        }

        bool isVegetarian()
        {
            foreach(Ingredient ingredient in Ingredients)
            {
                if (ingredient.GetType() != typeof(VegeterianIngredient)) return false;
            }
            return true;
        }

        bool isPescetarian()
        {
            foreach (Ingredient ingredient in Ingredients)
            {
                if (ingredient.GetType() != typeof(VegeterianIngredient) || ingredient.GetType() != typeof(PesceterianIngredient)) return false;
            }
            return true;
        }
    }
}
