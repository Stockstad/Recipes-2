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
        Recipe selected;
        bool isMenu = true;
        string[] currentDirectory = Directory.GetFiles(Directory.GetCurrentDirectory() + @"\recipes\", "*.json");//Get the older, saved recipe files.
        public Form1()
        {
            InitializeComponent();
        }



        private void ShowBtn_Click(object sender, EventArgs e) //Show selected recipe from the list.
        {
            if (isMenu)
            {
                selected = ProgramManager.recipes.FirstOrDefault(o => o.Name == RecipesList.SelectedItem);
                if (selected != null)
                {
                    isMenu = false;
                    ShowBtn.Text = "Back";
                    EditBtn.Show();
                    RecipesList.Items.Clear();
                    foreach (var ingredient in selected.Ingredient)
                    {
                        RecipesList.Items.Add(ingredient);
                    }
                }
            }
            else
            {
                isMenu = true;
                ShowBtn.Text = "Show";
                RecipesList.Items.Clear();
                RefreshList();
                EditBtn.Hide();
            }
        }

        private void OnLoad(object sender, EventArgs e) //Deserialises the .json:s and displays already saved recipes.
        {
            EditBtn.Hide();
            foreach (string file in currentDirectory)
            {
                ProgramManager.recipes.Add(JsonConvert.DeserializeObject<Recipe>(File.ReadAllText(file)));
            }
            RefreshList();
        }

        private void AddBtn_Click(object sender, EventArgs e) //Takes user to the add page.
        {
            Adder add = new Adder();
            add.ShowDialog();
        }

        private void menuBtn_Click(object sender, EventArgs e) //Returns the program to its initial state.
        {
          
        }

        private void RefreshList() //Refreshes the visible list.
        {
            foreach (var rec in ProgramManager.recipes)
            {
                RecipesList.Items.Add(rec.ToString());
            }
        }

        private void shopListBtn_Click(object sender, EventArgs e) //Takes the user to the ShoppingList window. 
        {
            ShoppingList shop = new ShoppingList();
            shop.ShowDialog();
        }

        private void ChangeLogLabel_Click(object sender, EventArgs e)
        {

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            
            if (selected != null)
            {
                ProgramManager.EditRecipe(selected);
            }
            Editor editor = new();
            editor.ShowDialog();

        }
    }

  
}