#pragma checksum "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\Employee\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32be154355aa92d2556345352fbb18ee6d930a4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Profile), @"mvc.1.0.view", @"/Views/Employee/Profile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32be154355aa92d2556345352fbb18ee6d930a4b", @"/Views/Employee/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe811de377df87f992a1034b07ada8fe00de4d53", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EasyHRM.Core.DataModel.EmployeeModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\Employee\Profile.cshtml"
  
    ViewData["Title"] = "Profile ";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row page-titles\">\r\n    <div class=\"col-md-5 align-self-center\">\r\n        <h3 class=\"text-themecolor\">Profile</h3>\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32be154355aa92d2556345352fbb18ee6d930a4b4121", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
            <li class=""breadcrumb-item active"">Profile </li>
        </ol>
    </div>

</div>

<div class=""row"">
    <div class=""col-lg-6 col-xlg-3 col-md-6"">
        <div class=""card"">
            <div class=""card-body"">
                <center class=""m-t-30"">
                    <img");
            BeginWriteAttribute("src", " src=\"", 654, "\"", 676, 1);
#nullable restore
#line 23 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\Employee\Profile.cshtml"
WriteAttributeValue("", 660, Model.ImagePath, 660, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-circle\" width=\"150\" />\r\n                    <h4 class=\"card-title m-t-10\">");
#nullable restore
#line 24 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\Employee\Profile.cshtml"
                                             Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <h6 class=\"card-subtitle\">");
#nullable restore
#line 25 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\Employee\Profile.cshtml"
                                         Write(Model.DesignationModel.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                    <div class=""row text-center justify-content-md-center"">

                        <div class=""col-4""> <small class=""text-muted"">Joining : </small><a href=""javascript:void(0)"" class=""link""><i class=""icon-picture""></i> <font class=""font-medium""> ");
#nullable restore
#line 28 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\Employee\Profile.cshtml"
                                                                                                                                                                                     Write(Model.JoiningDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</font></a></div>\r\n                        <div class=\"col-4\"> <small class=\"text-muted\">Basic Salary : </small><a href=\"javascript:void(0)\" class=\"link\"><i class=\"icon-picture\"></i> <font class=\"font-medium\"> ");
#nullable restore
#line 29 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\Employee\Profile.cshtml"
                                                                                                                                                                                          Write(Model.BasicSalary);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</font></a></div>
                    </div>
                </center>
            </div>
            <div>
                <hr>
            </div>
            <div class=""card-body"">
                <small class=""text-muted"">Email address </small>
                <h6>");
#nullable restore
#line 38 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\Employee\Profile.cshtml"
               Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6> <small class=\"text-muted p-t-30 db\">Phone</small>\r\n                <h6>");
#nullable restore
#line 39 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\Employee\Profile.cshtml"
               Write(Model.Mobile);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6> <small class=\"text-muted p-t-30 db\">Address</small>\r\n                <h6>");
#nullable restore
#line 40 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\Employee\Profile.cshtml"
               Write(Model.PresentAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                <br />
                <button class=""btn btn-circle btn-secondary""><i class=""fa fa-facebook""></i></button>
                <button class=""btn btn-circle btn-secondary""><i class=""fa fa-twitter""></i></button>
                <button class=""btn btn-circle btn-secondary""><i class=""fa fa-youtube""></i></button>
            </div>
        </div>
    </div>

</div>


");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EasyHRM.Core.DataModel.EmployeeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
