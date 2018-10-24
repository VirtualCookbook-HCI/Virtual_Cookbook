using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
                    dbcon.SaveChanges();

                    Response.Redirect("RecipePage.aspx");

                }
            }
        }
    }
}