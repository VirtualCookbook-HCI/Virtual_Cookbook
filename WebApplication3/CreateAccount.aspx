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
            Username: <asp:TextBox ID="usernameTextBox" runat="server"></asp:TextBox>
            <asp:Label ID="UsernameLabel" runat="server" Text="This Username is already taken." Visible="False"></asp:Label>
        </p>
        <p>
            Password:<asp:TextBox ID="passwordTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="createAccountButton" runat="server" OnClick="createAccountButton_Click" Text="Submit" />
        </p>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Login.aspx">Already Have an Account, Login Here</asp:HyperLink>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
