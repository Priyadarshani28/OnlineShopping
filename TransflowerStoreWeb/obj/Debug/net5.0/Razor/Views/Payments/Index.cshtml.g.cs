#pragma checksum "C:\dotnet2\HandsOn\OnlineShopping\TransflowerStoreWeb\Views\Payments\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "712c1647f74636970a126bc5c949fe1b06485d9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payments_Index), @"mvc.1.0.view", @"/Views/Payments/Index.cshtml")]
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
#line 1 "C:\dotnet2\HandsOn\OnlineShopping\TransflowerStoreWeb\Views\Payments\Index.cshtml"
using PaymentProcessing;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"712c1647f74636970a126bc5c949fe1b06485d9b", @"/Views/Payments/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3a98b6fc9fbcaa36df3430de3d3a60654378b73", @"/Views/_ViewImports.cshtml")]
    public class Views_Payments_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\dotnet2\HandsOn\OnlineShopping\TransflowerStoreWeb\Views\Payments\Index.cshtml"
  
    ViewData["Title"] = "Payment Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Payments</h1>\r\n</div>\r\n\r\n<h1>Payment List</h1>\r\n<hr/>\r\n\r\n<div>\r\n");
#nullable restore
#line 14 "C:\dotnet2\HandsOn\OnlineShopping\TransflowerStoreWeb\Views\Payments\Index.cshtml"
     foreach (Payment  paymt in ViewData["payments"] as List<Payment>)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("       <p>  Payment  :");
#nullable restore
#line 16 "C:\dotnet2\HandsOn\OnlineShopping\TransflowerStoreWeb\Views\Payments\Index.cshtml"
                 Write(paymt.PaymentID);

#line default
#line hidden
#nullable disable
            WriteLiteral("   <a href=\"/payments/details/122\">Details</a></p>  \r\n");
#nullable restore
#line 17 "C:\dotnet2\HandsOn\OnlineShopping\TransflowerStoreWeb\Views\Payments\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
