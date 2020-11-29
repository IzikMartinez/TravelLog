<%@ Page Language="C#" UnobtrusiveValidationMode="None" AutoEventWireup="true" CodeBehind="Add Pinpoint.aspx.cs" Inherits="TravelLog.Add_Pinpoint" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Travel Log"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Location"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtLocation" runat="server" Width="222px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Date"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtDate" runat="server" Width="222px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Description"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <p>
            <asp:TextBox ID="txtDescription" runat="server" Height="214px" Width="537px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnFinish" runat="server" OnClick="btnFinish_Click" Text="Finish" CssClass="button" />
        </p>
        <p>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TravelLogConnectionString %>" SelectCommand="SELECT * FROM [Pinpoint]"></asp:SqlDataSource>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
