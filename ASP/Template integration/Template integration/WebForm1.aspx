<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Template_integration.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
          <div class="message">
          <div class="container">
              <h2 class="text-center">Why do we use it</h2>
              <p class="text-center"><i>Lorem Ipsum is simply dummy text of the printing and typesetting industry</i></p>
              <p class="text-center">Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a gall ey of type and scrambled it to make a type specimen book. It has survived not only five centuries</p>
              <div class="row">
                    <div class="col-12 text-center">
                      <button type="button"><a href="#">Read more</a></button>
                    </div>
              </div>
          </div>
      </div>
      <div class="what_to_do container">
           <h2 class="text-center">What we do</h2>
           <div class="row container">
                <div class="col-12 col-md-4 col-lg-4 col-xl-4 text-center">
                    <i class="text-center fab fa-pagelines"></i>
                    <h3>Lorem Ipsum</h3>
                    <p> Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text</p>
                    <div class="row">
                          <div class="col-12 text-center">
                            <button type="button"><a href="#">Read more</a></button>
                          </div>
                    </div>
                </div>
                <div class="col-12 col-md-4 col-lg-4 col-xl-4 text-center">
                   <i class="text-center fas fa-coffee"></i>
                   <h3>Lorem Ipsum</h3>
                   <p> Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text</p>
                   <div class="row">
                         <div class="col-12 text-center">
                           <button type="button"><a href="#">Read more</a></button>
                         </div>
                   </div>
                </div>
                <div class="col-12 col-md-4 col-lg-4 col-xl-4 text-center">
                    <i class="text-center fas fa-table"></i>
                    <h3>Lorem Ipsum</h3>
                    <p> Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text</p>
                    <div class="row">
                          <div class="col-12 text-center">
                            <button type="button"><a href="#">Read more</a></button>
                          </div>
                    </div>
                </div>
            </div>
      </div>
      <div class="four">
          <div class="container">
               <h1 class="text-center">There are many variations of passages of Lorem Ipsum available?</h1>
               <div class="row">
                     <div class="col-12 text-center">
                       <button type="button"><a href="#">Read more</a></button>
                     </div>
               </div>
          </div>
      </div>
      <div class="five">
          <h2 class="text-center">Choose your cup of tea</h2>
          <br>
          <div class="row container">
              <div class="col-12 col-md-3 col-lg-3 col-xl-3">
                  <img src="images/cup/1.jpeg">
              </div>
              <div class="col-12 col-md-3 col-lg-3 col-xl-3">
                  <img src="images/cup/2.jpeg">
              </div>
              <div class="col-12 col-md-3 col-lg-3 col-xl-3">
                  <img src="images/cup/3.jpeg">
              </div>
              <div class="col-12 col-md-3 col-lg-3 col-xl-3">
                  <img src="images/cup/4.jpeg">
              </div>
          </div>
          <br>
          <div class="row container">
              <div class="col-12 col-md-3 col-lg-3 col-xl-3">
                  <img src="images/cup/5.jpeg">
              </div>
              <div class="col-12 col-md-3 col-lg-3 col-xl-3">
                  <img src="images/cup/6.jpeg">
              </div>
              <div class="col-12 col-md-3 col-lg-3 col-xl-3">
                  <img src="images/cup/7.jpeg">
              </div>
              <div class="col-12 col-md-3 col-lg-3 col-xl-3">
                  <img src="images/cup/8.jpeg">
              </div>
          </div>
      </div>
      <div class="six">
        <div class="container text-center">
            <i class="fas fa-quote-left"></i>
            <p>Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage</p>
        </div>
        <div class="people row">
          <div class="col-12 col-md-4 col-lg-4 col-xl-4">
              <img class="rounded-circle" src="images/people/1.jpeg">
              <h3 class="text-center">Anna Doe</h3>
              <p class="text-center">There are many variations of passages of Lorem Ipsum available</p>
          </div>
          <div class="col-12 col-md-4 col-lg-4 col-xl-4">
              <img class="rounded-circle" src="images/people/2.jpeg">
              <h3 class="text-center">Anna Doe</h3>
              <p class="text-center">There are many variations of passages of Lorem Ipsum available</p>
          </div>
          <div class="col-12 col-md-4 col-lg-4 col-xl-4">
              <img class="rounded-circle" src="images/people/3.jpeg">
              <h3 class="text-center">Anna Doe</h3>
              <p class="text-center">There are many variations of passages of Lorem Ipsum available</p>
          </div>
        </div>
      </div>
      <div class="letter text-center">
        <h1 class="text-center">Subscribe to get more info</h1>
        <p class="text-center">It is a long established fact that a reader</p>
        <div class="container">
          <form action="/action_page.php">
              <div class="form-group">
                 <input type="email" class="form-control" id="email">
               </div>
                <div class="form-group">
                <input type="telephone" class="form-control" id="pwd">
                </div>
           </form>
           <div class="row">
                 <div class="col-12 text-center">
                   <button type="button"><a href="#">Read more</a></button>
                 </div>
           </div>
        </div>
      </div>
</asp:Content>
