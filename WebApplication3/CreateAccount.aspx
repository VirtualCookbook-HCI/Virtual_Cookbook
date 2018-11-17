<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateAccount.aspx.cs" Inherits="WebApplication3.CreateAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
            background-color: azure;
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
        <p>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Text="Create Account"></asp:Label>
        </p>
        <p>
            Email:</p>
        <p>
            &nbsp;<asp:TextBox ID="emailTextBox" runat="server" Height="35px" Width="301px"></asp:TextBox>
        </p>
        <p>
            Username:</p>
        <p>
            &nbsp;<asp:TextBox ID="usernameTextBox" runat="server" Height="35px" Width="299px"></asp:TextBox>
            <asp:Label ID="UsernameLabel" runat="server" Text="This Username is already taken." Visible="False"></asp:Label>
        </p>
        <p>
            Password:</p>
        <p>
            <asp:TextBox ID="passwordTextBox" TextMode="Password" runat="server" Height="35px" Width="300px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="createAccountButton" runat="server" OnClick="createAccountButton_Click" Text="Submit" BackColor="#66CCFF" BorderStyle="Outset" Font-Bold="True" Font-Size="Large" ForeColor="White" BorderColor="#66CCFF" Font-Names="Calibri"/>
        </p>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Login.aspx">Already Have an Account? Login Here</asp:HyperLink>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
