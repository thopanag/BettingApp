#pragma checksum "C:\Users\Thomas\Dropbox\CEID\Διπλωματική\BettingApp\Services\IdentityServer\Identity.API\Pages\Shared\_FooterBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "582843659ac278170ea3e6261b5fd29e5124b6f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BettingApp.Services.Identity.Pages.Shared.Pages_Shared__FooterBar), @"mvc.1.0.view", @"/Pages/Shared/_FooterBar.cshtml")]
namespace BettingApp.Services.Identity.Pages.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"582843659ac278170ea3e6261b5fd29e5124b6f5", @"/Pages/Shared/_FooterBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b67ebcc1947bf6bded4bd7d0c15e201dd8fd21d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__FooterBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h6><small>Betting App - Copyright ");
#nullable restore
#line 1 "C:\Users\Thomas\Dropbox\CEID\Διπλωματική\BettingApp\Services\IdentityServer\Identity.API\Pages\Shared\_FooterBar.cshtml"
                              Write(DateTime.UtcNow.AddHours(2).Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></h6>");
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
