#pragma checksum "D:\TokioMarine\TokioMarine\TokioMarine\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d89a09c9030479b5a7b84c997d19d6363491d8fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "D:\TokioMarine\TokioMarine\TokioMarine\Views\Product\Index.cshtml"
using DTO.Product;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d89a09c9030479b5a7b84c997d19d6363491d8fd", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f97253c7a05516ebbcf8a7985add7f0884582eb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GetProductDto>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\TokioMarine\TokioMarine\TokioMarine\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n");
#nullable restore
#line 8 "D:\TokioMarine\TokioMarine\TokioMarine\Views\Product\Index.cshtml"
Write(Html.ActionLink("Create New Product","Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1></h1>

  <table class=""table"">
  <thead>
    <tr>
      <th scope=""col"">#</th>
      <th scope=""col"">Name</th>
      <th scope=""col"">Description</th>
      <th scope=""col"">Price</th>
      <th scope=""col"">Count</th>
    </tr>
  </thead>
  <tbody>
");
#nullable restore
#line 22 "D:\TokioMarine\TokioMarine\TokioMarine\Views\Product\Index.cshtml"
         foreach (var item in @Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n             <th scope=\"row\">");
#nullable restore
#line 25 "D:\TokioMarine\TokioMarine\TokioMarine\Views\Product\Index.cshtml"
                        Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n             <td>");
#nullable restore
#line 26 "D:\TokioMarine\TokioMarine\TokioMarine\Views\Product\Index.cshtml"
            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n             <td>");
#nullable restore
#line 27 "D:\TokioMarine\TokioMarine\TokioMarine\Views\Product\Index.cshtml"
            Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n             <td>");
#nullable restore
#line 28 "D:\TokioMarine\TokioMarine\TokioMarine\Views\Product\Index.cshtml"
            Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n             <td>");
#nullable restore
#line 29 "D:\TokioMarine\TokioMarine\TokioMarine\Views\Product\Index.cshtml"
            Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n");
            WriteLiteral("          \r\n            <a");
            BeginWriteAttribute("href", " href=\"", 840, "\"", 873, 2);
            WriteAttributeValue("", 847, "Product/AddToBill/", 847, 18, true);
#nullable restore
#line 33 "D:\TokioMarine\TokioMarine\TokioMarine\Views\Product\Index.cshtml"
WriteAttributeValue("", 865, item.Id, 865, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Add</a>\r\n            </tr>\r\n");
#nullable restore
#line 35 "D:\TokioMarine\TokioMarine\TokioMarine\Views\Product\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GetProductDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
