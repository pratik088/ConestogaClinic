#pragma checksum "D:\Conestoga\CAD\Sem2\MicrosoftWeb\PSPatients\PSPatients\Views\PSMedication\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92df133139688732b46b4dd05127a605b941f818"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PSMedication_Delete), @"mvc.1.0.view", @"/Views/PSMedication/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PSMedication/Delete.cshtml", typeof(AspNetCore.Views_PSMedication_Delete))]
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
#line 1 "D:\Conestoga\CAD\Sem2\MicrosoftWeb\PSPatients\PSPatients\Views\_ViewImports.cshtml"
using PSPatients;

#line default
#line hidden
#line 2 "D:\Conestoga\CAD\Sem2\MicrosoftWeb\PSPatients\PSPatients\Views\_ViewImports.cshtml"
using PSPatients.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92df133139688732b46b4dd05127a605b941f818", @"/Views/PSMedication/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b056b5a2f96d1068ba260f4f20a3b4a556465ff", @"/Views/_ViewImports.cshtml")]
    public class Views_PSMedication_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PSPatients.Models.Medication>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Conestoga\CAD\Sem2\MicrosoftWeb\PSPatients\PSPatients\Views\PSMedication\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(81, 32, true);
            WriteLiteral("\r\n    <h1>Delete Medication for ");
            EndContext();
            BeginContext(114, 26, false);
#line 7 "D:\Conestoga\CAD\Sem2\MicrosoftWeb\PSPatients\PSPatients\Views\PSMedication\Delete.cshtml"
                         Write(ViewBag.MedicationTypeName);

#line default
#line hidden
            EndContext();
            BeginContext(140, 168, true);
            WriteLiteral("</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Medication</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-4\">\r\n            ");
            EndContext();
            BeginContext(309, 40, false);
#line 15 "D:\Conestoga\CAD\Sem2\MicrosoftWeb\PSPatients\PSPatients\Views\PSMedication\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(349, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dt class=\"col-sm-8\">\r\n            ");
            EndContext();
            BeginContext(410, 36, false);
#line 18 "D:\Conestoga\CAD\Sem2\MicrosoftWeb\PSPatients\PSPatients\Views\PSMedication\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(446, 66, true);
            WriteLiteral("\r\n            </dt>\r\n        <dt class = \"col-sm-4\">\r\n            ");
            EndContext();
            BeginContext(513, 41, false);
#line 21 "D:\Conestoga\CAD\Sem2\MicrosoftWeb\PSPatients\PSPatients\Views\PSMedication\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(554, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dt class=\"col-sm-8\">\r\n            ");
            EndContext();
            BeginContext(615, 37, false);
#line 24 "D:\Conestoga\CAD\Sem2\MicrosoftWeb\PSPatients\PSPatients\Views\PSMedication\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(652, 52, true);
            WriteLiteral("\r\n        </dt><dt class = \"col-sm-4\">\r\n            ");
            EndContext();
            BeginContext(705, 49, false);
#line 26 "D:\Conestoga\CAD\Sem2\MicrosoftWeb\PSPatients\PSPatients\Views\PSMedication\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Concentration));

#line default
#line hidden
            EndContext();
            BeginContext(754, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dt class=\"col-sm-8\">\r\n            ");
            EndContext();
            BeginContext(815, 45, false);
#line 29 "D:\Conestoga\CAD\Sem2\MicrosoftWeb\PSPatients\PSPatients\Views\PSMedication\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Concentration));

#line default
#line hidden
            EndContext();
            BeginContext(860, 62, true);
            WriteLiteral("\r\n        </dt>\r\n        <dt class = \"col-sm-4\">\r\n            ");
            EndContext();
            BeginContext(923, 63, false);
#line 32 "D:\Conestoga\CAD\Sem2\MicrosoftWeb\PSPatients\PSPatients\Views\PSMedication\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ConcentrationCodeNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(986, 62, true);
            WriteLiteral("\r\n        </dt>\r\n        <dt class = \"col-sm-8\">\r\n            ");
            EndContext();
            BeginContext(1049, 77, false);
#line 35 "D:\Conestoga\CAD\Sem2\MicrosoftWeb\PSPatients\PSPatients\Views\PSMedication\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ConcentrationCodeNavigation.ConcentrationCode));

#line default
#line hidden
            EndContext();
            BeginContext(1126, 68, true);
            WriteLiteral("\r\n        </dt class>\r\n        <dt class = \"col-sm-4\">\r\n            ");
            EndContext();
            BeginContext(1195, 60, false);
#line 38 "D:\Conestoga\CAD\Sem2\MicrosoftWeb\PSPatients\PSPatients\Views\PSMedication\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DispensingCodeNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1255, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dt class=\"col-sm-8\">\r\n            ");
            EndContext();
            BeginContext(1316, 71, false);
#line 41 "D:\Conestoga\CAD\Sem2\MicrosoftWeb\PSPatients\PSPatients\Views\PSMedication\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DispensingCodeNavigation.DispensingCode));

#line default
#line hidden
            EndContext();
            BeginContext(1387, 62, true);
            WriteLiteral("\r\n        </dt>\r\n        <dt class = \"col-sm-4\">\r\n            ");
            EndContext();
            BeginContext(1450, 50, false);
#line 44 "D:\Conestoga\CAD\Sem2\MicrosoftWeb\PSPatients\PSPatients\Views\PSMedication\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MedicationType));

#line default
#line hidden
            EndContext();
            BeginContext(1500, 62, true);
            WriteLiteral("\r\n        </dt>\r\n        <dt class = \"col-sm-8\">\r\n            ");
            EndContext();
            BeginContext(1563, 51, false);
#line 47 "D:\Conestoga\CAD\Sem2\MicrosoftWeb\PSPatients\PSPatients\Views\PSMedication\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MedicationType.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1614, 44, true);
            WriteLiteral("\r\n        </dt class>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1658, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92df133139688732b46b4dd05127a605b941f81810708", async() => {
                BeginContext(1684, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1694, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "92df133139688732b46b4dd05127a605b941f81811101", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 52 "D:\Conestoga\CAD\Sem2\MicrosoftWeb\PSPatients\PSPatients\Views\PSMedication\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Din);

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
                BeginContext(1731, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(1814, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92df133139688732b46b4dd05127a605b941f81813018", async() => {
                    BeginContext(1836, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
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
                EndContext();
                BeginContext(1852, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
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
            EndContext();
            BeginContext(1865, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PSPatients.Models.Medication> Html { get; private set; }
    }
}
#pragma warning restore 1591
