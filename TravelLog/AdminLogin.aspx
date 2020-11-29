<%@ Page Title="Title" Language="C#" MasterPageFile="LoginMaster.master" CodeBehind="AdminLogin.aspx.cs" Inherits="TravelLog.AdminLogin" %>

<asp:Content ContentPlaceHolderID="cphHeader" runat="server">
    <p class="mainLbl">Admin Login</p><br />
</asp:Content>

<asp:Content ContentPlaceHolderID="cphButton" ID="cphButton" runat="server">
        <asp:Button runat="server" ID="btnAdminLogin" Text="Admin Login" CssClass="btn" OnClick="btnAdminLogin_OnClick"/>
</asp:Content>

