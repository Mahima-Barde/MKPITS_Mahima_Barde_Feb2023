﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Tourist_website_rajastan.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main>
    <article>

      <!-- 
        - #HERO
      -->

      <section class="section hero"
        style="background-image: url('./assets/images/hero-bg-bottom.png') url('./assets/images/hero-bg-top.png');width:100%;">
        <div class="container" style="background-image:url(./assets/images/blog-12.jpg);height:118%;width:100%;">

          <img src="./assets/images/shape-1.png" width="61" height="61" alt="Vector Shape" class="shape shape-1">

          <img src="./assets/images/shape-2.png" width="56" height="74" alt="Vector Shape" class="shape shape-2">

          <img src="./assets/images/shape-3.png" width="57" height="72" alt="Vector Shape" class="shape shape-3">

          <div class="hero-content">

            <p class="section-subtitle">Rajasthan Tourism</p>

            <h2 class="A Land of Exotic Architecture, Vibrant Culture, Rich Wildlife and Warm Hospitality"</h2>

            <p class="hero-text">
              I travel not to go anywhere, but to go. I travel for travel's sake the great affair is to move.
            </p>

            <div class="btn-group">
              <a href="#" class="btn btn-primary">Contact Us</a>

              <a href="#" class="btn btn-outline">Learn More</a>
            </div>

          </div>

          <figure class="hero-banner">
            <img src="./assets/images/hero-banner.png" width="686" height="812" loading="lazy" alt="hero banner"
              class="w-100">
          </figure>

        </div>
      </section>





      <!-- 
        - #DESTINATION
      -->

      <section class="section destination">
        <div class="container">

          <p class="section-subtitle">Destinations</p>

          <h2 class="h2 section-title">Choose Your Place</h2>

          <ul class="destination-list">

            <li class="w-50">
              <a href="#" class="destination-card">

                <figure class="card-banner">
                  <img src="./assets/images/destine1.jpg" width="1140" height="1100" loading="lazy"
                    alt="Malé, Maldives" class="img-cover">
                </figure>

                <div class="card-content">
                  <p class="card-subtitle">Hawa</p>

                  <h3 class="h3 card-title">Mahal</h3>
                </div>

              </a>
            </li>

            <li class="w-50">
              <a href="#" class="destination-card">

                <figure class="card-banner">
                  <img src="./assets/images/destine2.jpg" width="1140" height="1100" loading="lazy"
                    alt="Bangkok, Thailand" class="img-cover">
                </figure>

                <div class="card-content">
                  <p class="card-subtitle">Jaisalmer</p>

                  <h3 class="h3 card-title">Fort</h3>
                </div>

              </a>
            </li>

            <li>
              <a href="#" class="destination-card">

                <figure class="card-banner">
                  <img src="./assets/images/destine3--1.jpg" width="1110" height="480" loading="lazy"
                    alt="Kuala Lumpur, Malaysia" class="img-cover">
                </figure>

                <div class="card-content">
                  <p class="card-subtitle">Blue City</p>

                  <h3 class="h3 card-title">Jaipur</h3>
                </div>

              </a>
            </li>

            <li>
              <a href="#" class="destination-card">

                <figure class="card-banner">
                  <img src="./assets/images/destine4.jpg" width="1110" height="480" loading="lazy"
                    alt="Kathmandu, Nepal" class="img-cover">
                </figure>

                <div class="card-content">
                  <p class="card-subtitle">Ranthambore</p>

                  <h3 class="h3 card-title">National Park</h3>
                </div>

              </a>
            </li>

            <li>
              <a href="#" class="destination-card">

                <figure class="card-banner">
                  <img src="./assets/images/detine5.jpg" width="1110" height="480" loading="lazy"
                    alt="Jakarta, Indonesia" class="img-cover">
                </figure>

                <div class="card-content">
                  <p class="card-subtitle">City of lake</p>

                  <h3 class="h3 card-title">Udaipur</h3>
                </div>

              </a>
            </li>

          </ul>

        </div>
      </section>





      <!-- 
        - #POPULAR
      -->

      <section class="section popular">
        <div class="container">

          <p class="section-subtitle">Featured Tours</p>

          <h2 class="h2 section-title">Most Popular Tours</h2>

          <ul class="popular-list">

            <li>
              <div class="popular-card">

                <figure class="card-banner">
                  <a href="#">
                    <img src="./assets/images/popular-1.jpg" width="740" height="518" loading="lazy"
                      alt="Kuala , Malaysia" class="img-cover">
                  </a>

                  <span class="card-badge">
                    <ion-icon name="time-outline"></ion-icon>

                    <time datetime="P12D">12 Days</time>
                  </span>
                </figure>

                <div class="card-content">

                  <div class="card-wrapper">
                    <div class="card-price">From $50.00</div>

                    <div class="card-rating">
                      <ion-icon name="star"></ion-icon>
                      <ion-icon name="star"></ion-icon>
                      <ion-icon name="star"></ion-icon>
                      <ion-icon name="star"></ion-icon>
                      <ion-icon name="star-outline"></ion-icon>

                      <data value="2">(2)</data>
                    </div>
                  </div>

                  <h3 class="card-title">
                    <a href="#">A good traveler has no fixed plans and is not intent on arriving.</a>
                  </h3>

                  <address class="card-location">Jaisalmer, Rajasthan</address>

                </div>

              </div>
            </li>

            <li>
              <div class="popular-card">

                <figure class="card-banner">
                  <a href="#">
                    <img src="./assets/images/popular-2.jpg" width="740" height="518" loading="lazy"
                      alt="Kuala Lumpur, Malaysia" class="img-cover">
                  </a>

                  <span class="card-badge">
                    <ion-icon name="time-outline"></ion-icon>

                    <time datetime="P12D">12 Days</time>
                  </span>
                </figure>

                <div class="card-content">

                  <div class="card-wrapper">
                    <div class="card-price">From $50.00</div>

                    <div class="card-rating">
                      <ion-icon name="star"></ion-icon>
                      <ion-icon name="star"></ion-icon>
                      <ion-icon name="star"></ion-icon>
                      <ion-icon name="star"></ion-icon>
                      <ion-icon name="star-outline"></ion-icon>

                      <data value="2">(2)</data>
                    </div>
                  </div>

                  <h3 class="card-title">
                    <a href="#">A good traveler has no fixed plans and is not intent on arriving.</a>
                  </h3>

                  <address class="card-location">Hawa Mahal, Rajasthan</address>

                </div>

              </div>
            </li>

            <li>
              <div class="popular-card">

                <figure class="card-banner">
                  <a href="#">
                    <img src="./assets/images/popular-3.jpg" width="740" height="518" loading="lazy"
                      alt="Kuala Lumpur, Malaysia" class="img-cover">
                  </a>

                  <span class="card-badge">
                    <ion-icon name="time-outline"></ion-icon>

                    <time datetime="P12D">12 Days</time>
                  </span>
                </figure>

                <div class="card-content">

                  <div class="card-wrapper">
                    <div class="card-price">From $50.00</div>

                    <div class="card-rating">
                      <ion-icon name="star"></ion-icon>
                      <ion-icon name="star"></ion-icon>
                      <ion-icon name="star"></ion-icon>
                      <ion-icon name="star"></ion-icon>
                      <ion-icon name="star-outline"></ion-icon>

                      <data value="2">(2)</data>
                    </div>
                  </div>

                  <h3 class="card-title">
                    <a href="#">A good traveler has no fixed plans and is not intent on arriving.</a>
                  </h3>

                  <address class="card-location">Jaipur, Rajasthan</address>

                </div>

              </div>
            </li>

          </ul>

        </div>
      </section>





      <!-- 
        - #ABOUT
      -->

      <section class="section about">
        <div class="container">

          <div class="about-content">

            <p class="section-subtitle">About Us</p>

            <h2 class="h2 section-title">Explore all tour of the world with us.</h2>

            <p class="about-text">
              Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or
              randomised words
              which don't look even slightly believable.
            </p>

            <ul class="about-list">

              <li class="about-item">

                <div class="about-item-icon">
                  <ion-icon name="compass"></ion-icon>
                </div>

                <div class="about-item-content">
                  <h3 class="h3 about-item-title">Tour guide</h3>

                  <p class="about-item-text">
                    Lorem Ipsum available, but the majority have suffered alteration in some.
                  </p>
                </div>

              </li>

              <li class="about-item">

                <div class="about-item-icon">
                  <ion-icon name="briefcase"></ion-icon>
                </div>

                <div class="about-item-content">
                  <h3 class="h3 about-item-title">Friendly price</h3>

                  <p class="about-item-text">
                    Lorem Ipsum available, but the majority have suffered alteration in some.
                  </p>
                </div>

              </li>

              <li class="about-item">

                <div class="about-item-icon">
                  <ion-icon name="umbrella"></ion-icon>
                </div>

                <div class="about-item-content">
                  <h3 class="h3 about-item-title">Reliable tour</h3>

                  <p class="about-item-text">
                    Lorem Ipsum available, but the majority have suffered alteration in some.
                  </p>
                </div>

              </li>

            </ul>

            <a href="#" class="btn btn-primary">Booking Now</a>

          </div>

          <figure class="about-banner">
            <img src="./assets/images/about-banner.png" width="756" height="842" loading="lazy" alt="" class="w-100">
          </figure>

        </div>
      </section>





      <!-- 
        - #BLOG
      -->

      <section class="section blog">
        <div class="container">

          <p class="section-subtitle">From The Blog Post</p>

          <h2 class="h2 section-title">Latest News & Articles</h2>

          <ul class="blog-list">

            <li>
              <div class="blog-card">

                <figure class="card-banner">

                  <a href="#">
                    <img src="./assets/images/blog-1.jpg" width="740" height="518" loading="lazy"
                      alt="A good traveler has no fixed plans and is not intent on arriving." class="img-cover">
                  </a>

                  <span class="card-badge">
                    <ion-icon name="time-outline"></ion-icon>

                    <time datetime="12-04">04 Dec</time>
                  </span>

                </figure>

                <div class="card-content">

                  <div class="card-wrapper">

                    <div class="author-wrapper">
                      <figure class="author-avatar">
                        <img src="./assets/images/author-avatar.png" width="30" height="30" alt="Jony bristow">
                      </figure>

                      <div>
                        <a href="#" class="author-name">Jony bristow</a>

                        <p class="author-title">Admin</p>
                      </div>
                    </div>

                    <time class="publish-time" datetime="10:30">10:30 AM</time>

                  </div>

                  <h3 class="card-title">
                    <a href="#">
                      A good traveler has no fixed plans and is not intent on arriving.
                    </a>
                  </h3>

                  <a href="#" class="btn-link">
                    <span>Read More</span>

                    <ion-icon name="arrow-forward-outline" aria-hidden="true"></ion-icon>
                  </a>

                </div>

              </div>
            </li>

            <li>
              <div class="blog-card">

                <figure class="card-banner">

                  <a href="#">
                    <img src="./assets/images/blog-2.jpg" width="740" height="518" loading="lazy"
                      alt="A good traveler has no fixed plans and is not intent on arriving." class="img-cover">
                  </a>

                  <span class="card-badge">
                    <ion-icon name="time-outline"></ion-icon>

                    <time datetime="12-04">04 Dec</time>
                  </span>

                </figure>

                <div class="card-content">

                  <div class="card-wrapper">

                    <div class="author-wrapper">
                      <figure class="author-avatar">
                        <img src="./assets/images/author-avatar.png" width="30" height="30" alt="Jony bristow">
                      </figure>

                      <div>
                        <a href="#" class="author-name">Jony bristow</a>

                        <p class="author-title">Admin</p>
                      </div>
                    </div>

                    <time class="publish-time" datetime="10:30">10:30 AM</time>

                  </div>

                  <h3 class="card-title">
                    <a href="#">
                      A good traveler has no fixed plans and is not intent on arriving.
                    </a>
                  </h3>

                  <a href="#" class="btn-link">
                    <span>Read More</span>

                    <ion-icon name="arrow-forward-outline" aria-hidden="true"></ion-icon>
                  </a>

                </div>

              </div>
            </li>

            <li>
              <div class="blog-card">

                <figure class="card-banner">

                  <a href="#">
                    <img src="./assets/images/blog-3.jpg" width="740" height="518" loading="lazy"
                      alt="A good traveler has no fixed plans and is not intent on arriving." class="img-cover">
                  </a>

                  <span class="card-badge">
                    <ion-icon name="time-outline"></ion-icon>

                    <time datetime="12-04">04 Dec</time>
                  </span>

                </figure>

                <div class="card-content">

                  <div class="card-wrapper">

                    <div class="author-wrapper">
                      <figure class="author-avatar">
                        <img src="./assets/images/author-avatar.png" width="30" height="30" alt="Jony bristow">
                      </figure>

                      <div>
                        <a href="#" class="author-name">Jony bristow</a>

                        <p class="author-title">Admin</p>
                      </div>
                    </div>

                    <time class="publish-time" datetime="10:30">10:30 AM</time>

                  </div>

                  <h3 class="card-title">
                    <a href="#">
                      A good traveler has no fixed plans and is not intent on arriving.
                    </a>
                  </h3>

                  <a href="#" class="btn-link">
                    <span>Read More</span>

                    <ion-icon name="arrow-forward-outline" aria-hidden="true"></ion-icon>
                  </a>

                </div>

              </div>
            </li>

          </ul>

        </div>
      </section>

    </article>
  </main>

</asp:Content>
