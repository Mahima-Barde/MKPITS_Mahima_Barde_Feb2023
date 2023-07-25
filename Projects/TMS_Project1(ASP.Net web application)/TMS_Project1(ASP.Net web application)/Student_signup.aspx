<%@ Page Title="" Language="C#" MasterPageFile="~/TMS_Site.Master" AutoEventWireup="true" CodeBehind="Student_signup.aspx.cs" Inherits="TMS_Project1_ASP.Net_web_application_.Student_signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br/>
   <div class="container" style="-webkit-box-shadow: 1px 1px 48px 12px rgba(0,0,0,0.65);
                                 -moz-box-shadow: 1px 1px 48px 12px rgba(0,0,0,0.65);
                                  box-shadow: 1px 1px 48px 12px rgba(0,0,0,0.65);">
       <br/>
    <div class="row">
        <div class="col-md-12">
            <h1 class="jumbotron bg-primary text-center text-white">Student Sign Up</h1>
            </div>
            </div>
       <div class="row">
        <div class="col-md-4">
            <asp:TextBox ID="NameTextbox" class="form-control" placeholder="Enter Name" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ControlToValidate="NameTextbox" runat="server" setfocusonrerror="true" forecolor="red" display="dynamic" ErrorMessage="Name is required"></asp:RequiredFieldValidator>
            <br/>
            <asp:TextBox ID="FathernameTextbox" class="form-control" placeholder="Enter Father Name" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ControlToValidate="FathernameTextbox" runat="server" setfocusonrerror="true" forecolor="red" display="dynamic" ErrorMessage=" Father Name is required"></asp:RequiredFieldValidator>
            <br/>
            <asp:TextBox ID="SurnameTextBox" class="form-control" placeholder="Enter Surname" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ControlToValidate="SurnameTextBox" runat="server" setfocusonrerror="true" forecolor="red" display="dynamic" ErrorMessage=" Surname is required"></asp:RequiredFieldValidator>
            <br/>
            <asp:DropDownList ID="genderdropdown" class="form-control" runat="server">
                <asp:ListItem Selected="True">Select Gender</asp:ListItem>
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator  ControlToValidate="genderdropdown" IntialValue="Select Gender" runat="server" setfocusonrerror="true" forecolor="red" display="dynamic" ErrorMessage="Gender is required"></asp:RequiredFieldValidator>
            <br/>
            <asp:TextBox ID="AgeTextBox" class="form-control" placeholder="Enter Age" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ControlToValidate="AgeTextBox" runat="server" setfocusonrerror="true" forecolor="red" display="dynamic" ErrorMessage=" Age is required"></asp:RequiredFieldValidator>
            <br/>
            <asp:TextBox ID="CountryTextbox" class="form-control" placeholder="Enter Country" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ControlToValidate="CountryTextbox" runat="server" setfocusonrerror="true" forecolor="red" display="dynamic" ErrorMessage=" Country is required"></asp:RequiredFieldValidator>
            </div>

        <div class="col-md-4">
            <asp:TextBox ID="CityTextBox" class="form-control" placeholder="Enter City" runat="server"></asp:TextBox>
            <br/>
            <asp:TextBox ID="AddressTextBox" Textmode="multiline" Rows="5" column="15" class="form-control" placeholder="Enter Address" runat="server"></asp:TextBox>
            <br/>
            <asp:TextBox ID="ClassTextBox" class="form-control" placeholder="Enter class" runat="server"></asp:TextBox>
            <br/>
            <asp:DropDownList Id="goingdropdown" class="form-control" runat="server">
                <asp:ListItem>Select going to</asp:ListItem>
                <asp:ListItem>School</asp:ListItem>
                <asp:ListItem>College</asp:ListItem>
                <asp:ListItem>University</asp:ListItem>
                <asp:ListItem>Other</asp:ListItem>
            </asp:DropDownList>
            <br/>
            <asp:TextBox ID="SubjectTextBox" class="form-control" placeholder="Enter Subject" runat="server"></asp:TextBox>
            <br/>
          </div>

           <div class="col-md-4">
           <asp:TextBox ID="ContactTextBox" class="form-control" placeholder="Enter Contactno." runat="server"></asp:TextBox>
            <br/>
            <asp:DropDownList ID="tutiontypeDropDownList" class="form-control" runat="server">
                <asp:ListItem >Select Tution mode</asp:ListItem>
                <asp:ListItem>Online</asp:ListItem>
                <asp:ListItem>Physical</asp:ListItem>
            </asp:DropDownList>
             <br/>
               <asp:DropDownList ID="TutorpreferredDropDownList2" class="form-control" runat="server">
                <asp:ListItem >Select Tutor Preference</asp:ListItem>
                <asp:ListItem>Master</asp:ListItem>
                <asp:ListItem>Graduation</asp:ListItem>
                <asp:ListItem>PHD</asp:ListItem>
                <asp:ListItem>MHIL</asp:ListItem>
                <asp:ListItem>Other</asp:ListItem>
            </asp:DropDownList>
             <br/>
             <asp:TextBox ID="UsernameTextBox" class="form-control" placeholder="Enter Username" runat="server"></asp:TextBox>
            <br/>
             <asp:TextBox ID="PasswordTextBox" class="form-control" placeholder="Enter Password" runat="server"></asp:TextBox>
            <br/>
             <asp:TextBox ID="ReeneterTextBox" class="form-control" placeholder="Re-enter Password" runat="server"></asp:TextBox>
            <br/>
               </div>
     </div>
       <br/>
       <div class="row">
           <div class="col-md-4 mx-auto">
           <asp:Button Id="Studentsignupbtn" Cssclass="btn btn-primary btn-block" runat="server" Text="Sign Up" />
         </div>
     </div>
       <br/>
  </div>
    <br/>

            
</asp:Content>
