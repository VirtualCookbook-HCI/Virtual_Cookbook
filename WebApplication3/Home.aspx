﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication3.Home" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
            height:100%;
            background-image: url("https://images.pexels.com/photos/139259/pexels-photo-139259.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940");
            background-repeat: no-repeat;
            background-size: 100% 100%;
            background-attachment: fixed;
            display:flex;
            justify-content:center;
            <!--align-items:center;-->
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Franklin Gothic Demi Cond" Font-Size="XX-Large" ForeColor="#33CCCC" Text="Welcome to Virtual Cookbook"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="White" Text="Please login or create an account to continue"></asp:Label>
            <br />
            <br />
            <asp:Button ID="loginButton" runat="server" OnClick="loginButton_Click" Text="Login" BackColor="#66CCFF" BorderStyle="Outset" Font-Bold="True" Font-Size="X-Large" ForeColor="White" BorderColor="#66CCFF" Font-Names="Calibri" Width="179px"/>
&nbsp;
            <asp:Button ID="registerButton" runat="server" OnClick="registerButton_Click" Text="Register" BackColor="#66CCFF" BorderStyle="Outset" Font-Bold="True" Font-Size="X-Large" ForeColor="White" BorderColor="#66CCFF" Font-Names="Calibri" Width="179px" />
        </div>
    </form>
</body>
</html>
