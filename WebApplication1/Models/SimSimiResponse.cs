using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class SimSimiResponse
    {
        [JsonProperty("response")]
        public string Response { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("result")]
        public int Result { get; set; }

        [JsonProperty("msg")]
        public string Message { get; set; }
    }
}