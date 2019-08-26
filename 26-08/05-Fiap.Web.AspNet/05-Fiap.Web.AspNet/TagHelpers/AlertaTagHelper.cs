using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _05_Fiap.Web.AspNet.TagHelpers
{
    public class AlertaTagHelper : TagHelper
    {
        public string Mensagem { get; set; }
        public string Tipo { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (!String.IsNullOrEmpty(Mensagem))
            {
                output.TagName = "div";
                output.Attributes.SetAttribute("class", "alert alert-" + Tipo);
                output.Content.SetContent(Mensagem);
            }
        }
    }
}
