using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class wfLogin : clPagina
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {

        }
    }
    protected void btnIngresar_Click(object sender, EventArgs e)
    {
        String Vret = ValidarCredenciales(txtEmail.Text, txtPassword.Text);
        
        if(Vret != "")
        {
            Response.Redirect("wfDashRegistros.aspx");
        }
        else
        {
            lblPantalla.Text = Vret;
        }
    }
}   