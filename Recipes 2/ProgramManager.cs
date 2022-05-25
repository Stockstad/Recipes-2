using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes_2
{
    internal class ProgramManager //ProgramManager includes the variables and data needed for the entire program.
    {
        public static List<Recipe> recipes = new List<Recipe>();
        public static Recipe? toEdit;

        public static List<Recipe> Shuffle() //Shuffles the list of Recipes. 
        {
            Random rand = new Random();
            return recipes.OrderBy(a => rand.Next()).ToList();
        }

        public static void EditRecipe(Recipe te)
        {
            toEdit = te;
        }
    }

 
}
