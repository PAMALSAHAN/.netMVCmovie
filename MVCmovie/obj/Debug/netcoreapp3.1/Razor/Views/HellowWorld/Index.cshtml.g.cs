#pragma checksum "F:\pamal\pamal\udemy\c#\.netcoreASP\work\.netMVCmovie\MVCmovie\Views\HellowWorld\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "437fd8202560f47542a0f4a8be867145148e2c0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HellowWorld_Index), @"mvc.1.0.razor-page", @"/Views/HellowWorld/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"437fd8202560f47542a0f4a8be867145148e2c0d", @"/Views/HellowWorld/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af2525accdaaa8646a827c766b0f8aa99925832b", @"/Views/_ViewImports.cshtml")]
    public class Views_HellowWorld_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "F:\pamal\pamal\udemy\c#\.netcoreASP\work\.netMVCmovie\MVCmovie\Views\HellowWorld\Index.cshtml"
  
    // ViewData["Title"] = "HellowWorld";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"form-text\">This is Hellow and Index Page run time compilation</h1>\r\n<h3 class=\"form-text\">");
#nullable restore
#line 8 "F:\pamal\pamal\udemy\c#\.netcoreASP\work\.netMVCmovie\MVCmovie\Views\HellowWorld\Index.cshtml"
                 Write(TempData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3 class=\"form-text\">  ");
#nullable restore
#line 9 "F:\pamal\pamal\udemy\c#\.netcoreASP\work\.netMVCmovie\MVCmovie\Views\HellowWorld\Index.cshtml"
                   Write(ViewBag.k);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </h3>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVCmovie.Views.HellowWorld.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MVCmovie.Views.HellowWorld.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MVCmovie.Views.HellowWorld.IndexModel>)PageContext?.ViewData;
        public MVCmovie.Views.HellowWorld.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
