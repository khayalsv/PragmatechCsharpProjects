#pragma checksum "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\ServicesBox\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ac45dccbee84c126777ee8a21a095c100d21b50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ServicesBox_List), @"mvc.1.0.view", @"/Areas/Admin/Views/ServicesBox/List.cshtml")]
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
#line 1 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\_ViewImports.cshtml"
using NoTech;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\_ViewImports.cshtml"
using NoTech.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\_ViewImports.cshtml"
using NoTech.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ac45dccbee84c126777ee8a21a095c100d21b50", @"/Areas/Admin/Views/ServicesBox/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb19270f775237d817e8fe39c4b1c6ac3015960f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ServicesBox_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<ServicesBox>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\ServicesBox\List.cshtml"
 if (TempData["Success"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-primary\" role=\"alert\">\r\n        ");
#nullable restore
#line 6 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\ServicesBox\List.cshtml"
   Write(TempData["Success"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 8 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\ServicesBox\List.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
    <a href=""/Admin/ServicesBox/Create"" class=""btn btn-success"">Add</a>
</div>

<div class=""table-responsive scrollbar"">
    <table class=""table table-hover"">
        <thead>
            <tr>
                <th scope=""col"">ID</th>
                <th scope=""col"">Title 1</th>
                <th scope=""col"">Title 2</th>
                <th scope=""col"">Text 1</th>
                <th scope=""col"">Text 2</th>
                <th scope=""col"">Icon</th>

                <th class=""text-end"" scope=""col"">Actions</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 29 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\ServicesBox\List.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\ServicesBox\List.cshtml"
               Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\ServicesBox\List.cshtml"
               Write(item.Title1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\ServicesBox\List.cshtml"
               Write(item.Title2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\ServicesBox\List.cshtml"
               Write(item.Text1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\ServicesBox\List.cshtml"
               Write(item.Text2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\ServicesBox\List.cshtml"
               Write(item.Icon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td class=\"text-end\">\r\n                    <div>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1152, "\"", 1191, 2);
            WriteAttributeValue("", 1159, "/Admin/ServicesBox/Edit/", 1159, 24, true);
#nullable restore
#line 41 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\ServicesBox\List.cshtml"
WriteAttributeValue("", 1183, item.ID, 1183, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-edit\"></i></a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1252, "\"", 1293, 2);
            WriteAttributeValue("", 1259, "/Admin/ServicesBox/Delete/", 1259, 26, true);
#nullable restore
#line 42 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\ServicesBox\List.cshtml"
WriteAttributeValue("", 1285, item.ID, 1285, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Are you delete?\')\"><i class=\"fas fa-trash-alt\"></i></a>\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 46 "C:\Users\selim\Desktop\Csharp\AspNet\NoTech\Areas\Admin\Views\ServicesBox\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<ServicesBox>> Html { get; private set; }
    }
}
#pragma warning restore 1591