<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Application_Session.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Webform 1:<br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Execute" Width="135px" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Transfer" />
            <br />
        </div>
    </form>
</body>
</html>
