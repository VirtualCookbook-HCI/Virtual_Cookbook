using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;

            CookbookDatabaseEntities dbcon = new CookbookDatabaseEntities();

            if (IsPostBack)
            {
                Validate();
                if (IsValid)
                {
                    string username = usernameTextBox.Text;
                    string password = passwordTextBox.Text;

                    dbcon.CookbookUsers.SqlQuery($"SELECT * FROM CookbookUsers WHERE Username = {username} AND Password = {password}");

                    dbcon.SaveChanges();
                    Response.Redirect("RecipePage.aspx");

                }
            }
        }
    }
}