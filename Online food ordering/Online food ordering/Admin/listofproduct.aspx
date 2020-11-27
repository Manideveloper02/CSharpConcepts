<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Site1.Master" AutoEventWireup="true" CodeBehind="listofproduct.aspx.cs" Inherits="Online_food_ordering.Admin.listofproduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main-content">

        <!-- Container fluid  -->
        <!-- ============================================================== -->
        <div class="page-content container-fluid">
            <!-- ============================================================== -->
            <!-- Start Page Content -->
            <!-- ============================================================== -->
            <!-- basic table -->
            <div class="row">
                <div class="col-lg-12">
                    <div class="card">
                        <div class="card-body  pt-0">
                            <ul class="nav nav-tabs nav-tabs-custom mb-4">
                            </ul>
                            <div class="table-responsive">
                                <table class="table table-centered datatable dt-responsive nowrap " style="border-collapse: collapse; border-spacing: 0; width: 100%;">
                                    <thead class="thead-light">
                                        <tr>

                                            <th>Product ID</th>
                                            <th>Product Name</th>
                                            <th>Product Type</th>
                                            <th>Product Price</th>
                                            <th>Product Image</th>
                                            <th>Product Status</th>

                                            <th style="width: 120px;">Action</th>
                                        </tr>
                                    </thead>
                                    <tbody>

                                        <asp:Repeater ID="Repeater1" runat="server">
                                            <ItemTemplate>
                                                <tr>



                                                    <td><a href="javascript: void(0);" class="text-dark font-weight-bold">#P<%#Container.ItemIndex+1%> </a></td>
                                                    <td>
                                                        <%#Eval("name")%>
                                                    </td>
                                                    <td>
                                                        <%#Eval("categorie")%>
                                                    </td>
                                                    <td><%#Eval("price")%></td>

                                                    <td>
                                                        <img src="../UI/assets/images/product-image/<%#Eval("img")%>" alt="Banner" width="80">
                                                    </td>
                                                    <td>
                                                        <div class="badge badge-soft-success font-size-12"><%#Eval("status")%></div>
                                                    </td>

                                                    <td>
                                                        <a href="javascript:void(0);" class="mr-3 text-primary" data-toggle="tooltip" data-placement="top" title="" data-original-title="Edit"><i class="mdi mdi-pencil font-size-18"></i></a>
                                                        <a href="javascript:void(0);" class="text-danger" data-toggle="tooltip" data-placement="top" title="" data-original-title="Delete"><i class="mdi mdi-trash-can font-size-18"></i></a>
                                                    </td>
                                                </tr>

                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script src="assets/libs/jquery/dist/jquery.min.js"></script>
    <script src="assets/extra-libs/DataTables/datatables.min.js"></script>
    <script src="dist/js/pages/datatable/datatable-basic.init.js"></script>
</asp:Content>
