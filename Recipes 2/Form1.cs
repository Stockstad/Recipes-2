using System;
using System.Collections;
using System.Linq;
using System.IO;
using System.Drawing;
using Newtonsoft.Json;

namespace Recipes_2
{
    public partial class Form1 : Form
    {
        string[] currentDirectory = Directory.GetFiles(Directory.GetCurrentDirectory() + @"\recipes\", "*.json");
        List<Recipe> recipes = new List<Recipe>();
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        { 
            RecipesList.Items.Add(recipes[0].Name);
            foreach (var ingredient in recipes[0].Ingredient)
            {
                RecipesList.Items.Add(ingredient.ToString());
            }

        }

        private void OnLoad(object sender, EventArgs e)
        {
            foreach (string file in currentDirectory)
            {
                recipes.Add(JsonConvert.DeserializeObject<Recipe>(File.ReadAllText(file)));
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Adder add = new Adder();
            add.ShowDialog();
        }
    }

  
}