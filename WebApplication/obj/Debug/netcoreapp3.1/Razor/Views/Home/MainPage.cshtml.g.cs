#pragma checksum "C:\Users\odint\RiderProjects\WebApplication\WebApplication\Views\Home\MainPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f048ebda4e54089512ab563a2b5243f95f624fc4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MainPage), @"mvc.1.0.view", @"/Views/Home/MainPage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f048ebda4e54089512ab563a2b5243f95f624fc4", @"/Views/Home/MainPage.cshtml")]
    public class Views_Home_MainPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div> Hello World! </div>\r\n<script src=\"https://code.jquery.com/jquery-3.3.1.min.js\"></script>\r\n\r\n");
#nullable restore
#line 4 "C:\Users\odint\RiderProjects\WebApplication\WebApplication\Views\Home\MainPage.cshtml"
 using (Html.BeginForm("MPage", "FirstPage")){

#line default
#line hidden
#nullable disable
            WriteLiteral("<button method=\"post\" >Выход</button>");
#nullable restore
#line 5 "C:\Users\odint\RiderProjects\WebApplication\WebApplication\Views\Home\MainPage.cshtml"
                                     }

#line default
#line hidden
#nullable disable
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