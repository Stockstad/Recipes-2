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
        List<Ingredient> newIngredients = new List<Ingredient>();
        public Adder()
        {
            InitializeComponent();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            var newRecipe = new Recipe();
            newRecipe.Name = RecipeNameBox.Text;
            newRecipe.Ingredient = newIngredients;
            File.WriteAllText(Directory.GetCurrentDirectory() + @"\recipes\" + newRecipe.Name + ".json", JsonConvert.SerializeObject(newRecipe));
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            newIngredients.Add(new Ingredient(IngredientName.Text, (int)Amount.Value, ComboValue()));
            RefreshList();
        }

        private Prop ComboValue()
        {
            if (Property.Text == "Litre") { return Prop.litre; }
            else if (Property.Text == "Amount") { return Prop.amount; }
            else { return Prop.gram; }
        } 

        private void RefreshList()
        {
            AddedList.Items.Clear();
            foreach (var ingred in newIngredients)
            {
                AddedList.Items.Add(ingred.ToString());
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (AddedList.SelectedIndex != -1)
            {
                newIngredients.RemoveAt(AddedList.SelectedIndex);
                RefreshList();
            }
        }
    } 
}
