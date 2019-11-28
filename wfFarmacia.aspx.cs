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
        rpt1.DataSource = GetListaFarmacia();
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
            Label lblCorreo = (Label)e.Item.FindControl("lblCorreo");
            Label LblEstado = (Label)e.Item.FindControl("LblEstado");
            LinkButton lkbEliminar = (LinkButton)e.Item.FindControl("lkbEliminar");

            clFarmacia Objlista = (clFarmacia)e.Item.DataItem;

            lblcodigo.Text = Objlista.far_codigo.ToString();
            lblNombre.Text = Objlista.far_nombre;
            lbllat.Text = Objlista.far_latitud.ToString();
            lblalt.Text = Objlista.far_longitud.ToString();
            lblCorreo.Text = Objlista.far_correo;
            LblEstado.Text = Objlista.far_estado;

            lkbEliminar.CommandArgument = Objlista.far_codigo.ToString();
            lkbEliminar.CommandName = "Eliminar";

            lblNombre.Attributes.Add("cod", Objlista.far_codigo.ToString());
            lblNombre.Attributes.Add("nom", Objlista.far_nombre);
            lblNombre.Attributes.Add("lat", Objlista.far_latitud.ToString());
            lblNombre.Attributes.Add("alt", Objlista.far_longitud.ToString());
            lblNombre.Attributes.Add("cor", Objlista.far_correo);
            lblNombre.Attributes.Add("est", Objlista.far_estado);
            lblNombre.Attributes.Add("cla", Objlista.far_clave);
        }
    }
    protected void rpt1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "Eliminar")
        {
            //DeleteFarmacia(int.Parse(e.CommandArgument));
        }
        llenarRpt();
    }

    protected void BtnGuardar_Click(object sender, EventArgs e)
    {
        Guardar();
    }
    private void Guardar()
    {
        clFarmacia obj = new clFarmacia();

        if (txtCodigo.Text != "0" && txtCodigo.Text != "")
        {
            obj.far_codigo = int.Parse(txtCodigo.Text);
        }
        obj.far_nombre = txtNombre.Text;
        obj.far_latitud = double.Parse(txtLatitud.Text);
        obj.far_longitud = double.Parse(txtAltitud.Text);

        //var i = GuardarCentroMedico(obj);

        llenarRpt();
      

    }
}