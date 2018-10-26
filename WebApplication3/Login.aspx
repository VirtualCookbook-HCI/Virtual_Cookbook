<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication3.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Login:</p>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/CreateAccount.aspx">Don&#39;t Have an Account, Register Now</asp:HyperLink>
        </p>
        <p>
            Username:
            <asp:TextBox ID="usernameTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Password:
            <asp:TextBox ID="passwordTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="SubmitButton" runat="server" OnClick="SubmitButton_Click" Text="Login" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Invalid Username or Password" Visible="False"></asp:Label>
        </p>
    </form>
</body>
</html>
