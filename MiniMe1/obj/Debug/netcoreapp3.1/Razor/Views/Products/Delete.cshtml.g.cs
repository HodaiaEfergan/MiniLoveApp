#pragma checksum "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88140230c7aece23e96fde449135cffa5b8d4004"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Delete), @"mvc.1.0.view", @"/Views/Products/Delete.cshtml")]
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
#line 1 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\_ViewImports.cshtml"
using MiniMe1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\_ViewImports.cshtml"
using MiniMe1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88140230c7aece23e96fde449135cffa5b8d4004", @"/Views/Products/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66327196693b9adf488384dcc3d93a5e3de910bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sharedAngular.Models.Products>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Products</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NewPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NewPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Size));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Size));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Size2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Size2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Size3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Size3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Size4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Size4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Size5));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Size5));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 87 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Size6));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 90 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Size6));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 93 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Size7));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 96 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Size7));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 99 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Size8));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 102 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Size8));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 105 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Size9));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 108 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Size9));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 111 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Size10));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 114 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Size10));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 117 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Colors));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 120 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Colors));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 123 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Colors2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 126 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Colors2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 129 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Colors3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 132 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Colors3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 135 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Colors4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 138 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Colors4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 141 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Time));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 144 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Time));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 147 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NumOfSale));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 150 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NumOfSale));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 153 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.OnSale));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 156 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.OnSale));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 159 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Pictures));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 162 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Pictures));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 165 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Pictures2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 168 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Pictures2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 171 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Pictures3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 174 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Pictures3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 177 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Pictures4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 180 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Pictures4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 183 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Pictures5));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 186 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Pictures5));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88140230c7aece23e96fde449135cffa5b8d400423643", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "88140230c7aece23e96fde449135cffa5b8d400423910", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 191 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88140230c7aece23e96fde449135cffa5b8d400425704", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sharedAngular.Models.Products> Html { get; private set; }
    }
}
#pragma warning restore 1591
