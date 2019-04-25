using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class messageController : Controller
    {
        // GET: message
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult simsim(string t)
        {
            try
            {
                WebRequest request = WebRequest.Create("http://sandbox.api.simsimi.com/request.p?key=b883f6c2-9e59-4794-8952-b5d396cc7a60&lc=vn&ft=1.0&text=" + t);
                WebResponse response = request.GetResponse();

                Stream data = response.GetResponseStream();

                string text = "";
                using (StreamReader sr = new StreamReader(data))
                    text = sr.ReadToEnd();
                var simSimi = JsonConvert.DeserializeObject<SimSimiResponse>(text);

                //text = text.Replace(@"{""status"":200,""respSentence"":""", "");
                //text = text.Replace(@"""}", "");
                return Content(simSimi.Response);
            }
            catch (Exception e)
            {
                return View();
            }
        }
    }
}