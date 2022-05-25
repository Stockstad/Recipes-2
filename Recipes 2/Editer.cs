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
    public partial class Editor : Form
    {
        Recipe editing;
        Recipe oldRecipe;
        Ingredient selected;
        public Editor()
        {
            InitializeComponent();
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            #pragma warning disable CS8601 // Possible null reference assignment.
            editing = ProgramManager.toEdit;
            oldRecipe = ProgramManager.toEdit;

            foreach (var ingredient in editing.Ingredient)
            {
                EditList.Items.Add(ingredient.Name);
            }

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (selected != null)
            {
                editing.Ingredient.Remove(selected);
                selected.Name = NameBox.Text;
                selected.Property = SelectProperty(PropertyBox.Text);
                selected.Quantity = ValueBox.Value;
                MessageBox.Show("Made edits successfully!");
                editing.Ingredient.Add(selected);
                RefreshList();
            }
        }

        private void EditList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = editing.Ingredient.FirstOrDefault(o => o.Name == EditList.SelectedItem);
            if (selected != null)
            {
                NameBox.Text = selected.Name;
                PropertyBox.Text = selected.Property.ToString();
                ValueBox.Value = selected.Quantity;
            }
        }

        private Prop SelectProperty(string property) //Checking what the property type is.
        {
            if (property == "Litre") { return Prop.litre; }
            else if (property == "Amount") { return Prop.amount; }
            else { return Prop.gram; }
        }

        private void RefreshList()
        {
            EditList.Items.Clear();
            foreach (var ingredient in editing.Ingredient)
            {
                EditList.Items.Add(ingredient.Name);
            }

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            ProgramManager.recipes.Remove(oldRecipe);
            File.Delete(Directory.GetCurrentDirectory() + @"\recipes\" + oldRecipe.Name + ".json");
            ProgramManager.recipes.Add(editing);
            File.WriteAllText(Directory.GetCurrentDirectory() + @"\recipes\" + editing.Name + ".json", JsonConvert.SerializeObject(editing));
            this.Close();
        }

        private void AddNewBtn_Click(object sender, EventArgs e)
        {
            var n = NameBox.Text;
            var p = SelectProperty(PropertyBox.Text);
            var q = ValueBox.Value;
            Ingredient ingred = new(n, q, p);
            editing.Ingredient.Add(ingred);
            RefreshList();
       
        }
    }
}
