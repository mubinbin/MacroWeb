#pragma checksum "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Home\_AllUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c361da04caf6394e07dcbf882c8b380ca9d7bbb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__AllUsers), @"mvc.1.0.view", @"/Views/Home/_AllUsers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c361da04caf6394e07dcbf882c8b380ca9d7bbb3", @"/Views/Home/_AllUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f79ae70473930a94ccb32df75e641474257ab182", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__AllUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FollowMultiple", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Home\_AllUsers.cshtml"
  
    Layout=null;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c361da04caf6394e07dcbf882c8b380ca9d7bbb34391", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Home\_AllUsers.cshtml"
      
        foreach(User u in ViewBag.allusers)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div style=\"margin:0 15px 0 15px; cursor: pointer;\">\r\n                <a style=\"font-size:1.4rem;\"");
                BeginWriteAttribute("onclick", " onclick=\"", 271, "\"", 326, 6);
                WriteAttributeValue("", 281, "showModal(\'/userdetail/", 281, 23, true);
#nullable restore
#line 9 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Home\_AllUsers.cshtml"
WriteAttributeValue("", 304, u.UserId, 304, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 313, "\',", 313, 2, true);
                WriteAttributeValue(" ", 315, "\'", 316, 2, true);
#nullable restore
#line 9 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Home\_AllUsers.cshtml"
WriteAttributeValue("", 317, u.Name, 317, 7, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 324, "\')", 324, 2, true);
                EndWriteAttribute();
                WriteLiteral("><i title=\"Profile\" class=\"text-dark fas fa-user\"></i> ");
#nullable restore
#line 9 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Home\_AllUsers.cshtml"
                                                                                                                                                      Write(u.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                <input name=\"UsersAreChecked\" type=\"checkbox\"");
                BeginWriteAttribute("value", " value=\"", 456, "\"", 473, 1);
#nullable restore
#line 10 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Home\_AllUsers.cshtml"
WriteAttributeValue("", 464, u.UserId, 464, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            </div>\r\n");
#nullable restore
#line 12 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Home\_AllUsers.cshtml"
        }
    

#line default
#line hidden
#nullable disable
                WriteLiteral("    <button class=\"btn btn-primary btn-sm d-block mt-2\">Follow</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
