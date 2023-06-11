<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Contact2aspx.aspx.cs" Inherits="Tourist_website_rajastan.Contact2aspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--Contact us-->
    <!--Back ground image can be added-->
        <section class="contact";>
            <div class="contact-form">
                <h1>Contact <span>Us</span></h1>
                <p>We are always out there to help you! Fill out the form given below and get a reply from us within 2 business days.</p>
            <form action="">
                <input type="text" style="padding: 1em; color:cornsilk;"name="myname" placeholder="Your Name" required>
                <input type="email"style="padding: 1em;color:cornsilk;" name="email" placeholder="Your E-mail" required>
                <input type="text" style="padding: 1em;color:cornsilk;" name="subject" placeholder="What brings you here?" required>
                <textarea name="message" style="color:cornsilk;"cols="30" rows="10" placeholder="Your Message" required></textarea>
                <input type="submit" value="Submit" class="submit-btn">
            </form>
            </div>
            
        </section>

        <!--Contact us end here-->

</asp:Content>
