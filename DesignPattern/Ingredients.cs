using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    class Ingredients
    {
        public bool isVegetarian { get;  }
        public string name { get; }

        public Ingredients(string name, bool isVegetarian)
        {
            this.name = name;
            this.isVegetarian = isVegetarian;
        }

        public bool isIngredientVegetarian()
        {
            return this.isVegetarian;
        }
    }
}
