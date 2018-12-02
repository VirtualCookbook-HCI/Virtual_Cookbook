<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditRecipe.aspx.cs" Inherits="WebApplication3.EditRecipe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
       
       ul{
           list-style-type: none;
           margin: 0;
           padding: 0;
           overflow: hidden;
           background-color: #333;
       }
       li{
           float: left;
       }

       li a{
           display:block;
           color: white;
           text-align: center;
           padding: 14px 16px;
           text-decoration: none;
       }

       li a:hover{
           background-color: #111;
       }
       

       body {
            background-color: azure;
            width:100vw;
            height:100vw;
            display:flex;
            justify-content:center;
            <!--align-items:center;-->
        }
        .auto-style1 {
            text-align: justify;
        }
        .auto-style2 {
            text-align: justify;
        }
               
    </style>
</head>
    <body>
    <ul>
        <li><a class="active" href= "RecipePage.aspx">Recipe Page</a></li>
        <li><a href="NewRecipe.aspx">New Recipe</a></li>
        <li><a href="Login.aspx">Logout</a></li>
    </ul>
    
    <form id="form1" runat="server">
        <div>
            <h1>
                <asp:LinkButton runat="server" CssClass="btn btn-default" ID="btnRecipePage" Text="Recipe Page" OnClick="btnRecipePage_Click" BackColor="#66CCFF" BorderStyle="Outset" Font-Bold="True" Font-Size="Large" ForeColor="White" BorderColor="#66CCFF" Font-Names="Calibri"  />
            </h1>
            <h2 class="auto-style1">Edit Existing Recipe:</h2>
            <p class="auto-style1">
                Recipe Name:&nbsp;&nbsp; </p>
            <p class="auto-style1">
                <asp:TextBox ID="recipeNameTextBox" runat="server"></asp:TextBox>
            </p>
            <p class="auto-style1">
            <asp:Label ID="NameLabel" runat="server" Text="Label" Visible="False"></asp:Label>
            </p>
            <p class="auto-style1">
                Ingredients: </p>
            <p>
                &nbsp;<asp:TextBox ID="ingredientsTextBox" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="IngredientButton" runat="server" OnClick="IngredientButton_Click" Text="Add Another Ingredient" BackColor="#66CCFF" BorderStyle="Outset" Font-Bold="True" Font-Size="Medium" ForeColor="White" BorderColor="#66CCFF" Font-Names="Calibri" />
            </p>
            <p>
                &nbsp;<asp:Label ID="ingredientsLabel" runat="server" Text="Label"></asp:Label>
            </p>
            <p>
                &nbsp;Instructions:</p>
            <p>
                &nbsp;<asp:TextBox ID="instructionsTextBox" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="InstructionButton" runat="server" OnClick="InstructionButton_Click" Text="Add Another Instruction" BackColor="#66CCFF" BorderStyle="Outset" Font-Bold="True" Font-Size="Medium" ForeColor="White" BorderColor="#66CCFF" Font-Names="Calibri" />

            &nbsp;&nbsp;&nbsp;

            </p>
            <p>
                &nbsp;<asp:Label ID="instructionsLabel" runat="server" Text="Label"></asp:Label>
            </p>
            <p>
        &nbsp;<asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Save" BackColor="#66CCFF" BorderStyle="Outset" Font-Bold="True" Font-Size="Large" ForeColor="White" BorderColor="#66CCFF" Font-Names="Calibri"  />
            </p>
        </div>
    </form>
</body>
</html>
