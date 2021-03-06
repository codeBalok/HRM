#pragma checksum "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\PayRoll\EmpPaySlipDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb3a04234275118c2348d33c477337c3a7866714"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PayRoll_EmpPaySlipDetails), @"mvc.1.0.view", @"/Views/PayRoll/EmpPaySlipDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb3a04234275118c2348d33c477337c3a7866714", @"/Views/PayRoll/EmpPaySlipDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe811de377df87f992a1034b07ada8fe00de4d53", @"/Views/_ViewImports.cshtml")]
    public class Views_PayRoll_EmpPaySlipDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EasyHRM.Core.DataModel.EmployeePaySlipModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllowanceList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PayRoll", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\PayRoll\EmpPaySlipDetails.cshtml"
  
    ViewData["Title"] = "Employee PaySlip List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row page-titles\">\r\n    <div class=\"col-md-5 align-self-center\">\r\n        <h3 class=\"text-themecolor\">Allowance List</h3>\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb3a04234275118c2348d33c477337c3a78667144208", async() => {
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
            <li class=""breadcrumb-item active"">Allowance/Deduction List </li>
        </ol>
    </div>
</div>

<div class=""row"">
    <div class=""col-md-12"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""row"">

                    <div class=""col-md-12"">
                        <a class=""btn btn-primary btn-sm""");
            BeginWriteAttribute("href", " href=\"", 758, "\"", 814, 1);
#nullable restore
#line 24 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\PayRoll\EmpPaySlipDetails.cshtml"
WriteAttributeValue("", 765, Url.Action("PrintPaySlip", new { id = Model.Id}), 765, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"> <i class=""fa fa-print""></i>  </a>
                        <br /><br />
                    </div>
                    

                    <div class=""col-md-12"">
                        <address class=""pull-left"">
                            <h4 class=""font-bold"">");
#nullable restore
#line 31 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\PayRoll\EmpPaySlipDetails.cshtml"
                                             Write(Model.Employee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\r\n                            <p class=\"m-l-30\">\r\n                                ");
#nullable restore
#line 33 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\PayRoll\EmpPaySlipDetails.cshtml"
                           Write(Model.Employee.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <br />");
#nullable restore
#line 34 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\PayRoll\EmpPaySlipDetails.cshtml"
                                 Write(Model.Employee.Mobile);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <br /> ");
#nullable restore
#line 35 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\PayRoll\EmpPaySlipDetails.cshtml"
                                  Write(Model.Employee.PresentAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                        </address>\r\n                        <address class=\"pull-right\">\r\n                            <p class=\"m-l-30\">\r\n                                Payment Month :  ");
#nullable restore
#line 40 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\PayRoll\EmpPaySlipDetails.cshtml"
                                            Write(Model.PaySlip.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <br />Payment Date :  ");
#nullable restore
#line 41 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\PayRoll\EmpPaySlipDetails.cshtml"
                                                 Write(Model.PaySlip.PaymentDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                        </address>\r\n\r\n");
            WriteLiteral(@"                    </div>

                    <div class=""col-md-6"">
                        <h4 class=""card-title"">Allowances</h4>
                        <table class=""table color-table info-table table-bordered"">
                            <thead>
                                <tr>
                                    <th>
                                        No
                                    </th>
                                    <th>
                                        Name
                                    </th>
                                    <th>Value</th>
                                    <th>Amount</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 68 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\PayRoll\EmpPaySlipDetails.cshtml"
                                 foreach (var item in Model.PaySlipAllowances)
                                {
                                    if (item.AllowanceType == "Allowance")
                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td> 1</td>\r\n                                            <td> ");
#nullable restore
#line 75 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\PayRoll\EmpPaySlipDetails.cshtml"
                                            Write(item.AllowanceName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                            <td> ");
#nullable restore
#line 76 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\PayRoll\EmpPaySlipDetails.cshtml"
                                            Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span> ");
#nullable restore
#line 76 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\PayRoll\EmpPaySlipDetails.cshtml"
                                                                     if (!item.IsValue)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<span> %</span>");
#nullable restore
#line 77 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\PayRoll\EmpPaySlipDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                                            <td> ");
#nullable restore
#line 78 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\PayRoll\EmpPaySlipDetails.cshtml"
                                            Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\r\n                                        </tr>\r\n");
#nullable restore
#line 81 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\PayRoll\EmpPaySlipDetails.cshtml"

                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </tbody>\r\n                            <tfoot>\r\n                                <tr>\r\n\r\n                                    <td colspan=\"3\">Total Allowance </td>\r\n                                    <td> ");
#nullable restore
#line 90 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\PayRoll\EmpPaySlipDetails.cshtml"
                                    Write(Model.AllowanceTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                </tr>
                            </tfoot>
                        </table>
                    </div>
                    <div class=""col-md-6"">
                        <h4 class=""card-title"">Deductions</h4>
                        <table class=""table color-table danger-table table-bordered"">
                            <thead>
                                <tr>
                                    <th>
                                        No
                                    </th>
                                    <th>
                                        Name
                                    </th>
                                    <th>Value</th>
                                    <th>Amount</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 111 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\PayRoll\EmpPaySlipDetails.cshtml"
                                 foreach (var item in Model.PaySlipAllowances)
                                {
                                    if (item.AllowanceType == "Deduction")
                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td> 1</td>\r\n                                            <td> ");
#nullable restore
#line 118 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\PayRoll\EmpPaySlipDetails.cshtml"
                                            Write(item.AllowanceName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                            <td> ");
#nullable restore
#line 119 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\PayRoll\EmpPaySlipDetails.cshtml"
                                            Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span> ");
#nullable restore
#line 119 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\PayRoll\EmpPaySlipDetails.cshtml"
                                                                     if (!item.IsValue)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<span> %</span>");
#nullable restore
#line 120 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\PayRoll\EmpPaySlipDetails.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                                            <td> ");
#nullable restore
#line 121 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\PayRoll\EmpPaySlipDetails.cshtml"
                                            Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\r\n                                        </tr>\r\n");
#nullable restore
#line 124 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\PayRoll\EmpPaySlipDetails.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </tbody>\r\n                            <tfoot>\r\n                                <tr>\r\n\r\n                                    <td colspan=\"3\">Total Deduction </td>\r\n                                    <td> ");
#nullable restore
#line 132 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\PayRoll\EmpPaySlipDetails.cshtml"
                                    Write(Model.DeductionTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                </tr>
                            </tfoot>
                        </table>

                    </div>

                    

                    <div class=""col-md-12"">
                        <hr />
                        <table class=""table table-bordered"">
                            <tr>
                                <th><strong class=""pull-right""> Basic Salarry</strong>  </th>
                                <th><strong class=""pull-right""> Total Allowance</strong> </th>
                                <th><strong class=""pull-right""> Total Deduction</strong></th>
                            </tr>
                            <tr>
                                <td><span class=""pull-right"">");
#nullable restore
#line 150 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\PayRoll\EmpPaySlipDetails.cshtml"
                                                        Write(Model.Employee.BasicSalary);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span> </td>\r\n                                <td> <span class=\"pull-right\">");
#nullable restore
#line 151 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\PayRoll\EmpPaySlipDetails.cshtml"
                                                         Write(Model.AllowanceTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span> </td>\r\n                                <td><span class=\"pull-right\"> ");
#nullable restore
#line 152 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\PayRoll\EmpPaySlipDetails.cshtml"
                                                         Write(Model.DeductionTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span> </td>
                            </tr>
                            <tr>
                                <td colspan=""2""> <span class=""pull-right""> <strong>Net Salary </strong> </span>  </td>
                                <td><span class=""pull-right""> <strong> ");
#nullable restore
#line 156 "D:\Clients\Abdul HRM\HRM\Project\EasyHRM.Web\Views\PayRoll\EmpPaySlipDetails.cshtml"
                                                                  Write(Model.NetSalary);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </strong></span> </td>\r\n                            </tr>\r\n                        </table>\r\n                    </div>\r\n\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EasyHRM.Core.DataModel.EmployeePaySlipModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
