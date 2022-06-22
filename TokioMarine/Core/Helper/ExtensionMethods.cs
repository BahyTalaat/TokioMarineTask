using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace Core.Helper
{
    public static class ExtensionMethods
    {
        public static string ToJsonNS(this Object obj, bool handleRefLoop = true)
        {
            return Helper.ToJsonNS(obj, handleRefLoop);
        }
        public static bool IsNullOrEmptyWithTrim(this string str)
        {

            if (str == null || str.Trim() == "")
                return true;
            return false;

        }
    }
}
