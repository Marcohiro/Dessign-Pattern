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

        bool IsVegetarian()
        {
            foreach(Ingredient ingredient in Ingredients)
            {
                if (ingredient.GetType() != typeof(VegeterianIngredient)) return false;
            }
            return true;
        }

        bool IsPescetarian()
        {
            foreach (Ingredient ingredient in Ingredients)
            {
                if (ingredient.GetType() != typeof(VegeterianIngredient) || ingredient.GetType() != typeof(PesceterianIngredient)) return false;
            }
            return true;
        }

        public Kebab SansOignon()
        {
            foreach(Ingredient ingredient in Ingredients)
            {
                if (ingredient.GetType() == typeof(OignonIngredient)) this.Ingredients.Remove(ingredient);
            }
            return this;
        }

        public Kebab SupplementFromage()
        {
            foreach (Ingredient ingredient in Ingredients)
            {
                if (ingredient.GetType() == typeof(CheeseIngredient)) this.Ingredients.Add(ingredient);
            }
            return this;
        }
    }
}
