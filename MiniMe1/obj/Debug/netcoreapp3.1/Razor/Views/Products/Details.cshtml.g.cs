#pragma checksum "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3f3a641f027b909a3469bd5a2a989b669997782"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Details), @"mvc.1.0.view", @"/Views/Products/Details.cshtml")]
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
#nullable restore
#line 1 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3f3a641f027b909a3469bd5a2a989b669997782", @"/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66327196693b9adf488384dcc3d93a5e3de910bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sharedAngular.Models.Products>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToLike", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:black"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
  
    ViewData["Title"] = Html.DisplayFor(model => model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\" style=\"margin-top:30px\">\r\n    <div class=\"row\">\r\n\r\n        <div class=\"col-sm\">\r\n\r\n            <div class=\"fakeimg\"><img");
            BeginWriteAttribute("src", " src=", 288, "", 334, 1);
#nullable restore
#line 12 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
WriteAttributeValue("", 293, Html.DisplayFor(model => model.Pictures), 293, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"300px\"></div><br>\r\n        </div>\r\n\r\n\r\n\r\n\r\n        <div class=\"col-sm\">\r\n\r\n            <h2>");
#nullable restore
#line 20 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
           Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n            <p>");
#nullable restore
#line 22 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
          Write(Html.DisplayNameFor(model => model.Colors));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n            <button type=\"button\" class=\"btn btn-dark\">");
#nullable restore
#line 24 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
                                                  Write(Html.DisplayFor(model => model.Colors));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n\r\n");
#nullable restore
#line 26 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
             if (Model.Colors2 != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <input type=\"submit\" class=\"btn btn-dark\"");
            BeginWriteAttribute("value", " value=\"", 765, "\"", 813, 1);
