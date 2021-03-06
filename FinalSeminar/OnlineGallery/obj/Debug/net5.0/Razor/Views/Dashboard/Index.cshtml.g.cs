#pragma checksum "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72913ef96cce073b08cbe67c899c26b3d773a18e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
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
#nullable restore
#line 1 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\Dashboard\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\Dashboard\Index.cshtml"
using OnlineGallery.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\Dashboard\Index.cshtml"
using OnlineGallery.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72913ef96cce073b08cbe67c899c26b3d773a18e", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0d07fbc517cad37bf602b0d43b0b3b78e3b67e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/dashboard/01.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("dashboard"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/dashboard/02.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/dashboard/03.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 8 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Dashboard";
    ViewData["Dashboard"] = "active";
    Layout = "~/Views/Shared/_DashboardLayout.cshtml";

    var userId = userManager.GetUserId(User);

    // Count favorite products
    int favorites = context.MyFavorites.Where(e => e.UserId.Equals(userId)).Count();

    var records = context.AuctionRecords.Where(e => e.UserId.Equals(userId)).ToList();
    // Count the auction participated
    int actives = records.Select(e => e.AuctionId).Distinct().Count();

    // Count winning bid
    int winningBids = context.Transactions.Where(e => e.UserId.Equals(userId) && e.Auctioned).Count();

    // Cart
    var cart = context.Carts.Where(e => e.UserId.Equals(userId)).Select(e => e.Product).ToList();

    var transactionIds = context.Transactions.Where(e => e.UserId.Equals(userId)).Select(e => e.Id).ToList();
    // Pending Transaction
    var pending = context.TransactionDetails.Where(e => transactionIds.Contains(e.TransactionId) && !e.Transaction.Status).ToList();

    // Completed Transaction
    var completed = context.TransactionDetails.Where(e => transactionIds.Contains(e.TransactionId) && e.Transaction.Status).ToList();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""dashboard-widget mb-40"">
    <div class=""dashboard-title mb-30"">
        <h5 class=""title"">My Activity</h5>
    </div>
    <div class=""row justify-content-center mb-30-none"">
        <div class=""col-md-4 col-sm-6"">
            <div class=""dashboard-item"">
                <div class=""thumb"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "72913ef96cce073b08cbe67c899c26b3d773a18e6972", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"content\">\r\n                    <h2 class=\"title\"><span class=\"counter\">");
#nullable restore
#line 47 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\Dashboard\Index.cshtml"
                                                       Write(actives);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></h2>
                    <h6 class=""info"">Active Bids</h6>
                </div>
            </div>
        </div>
        <div class=""col-md-4 col-sm-6"">
            <div class=""dashboard-item"">
                <div class=""thumb"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "72913ef96cce073b08cbe67c899c26b3d773a18e8768", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"content\">\r\n                    <h2 class=\"title\"><span class=\"counter\">");
#nullable restore
#line 58 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\Dashboard\Index.cshtml"
                                                       Write(winningBids);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></h2>
                    <h6 class=""info"">Items Won</h6>
                </div>
            </div>
        </div>
        <div class=""col-md-4 col-sm-6"">
            <div class=""dashboard-item"">
                <div class=""thumb"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "72913ef96cce073b08cbe67c899c26b3d773a18e10566", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"content\">\r\n                    <h2 class=\"title\"><span class=\"counter\">");
#nullable restore
#line 69 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\Dashboard\Index.cshtml"
                                                       Write(favorites);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></h2>
                    <h6 class=""info"">Favorites</h6>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""dashboard-widget"">
    <h5 class=""title mb-10"">Current Record</h5>
    <div class=""dashboard-purchasing-tabs"">
        <ul class=""nav-tabs nav"">
            <li>
                <a href=""#cart"" class=""active"" data-toggle=""tab"">Cart</a>
            </li>
            <li>
                <a href=""#pending-transaction"" data-toggle=""tab"">Pending Transaction</a>
            </li>
            <li>
                <a href=""#completed-transaction"" data-toggle=""tab"">Completed Transaction</a>
            </li>
        </ul>
        <div class=""tab-content"">
            <div class=""tab-pane show active fade"" id=""cart"">
                <table class=""purchasing-table table-bordered"">
                    <thead>
                        <tr>
                            <th class=""align-middle text-center"">Id</th>
                            <th cla");
            WriteLiteral(@"ss=""align-middle text-center"">Name</th>
                            <th class=""align-middle text-center"">Price</th>
                            <th class=""align-middle text-center"">Status</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 102 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\Dashboard\Index.cshtml"
                         if (cart.Count() > 0)
                        {
                            foreach (var item in cart)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td class=\"align-middle text-center\">");
#nullable restore
#line 107 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\Dashboard\Index.cshtml"
                                                                    Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"pl-1\" style=\"width: 300px;\">");
