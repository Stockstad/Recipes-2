using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes_2
{
    enum Prop {gram, litre, amount};
    internal class Ingredient
    {
        public string Name;
        public decimal Quantity;
        public Prop Property;

        public Ingredient(string n, decimal q, Prop p)
        {
            Name = n;
            Quantity = q;
            Property = p;
        }

        public override string ToString()
        {
            return Name + " " + Quantity + " " + Property;
        }

    }
}
