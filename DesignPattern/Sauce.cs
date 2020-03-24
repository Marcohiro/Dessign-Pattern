using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    enum TypeSauce
    {
        Algerienne,
        Samourai,
        Blanche,
        Barbecue,
        Mayonnaise
    }
    class Sauce
    {
        public string Name { get; }

        public TypeSauce TypeSauce { get; }
        public Sauce(string name, TypeSauce sauce)
        {
            this.Name = name;
            this.TypeSauce = sauce;
        }
    }
}
