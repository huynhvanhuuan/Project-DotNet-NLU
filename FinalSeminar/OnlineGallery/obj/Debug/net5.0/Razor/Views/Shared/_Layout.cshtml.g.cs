#pragma checksum "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b17a18574bf375d7f46d6a49756856f160192c23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b17a18574bf375d7f46d6a49756856f160192c23", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0d07fbc517cad37bf602b0d43b0b3b78e3b67e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
#nullable restore
#line 3 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("~/Views/PartialView/Head.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b17a18574bf375d7f46d6a49756856f160192c233401", async() => {
                WriteLiteral("\r\n    <!--============= ScrollToTop Section Starts Here =============-->\r\n    ");
#nullable restore
#line 6 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("~/Views/PartialView/ScrollToTop.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <!--============= ScrollToTop Section Ends Here =============-->\r\n    <!--============= Header Section Starts Here =============-->\r\n    ");
#nullable restore
#line 9 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("~/Views/PartialView/Header.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <!--============= Header Section Ends Here =============-->\r\n    ");
#nullable restore
#line 11 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <div class=""modal"" tabindex=""-1"" id=""form-modal"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title""></h5>
                    <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
                </div>
                <div class=""modal-body"">
                </div>
            </div>
        </div>
    </div>
    <!--============= Footer Section Starts Here =============-->
    ");
#nullable restore
#line 25 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("~/Views/PartialView/Footer.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <!--============= Footer Section Ends Here =============-->\r\n    <!--============= Scripts Section Starts Here =============-->\r\n    ");
#nullable restore
#line 28 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("~/Views/PartialView/Scripts.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 29 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\Shared\_Layout.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <!--============= Scripts Section Ends Here =============-->\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
