<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="DrivenITForm.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        Transaction Form :</p>
<p>
    item id&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :
    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="ItemDescr" DataValueField="ItemId">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:drivenitdbConnectionString %>" ProviderName="<%$ ConnectionStrings:drivenitdbConnectionString.ProviderName %>" SelectCommand="SELECT [ItemId], [ItemDescr] FROM [Itemmaster]"></asp:SqlDataSource>
</p>
    <p>
        Transaction Type :&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="RadioButton1" runat="server" GroupName="tt" Text="Issue" />
&nbsp;&nbsp;
        <asp:RadioButton ID="RadioButton2" runat="server" GroupName="tt" Text="Received" />
</p>
    <p>
        Transaction Quantity:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</p>
    <p>
        Transaction Date&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :<asp:TextBox ID="TextBox2" runat="server" TextMode="Date"></asp:TextBox>
</p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Edit" />
&nbsp;
        <asp:Button ID="Button3" runat="server" Text="Delete" />
</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="TransID" DataSourceID="SqlDataSource2" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="796px">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="TransID" HeaderText="TransID" InsertVisible="False" ReadOnly="True" SortExpression="TransID" />
                <asp:BoundField DataField="ItemID" HeaderText="ItemID" SortExpression="ItemID" />
                <asp:BoundField DataField="TransType" HeaderText="TransType" SortExpression="TransType" />
                <asp:BoundField DataField="TransQty" HeaderText="TransQty" SortExpression="TransQty" />
                <asp:BoundField DataField="TransDate" HeaderText="TransDate" SortExpression="TransDate" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:drivenitdbConnectionString %>" DeleteCommand="DELETE FROM [Transactions] WHERE [TransID] = @TransID" InsertCommand="INSERT INTO [Transactions] ([ItemID], [TransType], [TransQty], [TransDate]) VALUES (@ItemID, @TransType, @TransQty, @TransDate)" SelectCommand="SELECT [TransID], [ItemID], [TransType], [TransQty], [TransDate] FROM [Transactions]" UpdateCommand="UPDATE [Transactions] SET [ItemID] = @ItemID, [TransType] = @TransType, [TransQty] = @TransQty, [TransDate] = @TransDate WHERE [TransID] = @TransID">
            <DeleteParameters>
                <asp:Parameter Name="TransID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="ItemID" Type="Int32" />
                <asp:Parameter Name="TransType" Type="String" />
                <asp:Parameter Name="TransQty" Type="Int32" />
                <asp:Parameter Name="TransDate" Type="DateTime" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="ItemID" Type="Int32" />
                <asp:Parameter Name="TransType" Type="String" />
                <asp:Parameter Name="TransQty" Type="Int32" />
                <asp:Parameter Name="TransDate" Type="DateTime" />
                <asp:Parameter Name="TransID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
</asp:Content>
