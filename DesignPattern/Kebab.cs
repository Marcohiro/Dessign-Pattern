using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    class Kebab
    {

        public List<Ingredients> ingredients { get; }

        bool isVegetarian()
        {
            foreach(Ingredients ingredient in ingredients)
            {
                if (!ingredient.isVegetarian) return false;
            }
            return true;
        }
    }
}
