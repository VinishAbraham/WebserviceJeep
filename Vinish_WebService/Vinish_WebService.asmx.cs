using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Vinish_WebService
{
    /// <summary>
    /// Summary description for Vinish_WebService
    /// </summary>
    [WebService(Namespace = "http://jeep.com")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Vinish_WebService : System.Web.Services.WebService
    {

        [WebMethod (Description ="Greets the user and displays the current time.")]
        public string Hello_Vinish( string firstName, string lastName)
        {
            var dateTime = DateTime.Now;

            return string.Format("Hello {0} {1} ! The time is now: {2} .",firstName,lastName,dateTime);
        }

        [WebMethod(Description = " This will tell you the cool Code Name for your Jeep Wrangler. Enjoy!")] 
        public string Vinish_Jeep_Identifier(int jeepWranglerYear)
        {
            var codeName = "Jeep";

            if (jeepWranglerYear >= 2018)
            {
                codeName = "JL";
            }
            else if (jeepWranglerYear < 2018 && jeepWranglerYear >= 2007)
            {
                codeName = "JK";
            }
            else if (jeepWranglerYear <= 2006 && jeepWranglerYear >= 1997)
            {
                codeName = "TJ";
            }
            else if (jeepWranglerYear <= 1996 && jeepWranglerYear >= 1987)
            {
                codeName = "YJ";
            }
            else
            {
                codeName = "CJ";
            }

            return string.Format("Your {0} Jeep Wrangler's Code Name is : {1}. Have an awesome day. Happy Jeepin !!!!", jeepWranglerYear,  codeName);
        }


    }
}
