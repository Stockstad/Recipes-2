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
        public Form1()
        {
            InitializeComponent();
        }



        private void ShowBtn_Click(object sender, EventArgs e)
        {
            var selected = ProgramManager.recipes.FirstOrDefault(o => o.Name == RecipesList.SelectedItem);
            if (selected != null)
            {
                RecipesList.Items.Clear();
                foreach (var ingredient in selected.Ingredient)
                {
                    RecipesList.Items.Add(ingredient);
                }
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            foreach (string file in currentDirectory)
            {
                ProgramManager.recipes.Add(JsonConvert.DeserializeObject<Recipe>(File.ReadAllText(file)));
            }
            RefreshList();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Adder add = new Adder();
            add.ShowDialog();
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            RecipesList.Items.Clear();
            RefreshList();
        }

        private void RefreshList()
        {
            foreach (var rec in ProgramManager.recipes)
            {
                RecipesList.Items.Add(rec.ToString());
            }
        }

        private void shopListBtn_Click(object sender, EventArgs e)
        {
            ShoppingList shop = new ShoppingList();
            shop.ShowDialog();
        }
    }

  
}