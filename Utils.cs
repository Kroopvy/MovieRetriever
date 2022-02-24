using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRetriever.ASP.Helpers
{
    public class Utils
    {
            public static string KeyWord
            {
                get { return (string)HttpContext.Current.Session["KeyWord"]; }
                set { HttpContext.Current.Session["KeyWord"] = value; }
            }

           public static int Page
            {
            get { return (int)HttpContext.Current.Session["Page"]; }
            set { HttpContext.Current.Session["Page"] = value; }
        }

    }
}