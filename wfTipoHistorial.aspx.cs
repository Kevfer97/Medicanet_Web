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
        rpt1.DataSource = GetListaTipoHistorial();
        rpt1.DataBind();        
    }
    protected void rpt1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "Eliminar")
        {
            //DeleteCentroMedico(int.Parse(e.CommandArgument));
        }
        llenarRpt();
    }
    protected void rpt1_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            Label lblcodigo = (Label)e.Item.FindControl("lblcodigo");
            Label lblNombre = (Label)e.Item.FindControl("lblNombre");
            LinkButton lkbEliminar = (LinkButton)e.Item.FindControl("lkbEliminar");

            clTipoHistorial Objlista = (clTipoHistorial)e.Item.DataItem;

            lblcodigo.Text = Objlista.thm_codigo.ToString();
            lblNombre.Text = Objlista.thm_nombre;

            lkbEliminar.CommandArgument = Objlista.thm_codigo.ToString();
            lkbEliminar.CommandName = "Eliminar";

            lblNombre.Attributes.Add("cod", Objlista.thm_codigo.ToString());
            lblNombre.Attributes.Add("nom", Objlista.thm_nombre);
        }
    }

    protected void BtnGuardar_Click(object sender, EventArgs e)
    {
        Guardar();
    }
    private void Guardar()
    {
        clTipoHistorial obj = new clTipoHistorial();

        if (txtCodigo.Text != "0" && txtCodigo.Text != "")
        {
            obj.thm_codigo = int.Parse(txtCodigo.Text);
        }
        obj.thm_nombre = txtNombre.Text;

       // var i = GuardarCentroMedico(obj);

        llenarRpt();
      

    }
}