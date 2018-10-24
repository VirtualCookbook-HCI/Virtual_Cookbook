using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;

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

            if (IsPostBack)
            {
                Validate();
                if (IsValid)
                {
                    string email = emailTextBox.Text;
                    string username = usernameTextBox.Text;
                    string password = passwordTextBox.Text;

                    Label1.Text = "test";

                    CookbookUser newUser = new CookbookUser();

                    //User newUser = new User();
                    newUser.UserId = (int) DateTime.Now.ToFileTime();
                    newUser.Email = email;
                    newUser.Username = username;
                    newUser.Password = password;

                    dbcon.CookbookUsers.Add(newUser);
                    dbcon.SaveChanges();

                    Response.Redirect("RecipePage.aspx");

                }
            }

        }
    }
}