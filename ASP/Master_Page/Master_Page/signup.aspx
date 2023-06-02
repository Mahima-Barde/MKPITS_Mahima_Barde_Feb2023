<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="Master_Page.signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style7 {
        text-align: center;
    }
    .auto-style8 {
        width: 100%;
    }
    .auto-style10 {
        width: 531px;
        text-align: right;
    }
    .auto-style11 {
        margin-left: 19px;
    }
    .auto-style12 {
        margin-left: 21px;
    }
    .auto-style13 {
        margin-left: 22px;
    }
    .auto-style14 {
        color: #006600;
    }
    .auto-style15 {
        font-size: x-large;
    }
    .auto-style16 {
        width: 531px;
        text-align: right;
        height: 30px;
    }
    .auto-style17 {
        height: 30px;
    }
        .auto-style18 {
            margin-left: 5px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style7">
    &nbsp;</p>
<p class="auto-style7">
    <span class="auto-style14"><span class="auto-style15">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Enter information to</span><strong><span class="auto-style15"> Signup</span></strong></span><br class="auto-style15" />
</p>
<table class="auto-style8">
    <tr>
        <td class="auto-style16">Username:</td>
        <td class="auto-style17">&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="TextBox1" runat="server" BackColor="Silver" BorderColor="Silver" ForeColor="#333333" CssClass="auto-style18"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="User name cannot be empty">Please Enter user name</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style10">Password:</td>
        <td>
            &nbsp;
            <asp:TextBox ID="TextBox2" runat="server" BackColor="Silver" CssClass="auto-style11" Width="174px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </td>
    </tr>
    <tr>
        <td class="auto-style10">E-mail Id:</td>
        <td>
            &nbsp;
            <asp:TextBox ID="TextBox3" runat="server" BackColor="Silver" CssClass="auto-style12" Width="232px"></asp:TextBox>
        &nbsp;
        </td>
    </tr>
    <tr>
        <td class="auto-style10">Mobile number:</td>
        <td>
            &nbsp;
            <asp:TextBox ID="TextBox4" runat="server" BackColor="Silver" CssClass="auto-style13"></asp:TextBox>
        </td>
    </tr>
</table>
<p class="auto-style7">
    <asp:Button ID="Button1" runat="server" BorderStyle="Groove" ForeColor="#0033CC" Text="Sign up" />
</p>
<p>
    &nbsp;</p>
<asp:ValidationSummary ID="ValidationSummary1" runat="server" />
<p>
</p>
</asp:Content>
