#pragma checksum "C:\Users\memil\OneDrive - Ivri\MemiWebSite\Courses\Architecting Application for Microsoft Azure - The Complete Guide\Resources\DemoApp\inventory\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "041d6241795e91cb6cae410b6f7db2b0d4a95d54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(inventory.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace inventory.Pages
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
#line 1 "C:\Users\memil\OneDrive - Ivri\MemiWebSite\Courses\Architecting Application for Microsoft Azure - The Complete Guide\Resources\DemoApp\inventory\Pages\_ViewImports.cshtml"
using inventory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\memil\OneDrive - Ivri\MemiWebSite\Courses\Architecting Application for Microsoft Azure - The Complete Guide\Resources\DemoApp\inventory\Pages\Index.cshtml"
using Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"041d6241795e91cb6cae410b6f7db2b0d4a95d54", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01306ad4e99ef26b91cd06313e28a3e6f20429d4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "saveInventory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\memil\OneDrive - Ivri\MemiWebSite\Courses\Architecting Application for Microsoft Azure - The Complete Guide\Resources\DemoApp\inventory\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-5\">Manage Inventory</h1>\r\n");
#nullable restore
#line 12 "C:\Users\memil\OneDrive - Ivri\MemiWebSite\Courses\Architecting Application for Microsoft Azure - The Complete Guide\Resources\DemoApp\inventory\Pages\Index.cshtml"
     if (ViewData["books"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table class=\"table\">\r\n            <tr>\r\n                <th>Name</th>\r\n                <th>Author</th>\r\n                <th>Pages</th>\r\n                <th>Price</th>\r\n                <th></th>\r\n            </tr>\r\n\r\n\r\n");
#nullable restore
#line 24 "C:\Users\memil\OneDrive - Ivri\MemiWebSite\Courses\Architecting Application for Microsoft Azure - The Complete Guide\Resources\DemoApp\inventory\Pages\Index.cshtml"
             foreach (var book in ViewData["books"] as List<inventory.Models.Book>)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 28 "C:\Users\memil\OneDrive - Ivri\MemiWebSite\Courses\Architecting Application for Microsoft Azure - The Complete Guide\Resources\DemoApp\inventory\Pages\Index.cshtml"
                   Write(Html.DisplayFor(m=>book.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 31 "C:\Users\memil\OneDrive - Ivri\MemiWebSite\Courses\Architecting Application for Microsoft Azure - The Complete Guide\Resources\DemoApp\inventory\Pages\Index.cshtml"
                   Write(Html.DisplayFor(m=>book.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 34 "C:\Users\memil\OneDrive - Ivri\MemiWebSite\Courses\Architecting Application for Microsoft Azure - The Complete Guide\Resources\DemoApp\inventory\Pages\Index.cshtml"
                   Write(Html.DisplayFor(m=>book.Pages));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 37 "C:\Users\memil\OneDrive - Ivri\MemiWebSite\Courses\Architecting Application for Microsoft Azure - The Complete Guide\Resources\DemoApp\inventory\Pages\Index.cshtml"
                   Write(Html.DisplayFor(m=>book.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "041d6241795e91cb6cae410b6f7db2b0d4a95d547197", async() => {
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"bookId\"");
                BeginWriteAttribute("value", " value=\"", 1169, "\"", 1185, 1);
#nullable restore
#line 41 "C:\Users\memil\OneDrive - Ivri\MemiWebSite\Courses\Architecting Application for Microsoft Azure - The Complete Guide\Resources\DemoApp\inventory\Pages\Index.cshtml"
WriteAttributeValue("", 1177, book.ID, 1177, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            ");
#nullable restore
#line 42 "C:\Users\memil\OneDrive - Ivri\MemiWebSite\Courses\Architecting Application for Microsoft Azure - The Complete Guide\Resources\DemoApp\inventory\Pages\Index.cshtml"
                       Write(Html.TextBoxFor(m=>book.InStock));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            <button>Save</button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 47 "C:\Users\memil\OneDrive - Ivri\MemiWebSite\Courses\Architecting Application for Microsoft Azure - The Complete Guide\Resources\DemoApp\inventory\Pages\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n");
#nullable restore
#line 49 "C:\Users\memil\OneDrive - Ivri\MemiWebSite\Courses\Architecting Application for Microsoft Azure - The Complete Guide\Resources\DemoApp\inventory\Pages\Index.cshtml"
    }
    else  {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br/>\r\n        <h2 class=\"display-7\">Nothing to see here folks :-)</h2>\r\n");
#nullable restore
#line 53 "C:\Users\memil\OneDrive - Ivri\MemiWebSite\Courses\Architecting Application for Microsoft Azure - The Complete Guide\Resources\DemoApp\inventory\Pages\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 55 "C:\Users\memil\OneDrive - Ivri\MemiWebSite\Courses\Architecting Application for Microsoft Azure - The Complete Guide\Resources\DemoApp\inventory\Pages\Index.cshtml"
     if (ViewData["Error"]!=null)  {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p style=\'color: red\'>");
#nullable restore
#line 56 "C:\Users\memil\OneDrive - Ivri\MemiWebSite\Courses\Architecting Application for Microsoft Azure - The Complete Guide\Resources\DemoApp\inventory\Pages\Index.cshtml"
                         Write(ViewData["Error"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 57 "C:\Users\memil\OneDrive - Ivri\MemiWebSite\Courses\Architecting Application for Microsoft Azure - The Complete Guide\Resources\DemoApp\inventory\Pages\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
