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
        static string ingredients = "";
        static string instructions = "";

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
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CookbookDatabase.mdf;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From CookbookRecipes where RecipeName = '" + nameTextBox.Text + "' and Ingredients = '" + ingredientsTextBox.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                //UsernameLabel.Visible = true;

            }
            else
            {
                string recipeName = "";

                // Get remaining ingredients and intructions
                if(ingredientsTextBox.Text != "")
                {
                    ingredients += ingredientsTextBox.Text;
                }

                if (instructionsTextBox.Text != "")
                {
                    instructions += instructionsTextBox.Text;
                }

                // Make sure there is a recipe name
                if (nameTextBox.Text.Equals(""))
                {
                    NameLabel.Text = "*Enter a recipe name";

                }
                else
                {
                    recipeName = nameTextBox.Text;
                    CookbookRecipe newRecipe = new CookbookRecipe
                    {
                        RecipeId = (int)DateTime.Now.ToFileTime(),
                        RecipeName = recipeName,
                        Ingredients = ingredients,
                        Instructions = instructions,
                        UserId = (int)Session["UserID"] // hardcoded so that it matches my user id
                    };

                    dbcon.CookbookRecipes.Add(newRecipe);
                    dbcon.SaveChanges();
                    Response.Redirect("Recipepage.aspx");
                }
            }
        }


        protected void IngredientButton_Click(object sender, EventArgs e)
        {
            string ingredient = ingredientsTextBox.Text;
            ingredients += ingredient + ", ";
            EnteredIngredientsLabel.Visible = true;
            EnteredIngredientsLabel.Text = ingredients;
            ingredientsTextBox.Text = "";
        }

        protected void InstructionButton_Click(object sender, EventArgs e)
        {
            string instruction = instructionsTextBox.Text;
            instructions += instruction + ", ";
            EnteredInstructionsLabel.Visible = true;
            EnteredInstructionsLabel.Text = instructions;
            instructionsTextBox.Text = "";
        }
    }
}