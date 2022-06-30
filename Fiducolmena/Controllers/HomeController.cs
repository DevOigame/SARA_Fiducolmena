using Fiducolmena.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestSharp;
using System.Web.Script.Serialization;
using System.Configuration;
using System.Net;
using Fiducolmena.Filters;

namespace Fiducolmena.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string requestNumber)
        {
            ViewBag.requestNumber = requestNumber;
            return View();
        }
        [FilterLinkUsed]
        [HttpPost]
        public ActionResult Prevalidacion(string NumIdentifica, string RequestNumber)
        {

            //var projectkey = ConfigurationManager.AppSettings["projectKey"];
            //var projectName = ConfigurationManager.AppSettings["projectName"];
            //var adoHostUrl = ConfigurationManager.AppSettings["adoHostUrl"];
            //var validarPersonUrl = string.Format("https://{0}/{2}/validar-persona?key={1}&projectName={2}&", adoHostUrl, projectkey, projectName);

            //var urlCallback = string.Format("callback=https://{0}/Home/ProcesoExitoso", ConfigurationManager.AppSettings["callbackHostUrl"]);

            ////caches();
            //using (var db = new SARLAFTFIDUCOLMENAEntities())
            //{
            //    var registeredPerson = db.Persona_val.FirstOrDefault(x => x.IDENTIFICATION_NUMBER == NumIdentifica);
            //    if (registeredPerson != null)
            //    {
            //        JavaScriptSerializer serializer = new JavaScriptSerializer();
            //        var parameterObject = new
            //        {
            //            requestNumber = RequestNumber
            //        };
            //        var parametersSerializer = serializer.Serialize(parameterObject);

            //        /* Enrolamiento */
            //        db.sp_registro_inicial(registeredPerson.ID_IDENTIFICATION_TYPE, NumIdentifica);
            //        db.SaveChanges();

            //        //TODO: Pasar las URLs todas a variables de configuracion
            //        urlCallback = string.Format(urlCallback + "&Parameters={0}", parametersSerializer);
            //        // aqui pones fecha de acceso al link
            //        return Redirect(string.Format("{0}{1}", validarPersonUrl, urlCallback));
            //    }
            //    else
            //    {
            //        return Content("<script language='javascript' type='text/javascript'>alert('El usuario no se encuentra habilitado para realizar la validacion de identidad.'); document.location = '/Home/Index'; </script>");
            //    }
            //}
            return Content("<script language='javascript' type='text/javascript'>alert('Ejemplo de prueba.'); document.location = '/Home/Index'; </script>");
        }

        [HttpGet]
        public ActionResult ProcesoExitoso()
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            var callbackModel = serializer.Deserialize<AdoCallBackModel>(Request.QueryString["_Response"]);

            var parameters = System.Web.Helpers.Json.Decode(callbackModel.Parameters);
            var requestNumber = parameters.RequestNumber;

            //caches();
            var serviceHostUrl = ConfigurationManager.AppSettings["serviceHostUrl"];
            var serviceUrl = string.Format("{0}/api/v1/BiometricValidation/{1}/IdentityValidation", serviceHostUrl, requestNumber);
            var client = new RestClient(serviceUrl);

            var serviceRequest = new RestRequest(Method.POST);
            serviceRequest.RequestFormat = DataFormat.Json;
            serviceRequest.AddHeader("Content-Type", "application/json");
            serviceRequest.AddHeader("Accept", "application/json");
            serviceRequest.AddBody(new { transactionId = callbackModel.TransactionId });

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            ServicePointManager.Expect100Continue = true;
            IRestResponse response = client.ExecutePostAsync(serviceRequest).Result;

            Console.WriteLine(response.Content);
            return View();
        }

        [HttpPost]
        public ActionResult RegistroFinal1(string tiDoc, string numDoc, DateTime FechaExpe, string P_Nom, string S_Nom, string P_Apell, string S_Apell, bool select1, bool select2, bool select3)
        {
            Session["numero_documento"] = numDoc;
            //caches();
            using (var db = new SARLAFTFIDUCOLMENAEntities())
            {
                string vacio = "";
                long vacio2 = 0;
                db.sp_registro(1, tiDoc, numDoc, FechaExpe, P_Nom, S_Nom, P_Apell, S_Apell, select1, select2, select3, vacio, vacio2, vacio, vacio, vacio, vacio, vacio2, vacio2, vacio2, vacio2, vacio2);
                db.SaveChanges();
                return View("Form5");
            }
        }

        [HttpPost]
        public ActionResult RegistroFinal2(string Producto, long Num_Enc, string Unidad, long C_Garajes, string Ciudad, string Torre, long Deposito, string Inmueble, long V_Inmueble, long V_cuota_ini)
        {
            string numDoc = (string)Session["numero_documento"];
            //caches();
            using (var db = new SARLAFTFIDUCOLMENAEntities())
            {
                string vacio = "";
                long num = 127000;
                db.sp_registro(2, vacio, numDoc, null, vacio, vacio, vacio, vacio, true, true, true, Producto, Num_Enc, Ciudad, Inmueble, Unidad, Torre, V_Inmueble, C_Garajes, Deposito, V_cuota_ini, num);
                db.SaveChanges();
                return View("form6");
            }
        }
        [HttpGet]
        public ActionResult Errorlink()
        {
            return View("LinkExpire");
        }

        [HttpGet]
        public ActionResult ErrorRequestNumber()
        {
            return View("RequestInvalid");
        }
        [HttpGet]
        public ActionResult ErrorLinkAccess()
        {
            return View("LinkAccess");
        }
        //public void caches()
        //{
        //    Response.Cache.SetCacheability(HttpCacheability.NoCache);
        //    Response.Cache.SetExpires(DateTime.Now.AddDays(-1));
        //    Response.Cache.SetNoStore();
        //}
    }
}