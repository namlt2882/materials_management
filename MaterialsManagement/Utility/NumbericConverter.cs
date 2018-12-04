using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialsManagement.Utility
{
    public class NumbericConverter
    {
        public static string ConvertToBase62Arithmetic(long i)
        {
            const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder sb = new StringBuilder();
            do
            {
                sb.Insert(0, alphabet[(int)(i % 62)]);
                i = i / 62;
            } while (i != 0);
            return sb.ToString();
        }
    }
}
