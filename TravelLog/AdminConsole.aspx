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
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="User_ID" HeaderText="User_ID" InsertVisible="False" ReadOnly="True" SortExpression="User_ID" />
                <asp:BoundField DataField="User_Username" HeaderText="User_Username" SortExpression="User_Username" />
            </Columns>
        </asp:GridView>
        
        <asp:DetailsView ID="DetailsView1" runat="server" DataSourceID="dbControl" Height="50px" Width="125px">
            <Fields>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
            </Fields>
        </asp:DetailsView>
        
    </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TravelLogCS %>" SelectCommand="SELECT [User_ID], [User_Username] FROM [User]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="dbControl" runat="server" ConnectionString="<%$ ConnectionStrings:TravelLogCS %>" DeleteCommand="DELETE FROM [User] WHERE [User_ID] = @User_ID" InsertCommand="INSERT INTO [User] ([User_Username], [User_Password], [User_Email]) VALUES (@User_Username, @User_Password, @User_Email)" SelectCommand="SELECT * FROM [User] WHERE ([User_ID] = @User_ID)" UpdateCommand="UPDATE [User] SET [User_Username] = @User_Username, [User_Password] = @User_Password, [User_Email] = @User_Email WHERE [User_ID] = @User_ID">
        <DeleteParameters>
            <asp:Parameter Name="User_ID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="User_Username" Type="String" />
            <asp:Parameter Name="User_Password" Type="String" />
            <asp:Parameter Name="User_Email" Type="String" />
        </InsertParameters>
        <SelectParameters>
            <asp:ControlParameter ControlID="GridView1" Name="User_ID" PropertyName="SelectedValue" Type="Int32" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="User_Username" Type="String" />
            <asp:Parameter Name="User_Password" Type="String" />
            <asp:Parameter Name="User_Email" Type="String" />
            <asp:Parameter Name="User_ID" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</form>
</body>
</html>