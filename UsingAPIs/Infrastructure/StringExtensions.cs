using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAPIs.Infrastructure
{
    public static class StringExtensions
    {
        public static string FirstCharToUpper(this string input)
        {
            switch (input)
            {
                case null: return String.Empty;
                case "": return String.Empty;
                default: return input.First().ToString().ToUpper() + input.Substring(1);
            }
        }
    }
}
