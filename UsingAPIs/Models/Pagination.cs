using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAPIs.Models
{
    public class PaginationClass
    {
        public string Search { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}
