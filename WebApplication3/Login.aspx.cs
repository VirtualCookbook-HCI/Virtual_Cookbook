﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Web.Script;



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

                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CookbookDatabase.mdf;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From CookbookUsers where Username = '" + usernameTextBox.Text + "' and Password = '" + passwordTextBox.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        dbcon.SaveChanges();
                        Response.Redirect("Recipepage.aspx");
                    }
                    else
                    {
                        Label1.Visible = true;
                    }
                }
            }
        }
    }
}