using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsingAPIs.Models;

namespace UsingAPIs.Areas.GIPHY.Models
{
    public class GifViewModel
    {
        public Gif Gif { get; set; }
        public PaginationClass Pagination { get; set; } = new PaginationClass();
    }
}
