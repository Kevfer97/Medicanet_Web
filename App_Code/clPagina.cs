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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
/// <summary>
/// Descripción breve de clPagina
/// </summary>
public class clPagina: System.Web.UI.Page
{
    public string _NombreUsuario;
    public string _TipoUsuario;
    public int _CodigoUsuario;
    private static readonly HttpClient client = new HttpClient();
    public clPagina()
    {
        
    }
    string urlGetCentroMedico = "https://etps3.000webhostapp.com/ws/CentroMedico/centro_medico" ;
    string urlGetEspecialidad = "https://etps3.000webhostapp.com/ws/Especialidad/especialidad";
    string urlGetFarmacia = "https://etps3.000webhostapp.com/ws/Farmacia/farmacia";
    string urlGetMedicamento = "https://etps3.000webhostapp.com/ws/Medicamentos/catalogo";
    string urlGetMedico = "http://etps3.000webhostapp.com/ws/Medicos/medicos";
    string urlGetPersona = "http://etps3.000webhostapp.com/ws/Persona/personas?per=0";
    string urlGetTipoHistorial = "https://etps3.000webhostapp.com/ws/TipoHistorial/tipo_historial";


    string urlCantidadConsultas = "https://etps3.000webhostapp.com/ws/Consulta/consulta?per=0&doc=1&cod=0";
    string urlCantidadRecetas = "https://etps3.000webhostapp.com/ws/Receta/recetasPorConsulta?cod=28";
    string urlCantidadMedicamentosEntregados = "https://etps3.000webhostapp.com/ws/Medicamentos/medicamentos_entregados?per=0&cme=29&far=0";
    string urlCantidadMedicamentosPendientes = "https://etps3.000webhostapp.com/ws/Medicamentos/medicamentos_pendientes?per=0&cme=0";

    string ws2 = "https://etps3.000webhostapp.com/ws2/ws2/servicios/get.ListaFarmacias.php";
    string Autorization = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.IkhlbGxvIFdvcmxkISI.VzXeVJOGwyr_R_lWTM2VW1i7B24XlnxiPURkg4YxrWg";

    public class nameList
    {
        public List<clTipoHistorial> name { get; set; }
    }
    // public async List<clCentroMedico> GetListaCentroMedico()
    public int GetCantidadMedicamentosPendientes()
    {
        WebRequest request = WebRequest.Create(urlCantidadMedicamentosPendientes);
        request.Headers.Add("Authorization", Autorization);
        WebResponse response = request.GetResponse();
        using (Stream dataStream = response.GetResponseStream())
        {
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            List<clFarmacia> lista = JsonConvert.DeserializeObject<List<clFarmacia>>(responseFromServer);
            response.Close();
            return lista.Count;
        }
    }
    public int GetCantidadMedicamentosEntregados()
    {
        WebRequest request = WebRequest.Create(urlCantidadMedicamentosEntregados);
        request.Headers.Add("Authorization", Autorization);
        WebResponse response = request.GetResponse();
        using (Stream dataStream = response.GetResponseStream())
        {
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            List<clFarmacia> lista = JsonConvert.DeserializeObject<List<clFarmacia>>(responseFromServer);
            response.Close();
            return lista.Count;
        }
    }
    public List<clPersona> GetCantidadConsultas()
    {
        WebRequest request = WebRequest.Create(urlCantidadConsultas);
        request.Headers.Add("Authorization", Autorization);
        WebResponse response = request.GetResponse();
        using (Stream dataStream = response.GetResponseStream())
        {
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            List<clPersona> lista = JsonConvert.DeserializeObject<List<clPersona>>(responseFromServer);
            response.Close();
            return lista;
        }
    }
    public List<clFarmacia> GetCantidadRecetas()
    {
        WebRequest request = WebRequest.Create(urlCantidadRecetas);
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



    public List<clPersona> GetListaPersona()
    {
        WebRequest request = WebRequest.Create(urlGetPersona);
        request.Headers.Add("Authorization", Autorization);
        WebResponse response = request.GetResponse();
        using (Stream dataStream = response.GetResponseStream())
        {
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            List<clPersona> lista = JsonConvert.DeserializeObject<List<clPersona>>(responseFromServer);
            response.Close();
            return lista;
        }
    }

    public List<clPersona> GetListaMedico()
    {
        WebRequest request = WebRequest.Create(urlGetMedico);
        request.Headers.Add("Authorization", Autorization);
        WebResponse response = request.GetResponse();
        using (Stream dataStream = response.GetResponseStream())
        {
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            List<clPersona> lista = JsonConvert.DeserializeObject<List<clPersona>>(responseFromServer);
            response.Close();
            return lista;
        }
    }
    public List<clEspecialidad> GetListaEspecialidad()
    {
        WebRequest request = WebRequest.Create(urlGetEspecialidad);
        request.Headers.Add("Authorization", Autorization);
        WebResponse response = request.GetResponse();
        using (Stream dataStream = response.GetResponseStream())
        {
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            List<clEspecialidad> lista = JsonConvert.DeserializeObject<List<clEspecialidad>>(responseFromServer);
            response.Close();
            return lista;
        }
    }

    public List<clTipoHistorial> GetListaTipoHistorial()
    {
        WebRequest request = WebRequest.Create(urlGetTipoHistorial);
        request.Headers.Add("Authorization", Autorization);
        WebResponse response = request.GetResponse();
        using (Stream dataStream = response.GetResponseStream())
        {
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            List<clTipoHistorial> lista = JsonConvert.DeserializeObject<List<clTipoHistorial>>(responseFromServer);
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


    public string ValidarCredenciales(string correo,string clave)
    {
        string urlLogin = "https://etps3.000webhostapp.com/ws/Persona/log_in?usr="+ Uri.EscapeDataString(correo) + "&cla=" + Uri.EscapeDataString(clave);

        WebRequest request = WebRequest.Create(urlLogin);
        request.Headers.Add("Authorization", Autorization);
        WebResponse response = request.GetResponse();
        using (Stream dataStream = response.GetResponseStream())
        {
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            List<clLogueoUsuario> lista = JsonConvert.DeserializeObject<List<clLogueoUsuario>>(responseFromServer);
            response.Close();
            if (lista.Count > 0)
            {
                Loguear(lista.FirstOrDefault());
                return "ok";
            }
            else
            {
                return "";
            }
        }
        

      
    }

    private void Loguear(clLogueoUsuario objusr)
    {
        _NombreUsuario = objusr.correo;
        _CodigoUsuario = 0;
        _TipoUsuario = objusr.tipo;
        Session["usuario"] = _NombreUsuario;
        Session["usrcod"] = _CodigoUsuario;
        Session["usrtip"] = _TipoUsuario;

    }
    public void DesLoguear()
    {
        _NombreUsuario = "";
        _CodigoUsuario = 0;
        _TipoUsuario = "";
        Session.Abandon();

    }

}