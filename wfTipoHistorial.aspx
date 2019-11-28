<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="wfTipoHistorial.aspx.cs" Inherits="wfUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <section class="content-header">
        <h1>
            <asp:Label ID="lblTitulo" Text="" runat="server" >Listado de Tipo Historial Medicos:</asp:Label>
        </h1>
        <ol class="breadcrumb">
            <li><a href="#"><i class="fa fa-dashboard"></i>Home</a></li>
            <li class="active">Tipo Historial Medicos</li>
        </ol>
    </section>

    <!-- Main content -->
    <section class="content">
        <div class="row">
         <%-- crud Clientes--%>       
                <div class="col-md-12" id="divClientes" runat="server">
                    <div class="box box-primary">
                        <div class="box-header with-border">
                            <h3 class="box-title">Tipo Historial Medicos</h3>&nbsp&nbsp&nbsp <label class="btn btn-xs btnAdd btn-info"><i class="fa fa-plus" style="color:#fff;"></i></label>
                        </div>
                        <!-- /.box-header -->
                        <!-- form start -->
                        <div class="form-horizontal">
                            <div class="box-body">
                                <div id="Div4" class="dataTables_wrapper form-inline dt-bootstrap" runat="server">
                                    <div class="row">
                                        <div class="col-md-12"> <div class="table-responsive">
                                                <asp:Repeater ID="rpt1" runat="server" OnItemDataBound="rpt1_ItemDataBound" OnItemCommand="rpt1_ItemCommand">
                                                    <HeaderTemplate>
                                                        <table class="table table-striped tbltable" id="tbltable">
                                                            <thead>
                                                                <tr>
                                                                    <th>#</th>
                                                                    <th>#</th>
                                                                    <th>Nombre</th>
                                                                    <th></th>
                            
                                                                </tr>
                                                            </thead>
                                                            <tbody>
                                                    </HeaderTemplate>
                                                    <ItemTemplate>
                                                        <tr><td></td>
                                                            <td><asp:label ID="lblcodigo" runat="server" Text="-"></asp:Label></td>
                                                            <td><asp:label ID="lblNombre" CssClass="onH btnEdit" runat="server" Text="-"></asp:Label></td>
                                                                <td><asp:LinkButton ID="lkbEliminar" CssClass="btn-danger btn btn-xs btnEliminar" Text="Eliminar" runat="server" /> </td>
                                       
                                                        </tr>
                                                    </ItemTemplate>
                                                    <FooterTemplate>
                                                        </tbody>
                                            </table>
                                                    </FooterTemplate>
                                                </asp:Repeater>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- /.box-body -->
                        <div class="box box-footer">
                        </div>


                    </div>
                </div>
            </div>
            </section>

        <div class="modal fade" tabindex="-1" role="dialog" id="modal">
            <div class="modal-dialog" role="document" id="divmodal">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                        <h4 class="modal-title" id="tituloModal">Tipo Historial Medico: <small id="mal">    </small></h4>
                    </div>
                    <div class="modal-body" style="max-height: calc(100vh - 210px); overflow-y: auto;">
                        <div class="row">
                            <div class="col-sm-4 hidden col-xs-12">
                                <label class="control-label">Codigo</label>
                                <asp:TextBox runat="server"  CssClass=" form-control txtCodigo" ID="txtCodigo"></asp:TextBox>
                            </div>
                            <div class="col-sm-12  col-xs-12">
                                <label class="control-label">Nombre</label>
                                <asp:TextBox runat="server" CssClass=" form-control txtNombre " ID="txtNombre"></asp:TextBox>
                            </div>

                            <%-- para el reporte --%>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</button>
                        <asp:Button ID="BtnGuardar" OnClick="BtnGuardar_Click" CssClass="btn btn-primary" Text="Guardar" runat="server" />
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentScript" Runat="Server">
    <script>

        $(".btnAdd").click(function () {
            console.log("click");
            $(".txtCodigo").val("0");
            $(".txtNombre").val("");
            $("#mal").text("(Nuevo)");
            $("#modal").modal("show");
        })
        $(".btnEdit").click(function () {

            $(".txtCodigo").val($(this).attr("cod"));
            $(".txtNombre").val($(this).attr("nom"));
            $("#mal").text("(" + $(this).attr("cod") + ")");

            $("#modal").modal("show");
        })

        oTable = $('#tbltable').dataTable({
            "aoColumnDefs": [{ "bVisible": false, "aTargets": [0] }],
            "aaSortingFixed": [[0, 'asc']],
            "aaSorting": [[1, 'asc']],
            //"sDom": 'lfr<"giveHeight"t>ip',
            "sDom": '<"top"fi>',
            "bPaginate": false,
            "oLanguage": {
                "sSearch": "Buscar:",
                "sZeroRecords": "No se encontraron registros que mostrar",
                "sInfo": "Total registros mostrados: _TOTAL_",
                "sInfoFiltered": " - filtrados de _MAX_ registros"
            }
        });
    </script>
</asp:Content>

