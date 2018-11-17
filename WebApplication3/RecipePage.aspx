<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecipePage.aspx.cs" Inherits="WebApplication3.RecipePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   <style>
       
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="newRecipeButton" runat="server" Height="42px" OnClick="Button2_Click" Text="New Recipe" Width="143px" BackColor="#66CCFF" BorderStyle="Outset" Font-Bold="True" Font-Size="Large" ForeColor="White" BorderColor="#66CCFF" Font-Names="Calibri" />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Logout" Height="40px" Width="88px" BackColor="#66CCFF" BorderStyle="Outset" Font-Bold="True" Font-Size="Large" ForeColor="White" BorderColor="#66CCFF" Font-Names="Calibri" />
        </div>
        <p>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource" Height="245px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="407px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" SelectText="Details" >
                    <ControlStyle Width="20px" />
                    </asp:CommandField>
                    <asp:BoundField DataField="RecipeName" HeaderText="Recipe Name" SortExpression="RecipeName" />
                </Columns>
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>" SelectCommand="SELECT [RecipeName], [Ingredients], [Instructions] FROM [CookbookRecipes] ORDER BY [RecipeName]"></asp:SqlDataSource>
        </p>
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
