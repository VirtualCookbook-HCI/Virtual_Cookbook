using System;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            //TextBox1.Text = Session["UserId"].ToString();
        }
        protected void AddRecipe_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewRecipe.aspx");
        
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Web.Security.FormsAuthentication.SignOut();
            Response.Redirect("~/Login.aspx");
        }

        protected void DetailsView1_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
        {
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string recipeName = "";
            foreach (GridViewRow row in GridView1.Rows)
            {
                if (row.RowIndex == GridView1.SelectedIndex)
                {
                    recipeName = "'" + row.Cells[1].Text + "'";
                }
            }

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CookbookDatabase.mdf;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");

            SqlDataAdapter sda = new SqlDataAdapter("Select RecipeName, Ingredients, Instructions From CookbookRecipes where RecipeName = " + recipeName, con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            GridView2.DataSource = dt;
            GridView2.DataBind();
            foreach (GridViewRow row in GridView2.Rows)
            {
                // can use this foreach to design the gridview
                row.BackColor = Color.White;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewRecipe.aspx");
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}