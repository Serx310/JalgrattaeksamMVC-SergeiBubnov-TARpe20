#pragma checksum "C:\Users\serge\source\repos\JalgrattaeksamMVC\JalgrattaeksamMVC\Views\Eksams\Teooria.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8411c716e0844f176525ab009eae2ae335d02ae3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Eksams_Teooria), @"mvc.1.0.view", @"/Views/Eksams/Teooria.cshtml")]
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
#line 1 "C:\Users\serge\source\repos\JalgrattaeksamMVC\JalgrattaeksamMVC\Views\_ViewImports.cshtml"
using JalgrattaeksamMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\serge\source\repos\JalgrattaeksamMVC\JalgrattaeksamMVC\Views\_ViewImports.cshtml"
using JalgrattaeksamMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8411c716e0844f176525ab009eae2ae335d02ae3", @"/Views/Eksams/Teooria.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf8bf3d18daad29e76e54a13aaf653bd6a55b98e", @"/Views/_ViewImports.cshtml")]
    public class Views_Eksams_Teooria : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JalgrattaeksamMVC.Models.Eksam>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Registreeri", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TeooriaTulemus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\serge\source\repos\JalgrattaeksamMVC\JalgrattaeksamMVC\Views\Eksams\Teooria.cshtml"
  
    ViewData["Title"] = "Teooria";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Teooria</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8411c716e0844f176525ab009eae2ae335d02ae34340", async() => {
                WriteLiteral("Registreeri");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\serge\source\repos\JalgrattaeksamMVC\JalgrattaeksamMVC\Views\Eksams\Teooria.cshtml"
           Write(Html.DisplayNameFor(model => model.Eesnimi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\serge\source\repos\JalgrattaeksamMVC\JalgrattaeksamMVC\Views\Eksams\Teooria.cshtml"
           Write(Html.DisplayNameFor(model => model.Perenimi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\serge\source\repos\JalgrattaeksamMVC\JalgrattaeksamMVC\Views\Eksams\Teooria.cshtml"
           Write(Html.DisplayNameFor(model => model.Teooria));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\serge\source\repos\JalgrattaeksamMVC\JalgrattaeksamMVC\Views\Eksams\Teooria.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\serge\source\repos\JalgrattaeksamMVC\JalgrattaeksamMVC\Views\Eksams\Teooria.cshtml"
           Write(Html.DisplayFor(modelItem => item.Eesnimi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\serge\source\repos\JalgrattaeksamMVC\JalgrattaeksamMVC\Views\Eksams\Teooria.cshtml"
           Write(Html.DisplayFor(modelItem => item.Perenimi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8411c716e0844f176525ab009eae2ae335d02ae37572", async() => {
                WriteLiteral("\r\n                    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 945, "\"", 961, 1);
#nullable restore
#line 38 "C:\Users\serge\source\repos\JalgrattaeksamMVC\JalgrattaeksamMVC\Views\Eksams\Teooria.cshtml"
WriteAttributeValue("", 953, item.Id, 953, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 962, "\"", 985, 1);
#nullable restore
#line 38 "C:\Users\serge\source\repos\JalgrattaeksamMVC\JalgrattaeksamMVC\Views\Eksams\Teooria.cshtml"
WriteAttributeValue("", 969, nameof(item.Id), 969, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <div class=\"d-flex\">\r\n                        <div class=\"form-group mr-1\">\r\n                            <input type=\"number\"");
                BeginWriteAttribute("value", " value=\"", 1136, "\"", 1157, 1);
#nullable restore
#line 41 "C:\Users\serge\source\repos\JalgrattaeksamMVC\JalgrattaeksamMVC\Views\Eksams\Teooria.cshtml"
WriteAttributeValue("", 1144, item.Teooria, 1144, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=\"", 1158, "\"", 1186, 1);
#nullable restore
#line 41 "C:\Users\serge\source\repos\JalgrattaeksamMVC\JalgrattaeksamMVC\Views\Eksams\Teooria.cshtml"
WriteAttributeValue("", 1165, nameof(item.Teooria), 1165, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" min=""-1"" max=""10"" class=""form-control"" />
                        </div>
                        <div class=""form-group"">
                            <input type=""submit"" value=""Salvesta"" class=""btn btn-primary"" />
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                \r\n");
            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 56 "C:\Users\serge\source\repos\JalgrattaeksamMVC\JalgrattaeksamMVC\Views\Eksams\Teooria.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<JalgrattaeksamMVC.Models.Eksam>> Html { get; private set; }
    }
}
#pragma warning restore 1591
