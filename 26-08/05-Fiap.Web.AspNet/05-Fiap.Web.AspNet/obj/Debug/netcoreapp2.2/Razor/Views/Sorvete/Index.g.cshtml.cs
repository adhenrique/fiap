#pragma checksum "D:\fiap\26-08\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Sorvete\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64259d0d89924921675029a60953b00cd2be2b0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sorvete_Index), @"mvc.1.0.view", @"/Views/Sorvete/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sorvete/Index.cshtml", typeof(AspNetCore.Views_Sorvete_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\fiap\26-08\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\_ViewImports.cshtml"
using _05_Fiap.Web.AspNet;

#line default
#line hidden
#line 2 "D:\fiap\26-08\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\_ViewImports.cshtml"
using _05_Fiap.Web.AspNet.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64259d0d89924921675029a60953b00cd2be2b0f", @"/Views/Sorvete/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdc9d52fff5c641d1e5ff961a510040ecb4696f5", @"/Views/_ViewImports.cshtml")]
    public class Views_Sorvete_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Sorvete>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("tipo", "success", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::_05_Fiap.Web.AspNet.TagHelpers.AlertaTagHelper ___05_Fiap_Web_AspNet_TagHelpers_AlertaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\fiap\26-08\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Sorvete\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(65, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(94, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64259d0d89924921675029a60953b00cd2be2b0f4219", async() => {
                BeginContext(117, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(131, 10, true);
            WriteLiteral("\r\n</p>\r\n\r\n");
            EndContext();
            BeginContext(141, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("alerta", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64259d0d89924921675029a60953b00cd2be2b0f5606", async() => {
            }
            );
            ___05_Fiap_Web_AspNet_TagHelpers_AlertaTagHelper = CreateTagHelper<global::_05_Fiap.Web.AspNet.TagHelpers.AlertaTagHelper>();
            __tagHelperExecutionContext.Add(___05_Fiap_Web_AspNet_TagHelpers_AlertaTagHelper);
            BeginWriteTagHelperAttribute();
#line 13 "D:\fiap\26-08\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Sorvete\Index.cshtml"
      WriteLiteral(TempData["msg"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            ___05_Fiap_Web_AspNet_TagHelpers_AlertaTagHelper.Mensagem = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("mensagem", ___05_Fiap_Web_AspNet_TagHelpers_AlertaTagHelper.Mensagem, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            ___05_Fiap_Web_AspNet_TagHelpers_AlertaTagHelper.Tipo = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(201, 88, true);
            WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(290, 43, false);
#line 19 "D:\fiap\26-08\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Sorvete\Index.cshtml"
           Write(Html.DisplayNameFor(model => model[0].Nome));

#line default
#line hidden
            EndContext();
            BeginContext(333, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(389, 53, false);
#line 22 "D:\fiap\26-08\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Sorvete\Index.cshtml"
           Write(Html.DisplayNameFor(model => model[0].DataVencimento));

#line default
#line hidden
            EndContext();
            BeginContext(442, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(498, 45, false);
#line 25 "D:\fiap\26-08\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Sorvete\Index.cshtml"
           Write(Html.DisplayNameFor(model => model[0].Vegano));

#line default
#line hidden
            EndContext();
            BeginContext(543, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(599, 43, false);
#line 28 "D:\fiap\26-08\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Sorvete\Index.cshtml"
           Write(Html.DisplayNameFor(model => model[0].Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(642, 63, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 33 "D:\fiap\26-08\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Sorvete\Index.cshtml"
         if (Model != null)
        {
            

#line default
#line hidden
#line 35 "D:\fiap\26-08\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Sorvete\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(802, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(875, 9, false);
#line 39 "D:\fiap\26-08\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Sorvete\Index.cshtml"
                   Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(884, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(964, 39, false);
#line 42 "D:\fiap\26-08\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Sorvete\Index.cshtml"
                   Write(item.DataVencimento.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1003, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1084, 33, false);
#line 45 "D:\fiap\26-08\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Sorvete\Index.cshtml"
                    Write(item.Vegano ? "Vegano" : "Normal");

#line default
#line hidden
            EndContext();
            BeginContext(1118, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1198, 39, false);
#line 48 "D:\fiap\26-08\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Sorvete\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(1237, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 51 "D:\fiap\26-08\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Sorvete\Index.cshtml"
            }

#line default
#line hidden
#line 51 "D:\fiap\26-08\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Sorvete\Index.cshtml"
             
        }
        else
        {

#line default
#line hidden
            BeginContext(1340, 152, true);
            WriteLiteral("            <tr>\r\n                <td colspan=\"6\">\r\n                    Nao existem dados a serem mostrados.\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 60 "D:\fiap\26-08\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Sorvete\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1503, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Sorvete>> Html { get; private set; }
    }
}
#pragma warning restore 1591
