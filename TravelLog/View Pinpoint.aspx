<%@ Page Language="C#" UnobtrusiveValidationMode="None" AutoEventWireup="true" CodeBehind="View Pinpoint.aspx.cs" Inherits="TravelLog.View_Pinpoint" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblLocation" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblDate" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblDescription" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Image ID="img" runat="server" />
        <br />
        <br />
        <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click" Text="Return" />
    </form>
</body>
</html>
