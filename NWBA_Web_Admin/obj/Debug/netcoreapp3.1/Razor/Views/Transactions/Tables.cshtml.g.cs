#pragma checksum "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Admin\Views\Transactions\Tables.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "370ef950585fb600d0abe0e093b70014c89e221b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transactions_Tables), @"mvc.1.0.view", @"/Views/Transactions/Tables.cshtml")]
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
#line 1 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Admin\Views\_ViewImports.cshtml"
using NWBA_Web_Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Admin\Views\_ViewImports.cshtml"
using NWBA_Web_Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"370ef950585fb600d0abe0e093b70014c89e221b", @"/Views/Transactions/Tables.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fba146601a21cdb7e93f3386c899557fed0db37b", @"/Views/_ViewImports.cshtml")]
    public class Views_Transactions_Tables : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NWBA_Web_Admin.Models.Transaction>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Admin\Views\Transactions\Tables.cshtml"
  
    ViewData["Title"] = "Tables";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Statements for </h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Admin\Views\Transactions\Tables.cshtml"
           Write(Html.DisplayNameFor(model => model.TransactionId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Admin\Views\Transactions\Tables.cshtml"
           Write(Html.DisplayNameFor(model => model.TransactionType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Admin\Views\Transactions\Tables.cshtml"
           Write(Html.DisplayNameFor(model => model.AccountNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Admin\Views\Transactions\Tables.cshtml"
           Write(Html.DisplayNameFor(model => model.DestinationAccountNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Admin\Views\Transactions\Tables.cshtml"
           Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Admin\Views\Transactions\Tables.cshtml"
           Write(Html.DisplayNameFor(model => model.Comment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Admin\Views\Transactions\Tables.cshtml"
           Write(Html.DisplayNameFor(model => model.ModifyDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Admin\Views\Transactions\Tables.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Admin\Views\Transactions\Tables.cshtml"
               Write(Html.DisplayFor(modelItem => item.TransactionId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Admin\Views\Transactions\Tables.cshtml"
               Write(Html.DisplayFor(modelItem => item.TransactionType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Admin\Views\Transactions\Tables.cshtml"
               Write(Html.DisplayFor(modelItem => item.AccountNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Admin\Views\Transactions\Tables.cshtml"
               Write(Html.DisplayFor(modelItem => item.DestinationAccountNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Admin\Views\Transactions\Tables.cshtml"
               Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Admin\Views\Transactions\Tables.cshtml"
               Write(Html.DisplayFor(modelItem => item.Comment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Admin\Views\Transactions\Tables.cshtml"
               Write(Html.DisplayFor(modelItem => item.ModifyDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 62 "C:\Users\paula\OneDrive\Desktop\-a3-s3788210-s3782041\NWBA_Web_Admin\Views\Transactions\Tables.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NWBA_Web_Admin.Models.Transaction>> Html { get; private set; }
    }
}
#pragma warning restore 1591
