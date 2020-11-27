using System;
using System.Text;

namespace ElementGenerator
{
    public static class Extensions
    {
        public static string ToKebab (this string input)
        {
            StringBuilder bob = new StringBuilder();

            foreach(char c in input)
            {
                if (c >= 'A' && c <= 'Z' && bob.Length > 0)
                    bob.Append('-');

                bob.Append(c);                
            }

            return bob.ToString().ToLower();
        }
    }
}
