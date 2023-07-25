<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_login.aspx.cs" Inherits="TMS_Project1_ASP.Net_web_application_.admin.Admin_login" %>

<!doctype html>
<html lang="en">
  <head>
    <title>Login Page</title>
    
    <meta name="viewport" content="width=device-width, initial-scale=1">
     <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-9ndCyUaIbzAi2FUVXJi0CjmCapSmO7SnpJef0486qhLnuZ2cdeRhO02iuK6FUUVM" crossorigin="anonymous">
  
      <link href="../dist/sweetalert2.min.css" rel="stylesheet"/>
      <script src="../dist/sweetalert2.min.js"></script>
<style>
 *{
    padding:0;
    margin: 0;
    box-sizing: border-box;
    padding: 0.5em;
 }
 body{
    background:rgb(142, 176, 176);
    padding-top: 3em;
 }
 .row
 {
  background: white;
  border-radius: 2em;
  padding: 0em;
  height: 100%;
 
 }
 .col-lf-5
 {
    width: 40%;
    max-width: 50%;
 }
 .container
 {
    height: 126%;
    width: 100%;
    box-shadow:20px 20px 50px 10px black;
    border-radius: 2em;
 }
 .col-lg-7
 {
    height:100%;
    padding:0em;
    margin-left: -0.5em;
    margin-top: -0.5em;
    margin-bottom: -0.5em;
 }
 .btn1
 {
padding-inline:-1em;
background-color: rgb(45, 161, 177);
margin-left: 7em;
width: 6em;

 }
 .img-fluid
 {
border-radius: 2em;
 }
 .rowno-guuters
 {
    padding: 1em;
    box-shadow:20px 20px 50px 10px grey;
 }
 .heading
{
    margin-block: -1em;
    margin-block-end: 0em;
    font-size: 3em;
    font-family: cursive;
    font-style: normal;
    width: max-content;
    margin-left: 0.5em;
}
.form-control{
    margin-left:2em;
    width: 175%;
}
.img-fluid
{
    margin-top: -0.5em;
    margin-bottom: -0.5em;
}
    .RegularExpressionValidator1,RequiredFieldValidator
    {
        margin-left:2em;
    }

    
 </style> 
     </head>
<body>
       <section class="Form my-4 mx-5">
    <div class="container">
      <div class="row no-guuters">
        <div class="col-lg-7">
            <img src="./loginimg.jpg" class="img-fluid" alt="" style="margin-bottom:0.5em;"/>     
        </div>
        <div class="col-lf-5">
            <form id="form1" runat="server">
                <div class="form-row">
                    <div class="col-lg-5">
                        <h1 class="heading">Login Page</h1>
                      
                          <asp:TextBox ID="EmailIdTextBox1" class="form-control" placeholder="Email" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator Id="RequiredFieldValidator1" ControlToValidate="EmailIdTextBox1" Forecolor="red" SetFocusOnError="True" Display="Dynamic" ErrorMessage="Email is Required" runat="server" style="margin-left:1em;">

                  </asp:RequiredFieldValidator>
                       <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="EmailIdTextBox1"  runat="server" ForeColor="red"  SetFocusOnError="True" Display="Dynamic" ErrorMessage="Email is Invalid" style="margin-left:1em;" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="form-row">
                    <div class="col-lg-5">
                      
                        <asp:TextBox ID="passwordTextBox1" class="form-control" TextMode="Password" placeholder="Password" runat="server"></asp:TextBox>
                         <asp:RequiredFieldValidator Id="RequiredFieldValidator2" ControlToValidate="passwordTextBox1" Forecolor="red" SetFocusOnError="True" Display="Dynamic" ErrorMessage="Password is Required" runat="server">
                         </asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-row">
                    <div class="col-lg-5">
                      <%--  <button type="button"class="btn1">Login</button>--%>
                        <asp:Button ID="SubmitButton" class="btn1" runat="server" Text="Login" Onclick="SubmitButton_Click" />
                    </div>
                </div>
                <br/>
                <a href="#" style="margin-left: 2em;">Forgot password</a>
                <p style="margin-left: 2em;">Don't have an account? <a href="#">Register here</a></p>
             </form>
        </div>
    </div>   
   </div>
   </section>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-geWF76RCwLtnZ8qwWowPQNguL3RmwHVBC9FhGdlKrxdiJJigb/j/68SIy3Te4Bkz" crossorigin="anonymous"></script>
    <%-- <script src="../assets/vendor/jquery/jquery.min.js"></script>
     <script src="../assets/vendor/bootstrap/js/bootstrap.min.js"></script>--%>

    
</body>
</html>
