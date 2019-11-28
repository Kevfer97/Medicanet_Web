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
        rpt1.DataSource = GetListaEspecialidad();
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

            clEspecialidad Objlista = (clEspecialidad)e.Item.DataItem;

            lblcodigo.Text = Objlista.emd_codigo.ToString();
            lblNombre.Text = Objlista.emd_nombre;

            lkbEliminar.CommandArgument = Objlista.emd_codigo.ToString();
            lkbEliminar.CommandName = "Eliminar";

            lblNombre.Attributes.Add("cod", Objlista.emd_codigo.ToString());
            lblNombre.Attributes.Add("nom", Objlista.emd_nombre);
        }
    }

    protected void BtnGuardar_Click(object sender, EventArgs e)
    {
        Guardar();
    }
    private void Guardar()
    {
        clEspecialidad obj = new clEspecialidad();

        if (txtCodigo.Text != "0" && txtCodigo.Text != "")
        {
            obj.emd_codigo = int.Parse(txtCodigo.Text);
        }
        obj.emd_nombre = txtNombre.Text;

        //var i = GuardarCentroMedico(obj);

        llenarRpt();
      

    }
}