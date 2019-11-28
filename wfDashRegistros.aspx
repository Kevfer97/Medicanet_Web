<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="wfDashRegistros.aspx.cs" Inherits="wfDashRegistros" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

    <section class="content-header">
        <h1>
            <asp:Label ID="lblTitulo" Text="" runat="server" >Listado de Medicamentos:</asp:Label>
        </h1>
        <ol class="breadcrumb">
            <li><a href="#"><i class="fa fa-dashboard"></i>Home</a></li>
            <li class="active">Medicamentos</li>
        </ol>
    </section>

    <!-- Main content -->
    <section class="content">
      <!-- Info boxes -->
      <div class="row">
        <div class="col-md-4 col-sm-6 col-xs-12">
          <div class="info-box">
            <span class="info-box-icon bg-aqua"><i class="fa  fa-address-book"></i></span>

            <div class="info-box-content">
              <span class="info-box-text">Consultas Programadas</span>
              <span class="info-box-number"><center><h3><asp:Label runat="server" ID="lbl1"></asp:Label></h3></center> </span>
            </div>
            <!-- /.info-box-content -->
          </div>
          <!-- /.info-box -->
        </div>
        <!-- /.col -->
        <div class="col-md-4 col-sm-6 col-xs-12">
          <div class="info-box">
            <span class="info-box-icon bg-red"><i class="fa fa-ambulance"></i></span>

            <div class="info-box-content">
              <span class="info-box-text">Cantidad de Recetas Ingresadas</span>
              <span class="info-box-number"><center><h3><asp:Label runat="server" ID="lbl2"></asp:Label></h3></center> </span>
            </div>
            <!-- /.info-box-content -->
          </div>
          <!-- /.info-box -->
        </div>
        <!-- /.col -->

        <!-- fix for small devices only -->
        <div class="clearfix visible-sm-block"></div>

        <div class="col-md-4 col-sm-6 col-xs-12">
          <div class="info-box">
            <span class="info-box-icon bg-green"><i class="ion ion-ios-cart-outline"></i></span>

            <div class="info-box-content">
              <span class="info-box-text">Medicamentos Entregados</span>
              <span class="info-box-number"><center><h3><asp:Label runat="server" ID="lbl3"></asp:Label></h3></center> </span>
            </div>
            <!-- /.info-box-content -->
          </div>
          <!-- /.info-box -->
        </div>
        <!-- /.col -->
        <div class="col-md-4 col-sm-6 col-xs-12">
          <div class="info-box">
            <span class="info-box-icon bg-yellow"><i class="fa fa-qrcode"></i></span>

            <div class="info-box-content">
              <span class="info-box-text">Medicamentos Pendientes</span>
              <span class="info-box-number"><center><h3><asp:Label runat="server" ID="lbl4"></asp:Label></h3></center> </span>
            </div>
            <!-- /.info-box-content -->
          </div>
          <!-- /.info-box -->
        </div>
        <!-- /.col -->
           <div class="col-md-4 col-sm-6 col-xs-12">
          <div class="info-box">
            <span class="info-box-icon bg-blue"><i class="fa  fa-user-md"></i></span>

            <div class="info-box-content">
              <span class="info-box-text">Medicos</span>
              <span class="info-box-number"><center><h3><asp:Label runat="server" ID="lbl5"></asp:Label></h3></center> </span>
            </div>
            <!-- /.info-box-content -->
          </div>
          <!-- /.info-box -->
        </div>
          <div class="col-md-4 col-sm-6 col-xs-12">
          <div class="info-box">
            <span class="info-box-icon bg-teal"><i class="fa  fa-users"></i></span>

            <div class="info-box-content">
              <span class="info-box-text">Usuarios</span>
              <span class="info-box-number"><center><h3><asp:Label runat="server" ID="lbl6"></asp:Label></h3></center> </span>
            </div>
            <!-- /.info-box-content -->
          </div>
          <!-- /.info-box -->
        </div>
          <div class="col-md-4 col-sm-6 col-xs-12">
          <div class="info-box">
            <span class="info-box-icon bg-aqua"><i class="fa  fa-sitemap"></i></span>

            <div class="info-box-content">
              <span class="info-box-text">Farmacias Afiliadas</span>
              <span class="info-box-number"><center><h3><asp:Label runat="server" ID="lbl7"></asp:Label></h3></center> </span>
            </div>
            <!-- /.info-box-content -->
          </div>
          <!-- /.info-box -->
        </div>
           <!-- /.col -->
        <div class="col-md-4 col-sm-6 col-xs-12">
          <div class="info-box">
            <span class="info-box-icon bg-red"><i class="fa fa-hospital-o"></i></span>

            <div class="info-box-content">
              <span class="info-box-text">Centro Medicos</span>
              <span class="info-box-number"><center><h3><asp:Label runat="server" ID="lbl8"></asp:Label></h3></center> </span>
            </div>
            <!-- /.info-box-content -->
          </div>
          <!-- /.info-box -->
        </div>
        <!-- /.col -->
<div class="col-md-4 col-sm-6 col-xs-12">
          <div class="info-box">
            <span class="info-box-icon bg-green"><i class="fa fa-medkit"></i></span>

            <div class="info-box-content">
              <span class="info-box-text">Medicamentos Registrados</span>
              <span class="info-box-number"><center><h3><asp:Label runat="server" ID="lbl9"></asp:Label></h3></center> </span>
            </div>
            <!-- /.info-box-content -->
          </div>
          <!-- /.info-box -->
        </div>


      </div>
      <!-- /.row -->



    </section>



</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentScript" Runat="Server">
  
</asp:Content>