#nullable restore
#line 28 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
WriteAttributeValue("", 773, Html.DisplayFor(model => model.Colors2), 773, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 29 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
             if (Model.Colors3 != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <input type=\"submit\" class=\"btn btn-dark\"");
            BeginWriteAttribute("value", " value=\"", 947, "\"", 995, 1);
#nullable restore
#line 32 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
WriteAttributeValue("", 955, Html.DisplayFor(model => model.Colors3), 955, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 33 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
             if (Model.Colors4 != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <input type=\"submit\" class=\"btn btn-dark\"");
            BeginWriteAttribute("value", " value=\"", 1129, "\"", 1177, 1);
#nullable restore
#line 36 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
WriteAttributeValue("", 1137, Html.DisplayFor(model => model.Colors4), 1137, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 37 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n            <p>");
#nullable restore
#line 41 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
          Write(Html.DisplayNameFor(model => model.Size));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <in type=\"button\" class=\"btn btn-dark\">");
#nullable restore
#line 42 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
                                              Write(Html.DisplayFor(model => model.Size));

#line default
#line hidden
#nullable disable
            WriteLiteral("</in>\r\n\r\n");
#nullable restore
#line 44 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
             if (Model.Size2 > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <input type=\"submit\" class=\"btn btn-dark\"");
            BeginWriteAttribute("value", " value=\"", 1470, "\"", 1516, 1);
#nullable restore
#line 46 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
WriteAttributeValue("", 1478, Html.DisplayFor(model => model.Size2), 1478, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 47 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 49 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
             if (Model.Size3 > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <input type=\"submit\" class=\"btn btn-dark\"");
            BeginWriteAttribute("value", " value=\"", 1644, "\"", 1690, 1);
#nullable restore
#line 51 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
WriteAttributeValue("", 1652, Html.DisplayFor(model => model.Size3), 1652, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 52 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
             if (Model.Size4 > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <input type=\"submit\" class=\"btn btn-dark\"");
            BeginWriteAttribute("value", " value=\"", 1816, "\"", 1862, 1);
#nullable restore
#line 55 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
WriteAttributeValue("", 1824, Html.DisplayFor(model => model.Size4), 1824, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 56 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
             if (Model.Size5 > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <input type=\"submit\" class=\"btn btn-dark\"");
            BeginWriteAttribute("value", " value=\"", 1988, "\"", 2034, 1);
#nullable restore
#line 59 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
WriteAttributeValue("", 1996, Html.DisplayFor(model => model.Size5), 1996, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 60 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
             if (Model.Size6 > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <input type=\"submit\" class=\"btn btn-dark\"");
            BeginWriteAttribute("value", " value=\"", 2160, "\"", 2206, 1);
#nullable restore
#line 63 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
WriteAttributeValue("", 2168, Html.DisplayFor(model => model.Size6), 2168, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 64 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
             if (Model.Size7 > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <input type=\"submit\" class=\"btn btn-dark\"");
            BeginWriteAttribute("value", " value=\"", 2332, "\"", 2378, 1);
#nullable restore
#line 67 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
WriteAttributeValue("", 2340, Html.DisplayFor(model => model.Size7), 2340, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 68 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
             if (Model.Size8 > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <input type=\"submit\" class=\"btn btn-dark\"");
            BeginWriteAttribute("value", " value=\"", 2504, "\"", 2550, 1);
#nullable restore
#line 71 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
WriteAttributeValue("", 2512, Html.DisplayFor(model => model.Size8), 2512, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 72 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
             if (Model.Size9 > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <input type=\"submit\" class=\"btn btn-dark\"");
            BeginWriteAttribute("value", " value=\"", 2676, "\"", 2722, 1);
#nullable restore
#line 75 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
WriteAttributeValue("", 2684, Html.DisplayFor(model => model.Size9), 2684, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 76 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
             if (Model.Size10 > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <input type=\"submit\" class=\"btn btn-dark\"");
            BeginWriteAttribute("value", " value=\"", 2849, "\"", 2896, 1);
#nullable restore
#line 79 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
WriteAttributeValue("", 2857, Html.DisplayFor(model => model.Size10), 2857, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 80 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n            <p>");
#nullable restore
#line 87 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
          Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            <div class=""btn-group"" role=""group"" aria-label=""Basic example"">
                <button type=""button"" class=""btn btn-dark"">-</button>
                <button type=""button"" class=""btn btn-dark"">1</button>
                <button type=""button"" class=""btn btn-dark"">+</button>
            </div>
            <p>");
#nullable restore
#line 93 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
          Write(Html.DisplayFor(model => model.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral(" במלאי!</p>\r\n            <h5>");
#nullable restore
#line 94 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 94 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
                                                      Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ש\"ח</h5>\r\n\r\n            <p><b>פרטים נוספים: </b>");
#nullable restore
#line 96 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
                               Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <br>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3f3a641f027b909a3469bd5a2a989b66999778220806", async() => {
                WriteLiteral("\r\n                <p button type=\"button\" class=\"btn btn-dark\">הוספה לסל</button></p>\r\n\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 98 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
                                        WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3f3a641f027b909a3469bd5a2a989b66999778223082", async() => {
                WriteLiteral("הוסף לסל");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 102 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
                                                                      WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3f3a641f027b909a3469bd5a2a989b66999778225369", async() => {
                WriteLiteral("\r\n                <p button type=\"button\" class=\"btn btn-dark\">הוספה למועדפים</button></p>\r\n\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 103 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
                                        WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3f3a641f027b909a3469bd5a2a989b66999778227651", async() => {
                WriteLiteral("הוסף למועדפים");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 107 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
                                                                      WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-heart"" fill=""currentColor""
                 xmlns=""http://www.w3.org/2000/svg"">
                <path fill-rule=""evenodd""
                      d=""M8 2.748l-.717-.737C5.6.281 2.514.878 1.4 3.053c-.523 1.023-.641 2.5.314 4.385.92 1.815 2.834 3.989 6.286 6.357 3.452-2.368 5.365-4.542 6.286-6.357.955-1.886.838-3.362.314-4.385C13.486.878 10.4.28 8.717 2.01L8 2.748zM8 15C-7.333 4.868 3.279-3.04 7.824 1.143c.06.055.119.112.176.171a3.12 3.12 0 0 1 .176-.17C12.72-3.042 23.333 4.867 8 15z"">
                </path>
            </svg>
            </button>
            </p>
        </div>



    </div>
</div>



<div>
");
#nullable restore
#line 126 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
     if (Context.Session.GetString("manag") != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3f3a641f027b909a3469bd5a2a989b66999778230922", async() => {
                WriteLiteral("ערוך מוצר");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 128 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
                               WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <a>|</a>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3f3a641f027b909a3469bd5a2a989b66999778233104", async() => {
                WriteLiteral("מחק מוצר");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 130 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
                                 WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <a>|</a>\r\n");
#nullable restore
#line 132 "C:\Users\משתמש\Downloads\MiniLoveApp\MiniLoveApp\MiniMe1\Views\Products\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3f3a641f027b909a3469bd5a2a989b66999778235490", async() => {
                WriteLiteral("בחזרה למוצרים");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
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
