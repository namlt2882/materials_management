using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialsManagement.Utility
{
    public class StringUtility
    {
        public static string TrimIfPresent(string s)
        {
            if (s != null)
            {
                return s.Trim();
            }
            else
            {
                return null;
            }
        }

    }
}
