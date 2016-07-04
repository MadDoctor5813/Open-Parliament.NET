﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Open_Parliament.NET
{
    class RequestHelper
    {

        private WebClient webClient;

        private const string API_ROOT = "http://api.openparliament.ca/";

        public RequestHelper(string userAgent)
        {
            webClient = new WebClient();
            webClient.Headers["User-Agent"] = userAgent;
        }

        public string makeJSONRequest(string query)
        {
            byte[] response = webClient.DownloadData(API_ROOT + query);
            return BitConverter.ToString(response);
        }

    }
}
