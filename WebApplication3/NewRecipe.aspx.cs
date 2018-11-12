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
        int recipeId = 0;
        string[] ingredients = new string[15]; // has a cap of 15 ingredients right now
        CookbookDatabaseEntities dbcon;

        protected void Page_Load(object sender, EventArgs e)
        {
            recipeId = (int)DateTime.Now.ToFileTime();
            dbcon = new CookbookDatabaseEntities();

        }

        protected void btnRecipePage_Click(object sender, EventArgs e)
        {
            Response.Redirect("RecipePage.aspx");
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;

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
                    RecipeId = recipeId,
                    RecipeName = recipeName,
                    Ingredients = ingredients, // might want to get rid of instructions in recipe and just have them in their own database
                    Instructions = instructions,
                    UserId = -1311229662 // hardcoded so that it matches my user id
                };

                for (int i = 0; i < ingredients.Length; i++)
                {
                    CookbookIngredient newIngredient = new CookbookIngredient
                    {
                        IngredientId = i,
                        IngredientName = ingredients[i].ToString(),
                        RecipeId = recipeId
                    };

                    dbcon.CookbookIngredients.Add(newIngredient);
                }

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

        int count = 0;
        protected void Button1_Click(object sender, EventArgs e)
        {
            string ingredientName = ingredientsTextBox.Text;
            ingredients[count] = ingredientName;
            count++;

            //dbcon.CookbookIngredients.Add(newIngredient);
            //dbcon.SaveChanges();

            ingredientsTextBox.Text = "";
        }
    }
}