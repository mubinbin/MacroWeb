#pragma checksum "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Home\UserDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22944c7ffa20ccfbb1b515b13de1f966f34b1684"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserDetail), @"mvc.1.0.view", @"/Views/Home/UserDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22944c7ffa20ccfbb1b515b13de1f966f34b1684", @"/Views/Home/UserDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f79ae70473930a94ccb32df75e641474257ab182", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MacroWeb.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle d-block mx-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/profile1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Follow", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Home\UserDetail.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"edit-profile\">\r\n");
#nullable restore
#line 6 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Home\UserDetail.cshtml"
  
    if(ViewBag.UserToView.ImagePath == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "22944c7ffa20ccfbb1b515b13de1f966f34b16845528", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 10 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Home\UserDetail.cshtml"

    }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <img class=\"rounded-circle d-block mx-auto\"");
            BeginWriteAttribute("src", " src=\"", 310, "\"", 345, 1);
#nullable restore
#line 12 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Home\UserDetail.cshtml"
WriteAttributeValue("", 316, ViewBag.UserToView.ImagePath, 316, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"150\" height=\"150\">\r\n");
#nullable restore
#line 13 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Home\UserDetail.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div style=\"height: 30px; width: 50px; margin-left: 60%;\" id=\"follow-icon\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "22944c7ffa20ccfbb1b515b13de1f966f34b16847724", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 18 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Home\UserDetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData = ViewData;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("view-data", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n    \r\n");
#nullable restore
#line 21 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Home\UserDetail.cshtml"
      
        if(ViewBag.UserToView == ViewBag.curuser)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h5 style=\"width: 150px;\" class=\"mx-auto text-center\">");
#nullable restore
#line 24 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Home\UserDetail.cshtml"
                                                         Write(ViewBag.curuser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <a style=\"cursor: pointer; color: gray; text-decoration: none;\" onclick=\"editprofile(\'/editprofile\')\"> <i title=\"Edit Profile\" class=\"fas fa-pencil-alt\"></i></a></h5>\r\n");
#nullable restore
#line 25 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Home\UserDetail.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n<div class=\"d-flex justify-content-around\">\r\n    <p class=\"col-sm-4\"><span style=\"font-weight-bold; color: orange;\">");
#nullable restore
#line 31 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Home\UserDetail.cshtml"
                                                                  Write(ViewBag.UserToView.UsersFollowed.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <span style=\"color: darkblue;\">Following</span></p>\r\n    <p class=\"col-sm-4\"><span style=\"font-weight-bold; color: orange;\">");
#nullable restore
#line 32 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Home\UserDetail.cshtml"
                                                                  Write(ViewBag.UserToView.Followers.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <span style=\"color: darkblue;\">Followers</span></p>\r\n</div>\r\n<p style=\"text-align: center; font-weight-bold;\">Joined ");
#nullable restore
#line 34 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Home\UserDetail.cshtml"
                                                   Write(ViewBag.UserToView.CreatedAt.ToString("MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n<div>\r\n");
            WriteLiteral("    <h6>Current time: ");
#nullable restore
#line 41 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Home\UserDetail.cshtml"
                 Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MacroWeb.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
