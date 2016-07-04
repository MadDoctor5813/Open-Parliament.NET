using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Open_Parliament.NET
{
    public class OpenParliament
    {

        RequestHelper requestHelper;

        public OpenParliament(string userAgent)
        {
            requestHelper = new RequestHelper(userAgent);
        }

    }
}
