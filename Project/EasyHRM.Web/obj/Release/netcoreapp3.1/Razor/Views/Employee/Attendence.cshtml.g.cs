#pragma checksum "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Employee\Attendence.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75f54045878aa070cfef8c70c8139ba9da2acb9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Attendence), @"mvc.1.0.view", @"/Views/Employee/Attendence.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75f54045878aa070cfef8c70c8139ba9da2acb9a", @"/Views/Employee/Attendence.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe811de377df87f992a1034b07ada8fe00de4d53", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Attendence : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EasyHRM.Core.ViewModel.AttendenceReportViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Attendence", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Employee\Attendence.cshtml"
  
    ViewData["Title"] = "Take Attendence";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .margin-10 {
        margin-top: 6px;
    }

    .vertical-text {
        writing-mode: vertical-rl;
    }

    #customers {
        border-collapse: collapse;
        width: 100%;
    }

        #customers td, #customers th {
            border: 1px solid #ddd;
        }

        #customers tr:nth-child(even) {
            background-color: #f2f2f2;
        }

        #customers tr:hover {
            background-color: #ddd;
        }

        #customers td {
            font-size: 13px;
        }

        #customers th {
            padding-top: 12px;
            padding-bottom: 12px;
            text-align: left;
            background-color: #4CAF50;
            color: white;
        }
</style>
<div class=""row page-titles"">
    <div class=""col-md-5 align-self-center"">
        <h3 class=""text-themecolor"">Attendence Report </h3>
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item""><a href=""javascript:void(0)"">Home</a></li>
         ");
            WriteLiteral("   <li class=\"breadcrumb-item active\">Attendence Report</li>\r\n        </ol>\r\n    </div>\r\n\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 1235, "\"", 1243, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <button class=\"right-side-toggle waves-effect waves-light btn-inverse btn btn-circle btn-sm pull-right m-l-10\"><i class=\"ti-settings text-white\"></i></button>\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75f54045878aa070cfef8c70c8139ba9da2acb9a6587", async() => {
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card"">
                <div class=""card-body"">

                    <div class=""row"">
                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75f54045878aa070cfef8c70c8139ba9da2acb9a7162", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 68 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Employee\Attendence.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Month);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
#nullable restore
#line 69 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Employee\Attendence.cshtml"
                           Write(Html.DropDownListFor(x => x.Month, new List<SelectListItem>
                                                    {
                                                        new SelectListItem() {Text = "January", Value="1"},
                                                        new SelectListItem() {Text = "February", Value="2"},
                                                        new SelectListItem() {Text = "March", Value="3"},
                                                        new SelectListItem() {Text = "April", Value="4"},
                                                        new SelectListItem() {Text = "May", Value="5"},
                                                        new SelectListItem() {Text = "June", Value="6"},
                                                        new SelectListItem() {Text = "July", Value="7"},
                                                        new SelectListItem() {Text = "August", Value="8"},
                                                        new SelectListItem() {Text = "September", Value="9"},
                                                        new SelectListItem() {Text = "October ", Value="10"},
                                                        new SelectListItem() {Text = "November", Value="11"},
                                                        new SelectListItem() {Text = "December", Value="12"},
                                                    }, "Select Month", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75f54045878aa070cfef8c70c8139ba9da2acb9a10476", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 84 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Employee\Attendence.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Month);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <br />
                            <input class=""btn btn-primary margin-10"" type=""submit"" value=""Show Report"" />
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n");
#nullable restore
#line 101 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Employee\Attendence.cshtml"
         if (Model != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card\">\r\n                <div class=\"card-body\">\r\n                    <table id=\"customers\">\r\n                        <thead>\r\n                            <tr>\r\n                                <td>Employee</td>\r\n\r\n");
#nullable restore
#line 110 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Employee\Attendence.cshtml"
                                 foreach (var item in Model.AllCurrentMonthDate)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>\r\n                                        <span class=\"vertical-text\">");
#nullable restore
#line 113 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Employee\Attendence.cshtml"
                                                               Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n                                    </td>\r\n");
#nullable restore
#line 115 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Employee\Attendence.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tr>\r\n                        </thead>\r\n");
#nullable restore
#line 118 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Employee\Attendence.cshtml"
                         foreach (var emp in Model.StatusViewModel)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td> ");
#nullable restore
#line 122 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Employee\Attendence.cshtml"
                                Write(emp.EmployeeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 123 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Employee\Attendence.cshtml"
                                 foreach (var status in emp.statustViewModel)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>\r\n");
#nullable restore
#line 126 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Employee\Attendence.cshtml"
                                         if (status.Status == "Present")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"fa  fa-check\"> </span>\r\n");
#nullable restore
#line 129 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Employee\Attendence.cshtml"

                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 131 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Employee\Attendence.cshtml"
                                         if (status.Status == "Absense")
                                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"fa fa-times\"></span>\r\n");
#nullable restore
#line 135 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Employee\Attendence.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </td>\r\n");
#nullable restore
#line 137 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Employee\Attendence.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tr>\r\n");
#nullable restore
#line 140 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Employee\Attendence.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </table>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 144 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\Employee\Attendence.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EasyHRM.Core.ViewModel.AttendenceReportViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591