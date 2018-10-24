<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateAccount.aspx.cs" Inherits="WebApplication3.CreateAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Create Account:</p>
        <p>
            Email:
            <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            User name:
            <asp:TextBox ID="usernameTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Password:<asp:TextBox ID="passwordTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="createAccountButton" runat="server" OnClick="createAccountButton_Click" Text="Submit" />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
