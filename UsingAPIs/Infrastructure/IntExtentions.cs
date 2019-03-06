using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAPIs.Infrastructure
{
    public static class IntExtentions
    {
        public static string HeightToString(this int input)
        {
            if (input <= 0)
            {
                return string.Empty;
            }
            else if (input < 10)
            {
                return (input * 10).ToString() + " cm";
            }
            else
            {
                return string.Format("{0:0.00}", ((double)input / 10).ToString()) + " m";
            }
        }

        public static string WeightToString(this int input)
        {
            if (input <= 0)
            {
                return string.Empty;
            }
            else if (input < 10)
            {
                return (input * 10).ToString() + " dag";
            }
            else
            {
                return string.Format("{0:0.00}", ((double)input / 10).ToString()) + " kg";
            }
        }
    }
}
