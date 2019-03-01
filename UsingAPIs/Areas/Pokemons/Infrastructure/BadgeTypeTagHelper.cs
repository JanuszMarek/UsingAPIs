using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAPIs.Areas.Pokemons.Infrastructure
{
    [HtmlTargetElement(Attributes = "badge-type")]
    public class BadgeTypeTagHelper : TagHelper
    {
        public string BadgeType { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("class", $"badge badge-{BadgeType}");
        }

    }
}
