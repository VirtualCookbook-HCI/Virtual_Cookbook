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
            Username:
            <asp:TextBox ID="usernameTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            Password:
            <asp:TextBox ID="passwordTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="SubmitButton" runat="server" OnClick="SubmitButton_Click" Text="Submit" />
        </p>
    </form>
</body>
</html>
