#pragma checksum "C:\dotnet2\HandsOn\OnlineShopping\TransflowerStoreWeb\Views\Products\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32a714b79424087dae882a2ade2e54426082c068"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Update), @"mvc.1.0.view", @"/Views/Products/Update.cshtml")]
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
#line 1 "C:\dotnet2\HandsOn\OnlineShopping\TransflowerStoreWeb\Views\_ViewImports.cshtml"
using TransflowerStoreWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\dotnet2\HandsOn\OnlineShopping\TransflowerStoreWeb\Views\_ViewImports.cshtml"
using TransflowerStoreWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\dotnet2\HandsOn\OnlineShopping\TransflowerStoreWeb\Views\Products\Update.cshtml"
using Catalog;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32a714b79424087dae882a2ade2e54426082c068", @"/Views/Products/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3a98b6fc9fbcaa36df3430de3d3a60654378b73", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\dotnet2\HandsOn\OnlineShopping\TransflowerStoreWeb\Views\Products\Update.cshtml"
  
    ViewBag.Title="Update";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Update Existing Product</h2>\r\n\r\n\r\n");
#nullable restore
#line 11 "C:\dotnet2\HandsOn\OnlineShopping\TransflowerStoreWeb\Views\Products\Update.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table>\r\n        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 16 "C:\dotnet2\HandsOn\OnlineShopping\TransflowerStoreWeb\Views\Products\Update.cshtml"
           Write(Html.LabelFor(model => model.Id, new { htmlattributes = new { @class = "label label-info" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 19 "C:\dotnet2\HandsOn\OnlineShopping\TransflowerStoreWeb\Views\Products\Update.cshtml"
           Write(Html.EditorFor(model => model.Id, new { htmlattributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 24 "C:\dotnet2\HandsOn\OnlineShopping\TransflowerStoreWeb\Views\Products\Update.cshtml"
           Write(Html.LabelFor(model => model.Title, new { htmlattributes = new { @class = "label label-info" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 27 "C:\dotnet2\HandsOn\OnlineShopping\TransflowerStoreWeb\Views\Products\Update.cshtml"
           Write(Html.EditorFor(model => model.Title, new { htmlattributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n         <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 32 "C:\dotnet2\HandsOn\OnlineShopping\TransflowerStoreWeb\Views\Products\Update.cshtml"
           Write(Html.LabelFor(model => model.ImageUrl, new { htmlattributes = new { @class = "label label-info" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "C:\dotnet2\HandsOn\OnlineShopping\TransflowerStoreWeb\Views\Products\Update.cshtml"
           Write(Html.EditorFor(model => model.ImageUrl, new { htmlattributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "C:\dotnet2\HandsOn\OnlineShopping\TransflowerStoreWeb\Views\Products\Update.cshtml"
           Write(Html.LabelFor(model => model.UnitPrice, new { htmlattributes = new { @class = "label label-info" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\dotnet2\HandsOn\OnlineShopping\TransflowerStoreWeb\Views\Products\Update.cshtml"
           Write(Html.EditorFor(model => model.UnitPrice, new { htmlattributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n         <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\dotnet2\HandsOn\OnlineShopping\TransflowerStoreWeb\Views\Products\Update.cshtml"
           Write(Html.LabelFor(model => model.Quantity, new { htmlattributes = new { @class = "label label-info" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\dotnet2\HandsOn\OnlineShopping\TransflowerStoreWeb\Views\Products\Update.cshtml"
           Write(Html.EditorFor(model => model.Quantity, new { htmlattributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n        </tr>\r\n        <tr>\r\n            <td><input type=\"submit\" name=\"UpdateProduct\" value=\"UpdateProduct\" /></td>\r\n        </tr>\r\n    </table>\r\n");
#nullable restore
#line 61 "C:\dotnet2\HandsOn\OnlineShopping\TransflowerStoreWeb\Views\Products\Update.cshtml"
}

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
