<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Registrationform.aspx.cs" Inherits="Tourist_website_rajastan.Registrationform" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>

        #tsparticles {
    position: fixed;
    margin: 0;
    padding: 0;
    left: 0;
    top: 0;
    width: 100%;
    height: 100%;
}
        * {
    box-sizing: border-box;
}

body {
    font-family: sans-serif;
    height: 100vh;
    margin: 0;
    padding: 0;
}

/*/header {
    display: none;
}
    */

.box {
    background-color: rgba(0, 0, 0, 0.8);
    border-radius: 10px;
    box-shadow: 0 15px 25px rgba(0, 0, 0, 0.8);
    margin: auto auto;
    padding: 40px;
    position: absolute;
    top: 50%;
    left: 50%;
    transform: translate(-70%, -70%);
    margin-top: 11em;
        opacity: 0.75;
}

.box h2 {
    margin: 0 0 30px 0;
    padding: 0;
    color: #fff;
    text-align: center;
}

.box .inputBox label {
    color: #fff;
}

.box .inputBox input {
    background: transparent;
    border: none;
    border-bottom: 1px solid #fff;
    color: #fff;
    font-size: 18px;
    letter-spacing: 2px;
    margin-bottom: 30px;
    outline: none;
    padding: 10px 0;
    width: 100%;
}

.box input[type="submit"], .box button[type="submit"], a.button {
    font-family: sans-serif;
    background: #03a9f4;
    font-size: 11px;
    border: none;
    border-radius: 5px;
    color: #fff;
    cursor: pointer;
    font-weight: 600;
    padding: 10px 20px;
    letter-spacing: 2px;
    outline: none;
    text-transform: uppercase;
    text-decoration: none;
    margin: 2px 10px 2px 0;
    display: inline-block;
}

.box input[type="submit"]:hover, .box button[type="submit"]:hover, a.button:hover {
    opacity: 0.8;
}

    </style>
    <body style="background-image:url('./assets/images/regisbg.jpg');">
    <div id="tsparticles"></div>
<main class="box" >
    <h2>Register</h2>
    <form>
        <div class="inputBox">
            <label for="userName">Username</label>
            <input type="text" name="userName" id="userName" placeholder="type your username" required/>
        </div>
        <div class="inputBox">
            <label for="userPassword">Password</label>
            <input type="password" name="userPassword" id="userPassword" placeholder="type your password"
                   required/>
        </div>
        <div class="inputBox">
            <label for="userConfirmPassword">Confirm Password</label>
            <input type="password" name="userPassword" id="userConfirmPassword" placeholder="confirm your password"
                   required/>
        </div>
        <button type="submit" name="" style="float: left;">Submit</button>
        <a class="button" href="login.html" style="float: left;">Login</a>
    </form>
</main>
        </body>
<footer>
</footer>

<script src="https://cdn.jsdelivr.net/npm/tsparticles@1.34.1/tsparticles.min.js"
        integrity="sha256-D6LXCdCl4meErhc25yXnxIFUtwR96gPo+GtLYv89VZo=" crossorigin="anonymous"></script>
<script type="text/javascript" src="js/particles.js"></script>

    <div id="tsparticles"></div>
<main class="box">
    <h2>Register</h2>
    <form>
        <div class="inputBox">
            <label for="userName">Username</label>
            <input type="text" name="userName" id="userName" placeholder="type your username" required/>
        </div>
        <div class="inputBox">
            <label for="userPassword">Password</label>
            <input type="password" name="userPassword" id="userPassword" placeholder="type your password"
                   required/>
        </div>
        <div class="inputBox">
            <label for="userConfirmPassword">Confirm Password</label>
            <input type="password" name="userPassword" id="userConfirmPassword" placeholder="confirm your password"
                   required/>
        </div>
        <button type="submit" name="" style="float: left;" onclick="message2();">Submit</button>
        <a class="button" href="login.aspx" style="float: left;">Login</a>
    </form>
</main>
<footer style="padding-top:45em;">
</footer>

<script src="https://cdn.jsdelivr.net/npm/tsparticles@1.34.1/tsparticles.min.js"
        integrity="sha256-D6LXCdCl4meErhc25yXnxIFUtwR96gPo+GtLYv89VZo=" crossorigin="anonymous"></script>
<script type="text/javascript" src="js/particles.js"></script>


</asp:Content>
