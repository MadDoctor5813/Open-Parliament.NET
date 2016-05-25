using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Open_Parliament.NET
{
    public class OpenParliament
    {

        private WebClient client;

        public OpenParliament(string userAgent)
        {
            createClient();
        }

        private void createClient()
        {
            client = new WebClient();
            client.Headers["User-Agent"] = userAgent;
        }

    }
}
