#pragma checksum "C:\Users\joshua.lee\Documents\GitHub\LogManagerWebApp\LogManagerWebApp\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45c353b38adc9eaeadc6b5227a9bf4a243cf190f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LogManagerWebApp.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(LogManagerWebApp.Pages.Pages_Index), null)]
namespace LogManagerWebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\joshua.lee\Documents\GitHub\LogManagerWebApp\LogManagerWebApp\Pages\_ViewImports.cshtml"
using LogManagerWebApp;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45c353b38adc9eaeadc6b5227a9bf4a243cf190f", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"462ae52a2993d6da16c7d486fbfdf52638933a31", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 122, true);
            WriteLiteral("\r\n\r\n\r\n\r\n    <div class=\"section-wrapper\">\r\n\r\n        <div class=\"section-content\">\r\n            <h2 class=\"section-title\">");
            EndContext();
            BeginContext(149, 11, false);
#line 10 "C:\Users\joshua.lee\Documents\GitHub\LogManagerWebApp\LogManagerWebApp\Pages\Index.cshtml"
                                 Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(160, 21, true);
            WriteLiteral("</h2>\r\n\r\n            ");
            EndContext();
            BeginContext(181, 438, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "018266323130407a918ce1644505c1eb", async() => {
                BeginContext(200, 115, true);
                WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    <div class=\"input-group\">\r\n                        ");
                EndContext();
                BeginContext(315, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ce92fa1baf5e45898910a0cc219650fb", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 15 "C:\Users\joshua.lee\Documents\GitHub\LogManagerWebApp\LogManagerWebApp\Pages\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchTerm);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(380, 232, true);
                WriteLiteral("\r\n                        <span class=\"input-group-btn\">\r\n                            <button class=\"btn btn-default\">Search</button>\r\n                        </span>\r\n                    </div>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(619, 538, true);
            WriteLiteral(@"

            <table class=""log-table table"">
                <thead class=""thead-dark"">
                    <th>ID</th>
                    <th>Name</th>
                    <th>Last Modified</th>
                    <div class=""table-icons-title"">
                        <th>View</th>
                        <th>Edit</th>
                        <th>Delete</th>
                        <th>Timestamp</th>
                        <th>Save</th>
                    </div>
                </thead>
                <hr />
");
            EndContext();
#line 37 "C:\Users\joshua.lee\Documents\GitHub\LogManagerWebApp\LogManagerWebApp\Pages\Index.cshtml"
                 foreach (var log in Model.Logs)
                {

#line default
#line hidden
            BeginContext(1226, 68, true);
            WriteLiteral("                <tr class=\"table-results\">\r\n                    <td>");
            EndContext();
            BeginContext(1295, 6, false);
#line 40 "C:\Users\joshua.lee\Documents\GitHub\LogManagerWebApp\LogManagerWebApp\Pages\Index.cshtml"
                   Write(log.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1301, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1333, 8, false);
#line 41 "C:\Users\joshua.lee\Documents\GitHub\LogManagerWebApp\LogManagerWebApp\Pages\Index.cshtml"
                   Write(log.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1341, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1373, 16, false);
#line 42 "C:\Users\joshua.lee\Documents\GitHub\LogManagerWebApp\LogManagerWebApp\Pages\Index.cshtml"
                   Write(log.LastModified);

#line default
#line hidden
            EndContext();
            BeginContext(1389, 63, true);
            WriteLiteral("</td>\r\n                    <td class=\"btn\" asp-page=\"./ViewLog\"");
            EndContext();
            BeginWriteAttribute("asp-route-logId", " asp-route-logId=\"", 1452, "\"", 1477, 1);
#line 43 "C:\Users\joshua.lee\Documents\GitHub\LogManagerWebApp\LogManagerWebApp\Pages\Index.cshtml"
WriteAttributeValue("", 1470, log.Id, 1470, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1478, 138, true);
            WriteLiteral(">\r\n                        <i class=\"fas fa-eye\"></i>\r\n                    </td>\r\n                    <td class=\"btn\" asp-page=\"./EditLog\"");
            EndContext();
            BeginWriteAttribute("asp-route-logId", " asp-route-logId=\"", 1616, "\"", 1641, 1);
#line 46 "C:\Users\joshua.lee\Documents\GitHub\LogManagerWebApp\LogManagerWebApp\Pages\Index.cshtml"
WriteAttributeValue("", 1634, log.Id, 1634, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1642, 141, true);
            WriteLiteral(">\r\n                        <i class=\"fas fa-edit\"></i>\r\n                    </td>\r\n                    <td class=\"btn\" asp-page=\"./DeleteLog\"");
            EndContext();
            BeginWriteAttribute("asp-route-logId", " asp-route-logId=\"", 1783, "\"", 1808, 1);
#line 49 "C:\Users\joshua.lee\Documents\GitHub\LogManagerWebApp\LogManagerWebApp\Pages\Index.cshtml"
WriteAttributeValue("", 1801, log.Id, 1801, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1809, 145, true);
            WriteLiteral(">\r\n                        <i class=\"fas fa-trash-alt\"></i>\r\n                    </td>\r\n                    <td class=\"btn\" asp-page=\"./StampLog\"");
            EndContext();
            BeginWriteAttribute("asp-route-logId", " asp-route-logId=\"", 1954, "\"", 1979, 1);
#line 52 "C:\Users\joshua.lee\Documents\GitHub\LogManagerWebApp\LogManagerWebApp\Pages\Index.cshtml"
WriteAttributeValue("", 1972, log.Id, 1972, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1980, 140, true);
            WriteLiteral(">\r\n                        <i class=\"fas fa-stamp\"></i>\r\n                    </td>\r\n                    <td class=\"btn\" asp-page=\"./SaveLog\"");
            EndContext();
            BeginWriteAttribute("asp-route-logId", " asp-route-logId=\"", 2120, "\"", 2145, 1);
#line 55 "C:\Users\joshua.lee\Documents\GitHub\LogManagerWebApp\LogManagerWebApp\Pages\Index.cshtml"
WriteAttributeValue("", 2138, log.Id, 2138, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2146, 106, true);
            WriteLiteral(">\r\n                        <i class=\"fas fa-save\"></i>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 59 "C:\Users\joshua.lee\Documents\GitHub\LogManagerWebApp\LogManagerWebApp\Pages\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2271, 48, true);
            WriteLiteral("            </table>\r\n        </div>\r\n    </div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
