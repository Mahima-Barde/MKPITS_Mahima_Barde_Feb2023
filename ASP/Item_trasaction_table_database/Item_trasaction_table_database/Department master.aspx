<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Department master.aspx.cs" Inherits="Item_trasaction_table_database.Department_master" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Department Information
            <br />
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <hr>
        <asp:Label ID="Label1" runat="server" Text="Department Id"></asp:Label>
&nbsp;:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<p>
            <asp:Label ID="Label2" runat="server" Text="Department Name"></asp:Label>
&nbsp;:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Add" />
&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Modify" />
&nbsp;
            <asp:Button ID="Button3" runat="server" Text="Delete" />
        </p>
    </form>
</body>
</html>
