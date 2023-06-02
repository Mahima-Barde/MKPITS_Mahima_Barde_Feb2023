<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="signin.aspx.cs" Inherits="Master_Page.signin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style7 {
        text-align: center;
        color: #990099;
    }
    .auto-style8 {
        width: 100%;
    }
    .auto-style9 {
        text-align: right;
        width: 520px;
    }
    .auto-style10 {
        margin-left: 498px;
    }
    .auto-style11 {
        font-size: large;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style7">
    <strong>&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style11">&nbsp;Sign in please</span></strong></p>
<table class="auto-style8">
    <tr>
        <td class="auto-style9"><strong>Username :</strong></td>
        <td>
            <asp:TextBox ID="TextBox6" runat="server" BackColor="Silver"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style9"><strong>Password :</strong></td>
        <td>
            <asp:TextBox ID="TextBox7" runat="server" BackColor="Silver"></asp:TextBox>
        </td>
    </tr>
</table>
<br />
<strong>
<asp:Button ID="Button1" runat="server" BackColor="#3399FF" BorderStyle="Dotted" CssClass="auto-style10" ForeColor="Black" Text="Button" Width="174px" />
</strong>
<br />
</asp:Content>
