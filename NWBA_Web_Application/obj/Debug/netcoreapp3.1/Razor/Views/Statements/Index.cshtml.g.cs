#pragma checksum "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fa4467b5c32c7c7528bc1e097acd7f0fffbe9a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Statements_Index), @"mvc.1.0.view", @"/Views/Statements/Index.cshtml")]
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
#line 1 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\_ViewImports.cshtml"
using NWBA_Web_Application;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\_ViewImports.cshtml"
using NWBA_Web_Application.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
using X.PagedList.Mvc.Core.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fa4467b5c32c7c7528bc1e097acd7f0fffbe9a9", @"/Views/Statements/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"845faaa104019eee26a37e4d2aad5c0f89a2dd69", @"/Views/_ViewImports.cshtml")]
    public class Views_Statements_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NWBA_Web_Application.Models.StatementsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
  
    ViewData["Title"] = "Statement";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <h1>\r\n        Statement for\r\n");
#nullable restore
#line 14 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
           if (Model.id == 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
           Write(Html.Encode(ViewBag.Accounts[0].AccountNumber));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
                                                               ;
            }
            else 

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
            Write(Html.Encode(Model.id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
                                       ;
   

#line default
#line hidden
#nullable disable
            WriteLiteral("        </h1>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fa4467b5c32c7c7528bc1e097acd7f0fffbe9a98077", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fa4467b5c32c7c7528bc1e097acd7f0fffbe9a98347", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 25 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <label class=\"control-label\"> Please choose an account:</label>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fa4467b5c32c7c7528bc1e097acd7f0fffbe9a910182", async() => {
                    WriteLiteral("\r\n");
#nullable restore
#line 29 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
                     foreach (var account in (List<Account>)ViewBag.Accounts)
                    {
                        if (@account.AccountType == "S")
                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fa4467b5c32c7c7528bc1e097acd7f0fffbe9a910891", async() => {
                        WriteLiteral(" Savings: &nbsp; ");
#nullable restore
#line 33 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
                                                                               Write(account.AccountNumber);

#line default
#line hidden
#nullable disable
                        WriteLiteral(" ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
                               WriteLiteral(account.AccountNumber);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 34 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fa4467b5c32c7c7528bc1e097acd7f0fffbe9a913379", async() => {
                        WriteLiteral(" Checking: &nbsp; ");
#nullable restore
#line 37 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
                                                                                Write(account.AccountNumber);

#line default
#line hidden
#nullable disable
                        WriteLiteral(" ");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
                               WriteLiteral(account.AccountNumber);

#line default
#line hidden
#nullable disable
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
#nullable restore
#line 38 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 28 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"View\" class=\"btn btn-primary\" />\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 54 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Transactions[0].Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 57 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Transactions[0].TransactionType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 60 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Transactions[0].DestinationAccountNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 63 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Transactions[0].ModifyDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 66 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Transactions[0].Comment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 72 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
             foreach (var transaction in Model.Transactions)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 76 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
                   Write(Html.DisplayFor(x => transaction.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 79 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
                         switch (transaction.TransactionType)
                        {
                            case "D":
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
                           Write(Html.Raw("Deposit"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
                                                    ;
                                break;
                            case "W":
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
                           Write(Html.Raw("Withdrawal"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
                                                       ;
                                break;
                            case "T":
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
                           Write(Html.Raw("Transfer"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
                                                     ;
                                break;
                            case "S":
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
                           Write(Html.Raw("Service"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
                                                    ;
                                break;
                            case "B":
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
                           Write(Html.Raw("Billpay"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
                                                    ;
                                break;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 99 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
                          
                                string destination = "-";
                                if (transaction.DestinationAccountNumber != null)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
                               Write(Html.DisplayFor(x => transaction.DestinationAccountNumber));

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
                                                                                               
                                }
                                else
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
                               Write(Html.Encode(destination));

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
                                                             ;
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 113 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
                   Write(transaction.ModifyDate.ToLocalTime());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 116 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
                          
                                string comment = "-";
                                if (transaction.Comment != null)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 120 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
                               Write(Html.DisplayFor(x => transaction.Comment));

#line default
#line hidden
#nullable disable
#nullable restore
#line 120 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
                                                                              
                                }
                                else
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 124 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
                               Write(Html.Encode(comment));

#line default
#line hidden
#nullable disable
#nullable restore
#line 124 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
                                                         ;
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 129 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    ");
#nullable restore
#line 132 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Application\Views\Statements\Index.cshtml"
Write(Html.PagedListPager(Model.Transactions, page => Url.Action("Index", new { Model, page }),
            new PagedListRenderOptions
            {
                LiElementClasses = new[] { "page-item" },
                PageClasses = new[] { "page-link" }
            }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fa4467b5c32c7c7528bc1e097acd7f0fffbe9a929658", async() => {
                WriteLiteral("Back to Accounts");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NWBA_Web_Application.Models.StatementsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
