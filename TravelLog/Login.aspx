<%@ Page Language="C#" UnobtrusiveValidationMode="None" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TravelLog.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet1.css" rel="stylesheet" type="text/css">
</head>
<body>
    <form id="form1" class="center" runat="server">
        <asp:HyperLink runat="server" Text="Admin Login" NavigateUrl="AdminLogin.aspx"></asp:HyperLink>
        <div>
            <p class="mainLbl">Travel Log</p><br />
            <br />
            <p class="readLbl">Username:</p>
            <asp:TextBox CssClass="box" ID="txtUsername" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUsername" ErrorMessage="Username is required." ForeColor="#CC0000" ValidationGroup="loginValidationGroup"></asp:RequiredFieldValidator>
            <br />
            <br />
            <p class="readLbl">Password:</p>
            <asp:TextBox CssClass="box" ID="txtPassword" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password is required." ForeColor="#CC0000" ValidationGroup="loginValidationGroup"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" ValidationGroup="loginValidationGroup" />
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSignup" runat="server" OnClick="btnSignup_Click" Text="Sign Up" />
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TravelLogCS %>" SelectCommand="SELECT * FROM [User]"></asp:SqlDataSource>
        <br />
        <br />
        <asp:Label CssClass="readLbl" ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
    </form>
</body>
</html>
