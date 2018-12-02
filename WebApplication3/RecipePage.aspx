<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecipePage.aspx.cs" Inherits="WebApplication3.RecipePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   <style>
       
       .auto-style1 {
           text-align: center;
       }

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
        </div>
        <p>
            <div class="auto-style1">
&nbsp;<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource" Height="245px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowDeleting="GridView1_RowDeleting" OnRowCommand="GridView1_RowCommand" Width="407px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" >
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="RecipeName" HeaderText="Your Recipes" SortExpression="RecipeName" />
                    <asp:ButtonField ButtonType="Button"  Text="Delete" HeaderText=""  CommandName="DeleteRow" />
                </Columns>
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#66CCFF" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <%--<SortedAscendingCellStyle BackColor="#F1F1F1" />--%>
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
            </asp:GridView>
            </div>
            <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>" SelectCommand="SELECT [RecipeName] FROM [CookbookRecipes] WHERE ([UserId] = @UserId)">
                <SelectParameters>
                    <asp:SessionParameter Name="UserId" SessionField="UserId" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
        &nbsp;<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        <asp:GridView ID="GridView2" runat="server" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" OnRowEditing ="GridView2_RowEditing">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
