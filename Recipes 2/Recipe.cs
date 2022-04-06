using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes_2
{
    internal class Recipe
    {
        public string Name;
        public List<Ingredient> Ingredient = new List<Ingredient>();

        public override string ToString()
        {
            return Name;
        }

    }

  
}
