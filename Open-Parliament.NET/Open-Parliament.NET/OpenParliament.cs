﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Open_Parliament.NET
{
    public class OpenParliament
    {

        public RequestHelper RequestHelper
        {
            get
            {
                return requestHelper;
            }
        }
        private RequestHelper requestHelper;

        public OpenParliament(string userAgent)
        {
            requestHelper = new RequestHelper(userAgent);
        }

    }
}
