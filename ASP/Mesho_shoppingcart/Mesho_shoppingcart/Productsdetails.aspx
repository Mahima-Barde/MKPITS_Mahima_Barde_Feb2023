<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productsdetails.aspx.cs" Inherits="Mesho_shoppingcart.Productsdetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:DataList ID="DataList1" runat="server" OnSelectedIndexChanged="DataList1_SelectedIndexChanged">
         <ItemTemplate>
              <table cellpadding="2" cellspacing="-1" border="1" style="width:100%; height:0px;
                                           border:1px ; background-color: #FFFFFF">

                           
                               <table width="100%" style="margin: 2em;margin-top: 4em">
                                   <tr>
                           <td align="center" style="padding-bottom:3em;border:1px groove;">
                                    <%-- <asp:Label ID="prodname" Text='<%# Eval("prodname") %>' runat ="server"/>--%>

                                 
                               <asp:Image ID="Image1" ImageUrl='<%# Bind("prodimage", "~/{0}") %>' runat="server"

Height="250" Width="200" margin="3em"/></td>
                               <td  style="border:1px groove;width: 46%;">
                                   
                                  <div style="border:1px groove; margin: 1em;">
                             <h2 style="color:thistle;">     <asp:Label ID="Label1" Text='<%# Eval("prodname") %>' runat ="server" /></h2>
                                     <h1> RS.<asp:Label ID="Label2" Text='<%# Eval("prodprice") %>' runat ="server" /></h1>
                                       </div>
                                   <div style="border:1px groove; margin: 1em;">
                                       <h3>Sizes</h3>
                                       <h4>S,M,L,XL</h4>
                                       </div>
                                   <div style="border:1px groove; margin: 1em;">
                                       <b>Product Details</b><br/>
                                          Name :<%# Eval("prodname") %> <br />
                                           Description:<%# Eval("proddescription") %> <br />
                                        Sleeve Length : Short Sleeves<br/>
                                        Pattern : Solid</br>
                                        Sizes : </br>
                                        S (Bust Size : 34 in)
                                        M (Bust Size : 36 in)
                                        L (Bust Size : 38 in)
                                        XL (Bust Size : 40 in)</br>
                                        Country of Origin : India
                                       </div>
                                       
                                        

                                        <%-- <asp:Label ID="Label2" Text='<%# Eval("prodname") %>' runat ="server"/>--%>

                                      

                                   </td></tr>
                                   <tr style="margin-top:2em;">
                                       <td>
                                           <br/>
                                           
                                       <a style="text-decoration:none;padding:10px;background-color:powderblue;border-color:black;margin: 9em;border-radius:10px" href='<%# Eval("prodid","cart.aspx?prodid={0}") %>'>Add to Cart</a>
                                         
                                       <a style="text-decoration:none;padding:10px;background-color:powderblue;border-color:black;margin: 2em;border-radius:10px"  href="cart.aspx">Buy Now</a></td>
                                       </tr>
                                   </table>
                  
                  </table>

                               </ItemTemplate>


    </asp:DataList>


</asp:Content>
