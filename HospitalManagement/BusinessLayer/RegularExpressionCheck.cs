using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BusinessLayer
{
    public static class RegularExpressionCheck
    {
        public static bool RegCheck(string info,string exp)
        {
            Regex rg = new Regex(exp);
            Match match = rg.Match(info);
            if (match.Success)
                return true;
            return false;
        }
    }
}
