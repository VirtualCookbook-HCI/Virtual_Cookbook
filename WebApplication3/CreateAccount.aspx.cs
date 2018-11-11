using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WebApplication3
{
    public partial class CreateAccount : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
        {

        }

        protected void createAccountButton_Click(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;

            CookbookDatabaseEntities dbcon = new CookbookDatabaseEntities();
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\meganholme\source\repos\Virtual_Cookbook\WebApplication3\App_Data\CookbookDatabase.mdf;Integrated Security=True;MultipleActiveResultSets=True;Connect Timeout=30;Application Name=EntityFramework");
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CookbookDatabase.mdf;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFrameworkata Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Owner\Desktop\cookbook1\Virtual_Cookbook\WebApplication3\App_Data\CookbookDatabase.mdf;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From CookbookUsers where Username = '" + usernameTextBox.Text + "' and Email = '" + emailTextBox.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                UsernameLabel.Visible = true;
               
            }
            else
            {
                string email = emailTextBox.Text;
                string username = usernameTextBox.Text;
                string password = passwordTextBox.Text;

                CookbookUser newUser = new CookbookUser
                {

                    //User newUser = new User();
                    UserId = (int)DateTime.Now.ToFileTime(),
                    Email = email,
                    Username = username,
                    Password = password
                };

                dbcon.CookbookUsers.Add(newUser);
                dbcon.SaveChanges();
                Response.Redirect("Recipepage.aspx");

            }
        }
    }
}