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
        rpt1.DataSource = GetListaMedico();
        rpt1.DataBind();        
    }

    protected void rpt1_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            Label lblcodigo = (Label)e.Item.FindControl("lblcodigo");
            Label lblNombre = (Label)e.Item.FindControl("lblNombre");
            Label lblApellido = (Label)e.Item.FindControl("lblApellido");
            Label lblCorreo = (Label)e.Item.FindControl("lblCorreo");
            Label lblFecha = (Label)e.Item.FindControl("lblFecha");
            Label lblEstado = (Label)e.Item.FindControl("lblEstado");
            Label lblDui = (Label)e.Item.FindControl("lblDui");

            clPersona Objlista = (clPersona)e.Item.DataItem;

            lblcodigo.Text = Objlista.med_codigo.ToString();
            lblNombre.Text = Objlista.per_nombre;
            lblApellido.Text = Objlista.per_apellidos;
            lblCorreo.Text = Objlista.per_correo;
            lblFecha.Text = Objlista.per_fecha_nace.ToString("dd/MM/yyyy");
            lblEstado.Text = Objlista.per_estado;
            lblDui.Text = Objlista.per_dui;

            lblNombre.Attributes.Add("cod", Objlista.med_codigo.ToString());
            lblNombre.Attributes.Add("nom", Objlista.per_nombre);
            lblNombre.Attributes.Add("ape", Objlista.per_apellidos );
            lblNombre.Attributes.Add("cor", Objlista.per_correo);
            lblNombre.Attributes.Add("est", Objlista.per_estado);
            lblNombre.Attributes.Add("dui", Objlista.per_dui);
            lblNombre.Attributes.Add("cla", Objlista.per_clave);
        }
    }

    protected void BtnGuardar_Click(object sender, EventArgs e)
    {
        Guardar();
    }
    private void Guardar()
    {
        clPersona obj = new clPersona();

        if (txtCodigo.Text != "0" && txtCodigo.Text != "")
        {
            obj.per_codigo = int.Parse(txtCodigo.Text);
        }
        obj.per_nombre = txtNombre.Text;
        obj.per_apellidos = txtApellido.Text;
        obj.per_dui = txtDui.Text;
        obj.per_correo = txtCorreo.Text;
        obj.per_clave = txtClave.Text;
        obj.per_estado = ddlEsatdo.SelectedValue;

        //var i = GuardarCentroMedico(obj);

        llenarRpt();
      

    }
}