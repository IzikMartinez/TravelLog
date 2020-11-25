<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add Pinpoint.aspx.cs" Inherits="TravelLog.Add_Pinpoint" %>

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
        <asp:TextBox ID="TextBox1" runat="server" Width="222px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Date"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Width="222px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Description"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <p>
            <asp:TextBox ID="TextBox3" runat="server" Height="214px" Width="537px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Finish" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
