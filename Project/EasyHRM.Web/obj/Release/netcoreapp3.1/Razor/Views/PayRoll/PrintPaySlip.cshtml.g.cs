#pragma checksum "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\PayRoll\PrintPaySlip.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "739a7bd4aa3819b8545fc815e32b459926fbd421"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PayRoll_PrintPaySlip), @"mvc.1.0.view", @"/Views/PayRoll/PrintPaySlip.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"739a7bd4aa3819b8545fc815e32b459926fbd421", @"/Views/PayRoll/PrintPaySlip.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe811de377df87f992a1034b07ada8fe00de4d53", @"/Views/_ViewImports.cshtml")]
    public class Views_PayRoll_PrintPaySlip : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EasyHRM.Core.DataModel.EmployeePaySlipModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin2/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\PayRoll\PrintPaySlip.cshtml"
  
    Layout = null;
    ViewData["Title"] = "Employee PaySlip List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "739a7bd4aa3819b8545fc815e32b459926fbd4214619", async() => {
                WriteLiteral("\r\n\r\n\r\n    <!-- Bootstrap Core CSS -->\r\n");
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "739a7bd4aa3819b8545fc815e32b459926fbd4214963", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "739a7bd4aa3819b8545fc815e32b459926fbd4216141", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\r\n");
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
            WriteLiteral("\r\n\r\n<div");
            BeginWriteAttribute("id", " id=\"", 418, "\"", 423, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 435, "\"", 443, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div");
            BeginWriteAttribute("class", " class=\"", 459, "\"", 467, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <div class=""row"">
                                <div class=""col-md-12"">
                                    <address>
                                        <h4 class=""font-bold"">");
#nullable restore
#line 29 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\PayRoll\PrintPaySlip.cshtml"
                                                         Write(Model.Employee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\r\n                                        <p class=\"m-l-30\">\r\n                                            ");
#nullable restore
#line 31 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\PayRoll\PrintPaySlip.cshtml"
                                       Write(Model.Employee.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            <br />");
#nullable restore
#line 32 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\PayRoll\PrintPaySlip.cshtml"
                                             Write(Model.Employee.Mobile);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            <br /> ");
#nullable restore
#line 33 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\PayRoll\PrintPaySlip.cshtml"
                                              Write(Model.Employee.PresentAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </p>
                                    </address>
                                </div>
                                <br /> <br />
                                
                                       <div class=""col-md-12"">
                                           <span> Payment date : <b> ");
#nullable restore
#line 40 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\PayRoll\PrintPaySlip.cshtml"
                                                                Write(Model.PaySlip.PaymentDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b></span>  &nbsp; &nbsp;\r\n                                           <span> Payment Month : <b>  ");
#nullable restore
#line 41 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\PayRoll\PrintPaySlip.cshtml"
                                                                  Write(Model.PaySlip.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b> </span>\r\n                                       </div>\r\n\r\n\r\n                            <div class=\"col-md-6\">\r\n                                <h4");
            BeginWriteAttribute("class", " class=\"", 1824, "\"", 1832, 0);
            EndWriteAttribute();
            WriteLiteral(@">Allowances</h4>
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
#line 61 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\PayRoll\PrintPaySlip.cshtml"
                                         foreach (var item in Model.PaySlipAllowances)
            {
                if (item.AllowanceType == "Allowance")
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td> 1</td>\r\n                                <td> ");
#nullable restore
#line 68 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\PayRoll\PrintPaySlip.cshtml"
                                Write(item.AllowanceName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 70 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\PayRoll\PrintPaySlip.cshtml"
                               Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("  <span>\r\n");
#nullable restore
#line 71 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\PayRoll\PrintPaySlip.cshtml"
                                         if (!item.IsValue)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span> %</span>");
#nullable restore
#line 72 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\PayRoll\PrintPaySlip.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </span>\r\n                                </td>\r\n                                <td> ");
#nullable restore
#line 75 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\PayRoll\PrintPaySlip.cshtml"
                                Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 78 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\PayRoll\PrintPaySlip.cshtml"

}
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </tbody>
                                    <tfoot>
                                        <tr>

                                            <td colspan=""3"">Total Allowance </td>
                                            <td> ");
#nullable restore
#line 87 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\PayRoll\PrintPaySlip.cshtml"
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
              ");
            WriteLiteral("                      <tbody>\r\n");
#nullable restore
#line 108 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\PayRoll\PrintPaySlip.cshtml"
                                         foreach (var item in Model.PaySlipAllowances)
            {
                if (item.AllowanceType == "Deduction")
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td> 1</td>\r\n                                <td> ");
#nullable restore
#line 115 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\PayRoll\PrintPaySlip.cshtml"
                                Write(item.AllowanceName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 117 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\PayRoll\PrintPaySlip.cshtml"
                               Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>\r\n");
#nullable restore
#line 118 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\PayRoll\PrintPaySlip.cshtml"
                                         if (!item.IsValue)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span> %</span>");
#nullable restore
#line 119 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\PayRoll\PrintPaySlip.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </span>\r\n                                </td>\r\n                                <td> ");
#nullable restore
#line 122 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\PayRoll\PrintPaySlip.cshtml"
                                Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 125 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\PayRoll\PrintPaySlip.cshtml"
}
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </tbody>
                                    <tfoot>
                                        <tr>

                                            <td colspan=""3"">Total Deduction </td>
                                            <td> ");
#nullable restore
#line 133 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\PayRoll\PrintPaySlip.cshtml"
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
#line 151 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\PayRoll\PrintPaySlip.cshtml"
                                                                Write(Model.Employee.BasicSalary);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span> </td>\r\n                                        <td> <span class=\"pull-right\">");
#nullable restore
#line 152 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\PayRoll\PrintPaySlip.cshtml"
                                                                 Write(Model.AllowanceTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span> </td>\r\n                                        <td><span class=\"pull-right\"> ");
#nullable restore
#line 153 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\PayRoll\PrintPaySlip.cshtml"
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
#line 157 "E:\workspace\cloud\easy-hrm\Project\EasyHRM.Web\Views\PayRoll\PrintPaySlip.cshtml"
                                                                          Write(Model.NetSalary);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </strong></span> </td>
                                    </tr>
                                </table>
                            </div>

                            </div>

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
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
