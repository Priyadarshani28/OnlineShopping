#pragma checksum "C:\dotnet2\HandsOn\OnlineShopping\SimpleWebApp\Pages\aboutus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e7cff361749a193c190583ab2d387bdd7357753"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SimpleWebApp.Pages.Pages_aboutus), @"mvc.1.0.razor-page", @"/Pages/aboutus.cshtml")]
namespace SimpleWebApp.Pages
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
#line 1 "C:\dotnet2\HandsOn\OnlineShopping\SimpleWebApp\Pages\_ViewImports.cshtml"
using SimpleWebApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e7cff361749a193c190583ab2d387bdd7357753", @"/Pages/aboutus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4ddefde458abf5d7ae10116bc30cef16e8f2733", @"/Pages/_ViewImports.cshtml")]
    public class Pages_aboutus : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\dotnet2\HandsOn\OnlineShopping\SimpleWebApp\Pages\aboutus.cshtml"
  
    ViewData["Title"] = "About Us Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">About Us</h1>\r\n    <hr/>\r\n    <h2>Transflower Learning Pvt. Ltd.</h2>\r\n    <p>Doing Ordinary Things Extra Ordinarily.....</p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<aboutusModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<aboutusModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<aboutusModel>)PageContext?.ViewData;
        public aboutusModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
