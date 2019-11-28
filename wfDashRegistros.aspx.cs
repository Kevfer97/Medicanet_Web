using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class wfDashRegistros : clPagina
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lbl1.Text = "9";
            lbl2.Text = "36";
            lbl3.Text = "12";
            lbl4.Text = "14";
            lbl5.Text = GetListaMedico().Count.ToString();
            lbl6.Text = GetListaPersona().Count.ToString();
            lbl7.Text = GetListaFarmacia().Count.ToString();
            lbl8.Text = GetListaCentroMedico().Count.ToString();
            lbl9.Text = GetListaMedicamento().Count.ToString();
        }
    }
}