#pragma checksum "C:\dotnet2\HandsOn\OnlineShopping\TransflowerStoreWeb\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1c8297a481aacae1dfdfb95ceea019a4bf6e7ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Details), @"mvc.1.0.view", @"/Views/Products/Details.cshtml")]
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
#line 1 "C:\dotnet2\HandsOn\OnlineShopping\TransflowerStoreWeb\Views\Products\Details.cshtml"
using Catalog;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1c8297a481aacae1dfdfb95ceea019a4bf6e7ee", @"/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3a98b6fc9fbcaa36df3430de3d3a60654378b73", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\dotnet2\HandsOn\OnlineShopping\TransflowerStoreWeb\Views\Products\Details.cshtml"
  
    ViewBag.Title = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Product Details</h2>\r\n");
#nullable restore
#line 8 "C:\dotnet2\HandsOn\OnlineShopping\TransflowerStoreWeb\Views\Products\Details.cshtml"
  

    Product theProduct=ViewData["products"] as Product;

#line default
#line hidden
#nullable disable
            WriteLiteral("<table style=\"font-family:Arial\">\r\n    <tr>\r\n        <td><b>Product :</b></td>\r\n        <td>");
#nullable restore
#line 15 "C:\dotnet2\HandsOn\OnlineShopping\TransflowerStoreWeb\Views\Products\Details.cshtml"
       Write(theProduct.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n     <tr>\r\n        <td><b>Image :</b></td>\r\n        <td>  <img");
            BeginWriteAttribute("src", " src=\"", 341, "\"", 367, 1);
#nullable restore
#line 19 "C:\dotnet2\HandsOn\OnlineShopping\TransflowerStoreWeb\Views\Products\Details.cshtml"
WriteAttributeValue("", 347, theProduct.ImageUrl, 347, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"200\" height=\"200\"/></td>\r\n    </tr>\r\n    <tr>\r\n        <td><b>Description :</b></td>\r\n        <td>");
#nullable restore
#line 23 "C:\dotnet2\HandsOn\OnlineShopping\TransflowerStoreWeb\Views\Products\Details.cshtml"
       Write(theProduct.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td><b>Quantity :</b></td>\r\n        <td>");
#nullable restore
#line 27 "C:\dotnet2\HandsOn\OnlineShopping\TransflowerStoreWeb\Views\Products\Details.cshtml"
       Write(theProduct.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n        <td><b>Unit Price :</b></td>\r\n        <td>");
#nullable restore
#line 31 "C:\dotnet2\HandsOn\OnlineShopping\TransflowerStoreWeb\Views\Products\Details.cshtml"
       Write(theProduct.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td>\r\n            ");
#nullable restore
#line 36 "C:\dotnet2\HandsOn\OnlineShopping\TransflowerStoreWeb\Views\Products\Details.cshtml"
       Write(Html.ActionLink("Update", "Update", "Products", new { id = theProduct.Id }, ""));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n         <td>\r\n            ");
#nullable restore
#line 39 "C:\dotnet2\HandsOn\OnlineShopping\TransflowerStoreWeb\Views\Products\Details.cshtml"
       Write(Html.ActionLink("Delete", "Delete", "Products", new { id = theProduct.Id }, ""));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n          <td>\r\n            ");
#nullable restore
#line 42 "C:\dotnet2\HandsOn\OnlineShopping\TransflowerStoreWeb\Views\Products\Details.cshtml"
       Write(Html.ActionLink("Add to cart", "AddToCart", "ShoppingCart", new { id = theProduct.Id }, ""));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591