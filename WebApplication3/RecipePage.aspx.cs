using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            //comment this section out to get rid of the datasource error when you click on 'Details' in the gridview
            DataSet ds = new DataSet();

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CookbookDatabase.mdf;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");

            SqlDataAdapter sda = new SqlDataAdapter("Select * From CookbookRecipes where RecipeName = '" + Session["RecipeName"] + "'", con);

            sda.Fill(ds, "CookbookRecipes");
            DetailsView1.DataSource = ds.Tables["CookbookRecipes"];
            DetailsView1.DataBind(); 
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewRecipe.aspx");
        }
    }
}