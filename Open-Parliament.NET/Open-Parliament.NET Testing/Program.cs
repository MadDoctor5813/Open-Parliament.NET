using Open_Parliament.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Open_Parliament.NET_Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            OpenParliament openParliament = new OpenParliament("OpenParliament.NET - Testing - dragn194@gmail.com");
            Console.Write(openParliament.RequestHelper.makeJSONRequest("politicians/ziad-aboultaif/"));
            Console.ReadKey();
        }
    }
}
