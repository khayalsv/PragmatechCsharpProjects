#pragma checksum "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Areas\Admin\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9521e6f6191ec7b5e534abcfe9b55a4d3700bcfa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Index.cshtml")]
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
#line 1 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9521e6f6191ec7b5e534abcfe9b55a4d3700bcfa", @"/Areas/Admin/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b881055197282d0a2ab51004156381e82f1e1fbc", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<EntityLayer.Concrete.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Kateqoriya</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Kateqoriya adi</th>\r\n        <th>Passif et</th>\r\n        <th>Aktif et</th>\r\n        <th>Edit</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 22 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <th>");
#nullable restore
#line 25 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n    <td>");
#nullable restore
#line 26 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 519, "\"", 566, 3);
            WriteAttributeValue("", 526, "/Admin/Category/DeleteCategory/", 526, 31, true);
#nullable restore
#line 27 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 557, item.Id, 557, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 565, "/", 565, 1, true);
            EndWriteAttribute();
            WriteLiteral(" id=\"deleteBtn\" onclick=\"return confirm(\'Silmek istiyirsinizmi?\');\" class=\"btn btn-info\">Passif et</a></td>\r\n\r\n    <td><a href=\"#\" class=\"btn btn-warning\">Aktif et</a></td> \r\n    <td><a href=\"#\" class=\"btn btn-success\">Edit</a></td>\r\n</tr>\r\n");
#nullable restore
#line 32 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<a href=\"/Admin/Category/AddCategory/\" vlass=\"btn btn-primary\">Yeni kateqoriya</a>\r\n\r\n<br />\r\n<br />\r\n\r\n");
#nullable restore
#line 40 "C:\Users\selim\Desktop\Csharp\AspNet\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model,page=>Url.Action("index",new { page })));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<EntityLayer.Concrete.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591