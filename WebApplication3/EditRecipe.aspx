<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditRecipe.aspx.cs" Inherits="WebApplication3.EditRecipe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                <asp:LinkButton runat="server" CssClass="btn btn-default" ID="btnRecipePage" Text="Recipe Page" OnClick="btnRecipePage_Click" BackColor="#66CCFF" BorderStyle="Outset" Font-Bold="True" Font-Size="Large" ForeColor="White" BorderColor="#66CCFF" Font-Names="Calibri"  />
            </h1>
            <h2>Edit Existing Recipe:</h2>
            <p>
                Recipe Name:</p>
            <p>
                &nbsp;<asp:TextBox ID="recipeNameTextBox" runat="server" OnTextChanged="recipeNameTextBox_TextChanged"></asp:TextBox>
            <asp:Label ID="NameLabel" runat="server" Text="Label" Visible="False"></asp:Label>
            </p>
            <p>
                Ingredients: </p>
            <p>
                <asp:TextBox ID="ingredientsTextBox" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="IngredientButton" runat="server" OnClick="IngredientButton_Click" Text="Add Another Ingredient" BackColor="#66CCFF" BorderStyle="Outset" Font-Bold="True" Font-Size="Medium" ForeColor="White" BorderColor="#66CCFF" Font-Names="Calibri" />
            </p>
            <p>
                <asp:Label ID="ingredientsLabel" runat="server" Text="Label"></asp:Label>
            </p>
            <p>
                Instructions:</p>
            <p>
                <asp:TextBox ID="instructionsTextBox" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="InstructionButton" runat="server" OnClick="InstructionButton_Click" Text="Add Another Instruction" BackColor="#66CCFF" BorderStyle="Outset" Font-Bold="True" Font-Size="Medium" ForeColor="White" BorderColor="#66CCFF" Font-Names="Calibri" />

            </p>
            <p>
                <asp:Label ID="instructionsLabel" runat="server" Text="Label"></asp:Label>
            </p>
            <p>
        <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Save" BackColor="#66CCFF" BorderStyle="Outset" Font-Bold="True" Font-Size="Large" ForeColor="White" BorderColor="#66CCFF" Font-Names="Calibri"  />
            </p>
        </div>
    </form>
</body>
</html>
