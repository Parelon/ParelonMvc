using System;
using System.Collections.Generic;
using System.Linq;


namespace ParelonCore.Core
{
    public class Privacy
    {
        public static string getPolicy() { return "allPublic"; }
        public static bool isAccessible() { return true; }
        public static bool isAnonimous() { return false; }
    }
}