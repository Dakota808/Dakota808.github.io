using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Net;
using System.Web.Mvc;

namespace HW7.Controllers
{
    public class GiphyController : Controller
    {
        // GET: Giphy
        [HttpGet]
        public JsonResult GiphyTranslator(string keyWord)
        {
            string secretKey = System.Web.Configuration.WebConfigurationManager.AppSettings["gif"];
            
            string giphyUrl = "http://api.giphy.com/v1/stickers/translate?api_key=" + secretKey + "&s=" + keyWord;

            WebRequest sendRequest = WebRequest.Create(giphyUrl);

            WebResponse getResponse = sendRequest.GetResponse();

            Stream data = sendRequest.GetResponse().GetResponseStream();

            string convertResponse = new StreamReader(data).ReadToEnd();

            var serialize = new System.Web.Script.Serialization.JavaScriptSerializer();

            var jsonResponse = serialize.DeserializeObject(convertResponse);

            data.Close();
            getResponse.Close();
            return Json(jsonResponse, JsonRequestBehavior.AllowGet);
        }


    }
}