using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class wfUsuarios : clPagina
{
    protected void Page_Load(object sender, EventArgs e)
    {
        llenarRpt();
    }
    private void llenarRpt()
    {
        rpt1.DataSource = GetListaCentroMedico();
        rpt1.DataBind();        
    }

    protected void rpt1_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            Label lblcodigo = (Label)e.Item.FindControl("lblcodigo");
            Label lblNombre = (Label)e.Item.FindControl("lblNombre");
            Label lbllat = (Label)e.Item.FindControl("lbllat");
            Label lblalt = (Label)e.Item.FindControl("lblalt");
            LinkButton lkbEliminar = (LinkButton)e.Item.FindControl("lkbEliminar");

            clCentroMedico Objlista = (clCentroMedico)e.Item.DataItem;

            lblcodigo.Text = Objlista.cmd_codigo.ToString();
            lblNombre.Text = Objlista.cmd_nombre;
            lbllat.Text = Objlista.cmd_latitud.ToString();
            lblalt.Text = Objlista.cmd_longitud.ToString();

            lkbEliminar.CommandArgument = Objlista.cmd_codigo.ToString();
            lkbEliminar.CommandName = "Eliminar";

            lblNombre.Attributes.Add("cod", Objlista.cmd_codigo.ToString());
            lblNombre.Attributes.Add("nom", Objlista.cmd_nombre);
            lblNombre.Attributes.Add("lat", Objlista.cmd_latitud.ToString());
            lblNombre.Attributes.Add("alt", Objlista.cmd_longitud.ToString());
        }
    }


    protected void rpt1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "Eliminar")
        {
            //DeleteCentroMedico(int.Parse(e.CommandArgument));
        }
        llenarRpt();
    }
    protected void BtnGuardar_Click(object sender, EventArgs e)
    {
        Guardar();
    }
    private void Guardar()
    {
        clCentroMedico obj = new clCentroMedico();

        if (txtCodigo.Text != "0" && txtCodigo.Text != "")
        {
            obj.cmd_codigo = int.Parse(txtCodigo.Text);
        }
        obj.cmd_nombre = txtNombre.Text;
        obj.cmd_latitud = double.Parse(txtLatitud.Text);
        obj.cmd_longitud = double.Parse(txtAltitud.Text);

        var i = GuardarCentroMedico(obj);

        llenarRpt();
      

    }
}