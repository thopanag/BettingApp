#pragma checksum "C:\Users\Thomas\Dropbox\CEID\Διπλωματική\BettingApp\WebApps\WebRazorPages\WebRazorPages\Pages\Shared\_MatchPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6cb1709db903adf3154a03f0ab8d3f5db867505"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BettingApp.WebApps.WebRazorPages.Pages.Shared.Pages_Shared__MatchPartial), @"mvc.1.0.view", @"/Pages/Shared/_MatchPartial.cshtml")]
namespace BettingApp.WebApps.WebRazorPages.Pages.Shared
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
#line 3 "C:\Users\Thomas\Dropbox\CEID\Διπλωματική\BettingApp\WebApps\WebRazorPages\WebRazorPages\Pages\_ViewImports.cshtml"
using BettingApp.WebApps.WebRazorPages.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6cb1709db903adf3154a03f0ab8d3f5db867505", @"/Pages/Shared/_MatchPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d09d2985af4fd647a03c83a8b7bd76aae2be1195", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__MatchPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Match>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PossiblePickPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Thomas\Dropbox\CEID\Διπλωματική\BettingApp\WebApps\WebRazorPages\WebRazorPages\Pages\Shared\_MatchPartial.cshtml"
   
    bool displayTicker = !Model.CurrentMinute.Equals("0") && 
                         !Model.CurrentMinute.Equals("HT") && 
                         !Model.CurrentMinute.Equals("FT") &&
                         !Model.IsCanceled; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<td>\r\n    <div class=\"match-id\">");
#nullable restore
#line 9 "C:\Users\Thomas\Dropbox\CEID\Διπλωματική\BettingApp\WebApps\WebRazorPages\WebRazorPages\Pages\Shared\_MatchPartial.cshtml"
                     Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n</td>\r\n<td>\r\n    <div class=\"match\">\r\n        <div class=\"match-club\">\r\n            <div class=\"match-club-name\">");
#nullable restore
#line 14 "C:\Users\Thomas\Dropbox\CEID\Διπλωματική\BettingApp\WebApps\WebRazorPages\WebRazorPages\Pages\Shared\_MatchPartial.cshtml"
                                    Write(Model.HomeClubName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"match-club-score\"");
            BeginWriteAttribute("id", " id=\"", 488, "\"", 522, 3);
            WriteAttributeValue("", 493, "Match#", 493, 6, true);
