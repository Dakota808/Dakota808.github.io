using System;
using System.Collections.Generic;
using System.Web;
using System.Dynamic;
using System.IO;
using System.Net;
using System.Web.Mvc;
using HW7v2.DAL;
using HW7v2.Models;

namespace HW7v2.Controllers
{
    public class GiphyController : Controller
    {
        private SearchLogContext requestLog = new SearchLogContext();
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

            SearchLog requestLogDB = requestLog.SearchLogs.Create();

            requestLogDB.RequestTimestamp = DateTime.Now;

            requestLogDB.RequestType = Request.Url.OriginalString;

            requestLogDB.ClientIP = Request.UserHostAddress;

            requestLogDB.BrowserSearch = Request.Browser.Type;

            requestLog.SearchLogs.Add(requestLogDB);
            requestLog.SaveChanges();


            data.Close();
            getResponse.Close();
            return Json(jsonResponse, JsonRequestBehavior.AllowGet);
        }


    }
}