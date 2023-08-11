using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionExample
{
    public  static class StringExtension
    {
        public static string reverseString(this string s)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = s.Length - 1; i >= 0; i--)
            {
                sb.Append(s[i]);
            }


            return sb.ToString();

        }

        public static bool StartsWithUpperCase(this string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return false;

            char ch = s[0];
            return char.IsUpper(ch);

        }





    }
}
