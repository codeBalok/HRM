#pragma checksum "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\Employee\ChangePassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "468297d898311850e53d36ae11ee07e9672b0841"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_ChangePassword), @"mvc.1.0.view", @"/Views/Employee/ChangePassword.cshtml")]
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
#line 1 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\_ViewImports.cshtml"
using EasyHRM.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\_ViewImports.cshtml"
using EasyHRM.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"468297d898311850e53d36ae11ee07e9672b0841", @"/Views/Employee/ChangePassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe811de377df87f992a1034b07ada8fe00de4d53", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_ChangePassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EasyHRM.Core.ViewModel.ChangePasswordViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\Employee\ChangePassword.cshtml"
  
    ViewBag.Title = "ChangePass";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\Employee\ChangePassword.cshtml"
 if (TempData["Msg"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\">\r\n        <i class=\"ti-user\"></i>  ");
#nullable restore
#line 9 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\Employee\ChangePassword.cshtml"
                            Write(TempData["Msg"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">×</span> </button>\r\n    </div>\r\n");
#nullable restore
#line 12 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\Employee\ChangePassword.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\Employee\ChangePassword.cshtml"
 if (TempData["FMsg"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\">\r\n        <i class=\"ti-user\"></i>  ");
#nullable restore
#line 16 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\Employee\ChangePassword.cshtml"
                            Write(TempData["FMsg"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">×</span> </button>\r\n    </div>\r\n");
#nullable restore
#line 19 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\Employee\ChangePassword.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 22 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\Employee\ChangePassword.cshtml"
 using (Html.BeginForm("ChangePassword", "Employee", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\Employee\ChangePassword.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 26 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\Employee\ChangePassword.cshtml"
Write(Html.Partial("_ChangePassword", Model));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\Employee\ChangePassword.cshtml"
                                           ;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EasyHRM.Core.ViewModel.ChangePasswordViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