#nullable restore
#line 15 "C:\Users\Thomas\Dropbox\CEID\Διπλωματική\BettingApp\WebApps\WebRazorPages\WebRazorPages\Pages\Shared\_MatchPartial.cshtml"
WriteAttributeValue("", 499, Model.Id, 499, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 508, "#HomeClubScore", 508, 14, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
#nullable restore
#line 16 "C:\Users\Thomas\Dropbox\CEID\Διπλωματική\BettingApp\WebApps\WebRazorPages\WebRazorPages\Pages\Shared\_MatchPartial.cshtml"
            Write(Model.CurrentMinute.Equals("0") || Model.IsCanceled ? "-" : Model.HomeClubScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <br />\r\n        <div class=\"match-club\">\r\n            <div class=\"match-club-name\">");
#nullable restore
#line 21 "C:\Users\Thomas\Dropbox\CEID\Διπλωματική\BettingApp\WebApps\WebRazorPages\WebRazorPages\Pages\Shared\_MatchPartial.cshtml"
                                    Write(Model.AwayClubName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"match-club-score\"");
            BeginWriteAttribute("id", " id=\"", 821, "\"", 855, 3);
            WriteAttributeValue("", 826, "Match#", 826, 6, true);
#nullable restore
#line 22 "C:\Users\Thomas\Dropbox\CEID\Διπλωματική\BettingApp\WebApps\WebRazorPages\WebRazorPages\Pages\Shared\_MatchPartial.cshtml"
WriteAttributeValue("", 832, Model.Id, 832, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 841, "#AwayClubScore", 841, 14, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
#nullable restore
#line 23 "C:\Users\Thomas\Dropbox\CEID\Διπλωματική\BettingApp\WebApps\WebRazorPages\WebRazorPages\Pages\Shared\_MatchPartial.cshtml"
            Write(Model.CurrentMinute.Equals("0") || Model.IsCanceled ? "-" : Model.AwayClubScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <br />\r\n        <div class=\"match-current-minute\">\r\n            <div");
            BeginWriteAttribute("id", " id=\"", 1071, "\"", 1105, 3);
            WriteAttributeValue("", 1076, "Match#", 1076, 6, true);
#nullable restore
#line 28 "C:\Users\Thomas\Dropbox\CEID\Διπλωματική\BettingApp\WebApps\WebRazorPages\WebRazorPages\Pages\Shared\_MatchPartial.cshtml"
WriteAttributeValue("", 1082, Model.Id, 1082, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1091, "#CurrentMinute", 1091, 14, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 29 "C:\Users\Thomas\Dropbox\CEID\Διπλωματική\BettingApp\WebApps\WebRazorPages\WebRazorPages\Pages\Shared\_MatchPartial.cshtml"
                 if (!Model.IsCanceled)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Thomas\Dropbox\CEID\Διπλωματική\BettingApp\WebApps\WebRazorPages\WebRazorPages\Pages\Shared\_MatchPartial.cshtml"
                Write(Model.CurrentMinute.Equals("0") ? Model.KickoffDateTime.ToString("HH:mm") : Model.CurrentMinute);

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Thomas\Dropbox\CEID\Διπλωματική\BettingApp\WebApps\WebRazorPages\WebRazorPages\Pages\Shared\_MatchPartial.cshtml"
                                                                                                                      
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\Thomas\Dropbox\CEID\Διπλωματική\BettingApp\WebApps\WebRazorPages\WebRazorPages\Pages\Shared\_MatchPartial.cshtml"
                Write("Canceled");

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\Thomas\Dropbox\CEID\Διπλωματική\BettingApp\WebApps\WebRazorPages\WebRazorPages\Pages\Shared\_MatchPartial.cshtml"
                                 
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"current-minute-ticker\"");
            BeginWriteAttribute("id", " id=\"", 1469, "\"", 1496, 3);
            WriteAttributeValue("", 1474, "Match#", 1474, 6, true);
#nullable restore
#line 38 "C:\Users\Thomas\Dropbox\CEID\Διπλωματική\BettingApp\WebApps\WebRazorPages\WebRazorPages\Pages\Shared\_MatchPartial.cshtml"
WriteAttributeValue("", 1480, Model.Id, 1480, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1489, "#Ticker", 1489, 7, true);
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 38 "C:\Users\Thomas\Dropbox\CEID\Διπλωματική\BettingApp\WebApps\WebRazorPages\WebRazorPages\Pages\Shared\_MatchPartial.cshtml"
                                                                       Write(displayTicker ? "" : "hidden");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\'</div>\r\n        </div>\r\n    </div>\r\n</td>\r\n");
#nullable restore
#line 42 "C:\Users\Thomas\Dropbox\CEID\Διπλωματική\BettingApp\WebApps\WebRazorPages\WebRazorPages\Pages\Shared\_MatchPartial.cshtml"
 foreach (var pp in Model.PossiblePicks.OrderBy(pp => pp.MatchResultId))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <td>\r\n");
#nullable restore
#line 45 "C:\Users\Thomas\Dropbox\CEID\Διπλωματική\BettingApp\WebApps\WebRazorPages\WebRazorPages\Pages\Shared\_MatchPartial.cshtml"
           ViewData["matchCompletedOrCanceled"] = Model.IsCanceled || Model.CurrentMinute.Equals("FT"); 

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f6cb1709db903adf3154a03f0ab8d3f5db86750510806", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 46 "C:\Users\Thomas\Dropbox\CEID\Διπλωματική\BettingApp\WebApps\WebRazorPages\WebRazorPages\Pages\Shared\_MatchPartial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = pp;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </td>\r\n");
#nullable restore
#line 48 "C:\Users\Thomas\Dropbox\CEID\Διπλωματική\BettingApp\WebApps\WebRazorPages\WebRazorPages\Pages\Shared\_MatchPartial.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Match> Html { get; private set; }
    }
}
#pragma warning restore 1591