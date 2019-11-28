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
        rpt1.DataSource = GetListaMedicamento();
        rpt1.DataBind();        
    }


    protected void rpt1_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            Label lblcodigo = (Label)e.Item.FindControl("lblcodigo");
            Label lblNombre = (Label)e.Item.FindControl("lblNombre");
            Label lblDescripcion = (Label)e.Item.FindControl("lblDescripcion");
            Label lblMedida = (Label)e.Item.FindControl("lblMedida");
            LinkButton lkbEliminar = (LinkButton)e.Item.FindControl("lkbEliminar");

            clMedicamento Objlista = (clMedicamento)e.Item.DataItem;

            lblcodigo.Text = Objlista.mdc_codigo.ToString();
            lblNombre.Text = Objlista.mdc_nombre;
            lblDescripcion.Text = Objlista.mdc_descripcion;
            lblMedida.Text = Objlista.mdc_medida;

            lkbEliminar.CommandArgument = Objlista.mdc_codigo.ToString();
            lkbEliminar.CommandName = "Eliminar";

            lblNombre.Attributes.Add("cod", Objlista.mdc_codigo.ToString());
            lblNombre.Attributes.Add("nom", Objlista.mdc_nombre);
            lblNombre.Attributes.Add("des", Objlista.mdc_descripcion.ToString());
            lblNombre.Attributes.Add("med", Objlista.mdc_medida.ToString());
        }
    }

    protected void BtnGuardar_Click(object sender, EventArgs e)
    {
        Guardar();
    }

    protected void rpt1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "Eliminar")
        {
            //DeleteMedicamento(int.Parse(e.CommandArgument));
        }
        llenarRpt();
    }
    private void Guardar()
    {
        clMedicamento obj = new clMedicamento();

        if (txtCodigo.Text != "0" && txtCodigo.Text != "")
        {
            obj.mdc_codigo = int.Parse(txtCodigo.Text);
        }
        obj.mdc_nombre = txtNombre.Text;
        obj.mdc_descripcion = txtDescripcion.Text;
        obj.mdc_medida = ddlMedia.SelectedValue;

//        var i = GuardarCentroMedico(obj);

        llenarRpt();
      

    }
}