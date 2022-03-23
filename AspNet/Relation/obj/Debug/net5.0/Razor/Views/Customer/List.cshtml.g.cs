#pragma checksum "C:\Users\selim\Desktop\Csharp\AspNet\Relation\Views\Customer\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "639f11befffe9d3e233ecf2c67fd10489772b666"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_List), @"mvc.1.0.view", @"/Views/Customer/List.cshtml")]
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
#line 1 "C:\Users\selim\Desktop\Csharp\AspNet\Relation\Views\_ViewImports.cshtml"
using Relation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\selim\Desktop\Csharp\AspNet\Relation\Views\_ViewImports.cshtml"
using Relation.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\selim\Desktop\Csharp\AspNet\Relation\Views\_ViewImports.cshtml"
using Relation.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"639f11befffe9d3e233ecf2c67fd10489772b666", @"/Views/Customer/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1571080b43daddcba51fa24a124b8617c4044413", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <div>
        <a href=""/Customer/Create"" style=""width:100%"" class=""btn btn-success"">Add</a>
    </div>
    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th>ID</th>
                <th>CustomerName</th>
                <th>ProductName</th>
                <th>CRUD</th>

            </tr>
        </thead>
        <tbody>

");
#nullable restore
#line 18 "C:\Users\selim\Desktop\Csharp\AspNet\Relation\Views\Customer\List.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <th scope=\"row\">");
#nullable restore
#line 21 "C:\Users\selim\Desktop\Csharp\AspNet\Relation\Views\Customer\List.cshtml"
                               Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                    <th scope=\"row\">");
#nullable restore
#line 22 "C:\Users\selim\Desktop\Csharp\AspNet\Relation\Views\Customer\List.cshtml"
                               Write(item.Customers.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                    <td>");
#nullable restore
#line 23 "C:\Users\selim\Desktop\Csharp\AspNet\Relation\Views\Customer\List.cshtml"
                   Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td>\n                        <a");
            BeginWriteAttribute("href", " href=\"", 684, "\"", 714, 2);
            WriteAttributeValue("", 691, "/Customer/Edit/", 691, 15, true);
#nullable restore
#line 25 "C:\Users\selim\Desktop\Csharp\AspNet\Relation\Views\Customer\List.cshtml"
WriteAttributeValue("", 706, item.ID, 706, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:green\"><i class=\"fas fa-edit\"></i></a>\n                        <a");
            BeginWriteAttribute("href", " href=\"", 794, "\"", 826, 2);
            WriteAttributeValue("", 801, "/Customer/Delete/", 801, 17, true);
#nullable restore
#line 26 "C:\Users\selim\Desktop\Csharp\AspNet\Relation\Views\Customer\List.cshtml"
WriteAttributeValue("", 818, item.ID, 818, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Are you delete?\')\" style=\"color:red\"><i class=\"fas fa-trash-alt\"></i></a>\n                        <a");
            BeginWriteAttribute("href", " href=\"", 953, "\"", 986, 2);
            WriteAttributeValue("", 960, "/Customer/Details/", 960, 18, true);
#nullable restore
#line 27 "C:\Users\selim\Desktop\Csharp\AspNet\Relation\Views\Customer\List.cshtml"
WriteAttributeValue("", 978, item.ID, 978, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:steelblue\">About</a>\n                    </td>\n                </tr>\n");
#nullable restore
#line 30 "C:\Users\selim\Desktop\Csharp\AspNet\Relation\Views\Customer\List.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
