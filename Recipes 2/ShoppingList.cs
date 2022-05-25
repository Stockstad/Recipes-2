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
        List<Ingredient> shoppingList = new List<Ingredient>(); //the randomised list of recipes.
        List<Ingredient> finalList = new List<Ingredient>(); //the list that later gets sorted and queried. 
        string password = "GoesLikeClockwork88"; //Yes, this is the password. Don't bother stealing it; there's nothing on that account. 
        string sendTo = string.Empty; //Email to send to.
        string fullList = string.Empty; //Email text. 


        public ShoppingList()
        {
            InitializeComponent();
        }

        private void CreateListBtn_Click(object sender, EventArgs e) //Creates a preview shopping list and shows it to the user.
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
            catch (System.ArgumentOutOfRangeException)  //If the user has too few recipes this error gets thrown.
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

        private void BackBtn_Click(object sender, EventArgs e) //Returns to the menu.
        {
            this.Close();
        }

        private void SendBtn_Click(object sender, EventArgs e ) //send the email including the recipe. 
        {
            string htmlString = CreateString();
            Email(htmlString); //Pass html string to Email function.  


        }

        private void Email(string htmlString) //Intilalises the email. NOTICE!!! As of 1th of May 2022 this feature will not work.
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

        private string CreateString() //Transforms the ShoppingList into a string reday to be sent as an email. 
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