#nullable restore
#line 108 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\Dashboard\Index.cshtml"
                                                                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"align-middle text-center\">");
#nullable restore
#line 109 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\Dashboard\Index.cshtml"
                                                                    Write(item.DefaultPrice.Value.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 110 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\Dashboard\Index.cshtml"
                                     if (item.Status)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td class=\"align-middle text-center text-success font-weight-bolder\"><span>On sale</span></td>\r\n");
#nullable restore
#line 113 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\Dashboard\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td class=\"align-middle text-center text-danger font-weight-bolder\">Sold</td>\r\n");
#nullable restore
#line 117 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\Dashboard\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tr>\r\n");
#nullable restore
#line 119 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\Dashboard\Index.cshtml"
                            }
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td colspan=\"4\" class=\"align-middle text-center\">No data available in table</td>\r\n                            </tr>\r\n");
#nullable restore
#line 126 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\Dashboard\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
            <div class=""tab-pane show fade"" id=""pending-transaction"">
                <table class=""purchasing-table table-bordered"">
                    <thead>
                        <tr>
                            <th class=""align-middle text-center"">Id</th>
                            <th class=""align-middle text-center"">Product</th>
                            <th class=""align-middle text-center"">Price</th>
                            <th class=""align-middle text-center"">Created</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 141 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\Dashboard\Index.cshtml"
                         if (pending.Count() > 0)
                        {
                            foreach (var item in pending)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td class=\"align-middle text-center\">");
#nullable restore
#line 146 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\Dashboard\Index.cshtml"
                                                                    Write(item.TransactionId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"pl-1\" style=\"width: 300px;\">");
#nullable restore
#line 147 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\Dashboard\Index.cshtml"
                                                                      Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"align-middle text-center\">");
#nullable restore
#line 148 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\Dashboard\Index.cshtml"
                                                                    Write(item.Price.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"align-middle text-center\">");
#nullable restore
#line 149 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\Dashboard\Index.cshtml"
                                                                    Write(item.Transaction.CreateDate.Value.ToString("dd/MM/yyyy HH:mm:ss"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 151 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\Dashboard\Index.cshtml"
                            }
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td colspan=\"4\" class=\"align-middle text-center\">No data available in table</td>\r\n                            </tr>\r\n");
#nullable restore
#line 158 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\Dashboard\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
            <div class=""tab-pane show fade"" id=""completed-transaction"">
                <table class=""purchasing-table table-bordered"">
                    <thead>
                        <tr>
                            <th class=""align-middle text-center"">Id</th>
                            <th class=""align-middle text-center"">Product</th>
                            <th class=""align-middle text-center"">Price</th>
                            <th class=""align-middle text-center"">Date</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 173 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\Dashboard\Index.cshtml"
                         if (completed.Count() > 0)
                        {
                            foreach (var item in completed)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td class=\"align-middle text-center\">");
#nullable restore
#line 178 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\Dashboard\Index.cshtml"
                                                                    Write(item.TransactionId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"pl-1\" style=\"width: 300px;\">");
#nullable restore
#line 179 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\Dashboard\Index.cshtml"
                                                                      Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"align-middle text-center\">");
#nullable restore
#line 180 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\Dashboard\Index.cshtml"
                                                                    Write(item.Price.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td class=\"align-middle text-center\">");
#nullable restore
#line 181 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\Dashboard\Index.cshtml"
                                                                    Write(item.Transaction.CompletionDate.Value.ToString("dd/MM/yyyy HH:mm:ss"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 183 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\Dashboard\Index.cshtml"
                            }
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td colspan=\"4\" class=\"align-middle text-center\">No data available in table</td>\r\n                            </tr>\r\n");
#nullable restore
#line 190 "F:\NLU\.NET\Project-DotNet-NLU\FinalSeminar\OnlineGallery\Views\Dashboard\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ApplicationDbContext context { get; private set; }
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
