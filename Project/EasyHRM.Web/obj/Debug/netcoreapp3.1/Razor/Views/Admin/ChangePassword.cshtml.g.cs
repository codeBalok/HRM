#pragma checksum "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Admin\ChangePassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3233636a6d08f59947fb63c5c77a1862e166ec48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ChangePassword), @"mvc.1.0.view", @"/Views/Admin/ChangePassword.cshtml")]
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
#line 1 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\_ViewImports.cshtml"
using EasyHRM.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\_ViewImports.cshtml"
using EasyHRM.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3233636a6d08f59947fb63c5c77a1862e166ec48", @"/Views/Admin/ChangePassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe811de377df87f992a1034b07ada8fe00de4d53", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ChangePassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EasyHRM.Core.ViewModel.ChangePasswordViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Admin\ChangePassword.cshtml"
  
    ViewBag.Title = "ChangePass";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 8 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Admin\ChangePassword.cshtml"
 using (Html.BeginForm("ChangePassword", "admin", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Admin\ChangePassword.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <div class=\"form-horizontal\">\r\n        <div class=\"row\">\r\n            <!-- left column -->\r\n            <div class=\"col-md-12\">\r\n                <!-- general form elements -->\r\n                <div class=\"box box-primary\">\r\n");
#nullable restore
#line 18 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Admin\ChangePassword.cshtml"
                     if (TempData["FMsg"] != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"alert alert-danger\">\r\n                            <i class=\"ti-user\"></i>  ");
#nullable restore
#line 21 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Admin\ChangePassword.cshtml"
                                                Write(TempData["FMsg"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">×</span> </button>\r\n                        </div>\r\n");
#nullable restore
#line 24 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Admin\ChangePassword.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Admin\ChangePassword.cshtml"
                     if (TempData["Msg"] != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"alert alert-success\">\r\n                            <i class=\"ti-user\"></i>  ");
#nullable restore
#line 28 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Admin\ChangePassword.cshtml"
                                                Write(TempData["Msg"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"> <span aria-hidden=\"true\">×</span> </button>\r\n                        </div>\r\n");
#nullable restore
#line 31 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Admin\ChangePassword.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"box-header with-border\">\r\n                        <h3 class=\"box-title\">Change Password</h3>\r\n                    </div>\r\n                    <br />\r\n                    ");
#nullable restore
#line 36 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Admin\ChangePassword.cshtml"
               Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 39 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Admin\ChangePassword.cshtml"
                   Write(Html.LabelFor(model => model.CurrentPass, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-md-8\">\r\n                            ");
#nullable restore
#line 41 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Admin\ChangePassword.cshtml"
                       Write(Html.PasswordFor(model => model.CurrentPass, new { @class = "form-control", @placeholder = "Enter current password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 42 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Admin\ChangePassword.cshtml"
                       Write(Html.ValidationMessageFor(model => model.CurrentPass, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 47 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Admin\ChangePassword.cshtml"
                   Write(Html.LabelFor(model => model.NewPass, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-md-8\">\r\n                            ");
#nullable restore
#line 49 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Admin\ChangePassword.cshtml"
                       Write(Html.PasswordFor(model => model.NewPass, new { @class = "form-control", @placeholder = "Enter new password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 50 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Admin\ChangePassword.cshtml"
                       Write(Html.ValidationMessageFor(model => model.NewPass, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 55 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Admin\ChangePassword.cshtml"
                   Write(Html.LabelFor(model => model.ConfirmPass, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-md-8\">\r\n                            ");
#nullable restore
#line 57 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Admin\ChangePassword.cshtml"
                       Write(Html.PasswordFor(model => model.ConfirmPass, new { @class = "form-control", @placeholder = "Enter confirm password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 58 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Admin\ChangePassword.cshtml"
                       Write(Html.ValidationMessageFor(model => model.ConfirmPass, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""form-group"">
                        <div class=""col-md-offset-2 col-md-10"">
                            <input type=""submit"" value=""Change Password"" class=""btn btn-primary"" />
                        </div>
                    </div>
                    <hr />
                    <div>
                        <a");
            BeginWriteAttribute("href", " href=\"", 3548, "\"", 3555, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-arrow-circle-o-left\" aria-hidden=\"true\" style=\"margin-left:20px;\"></i></a>\r\n                        ");
#nullable restore
#line 69 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Admin\ChangePassword.cshtml"
                   Write(Html.ActionLink("Back to Dashboard", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <br />\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 76 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Admin\ChangePassword.cshtml"
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
