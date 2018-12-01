<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewRecipe.aspx.cs" Inherits="WebApplication3.NewRecipe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <style>
        body {
            background-color: bisque;
            width:100vw;
            height:100vw;
            display:flex;
            justify-content:center;
            <!--align-items:center;-->
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class ="container"></div>
            <div class ="row">
                <h2>
                <asp:LinkButton runat="server" CssClass="btn btn-default" ID="btnRecipePage" Text="Recipe Page" OnClick="btnRecipePage_Click" BackColor="#66CCFF" BorderStyle="Outset" Font-Bold="True" Font-Size="Large" ForeColor="White" BorderColor="#66CCFF" Font-Names="Calibri"  />
                    <br />
                    <br />
                    Add New Recipe:</h2>
            </div>
            <br />
            Recipe <asp:Label runat="server" Text="Name" Font-Size="Large" />
            :&nbsp;<br />
            <br />
            <asp:TextBox runat="server" ID="nameTextBox" Height="35px" Width="301px" />
            <asp:Label ID="NameLabel" runat="server" Text="Label" Visible="False"></asp:Label>
        </div>
        <p>
            <asp:Label runat="server" Text="Ingredients" Font-Size="Large" />
            :</p>
        <p>
            &nbsp;<asp:TextBox runat="server" ID="ingredientsTextBox" Height="35px" Width="300px" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="IngredientButton" runat="server" OnClick="IngredientButton_Click" Text="Add Another Ingredient" BackColor="#66CCFF" BorderStyle="Outset" Font-Bold="True" Font-Size="Medium" ForeColor="White" BorderColor="#66CCFF" Font-Names="Calibri" />
            </p>
        <p>
            <asp:Label ID="EnteredIngredientsLabel" runat="server" Text="Label" Visible="False" Font-Size="Large"></asp:Label>
            </p>
        <p>
            <asp:Label runat="server" Text="Instructions" Font-Size="Large" />

            :</p>
        <p>
            &nbsp;<asp:TextBox runat="server" ID="instructionsTextBox" Height="35px" Width="300px" />

        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="InstructionButton" runat="server" OnClick="InstructionButton_Click" Text="Add Another Instruction" BackColor="#66CCFF" BorderStyle="Outset" Font-Bold="True" Font-Size="Medium" ForeColor="White" BorderColor="#66CCFF" Font-Names="Calibri" />

        </p>
        <asp:Label ID="EnteredInstructionsLabel" runat="server" Text="Label" Visible="False" Font-Size="Large"></asp:Label>
        <br />
        <br />
        <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Save" BackColor="#66CCFF" BorderStyle="Outset" Font-Bold="True" Font-Size="Large" ForeColor="White" BorderColor="#66CCFF" Font-Names="Calibri"  />
    </form>
</body>
</html>
