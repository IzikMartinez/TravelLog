<%@ Page Language="C#" CodeBehind="AdminConsole.aspx.cs" Inherits="TravelLog.AdminConsole" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Title</title>
</head>
<body>
<form id="HtmlForm" runat="server">
    <div>
        
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="User_ID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="User_ID" HeaderText="User_ID" InsertVisible="False" ReadOnly="True" SortExpression="User_ID" />
                <asp:BoundField DataField="User_Username" HeaderText="User_Username" SortExpression="User_Username" />
                <asp:BoundField DataField="User_Password" HeaderText="User_Password" SortExpression="User_Password" />
                <asp:BoundField DataField="User_Email" HeaderText="User_Email" SortExpression="User_Email" />
            </Columns>
        </asp:GridView>
        
    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TravelLogCS %>" SelectCommand="SELECT * FROM [User]"></asp:SqlDataSource>
</form>
</body>
</html>