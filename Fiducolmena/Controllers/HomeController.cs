using Fiducolmena.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestSharp;
using System.Web.Script.Serialization;
using System.Configuration;

namespace Fiducolmena.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Prevalidacion(string NumIdentifica, string RequestNumber)
        {
            //TODO: estas variables se deben cargar desde configuracion
            var projectkey = "db92efc69991";
            var projectName = "FiducolmenaQA";
            var verificarPersonUrl = "https://adocolombia-qa.ado-tech.com/FiducolmenaQA/{0}?key={1}&projectName={2}&";            

            var urlCallback = @"callback=https://"+ ConfigurationManager.AppSettings["hostUrl"] +"/Home/ProcesoExitoso&Parameters={0}";

            caches();
            using (var db = new SARLAFTFIDUCOLMENAEntities())
            {
                var rqn = db.Persona_val.Where(x => x.REQUEST_NUMBER == RequestNumber).FirstOrDefault();
                if (!RequestNumber.Equals(rqn.REQUEST_NUMBER))
                {
                    return Content("<script language='javascript' type='text/javascript'>alert('Rectificar número de encargo o comunicarse con la constructora.'); document.location = '/Home/Index'; </script>");
                }

                var list = db.Persona_val.Where(x => x.IDENTIFICATION_NUMBER == NumIdentifica).FirstOrDefault();
                if (list != null)
                {
                    string identificationType2;
                    if (list.ID_IDENTIFICATION_TYPE == "CC")
                    {
                        identificationType2 = "1";
                    }
                    else
                    {
                        identificationType2 = "2";
                    }
                    JavaScriptSerializer serializer = new JavaScriptSerializer();
                    var parameterObject = new
                    {
                        documentType = identificationType2,
                        identificationNumber = NumIdentifica,
                        requestNumber = RequestNumber
                    };
                    var parametersSerializer = serializer.Serialize(parameterObject);

                    var list2 = db.Persona_fidu.Where(x => x.identificacion == NumIdentifica).FirstOrDefault();
                    if (list2 != null)
                    {
                        /* Validacion */
                        Session["numero_documento"] = NumIdentifica;

                        verificarPersonUrl = string.Format(verificarPersonUrl, "verificar-persona", projectkey, projectName);
                        //TODO: Pasar las URLs todas a variables de configuracion
                        urlCallback = string.Format(urlCallback, parametersSerializer);
                        return Redirect(string.Format("{0}{1}", verificarPersonUrl, urlCallback));
                    }
                    else
                    {
                        /* Enrolamiento */
                        db.sp_registro_inicial(list.ID_IDENTIFICATION_TYPE, NumIdentifica);
                        db.SaveChanges();

                        //var verificarPersonUrl = "https://adocolombia-qa.ado-tech.com/FiducolmenaQA/{0}&key={1}&projectName={2}&";
                        verificarPersonUrl = string.Format(verificarPersonUrl, "validar-persona", projectkey, projectName);
                        //TODO: Pasar las URLs todas a variables de configuracion
                        urlCallback = string.Format(urlCallback, urlCallback);

                        return Redirect(string.Format("{0}{1}", verificarPersonUrl, urlCallback));
                    }
                }
                else
                {
                    return Content("<script language='javascript' type='text/javascript'>alert('El usuario no se encuentra habilitado para realizar la validacion de identidad.'); document.location = '/Home/Index'; </script>");
                }
            }
        }

        //extrae informacion de la appi de ado y la imprime en la vista corriendo el <script> traer()
        //public ActionResult Form3()
        //{
        //    string NumIdentifica = (string)Session["numero_documento"];
        //    using (var db = new SARLAFTFIDUCOLMENAEntities())
        //    {
        //        var list = db.Persona_fidu.Where(x => x.identificacion == NumIdentifica).FirstOrDefault();
        //        return View(list);

        //    }
        //}



        [HttpGet]
        public ActionResult ProcesoExitoso()
        {
            dynamic returnObj = Request.QueryString["_Response"];
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            var callbackModel = serializer.Deserialize<AdoCallBackModel>(Request.QueryString["_Response"]);

            var parameters = System.Web.Helpers.Json.Decode(callbackModel.Parameters);
            var documentType = parameters.documentType;
            var identificationNumber = parameters.identificationNumber;
            var requestNumber = parameters.requestNumber;

            caches();

            var client = new RestClient("https://fiducolmenabiometricval.oigame.com.co/api/v1/BiometricValidation/" + requestNumber + "/IdentityValidation");

            client.Timeout = -1;

            var serviceRequest = new RestRequest(Method.POST);

            serviceRequest.RequestFormat = DataFormat.Json;
            serviceRequest.AddBody(new { transactionId = callbackModel.TransactionId });
            serviceRequest.AddHeader("Content-Type", "application/json");

            serviceRequest.AddHeader("Accept", "application/json");

            IRestResponse response = client.Execute(serviceRequest);

            Console.WriteLine(response.Content);
            return View();

        }
        /*Agregar campo requestnumber SQL*/
        [HttpPost]
        public ActionResult RegistroFinal1(string tiDoc, string numDoc, DateTime FechaExpe, string P_Nom, string S_Nom, string P_Apell, string S_Apell, bool select1, bool select2, bool select3)
        {
            Session["numero_documento"] = numDoc;
            caches();
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
            caches();
            using (var db = new SARLAFTFIDUCOLMENAEntities())
            {
                string vacio = "";
                long num = 127000;
                db.sp_registro(2, vacio, numDoc, null, vacio, vacio, vacio, vacio, true, true, true, Producto, Num_Enc, Ciudad, Inmueble, Unidad, Torre, V_Inmueble, C_Garajes, Deposito, V_cuota_ini, num);
                db.SaveChanges();
                return View("form6");
            }
        }

        public void caches()
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.Now.AddDays(-1));
            Response.Cache.SetNoStore();
        }
    }
}