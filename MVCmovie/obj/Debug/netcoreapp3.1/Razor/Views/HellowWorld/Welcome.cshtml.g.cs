#pragma checksum "F:\pamal\pamal\udemy\c#\.netcoreASP\work\.netMVCmovie\MVCmovie\Views\HellowWorld\Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a57b31c7bdf0f27c31eb86ed17b55f9b97da9c48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HellowWorld_Welcome), @"mvc.1.0.view", @"/Views/HellowWorld/Welcome.cshtml")]
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
#line 1 "F:\pamal\pamal\udemy\c#\.netcoreASP\work\.netMVCmovie\MVCmovie\Views\_ViewImports.cshtml"
using MVCmovie;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\pamal\pamal\udemy\c#\.netcoreASP\work\.netMVCmovie\MVCmovie\Views\_ViewImports.cshtml"
using MVCmovie.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a57b31c7bdf0f27c31eb86ed17b55f9b97da9c48", @"/Views/HellowWorld/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af2525accdaaa8646a827c766b0f8aa99925832b", @"/Views/_ViewImports.cshtml")]
    public class Views_HellowWorld_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "F:\pamal\pamal\udemy\c#\.netcoreASP\work\.netMVCmovie\MVCmovie\Views\HellowWorld\Welcome.cshtml"
  
    ViewData["Title"] = "Welcome";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Welcome</h1>\r\n\r\n");
#nullable restore
#line 8 "F:\pamal\pamal\udemy\c#\.netcoreASP\work\.netMVCmovie\MVCmovie\Views\HellowWorld\Welcome.cshtml"
 for(int x=0; x < (int)ViewData["NumTimes"]; x++)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li class=\"form-control\">");
#nullable restore
#line 10 "F:\pamal\pamal\udemy\c#\.netcoreASP\work\.netMVCmovie\MVCmovie\Views\HellowWorld\Welcome.cshtml"
                        Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 11 "F:\pamal\pamal\udemy\c#\.netcoreASP\work\.netMVCmovie\MVCmovie\Views\HellowWorld\Welcome.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
