﻿<%@ Page Language="C#" UnobtrusiveValidationMode="None" AutoEventWireup="true" CodeBehind="Main Page.aspx.cs" Inherits="TravelLog.Main_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet1.css" rel="stylesheet" type="text/css"/>
</head>
<body>
    <form id="log" runat="server">
        <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClientClick="this.form.reset(); Response.Redirect(Login.aspx); return false;" />
    </form>
    <form id="form1" runat="server">
        <asp:ImageButton ID="imgBackground" runat="server" Height="558px" ImageUrl="~/World Map Image.png" OnClick="map_Click" Width="1129px" />
        <br />
        <asp:Button ID="btnAdd" runat="server" Text="Add Pinpoint" OnClick="btnAdd_Click" />
        <p>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TravelLogCS %>" SelectCommand="SELECT * FROM [Pinpoint]"></asp:SqlDataSource>
        </p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
