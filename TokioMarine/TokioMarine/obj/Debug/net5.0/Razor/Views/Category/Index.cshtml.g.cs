#pragma checksum "D:\TokioMarine\TokioMarine\TokioMarine\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c08dc11daa4783ba8fd8645cf534d3a794d3d792"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
#nullable restore
#line 1 "D:\TokioMarine\TokioMarine\TokioMarine\Views\_ViewImports.cshtml"
using TokioMarine;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\TokioMarine\TokioMarine\TokioMarine\Views\_ViewImports.cshtml"
using TokioMarine.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\TokioMarine\TokioMarine\TokioMarine\Views\Category\Index.cshtml"
using DTO.Category;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c08dc11daa4783ba8fd8645cf534d3a794d3d792", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f97253c7a05516ebbcf8a7985add7f0884582eb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GetCategoryDto>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\TokioMarine\TokioMarine\TokioMarine\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n");
#nullable restore
#line 8 "D:\TokioMarine\TokioMarine\TokioMarine\Views\Category\Index.cshtml"
Write(Html.ActionLink("Create New Category","Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1></h1>\r\n\n  <table class=\"table\">\r\n  <thead>\r\n    <tr>\r\n      <th scope=\"col\">#</th>\r\n      <th scope=\"col\">Name</th>\r\n    </tr>\r\n  </thead>\r\n  <tbody>\r\n");
#nullable restore
#line 19 "D:\TokioMarine\TokioMarine\TokioMarine\Views\Category\Index.cshtml"
         foreach (var item in @Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n             <th scope=\"row\">");
#nullable restore
#line 22 "D:\TokioMarine\TokioMarine\TokioMarine\Views\Category\Index.cshtml"
                        Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n             <td>");
#nullable restore
#line 23 "D:\TokioMarine\TokioMarine\TokioMarine\Views\Category\Index.cshtml"
            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          </tr>\r\n");
#nullable restore
#line 25 "D:\TokioMarine\TokioMarine\TokioMarine\Views\Category\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  </tbody>\r\n</table>\n   \r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GetCategoryDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
