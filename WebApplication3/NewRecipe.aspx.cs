using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using System.Data.Entity;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WebApplication3
{
    public partial class NewRecipe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRecipePage_Click(object sender, EventArgs e)
        {
            Response.Redirect("RecipePage.aspx");
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;

            CookbookDatabaseEntities dbcon = new CookbookDatabaseEntities();
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\camrynroadley\Virtual_Cookbook\WebApplication3\App_Data\CookbookDatabase.mdf;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFrameworkata Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Owner\Desktop\cookbook1\Virtual_Cookbook\WebApplication3\App_Data\CookbookDatabase.mdf;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CookbookDatabase.mdf;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFrameworkata Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Owner\Desktop\cookbook1\Virtual_Cookbook\WebApplication3\App_Data\CookbookDatabase.mdf;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From CookbookRecipes where RecipeName = '" + nameTextBox.Text + "' and Ingredients = '" + ingredientsTextBox.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                //UsernameLabel.Visible = true;

            }
            else
            {
                string recipeName = nameTextBox.Text;
                string ingredients = ingredientsTextBox.Text;
                string instructions = instructionsTextBox.Text;

                CookbookRecipe newRecipe = new CookbookRecipe
                {

                    RecipeId = (int)DateTime.Now.ToFileTime(),
                    RecipeName = recipeName,
                    Ingredients = ingredients,
                    Instructions = instructions,
                    UserId = -1311229662 // hardcoded so that it matches my user id
                };

                dbcon.CookbookRecipes.Add(newRecipe);
                dbcon.SaveChanges();
                Response.Redirect("Recipepage.aspx");

            }
/*
            if (IsPostBack)
            {
                Validate();
                if (IsValid)
                {
                    string recipeName = nameTextBox.Text;
                    string ingredients = ingredientsTextBox.Text;
                    string instructions = instructionsTextBox.Text;
                   
                    CookbookRecipe newRecipe = new CookbookRecipe();
                    newRecipe.RecipeId = (int)DateTime.Now.ToFileTime();
                    newRecipe.RecipeName = recipeName;
                    newRecipe.Ingredients = ingredients;
                    newRecipe.Instructions = instructions;

                    dbcon.CookbookRecipes.Add(newRecipe);
                    dbcon.CookbookRecipes.SaveChanges();

                    Response.Redirect("RecipePage.aspx");

                }
            }
            */
        }
    }
}