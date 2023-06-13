<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Gridview_EMI_Dataset.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Dataset-&gt;Datatable-&gt;DataColumn-&gt;DataRows-&gt;&nbsp;&nbsp;&nbsp; Datable-&gt;Dataset<br />
            <br />
        </div>
        <p>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Load" />
        </p>
        <hr>
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Show EMI" />
        <br />
    </form>
</body>
</html>
