#pragma checksum "/home/joao/Repos/seminarioTAPOO/seminarioTAPOO/Pages/Notas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f74f63ee8eac9d42427387db3c7e3cb9e5fa1661"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(seminarioTAPOO.Pages.Pages_Notas), @"mvc.1.0.razor-page", @"/Pages/Notas.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Notas.cshtml", typeof(seminarioTAPOO.Pages.Pages_Notas), null)]
namespace seminarioTAPOO.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/home/joao/Repos/seminarioTAPOO/seminarioTAPOO/Pages/_ViewImports.cshtml"
using seminarioTAPOO;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f74f63ee8eac9d42427387db3c7e3cb9e5fa1661", @"/Pages/Notas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"015fd47d80c5d8970354ccb8839ebeddc2caf253", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Notas : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "/home/joao/Repos/seminarioTAPOO/seminarioTAPOO/Pages/Notas.cshtml"
   ViewBag.Title = "Todas as Anotações";

#line default
#line hidden
            BeginContext(73, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(78, 13, false);
#line 5 "/home/joao/Repos/seminarioTAPOO/seminarioTAPOO/Pages/Notas.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(91, 81, true);
            WriteLiteral("</h2>\n<table class=\"table\">\n    <tr>\n        <th>ID</th>\n        <th>Titulo</th>\n");
            EndContext();
#line 10 "/home/joao/Repos/seminarioTAPOO/seminarioTAPOO/Pages/Notas.cshtml"
     if(Model != null && Model.Notas != null){
        foreach (var item in Model.Notas)
        {

#line default
#line hidden
            BeginContext(271, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(318, 7, false);
#line 15 "/home/joao/Repos/seminarioTAPOO/seminarioTAPOO/Pages/Notas.cshtml"
           Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(325, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(378, 9, false);
#line 18 "/home/joao/Repos/seminarioTAPOO/seminarioTAPOO/Pages/Notas.cshtml"
           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(387, 33, true);
            WriteLiteral("\n            </td>\n        </tr>\n");
            EndContext();
#line 21 "/home/joao/Repos/seminarioTAPOO/seminarioTAPOO/Pages/Notas.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(436, 9, true);
            WriteLiteral("</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Models.NotaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Models.NotaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Models.NotaModel>)PageContext?.ViewData;
        public Models.NotaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
