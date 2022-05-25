using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Recipes_2
{
    public partial class Adder : Form
    {
        List<Ingredient> newIngredients = new List<Ingredient>(); //Temporary ingredient list when adding a new recipe. 
        public Adder()
        {
            InitializeComponent();
        }

        private void CreateBtn_Click(object sender, EventArgs e) //Finalises the recipe and converts it into a .json file.
        {
            var newRecipe = new Recipe();
            newRecipe.Name = RecipeNameBox.Text;
            newRecipe.Ingredient = newIngredients;
            File.WriteAllText(Directory.GetCurrentDirectory() + @"\recipes\" + newRecipe.Name + ".json", JsonConvert.SerializeObject(newRecipe));
            MessageBox.Show("Recipe created successfully.");
            ProgramManager.recipes.Add(newRecipe);
            this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e) //Adds an ingredient into the ingredient list taking arguments from elements.
        {
            newIngredients.Add(new Ingredient(IngredientName.Text, Amount.Value, ComboValue()));
            RefreshList();
        }

        private Prop ComboValue() //Checking what the property type is.
        {
            if (Property.Text == "Litre") { return Prop.litre; }
            else if (Property.Text == "Amount") { return Prop.amount; }
            else { return Prop.gram; }
        } 

        private void RefreshList() //Refreshes the list.
        {
            AddedList.Items.Clear();
            foreach (var ingred in newIngredients)
            {
                AddedList.Items.Add(ingred.ToString());
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e) //Removes a selected ingredient from the list. 
        {
            if (AddedList.SelectedIndex != -1)
            {
                newIngredients.RemoveAt(AddedList.SelectedIndex);
                RefreshList();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BackToMenuBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } 
}
