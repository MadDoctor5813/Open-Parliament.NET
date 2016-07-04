using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Open_Parliament.NET
{
    public class RequestHelper
    {
        private WebClient webClient;

        private const string API_ROOT = "http://api.openparliament.ca/";

        public RequestHelper(string userAgent)
        {
            webClient = new WebClient();
            webClient.Headers["User-Agent"] = userAgent;
        }

        public T getJSONModel<T>(string query)
        {
            return JsonConvert.DeserializeObject<T>(makeJSONRequest(query));
        }

        public string makeJSONRequest(string query)
        {
            byte[] response = webClient.DownloadData(API_ROOT + query);
            return UTF8Encoding.UTF8.GetString(response);
        }

    }
}
