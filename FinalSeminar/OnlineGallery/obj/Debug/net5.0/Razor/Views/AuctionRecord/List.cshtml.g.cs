#pragma checksum "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\AuctionRecord\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b03dec26ef07456de6e04a8e2dccbed1466c64d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AuctionRecord_List), @"mvc.1.0.view", @"/Views/AuctionRecord/List.cshtml")]
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
#line 1 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\_ViewImports.cshtml"
using OnlineGallery;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\_ViewImports.cshtml"
using OnlineGallery.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b03dec26ef07456de6e04a8e2dccbed1466c64d3", @"/Views/AuctionRecord/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0d07fbc517cad37bf602b0d43b0b3b78e3b67e0", @"/Views/_ViewImports.cshtml")]
    public class Views_AuctionRecord_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlineGallery.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\AuctionRecord\List.cshtml"
  
    ViewData["Title"] = "Product";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center\"><i class=\"fas fa-user\"></i>&ensp;Product</h1>\r\n\r\n<div id=\"view-all\">\r\n    ");
#nullable restore
#line 11 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\AuctionRecord\List.cshtml"
Write(await Html.PartialAsync("_ViewAll", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnlineGallery.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591