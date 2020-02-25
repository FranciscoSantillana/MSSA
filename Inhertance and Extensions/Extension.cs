using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_and_Extensions
{
   static class Extension
    {
        public static int Negate(this int x)
        {
            return -x;
        }

        public static string AddPeriod(this string p) => ".";
        public static string Indent(this string p) => "\n";
       
    }
}
