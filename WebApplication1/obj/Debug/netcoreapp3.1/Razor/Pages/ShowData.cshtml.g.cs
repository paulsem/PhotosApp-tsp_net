#pragma checksum "C:\Users\Paul\source\repos\PhotosApp\WebApplication1\Pages\ShowData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1dad6fc583fb687095d7b699a28e0bfa450d5de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApplication1.Pages.Pages_ShowData), @"mvc.1.0.razor-page", @"/Pages/ShowData.cshtml")]
namespace WebApplication1.Pages
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
#line 1 "C:\Users\Paul\source\repos\PhotosApp\WebApplication1\Pages\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1dad6fc583fb687095d7b699a28e0bfa450d5de", @"/Pages/ShowData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd66e6c0b2d0593b97c0d67f6f506054866fe040", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ShowData : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Nume/Anotimp/Locatie"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Paul\source\repos\PhotosApp\WebApplication1\Pages\ShowData.cshtml"
  
    ViewData["Title"] = "ShowData";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ShowData</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1dad6fc583fb687095d7b699a28e0bfa450d5de4043", async() => {
                WriteLiteral("\r\n    <p>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b1dad6fc583fb687095d7b699a28e0bfa450d5de4320", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 10 "C:\Users\Paul\source\repos\PhotosApp\WebApplication1\Pages\ShowData.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchString);

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
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Search\" />\r\n    </p>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div style=\"background-color:black;color:white;padding:0px;\">\r\n\r\n");
#nullable restore
#line 16 "C:\Users\Paul\source\repos\PhotosApp\WebApplication1\Pages\ShowData.cshtml"
     foreach (var item in Model.Details)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div style=\"display:inline-block;padding:10px\">\r\n            <div>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 500, "\"", 516, 1);
#nullable restore
#line 20 "C:\Users\Paul\source\repos\PhotosApp\WebApplication1\Pages\ShowData.cshtml"
WriteAttributeValue("", 506, item.Path, 506, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Image\" style=\"height:200px;width:200px;\">\r\n            </div>\r\n            <div>\r\n                <p style=\"display:inline-block;\">Path:</p>\r\n                <p style=\"display:inline-block;\">");
#nullable restore
#line 24 "C:\Users\Paul\source\repos\PhotosApp\WebApplication1\Pages\ShowData.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.Path));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div>\r\n                <p style=\"display:inline-block;\">Locatie:</p>\r\n                <p style=\"display:inline-block;\">");
#nullable restore
#line 28 "C:\Users\Paul\source\repos\PhotosApp\WebApplication1\Pages\ShowData.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.Locatie));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n            </div>\r\n            <div>\r\n                <p style=\"display:inline-block;\">Anotimp:</p>\r\n                <p style=\"display:inline-block;\">");
#nullable restore
#line 33 "C:\Users\Paul\source\repos\PhotosApp\WebApplication1\Pages\ShowData.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.Anotimp));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n            </div>\r\n            <div>\r\n                <p style=\"display:inline-block;\">People:</p>\r\n                <p style=\"display:inline-block;\">");
#nullable restore
#line 38 "C:\Users\Paul\source\repos\PhotosApp\WebApplication1\Pages\ShowData.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.People));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 42 "C:\Users\Paul\source\repos\PhotosApp\WebApplication1\Pages\ShowData.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>     \r\n        <p style=\"display:inline-block;\">Count:</p>\r\n        <p style=\"display:inline-block;\">");
#nullable restore
#line 45 "C:\Users\Paul\source\repos\PhotosApp\WebApplication1\Pages\ShowData.cshtml"
                                    Write(ShowDataModel.aparitii);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n    </div>\r\n</div>\r\n<!--\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 54 "C:\Users\Paul\source\repos\PhotosApp\WebApplication1\Pages\ShowData.cshtml"
           Write(Html.DisplayNameFor(model => model.Details[0].Path));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 57 "C:\Users\Paul\source\repos\PhotosApp\WebApplication1\Pages\ShowData.cshtml"
           Write(Html.DisplayNameFor(model => model.Details[0].Locatie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 60 "C:\Users\Paul\source\repos\PhotosApp\WebApplication1\Pages\ShowData.cshtml"
           Write(Html.DisplayNameFor(model => model.Details[0].Anotimp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 63 "C:\Users\Paul\source\repos\PhotosApp\WebApplication1\Pages\ShowData.cshtml"
           Write(Html.DisplayNameFor(model => model.Details[0].People));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Imagine\r\n            </th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 72 "C:\Users\Paul\source\repos\PhotosApp\WebApplication1\Pages\ShowData.cshtml"
         foreach (var item in Model.Details)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr style=\"font-size:small\">\r\n                <td>\r\n                    ");
#nullable restore
#line 76 "C:\Users\Paul\source\repos\PhotosApp\WebApplication1\Pages\ShowData.cshtml"
               Write(Html.DisplayFor(modelItem => item.Path));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 79 "C:\Users\Paul\source\repos\PhotosApp\WebApplication1\Pages\ShowData.cshtml"
               Write(Html.DisplayFor(modelItem => item.Locatie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 82 "C:\Users\Paul\source\repos\PhotosApp\WebApplication1\Pages\ShowData.cshtml"
               Write(Html.DisplayFor(modelItem => item.Anotimp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 85 "C:\Users\Paul\source\repos\PhotosApp\WebApplication1\Pages\ShowData.cshtml"
               Write(Html.DisplayFor(modelItem => item.People));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>    \r\n                <td>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 2737, "\"", 2753, 1);
#nullable restore
#line 88 "C:\Users\Paul\source\repos\PhotosApp\WebApplication1\Pages\ShowData.cshtml"
WriteAttributeValue("", 2743, item.Path, 2743, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Image\" style=\"height:50px;width:50px;\">\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 91 "C:\Users\Paul\source\repos\PhotosApp\WebApplication1\Pages\ShowData.cshtml"
            
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n\r\n</table>\r\n-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Pages.ShowDataModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication1.Pages.ShowDataModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplication1.Pages.ShowDataModel>)PageContext?.ViewData;
        public WebApplication1.Pages.ShowDataModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
