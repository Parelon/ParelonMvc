using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parelon.Core
{
    public class Privacy
    {
        public static string getPolicy() { return "allPublic"; }
        public static bool isAccessible() { return true; }
        public static bool isAnonimous() { return true; }
    }
}