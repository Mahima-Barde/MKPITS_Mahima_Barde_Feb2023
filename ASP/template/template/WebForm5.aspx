<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="template.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/Javascript" language="Javascript">
        function message() {
            alert("Successfully Submitted");
        }
    </script>
    <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
</head>
<body>
    <style>
        .divider:after,
        .divider:before  
        {
         content: "";
         flex: 1;
          height: 1px;
         background: #eee;
        }
        img {
           vertical-align: middle;
            height: 32em;
            width: 42em;
            }
        .btn-block
        {
           display: block;
            width: 120%;
         }
        .form-control {
            display: block;
            width: 117%;
            height: 34px;
            padding: 6px 12px;
            font-size: 14px;
            line-height: 1.42857143;
            color: #555;
            background-color: #fff;
            background-image: none;
            border: 1px solid #ccc;
            border-radius: 4px;
        }

        .auto-style1 {
            float: left;
            width: 36.8em;
            height: 31.8em;
        }
        .auto-style2 {
            left: 0px;
            top: 0px;
        }
        
    </style>
    <form id="form1" runat="server">
        <section class="vh-100">
  <div class="container py-5 h-100">
    <div class="row d-flex align-items-center justify-content-center h-100">
      <div class="auto-style2">
          <!---div added-->
            <div style="float:left;">
        <img src="https://mdbcdn.b-cdn.net/img/Photos/new-templates/bootstrap-login-form/draw2.svg"
          class="auto-style1" alt="Phone image">
                </div><!--div close-->
      </div>
      <div class="col-md-7 col-lg-5 col-xl-5 offset-xl-1" style="float:left;margin-top: 3em;">
        </section>
            <div class="form" style="float:left;margin-top: 3em;">
          <!-- Email input -->
          <div class="form-outline mb-4">
              <label class="form-label" for="form1Example13">Email address</label>
          </div>

                <div class="form-outline mb-4">
              &nbsp;<label class="form-label" for="form1Example23">Password</label>
          </div>

          <div class="d-flex justify-content-around align-items-center mb-4">
            <!-- Checkbox -->
            <div class="form-check">
              <input class="form-check-input" type="checkbox" value="" id="form1Example3" checked />
              <label class="form-check-label" for="form1Example3"> Remember me </label>
            </div>
            <a href="#!">Forgot password?</a><br />
              <br />
&nbsp;<asp:Button OnClientClick="message();" ID="Button1"  runat="server" BackColor="#6699FF" BorderColor="#000066" CssClass="active left" ForeColor="White" Height="46px" OnClick="Button1_Click" Text="sign in" Width="167px" />
              <br />
          </div>

          <!-- Submit button -->

          <div class="divider d-flex align-items-center my-4">
            <p class="text-center fw-bold mx-3 mb-0 text-muted">OR</p>
          </div>

          <a class="btn btn-primary btn-lg btn-block" style="background-color: #3b5998" href="#!"
            role="button">
            <i class="fab fa-facebook-f me-2"></i>Continue with Facebook
          </a>
          <a class="btn btn-primary btn-lg btn-block" style="background-color: #55acee" href="#!"
            role="button">
            <i class="fab fa-twitter me-2"></i>Continue with Twitter</a>
</div>
        </form>
      </div>
    </div>
  </div>
</section>
    </form>
</body>
</html>
