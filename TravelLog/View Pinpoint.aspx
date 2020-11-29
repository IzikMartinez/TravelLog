<%@ Page Language="C#" UnobtrusiveValidationMode="None" AutoEventWireup="true" CodeBehind="View Pinpoint.aspx.cs" Inherits="TravelLog.View_Pinpoint" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet1.css" rel="stylesheet" type="text/css">
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label CssClass="readLbl" ID="lblLocation" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label CssClass="readLbl" ID="lblDate" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label CssClass="readLbl" ID="lblDescription" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <img id="imgOut" src="Pinpoint Image.png" alt="testing" width="116" height="157">
        <br />
        <br />
        <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click" Text="Return" />
        
    </form>
</body>
</html>
