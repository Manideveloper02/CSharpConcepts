<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Site1.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Online_food_ordering.UI.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <!-- Slider Arae Start -->
        <div class="slider-area">
            <div class="slider-active-3 owl-carousel slider-hm8 owl-dot-style">
                <!-- Slider Single Item Start -->
                <div class="slider-height-6 d-flex align-items-start justify-content-start bg-img" style="background-image: url(assets/images/slider-image/sample-1.jpg);">
                </div>

            </div>
        </div>
        <!-- Slider Arae End -->
        <!-- Static Area Start -->
        <section class="static-area mtb-60px">
        </section>
  <section class="categorie-area">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <!-- Section Title -->
                    <div class="section-title mt-res-sx-30px mt-res-md-30px">
                        <h2>Popular Categories</h2>
                    </div>
                    <!-- Section Title -->
                </div>
            </div>
            <!-- Category Slider Start -->
            <div class="category-slider owl-carousel owl-nav-style">
                <!-- Single item -->
                <div class="category-item">
                    <div class="category-list mb-30px">
                        <div class="category-thumb">
                            <a href="View.aspx?cat=Dinner">
                                <img src="assets/images/product-image/sample-1.jpg" alt="" />
                            </a>
                        </div>
                        <div class="desc-listcategoreis">
                            <div class="name_categories">
                                <h4>BF</h4>
                            </div>
                            <a href="View.aspx?cat=BF">View<i class="ion-android-arrow-dropright-circle"></i></a>
                        </div>
                    </div>
                    <div class="category-list">
                        <div class="category-thumb">
                            <a href="View.aspx?cat=Dinner">
                                <img src="assets/images/product-image/sample-1.jpg" alt="" />
                            </a>
                        </div>
                        <div class="desc-listcategoreis">
                            <div class="name_categories">
                                <h4>Lunch</h4>
                            </div>
                            <a href="View.aspx?cat=Lunch">View <i class="ion-android-arrow-dropright-circle"></i></a>
                        </div>
                    </div>
                </div>
                <!-- Single item -->
                <div class="category-item">
                    <div class="category-list mb-30px">
                        <div class="category-thumb">
                            <a href="View.aspx?cat=Dinner">
                                <img src="assets/images/product-image/sample-1.jpg" alt="" />
                            </a>
                        </div>
                        <div class="desc-listcategoreis">
                            <div class="name_categories">
                                <h4>Dinner</h4>
                            </div>
                            <a href="View.aspx?cat=Dinner">View <i class="ion-android-arrow-dropright-circle"></i></a>
                        </div>
                    </div>

                </div>

            </div>

        </div>
    </section>    
</asp:Content>
