using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TalkWithSimsimi
{
    class Simsimi
    {
        /// <summary>
        /// Lấy câu trả lời từ Simsimi
        /// </summary>
        /// <param name="t"></param>
        public void SIMSIMI(string t)
        {
            try
            {
                WebRequest request = WebRequest.Create("http://sandbox.api.simsimi.com/request.p?key=b883f6c2-9e59-4794-8952-b5d396cc7a60&lc=en&ft=1.0&text=" + t);
                WebResponse response = request.GetResponse();

                Stream data = response.GetResponseStream();

                string text = "";
                using (StreamReader sr = new StreamReader(data))
                    text = sr.ReadToEnd();
                var simSimi = JsonConvert.DeserializeObject<SimSimiResponse>(text);

                //text = text.Replace(@"{""status"":200,""respSentence"":""", "");
                //text = text.Replace(@"""}", "");
                Console.Write("Simsimi: {0}\n", simSimi.Response);
            }
            catch (Exception e)
            {
                Console.Write("Da co loi, vui long kiem tra ket noi mang!\n");
            }
        }
        //private const string SimSimiKey = "b883f6c2-9e59-4794-8952-b5d396cc7a60s";

        //public async Task<string> SimSimiRequest(string message)
        //{
        //    var request = $"http://sandbox.api.simsimi.com/request.p?key={SimSimiKey}&lc=es&ft=1.0&text={message}";
        //    var httpResponse = await new HttpClient().GetAsync(request);

        //    if (!httpResponse.IsSuccessStatusCode)
        //        return String.Empty;

        //    var response = await httpResponse.Content.ReadAsStringAsync();

        //    var simSimi = JsonConvert.DeserializeObject<SimSimiResponse>(response);
        //    if (simSimi.Result == 401)
        //        return simSimi.Message;
        //    else
        //    {
        //        return String.Empty;
        //    }


        //}

    }

}
