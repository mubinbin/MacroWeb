#pragma checksum "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Message\_SpiralMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88222f725a58df19196a8e62c559ccf3384644c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message__SpiralMessage), @"mvc.1.0.view", @"/Views/Message/_SpiralMessage.cshtml")]
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
#line 1 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\_ViewImports.cshtml"
using MacroWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\_ViewImports.cshtml"
using MacroWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\_ViewImports.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88222f725a58df19196a8e62c559ccf3384644c1", @"/Views/Message/_SpiralMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f79ae70473930a94ccb32df75e641474257ab182", @"/Views/_ViewImports.cshtml")]
    public class Views_Message__SpiralMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MacroWeb.Models.Message>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return mespost(this);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Message", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProcessSpiral", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Message\_SpiralMessage.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88222f725a58df19196a8e62c559ccf3384644c14893", async() => {
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <textarea class=\"form-control\" rows=\"4\" id=\"message-text\" name=\"SpiralContent\" for=\"SpiralContent\">Retweet Post</textarea>\r\n    </div>\r\n    <input type=\"hidden\" name=\"UserId\" for=\"UserId\"");
                BeginWriteAttribute("value", " value = \"", 395, "\"", 428, 1);
#nullable restore
#line 11 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Message\_SpiralMessage.cshtml"
WriteAttributeValue("", 405, ViewBag.curuser.UserId, 405, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <input type=\"hidden\" name=\"CenterId\" for=\"CenterId\"");
                BeginWriteAttribute("value", " value=\"", 487, "\"", 524, 1);
#nullable restore
#line 12 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Message\_SpiralMessage.cshtml"
WriteAttributeValue("", 495, ViewBag.curMessage.MessageId, 495, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <input type=\"hidden\" name=\"IsSpiral\" for=\"IsSpiral\" value=\"true\">\r\n    \r\n    <input class=\"btn btn-primary w-100\" type=\"submit\" value=\"Retweet\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div class=\"mt-3 border border-dark px-3 pt-2\">\r\n    <div class=\"font-weight-bold\">\r\n        <a class=\"text-primary\" style=\"cursor: pointer;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 828, "\"", 933, 6);
            WriteAttributeValue("", 838, "showModal(\'/userdetail/", 838, 23, true);
#nullable restore
#line 19 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Message\_SpiralMessage.cshtml"
WriteAttributeValue("", 861, ViewBag.curMessage.Creator.UserId, 861, 34, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 895, "\',", 895, 2, true);
            WriteAttributeValue(" ", 897, "\'", 898, 2, true);
#nullable restore
#line 19 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Message\_SpiralMessage.cshtml"
WriteAttributeValue("", 899, ViewBag.curMessage.Creator.Name, 899, 32, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 931, "\')", 931, 2, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 19 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Message\_SpiralMessage.cshtml"
                                                                                                                                                              Write(ViewBag.curMessage.Creator.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> - <span class=\"text-secondary\">");
#nullable restore
#line 19 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Message\_SpiralMessage.cshtml"
                                                                                                                                                                                                                                  Write(ViewBag.curMessage.UpdatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n    <div class=\"py-2\">");
#nullable restore
#line 21 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Message\_SpiralMessage.cshtml"
                 Write(ViewBag.curMessage.MessageContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MacroWeb.Models.Message> Html { get; private set; }
    }
}
#pragma warning restore 1591
