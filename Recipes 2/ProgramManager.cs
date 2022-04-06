using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes_2
{
    internal class ProgramManager
    {
        public static List<Recipe> recipes = new List<Recipe>();

        public static List<Recipe> Shuffle()
        {
            Random rand = new Random();
            return recipes.OrderBy(a => rand.Next()).ToList();
        }
    }

 
}
