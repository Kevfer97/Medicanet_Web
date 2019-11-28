using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class wfPruebaWs : clPagina
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            List<clCentroMedico> lista = GetListaCentroMedico();
            lbl.Text = "Respuesta: " + lista.Count;


            clCentroMedico obj = new clCentroMedico();


            obj.cmd_codigo = 0;
            obj.cmd_latitud = 12.85869;
            obj.cmd_longitud = 14.52534;
            obj.cmd_nombre = "Cambio desde la web";

          //  GuardarCentroMedico(obj).Wait();

        }
    }
}