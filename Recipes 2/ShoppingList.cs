using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Recipes_2
{
    public partial class ShoppingList : Form
    {
        List<Ingredient> shoppingList = new List<Ingredient>();
        List<Ingredient> finalList = new List<Ingredient>();
        string password = "GoesLikeClockwork88";
        string sendTo = string.Empty;
        string fullList = string.Empty;


        public ShoppingList()
        {
            InitializeComponent();
        }

        private void CreateListBtn_Click(object sender, EventArgs e)
        {
            finalList.Clear();
            shoppingList.Clear();
            ShoppingShowList.Items.Clear();
            NeededList.Items.Clear();
            int total = (int)dayBox.Value * (int)mealBox.Value;
            ProgramManager.recipes = ProgramManager.Shuffle();

            try
            {
                for (int i = 0; i < total; i++)
                {
                    shoppingList.AddRange(ProgramManager.recipes[i].Ingredient);
                    NeededList.Items.Add(ProgramManager.recipes[i].Name);
                }
            }
            catch (System.ArgumentOutOfRangeException) 
            {
                MessageBox.Show("You don't have enough recipes. Please add some more.");
            }
             finalList = shoppingList
              .GroupBy(x => x.Name)
              .Select(x => new Ingredient(x.First().Name,x.Sum(y=>y.Quantity),x.First().Property))
              .ToList();

            foreach (var ingredient in finalList)
            {
                ShoppingShowList.Items.Add(ingredient);
            }


        }

        private void ShoppingList_Load(object sender, EventArgs e)
        {
          
        
                  
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            string htmlString = CreateString();
            Email(htmlString); //Pass html string to Email function.  


        }

        private void Email(string htmlString)
        {
            try
            {
                sendTo = MailBox.Text;
                if (sendTo != string.Empty)
                {
                    MailMessage message = new MailMessage();
                    SmtpClient smtp = new SmtpClient();
                    message.From = new MailAddress("noreply.recipes2@gmail.com");
                    message.To.Add(new MailAddress(sendTo));
                    message.Subject = "Your Shopping List";
                    message.Body = htmlString;
                    smtp.Port = 587;
                    smtp.Host = "smtp.gmail.com"; //for gmail host  
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential("noreply.recipes2@gmail.com", password);
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Send(message);
                    MessageBox.Show("The shopping list has been successfully sent to the mail you provided!");
                }
                else
                    MessageBox.Show("Enter a valid e-mail if you want to send it!");
            }
            catch (Exception) { MessageBox.Show("Something went wrong. The mail was not sent. Check your internet connection or restart the program."); }
        }

        private string CreateString()
        {
            fullList += "Your shopping list:\n";
            foreach (var ingredient in shoppingList)
            {
                fullList += ingredient .ToString() + "\n";
            }
            fullList += "Do not reply to this message. If you have any questions, please refer to the official GitHub page. Happy cooking!";
            return fullList;         
        }
    }

}