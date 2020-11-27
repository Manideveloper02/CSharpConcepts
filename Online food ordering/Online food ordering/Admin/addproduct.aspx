<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="addproduct.aspx.cs" Inherits="Online_food_ordering.Admin.addproduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="main-content">
      <div class="page-content">
                    <div class="container-fluid">

                        <!-- start page title -->
                        <div class="row">
                            <div class="col-12">
                                <div class="page-title-box d-flex align-items-center justify-content-between">
                                    <h4 class="mb-0">Forms Elements</h4>

                                    <div class="page-title-right">
                                        <ol class="breadcrumb m-0">
                                            <li class="breadcrumb-item"><a href="javascript: void(0);">Forms</a></li>
                                            <li class="breadcrumb-item active">Forms Elements</li>
                                        </ol>
                                    </div>

                                </div>
                            </div>
                        </div>
                        <!-- end page title -->
                        
                        <div class="row">
                            <div class="col-12">
                                <div class="card">
                                    <div class="card-body">
        
                                        <h4 class="card-title">Product Details</h4>
                                        <p class="card-title-desc"> </p>
        
                                        <div class="form-group row">
                                            <label for="example-text-input" class="col-md-2 col-form-label">Product Name</label>
                                            <div class="col-md-10">
                                                <input class="form-control" type="text"   >
                                            </div>
                                        </div>
                                         <div class="form-group row">
                                            <label for="example-text-input" class="col-md-2 col-form-label">Product Image</label>
                                            <div class="col-md-10">
                                                <input class="form-control" type="file"   >
                                            </div>
                                        </div>
                                        <div class="form-group row">
                                            <label class="col-md-2 col-form-label">Category</label>
                                            <div class="col-md-10">
                                                <select class="form-control">
                                                    <option>Select</option>
                                                    <option>BF</option>
                                                    <option>Dinner</option>
                                                </select>
                                            </div>
                                        </div>
                                          <div class="form-group row">
                                            <label for="example-text-input" class="col-md-2 col-form-label">Product Price</label>
                                            <div class="col-md-10">
                                                <input class="form-control" type="text"   >
                                            </div>
                                        </div>
                                          <div class="form-group row">
                                            <label for="example-text-input" class="col-md-2 col-form-label">Product Details</label>
                                            <div class="col-md-10">
                                                <input class="form-control" type="text"   >
                                            </div>
                                        </div>  <div class="col-lg-12  " style="    padding-left: 85%;
">
                                            <a title="Add Awards" class="btn btn-success text-white pull-left" href="addproduct.aspx">ADD PRODUCT
                                            </a>
                                        </div>
                                    </div>
                                </div>
                            </div> <!-- end col -->
                        </div>
                        <!-- end row -->
 

                        <!-- end row -->
                    </div> <!-- container-fluid -->
                </div>
            </div>
</asp:Content>
