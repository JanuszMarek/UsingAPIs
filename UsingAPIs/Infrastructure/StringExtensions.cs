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
                default:
                    {
                        
                        var str = input.First().ToString().ToUpper() + input.Substring(1);

                        int? minus = input.IndexOf("-");
                        if(minus.HasValue && minus.Value > 0 && minus.Value + 2 < str.Length)
                        {
                            str = str.Substring(0, minus.Value + 1) + str.ElementAt(minus.Value + 1).ToString().ToUpper() + str.Substring(minus.Value + 2, str.Length - (minus.Value + 2));
                        }

                        return str;
                    }
                    
            }
        }


    }
}
