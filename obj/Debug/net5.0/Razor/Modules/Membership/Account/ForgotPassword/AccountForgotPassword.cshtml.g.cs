#pragma checksum "C:\Users\Alfad\OneDrive\Documents\Santri\Serenity\Serenity.Web\Modules\Membership\Account\ForgotPassword\AccountForgotPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eda8af106ae94f767d2503ed270bda2b877cca8d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_Membership_Account_ForgotPassword_AccountForgotPassword), @"mvc.1.0.view", @"/Modules/Membership/Account/ForgotPassword/AccountForgotPassword.cshtml")]
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
#line 2 "C:\Users\Alfad\OneDrive\Documents\Santri\Serenity\Serenity.Web\Modules\_ViewImports.cshtml"
using Serenity.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alfad\OneDrive\Documents\Santri\Serenity\Serenity.Web\Modules\_ViewImports.cshtml"
using Serenity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Alfad\OneDrive\Documents\Santri\Serenity\Serenity.Web\Modules\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Alfad\OneDrive\Documents\Santri\Serenity\Serenity.Web\Modules\_ViewImports.cshtml"
using System.Text;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eda8af106ae94f767d2503ed270bda2b877cca8d", @"/Modules/Membership/Account/ForgotPassword/AccountForgotPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e51a6726406726c4c80e74a4f172a74e8109eb85", @"/Modules/_ViewImports.cshtml")]
    public class Modules_Membership_Account_ForgotPassword_AccountForgotPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Alfad\OneDrive\Documents\Santri\Serenity\Serenity.Web\Modules\Membership\Account\ForgotPassword\AccountForgotPassword.cshtml"
  
    ViewData["Title"] = Texts.Forms.Membership.ForgotPassword.FormTitle.ToString(Localizer);
    ViewData["PageId"] = "ForgotPassword";
    Layout = MVC.Views.Shared._LayoutNoNavigation;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script id=\"Template_Membership_ForgotPasswordPanel\" type=\"text/template\">\r\n    <h2 class=\"text-center p-4\">\r\n        <img src=\"");
#nullable restore
#line 10 "C:\Users\Alfad\OneDrive\Documents\Santri\Serenity\Serenity.Web\Modules\Membership\Account\ForgotPassword\AccountForgotPassword.cshtml"
             Write(Url.Content("~/Content/site/images/serenity-logo-w-128.png"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" \r\n            class=\"rounded-circle p-1\" style=\"background-color: var(--s-sidebar-band-bg)\"\r\n            width=\"50\" height=\"50\" /> StartSharp\r\n    </h2>\r\n\r\n    <div class=\"s-Panel p-4\">\r\n        <h5 class=\"text-center mb-4\">");
#nullable restore
#line 16 "C:\Users\Alfad\OneDrive\Documents\Santri\Serenity\Serenity.Web\Modules\Membership\Account\ForgotPassword\AccountForgotPassword.cshtml"
                                Write(Texts.Forms.Membership.ForgotPassword.FormTitle.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <p class=\"text-center\">");
#nullable restore
#line 17 "C:\Users\Alfad\OneDrive\Documents\Santri\Serenity\Serenity.Web\Modules\Membership\Account\ForgotPassword\AccountForgotPassword.cshtml"
                          Write(Texts.Forms.Membership.ForgotPassword.FormInfo.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <form id=\"~_Form\" action=\"\">\r\n            <div id=\"~_PropertyGrid\"></div>\r\n            <button id=\"~_SubmitButton\" type=\"submit\" class=\"btn btn-primary mx-8 mt-2 w-100\">\r\n                ");
#nullable restore
#line 21 "C:\Users\Alfad\OneDrive\Documents\Santri\Serenity\Serenity.Web\Modules\Membership\Account\ForgotPassword\AccountForgotPassword.cshtml"
           Write(Texts.Forms.Membership.ForgotPassword.SubmitButton.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </button>
        </form>
    </div>
</script>

<div id=""ForgotPasswordPanel"" class=""s-container-tight mt-5 s-Form flex-layout"">
</div>
<script type=""text/javascript"">
$(function() {
    new Serenity.Membership.ForgotPasswordPanel($('#ForgotPasswordPanel')).init();
});
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Serenity.ITextLocalizer Localizer { get; private set; }
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
