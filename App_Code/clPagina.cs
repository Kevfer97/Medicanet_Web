using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Data;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Configuration;
using System.IO;
using System.Net;
/// <summary>
/// Descripción breve de clPagina
/// </summary>
public class clPagina: System.Web.UI.Page
{
    protected string _NombreUsuario;
    protected string _TipoUsuario;
    protected int _CodigoUsuario;

    public clPagina()
    {
        
    }
    string urlGetCentroMedico = "https://etps3.000webhostapp.com/ws/CentroMedico/centro_medico" ;
    string ws2 = "https://etps3.000webhostapp.com/ws2/ws2/servicios/get.ListaFarmacias.php";
    string Autorization = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.IkhlbGxvIFdvcmxkISI.VzXeVJOGwyr_R_lWTM2VW1i7B24XlnxiPURkg4YxrWg";

    // public async List<clCentroMedico> GetListaCentroMedico()
    public string GetListaCentroMedico()
    {
        WebRequest request = WebRequest.Create(urlGetCentroMedico);
        request.Headers.Add("Authorization", Autorization);

        WebResponse response = request.GetResponse();
        using (Stream dataStream = response.GetResponseStream())
        {
            // Open the stream using a StreamReader for easy access.  
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.  
            string responseFromServer = reader.ReadToEnd();
            // Display the content.  
            //List<clCentroMedico> Lista = JsonConvert.DeserializeObject<clCentroMedico>(responseFromServer.);



        // Close the response.  
        response.Close();
        return responseFromServer;
        }
    }
}