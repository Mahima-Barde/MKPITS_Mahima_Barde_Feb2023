<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Vendor master.aspx.cs" Inherits="Item_trasaction_table_database.Vendor_master" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Vendor Information
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
        <hr>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Vendor Id"></asp:Label>
&nbsp;:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Vendor Name"></asp:Label>
&nbsp; :<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Add" />
&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Modify" />
&nbsp;
            <asp:Button ID="Button3" runat="server" Text="Delete" />
            <br />
        </div>
    </form>
</body>
</html>
