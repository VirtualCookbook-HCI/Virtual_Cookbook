<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication3.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Welcome to Virtual Cookbook<br />
            <br />
            Please login or create an account to continue<br />
            <br />
            <asp:Button ID="loginButton" runat="server" OnClick="loginButton_Click" Text="Login" />
&nbsp;
            <asp:Button ID="registerButton" runat="server" OnClick="registerButton_Click" Text="Register" />
        </div>
    </form>
</body>
</html>
