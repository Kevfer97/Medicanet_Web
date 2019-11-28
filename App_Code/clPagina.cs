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
using System.Net.Http;
using Flurl.Http;
/// <summary>
/// Descripción breve de clPagina
/// </summary>
public class clPagina: System.Web.UI.Page
{
    protected string _NombreUsuario;
    protected string _TipoUsuario;
    protected int _CodigoUsuario;
    private static readonly HttpClient client = new HttpClient();
    public clPagina()
    {
        
    }
    string urlGetCentroMedico = "https://etps3.000webhostapp.com/ws/CentroMedico/centro_medico" ;
    string urlGetEspecialidad = "https://etps3.000webhostapp.com/ws/Especialidad/especialidad";
    string urlGetFarmacia = "https://etps3.000webhostapp.com/ws/Farmacia/farmacia";
    string urlGetMedicamento = "https://etps3.000webhostapp.com/ws/Medicamentos/catalogo";
    string urlGetMedico = "https://etps3.000webhostapp.com/ws/Medicos/medico";
    string urlGetPersona = "https://etps3.000webhostapp.com/ws/Persona/persona";
    string urlGetTipoHistorial = "https://etps3.000webhostapp.com/ws/TipoHistorial/tipo_historial";

    string ws2 = "https://etps3.000webhostapp.com/ws2/ws2/servicios/get.ListaFarmacias.php";
    string Autorization = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.IkhlbGxvIFdvcmxkISI.VzXeVJOGwyr_R_lWTM2VW1i7B24XlnxiPURkg4YxrWg";

    // public async List<clCentroMedico> GetListaCentroMedico()
    public List<clFarmacia> GetListaFarmacia()
    {
        WebRequest request = WebRequest.Create(urlGetFarmacia);
        request.Headers.Add("Authorization", Autorization);
        WebResponse response = request.GetResponse();
        using (Stream dataStream = response.GetResponseStream())
        {
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            List<clFarmacia> lista = JsonConvert.DeserializeObject<List<clFarmacia>>(responseFromServer);
            response.Close();
            return lista;
        }
    }
    public List<clCentroMedico> GetListaCentroMedico()
    {
        WebRequest request = WebRequest.Create(urlGetCentroMedico);
        request.Headers.Add("Authorization", Autorization);
        WebResponse response = request.GetResponse();
        using (Stream dataStream = response.GetResponseStream())
        {
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();           
            List<clCentroMedico> lista = JsonConvert.DeserializeObject<List<clCentroMedico>>(responseFromServer);
            response.Close();
        return lista;
        }
    }
    public List<clMedicamento> GetListaMedicamento()
    {
        WebRequest request = WebRequest.Create(urlGetMedicamento);
        request.Headers.Add("Authorization", Autorization);
        WebResponse response = request.GetResponse();
        using (Stream dataStream = response.GetResponseStream())
        {
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            List<clMedicamento> lista = JsonConvert.DeserializeObject<List<clMedicamento>>(responseFromServer);
            response.Close();
            return lista;
        }
    }
    public async Task<string> GuardarCentroMedico(clCentroMedico objcmd)
    {
        var keyValues = new List<KeyValuePair<string, string>>();

        var request = (HttpWebRequest)WebRequest.Create(urlGetCentroMedico);

       // var postData = "cod=" + objcmd.cmd_codigo;
       // postData += "&nom=" + Uri.EscapeDataString(objcmd.cmd_nombre);
       // postData += "&lat=" + objcmd.cmd_latitud;
       // postData += "&alt=" + objcmd.cmd_longitud;
       // var data = Encoding.ASCII.GetBytes(postData);

      //  keyValues.add(new KeyValuePair<string, string>("cod", objcmd.cmd_codigo.ToString()));
      //  keyValues.add(new KeyValuePair<string, string>("nom", objcmd.cmd_nombre));
      //  keyValues.add(new KeyValuePair<string, string>("lat", objcmd.cmd_latitud.ToString()));
      //  keyValues.add(new KeyValuePair<string, string>("alt", objcmd.cmd_longitud.ToString()));
      //
      //
      //
      //
      //  request.Content = new FormUrlEncodedContent(keyValues);
        request.Method = "POST";
        request.ContentType = "application/x-www-form-urlencoded";
       // request.ContentLength = data.Length;
        request.Headers.Add("Authorization", Autorization);

        using (var stream = request.GetRequestStream())
        {
         //   stream.Write(data, 0, data.Length);
        }

        var response = (HttpWebResponse)request.GetResponse();

        var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

        return responseString;
    }



 
    
}