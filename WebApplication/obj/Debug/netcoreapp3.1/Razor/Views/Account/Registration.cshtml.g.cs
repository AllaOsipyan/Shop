#pragma checksum "C:\Users\odint\RiderProjects\WebApplication\WebApplication\Views\Account\Registration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d7cc752b713e0ea8a57d960ba0535153ad76c2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Registration), @"mvc.1.0.view", @"/Views/Account/Registration.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d7cc752b713e0ea8a57d960ba0535153ad76c2f", @"/Views/Account/Registration.cshtml")]
    public class Views_Account_Registration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication.ViewModels.RegisterModel>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d7cc752b713e0ea8a57d960ba0535153ad76c2f2732", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" type=\"text/css\"");
                BeginWriteAttribute("href", "  href=\"", 98, "\"", 144, 1);
#nullable restore
#line 3 "C:\Users\odint\RiderProjects\WebApplication\WebApplication\Views\Account\Registration.cshtml"
WriteAttributeValue("", 106, Url.Content("~/Content/logincss.css"), 106, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d7cc752b713e0ea8a57d960ba0535153ad76c2f4160", async() => {
                WriteLiteral(@"
    <div class=""back"">
        <div class=""main_text"">Регистрация</div>
        <form method=""post"" style=""height:calc(80% - 20px)"">
                
            <div>
                <label>Введите имя пользователя</label><br />
                <span class=""info_text"">Имя пользователя должно включать от 5 до 50 символов. Имя регистрозависимо.</span>
                <div class=""error"">
                    ");
#nullable restore
#line 14 "C:\Users\odint\RiderProjects\WebApplication\WebApplication\Views\Account\Registration.cshtml"
               Write(Html.ValidationMessageFor(model => model.userName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"error\">");
#nullable restore
#line 16 "C:\Users\odint\RiderProjects\WebApplication\WebApplication\Views\Account\Registration.cshtml"
                              Write(ViewBag.Error);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>
                <input type=""text"" name=""userName"" required />

            </div>
                <div>
                    <label>Введите пароль</label><br />
                    <span class=""info_text"">Пароль должен включать от 8 до 50 символов. Пароль регистрозависим.</span>
                    <div class=""error"">
                        ");
#nullable restore
#line 24 "C:\Users\odint\RiderProjects\WebApplication\WebApplication\Views\Account\Registration.cshtml"
                   Write(Html.ValidationMessageFor(model => model.password));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                    <input type=""password"" name=""password"" required />
                    
                </div>
                <div>
                    <label asp-for=""PasswordConfirm"">Повторите пароль</label><br />
                    <div class=""error"">
                        ");
#nullable restore
#line 32 "C:\Users\odint\RiderProjects\WebApplication\WebApplication\Views\Account\Registration.cshtml"
                   Write(Html.ValidationMessageFor(model => model.checkPassword));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                    <input type=""password"" name=""checkPassword"" required />
                    
                </div>
                <div>
                    <label>Введите Email</label><br />
                    <div class=""error"">
                        ");
#nullable restore
#line 40 "C:\Users\odint\RiderProjects\WebApplication\WebApplication\Views\Account\Registration.cshtml"
                   Write(Html.ValidationMessageFor(model => model.email));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                    <input type=""text"" name=""email"" required />
                    
                </div>
                <div>
                    <input type=""submit"" value=""Регистрация"" />
                </div>

        </form>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication.ViewModels.RegisterModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
