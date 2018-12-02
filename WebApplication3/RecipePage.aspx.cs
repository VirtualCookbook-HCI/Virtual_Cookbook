﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication3
{
    public partial class RecipePage : System.Web.UI.Page
    {
        static string recipeName = "";
        static string ingredients = "";
        static string instructions = "";
        static int recipeId = 0;

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        /* For when user selects a recipe from gridview1 */
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectLabel.Visible = true;

            // get the name of the selected recipe
            foreach (GridViewRow row in GridView1.Rows)
            {
                if (row.RowIndex == GridView1.SelectedIndex)
                {
                    recipeName = row.Cells[1].Text;
                    Session["recipeName"] = recipeName;
                }
            }

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CookbookDatabase.mdf;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");

            SqlDataAdapter sda = new SqlDataAdapter("Select RecipeName, Ingredients, Instructions From CookbookRecipes where RecipeName = '" + recipeName + "'", con);

            // fill gridview2 with the selected recipe details
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GridView2.DataSource = dt;
            GridView2.DataBind();
            foreach (GridViewRow row in GridView2.Rows)
            {
                row.BackColor = Color.White;
            }

            // Store sessions of ingredients and instructions to be used if the user wants to edit the recipe
            Session["ingredients"] = dt.Rows[0][1].ToString();
            Session["instructions"] = dt.Rows[0][2].ToString();
            ingredients = dt.Rows[0][1].ToString();
            instructions = dt.Rows[0][2].ToString();

            // Store a session of the recipe id if the user wants to edit the recipe
            SqlDataAdapter sda1 = new SqlDataAdapter("Select RecipeId From CookbookRecipes where RecipeName = '" + recipeName + "'", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            Session["recipeId"] = dt1.Rows[0][0];
            recipeId = (int)dt1.Rows[0][0];
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName == "DeleteRow")
            {
                CookbookDatabaseEntities dbcon = new CookbookDatabaseEntities();

                // make an original recipe, this will be deleted and replaced by new recipe with the same id
                CookbookRecipe originalRecipe = new CookbookRecipe
                {
                    RecipeId = recipeId,
                    RecipeName = recipeName,
                    Ingredients = ingredients,
                    Instructions = instructions,
                    UserId = (int)Session["UserID"]
                };
                // remove the old recipe
                dbcon.CookbookRecipes.Attach(originalRecipe);
                dbcon.CookbookRecipes.Remove(originalRecipe);
                
                GridView1.DataBind();
            }
        }
      
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            CookbookDatabaseEntities dbcon = new CookbookDatabaseEntities();

            // make an original recipe, this will be deleted and replaced by new recipe with the same id
            CookbookRecipe originalRecipe = new CookbookRecipe
            {
                RecipeId = recipeId,
                RecipeName = recipeName,
                Ingredients = ingredients,
                Instructions = instructions,
                UserId = (int)Session["UserID"]
            };
            // remove the old recipe
            dbcon.CookbookRecipes.Attach(originalRecipe);
            dbcon.CookbookRecipes.Remove(originalRecipe);

            GridView1.DataBind();
        }
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CookbookDatabase.mdf;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
        //int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());

        //con.Open();
        //SqlCommand cmd = new SqlCommand("DELETE FROM CookbookUsers WHERE RecipeId='" + id + "'", con);
        //cmd.CommandType = CommandType.StoredProcedure;
        //cmd.Parameters.AddWithValue("@RecipeId", id);
        //cmd.ExecuteNonQuery();
        //con.Close();
        //GridView1.DataBind();

        //string recipeName = "";
        //foreach (GridViewRow row in GridView1.Rows)
        //{
        //    if (row.RowIndex == GridView1.SelectedIndex)
        //    {
        //        recipeName = "'" + row.Cells[1].Text + "'";

        //    }
        //} 

        /* For when user selects a recipe to edit from gridview2 */
        protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Response.Redirect("EditRecipe.aspx");
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}