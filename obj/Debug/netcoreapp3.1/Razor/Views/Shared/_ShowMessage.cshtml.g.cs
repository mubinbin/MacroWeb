#pragma checksum "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25558caf5af531c201226bddaed852be8abe4286"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ShowMessage), @"mvc.1.0.view", @"/Views/Shared/_ShowMessage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25558caf5af531c201226bddaed852be8abe4286", @"/Views/Shared/_ShowMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f79ae70473930a94ccb32df75e641474257ab182", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ShowMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_DeleteMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_DeleteComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
        
    User CurUser = ViewBag.curuser;
    foreach(Message m in Model)
    {   
        if(CurUser.UsersFollowed.Any(u=>u.UserFollowed==m.Creator) ||CurUser == m.Creator)
        {
            if(!m.IsSpiral)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"pl-3 font-weight-bold\">\r\n                    <a class=\"text-primary\" style=\"cursor: pointer;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 380, "\"", 451, 6);
            WriteAttributeValue("", 390, "showModal(\'/userdetail/", 390, 23, true);
#nullable restore
#line 11 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
WriteAttributeValue("", 413, m.Creator.UserId, 413, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 430, "\',", 430, 2, true);
            WriteAttributeValue(" ", 432, "\'", 433, 2, true);
#nullable restore
#line 11 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
WriteAttributeValue("", 434, m.Creator.Name, 434, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 449, "\')", 449, 2, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 11 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                                                                                                                                        Write(m.Creator.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> - <span class=\"text-secondary\">");
#nullable restore
#line 11 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                                                                                                                                                                                           Write(m.UpdatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n                <div class=\"pl-3 py-2\">");
#nullable restore
#line 13 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                                  Write(m.MessageContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 14 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
            }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"pl-3 font-weight-bold\">\r\n                    <a class=\"text-primary\" style=\"cursor: pointer;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 754, "\"", 825, 6);
            WriteAttributeValue("", 764, "showModal(\'/userdetail/", 764, 23, true);
#nullable restore
#line 16 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
WriteAttributeValue("", 787, m.Creator.UserId, 787, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 804, "\',", 804, 2, true);
            WriteAttributeValue(" ", 806, "\'", 807, 2, true);
#nullable restore
#line 16 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
WriteAttributeValue("", 808, m.Creator.Name, 808, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 823, "\')", 823, 2, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 16 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                                                                                                                                        Write(m.Creator.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> - <span class=\"text-secondary\">");
#nullable restore
#line 16 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                                                                                                                                                                                           Write(m.UpdatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n                <div class=\"pl-3 py-2\">");
#nullable restore
#line 18 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                                  Write(m.MessageContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 19 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                                          
                if(m.CenterId!=null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div style=\"font-size: 1 rem;\" class=\"ml-2 pl-3 font-weight-bold\">\r\n                        <a class=\"text-primary\" style=\"cursor: pointer;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1248, "\"", 1333, 6);
            WriteAttributeValue("", 1258, "showModal(\'/userdetail/", 1258, 23, true);
#nullable restore
#line 23 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
WriteAttributeValue("", 1281, m.Center.Creator.UserId, 1281, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1305, "\',", 1305, 2, true);
            WriteAttributeValue(" ", 1307, "\'", 1308, 2, true);
#nullable restore
#line 23 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
WriteAttributeValue("", 1309, m.Center.Creator.Name, 1309, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1331, "\')", 1331, 2, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 23 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                                                                                                                                                          Write(m.Center.Creator.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> - <span class=\"text-secondary\">");
#nullable restore
#line 23 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                                                                                                                                                                                                                    Write(m.Center.UpdatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                    <div style=\"font-size: 1 rem;\" class=\"ml-2 pl-3 py-2\">");
#nullable restore
#line 25 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                                                                     Write(m.Center.MessageContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 26 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div style=\"font-size: 1 rem;\" class=\"ml-2 pl-3 py-2\">Original post has been deleted!</div>\r\n");
#nullable restore
#line 28 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"my-4 row pl-3\">\r\n                <span class=\"col\">\r\n");
#nullable restore
#line 33 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                              
                    if(m.UsersLikedThisMessage.Any(l=>l.UserWhoLiked==ViewBag.curuser))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a class=\"text-danger\" style=\"cursor: pointer;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2044, "\"", 2096, 3);
            WriteAttributeValue("", 2054, "likeorunlike(\'unlikemessage/", 2054, 28, true);
#nullable restore
#line 36 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
WriteAttributeValue("", 2082, m.MessageId, 2082, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2094, "\')", 2094, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i title=\"Unlike\" class=\"fas fa-thumbs-up\"></i> </a>\r\n");
#nullable restore
#line 37 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                    }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a class=\"text-secondary\" style=\"cursor: pointer;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2258, "\"", 2308, 3);
            WriteAttributeValue("", 2268, "likeorunlike(\'likemessage/", 2268, 26, true);
#nullable restore
#line 38 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
WriteAttributeValue("", 2294, m.MessageId, 2294, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2306, "\')", 2306, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i title=\"Like\" class=\"far fa-thumbs-up\"></i> </a>\r\n");
#nullable restore
#line 39 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a style=\"cursor:pointer;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2450, "\"", 2531, 7);
            WriteAttributeValue("", 2460, "showModal(\'/userslikedmessage/", 2460, 30, true);
#nullable restore
#line 41 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
WriteAttributeValue("", 2490, m.MessageId, 2490, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2502, "\',", 2502, 2, true);
            WriteAttributeValue(" ", 2504, "\'Users", 2505, 7, true);
            WriteAttributeValue(" ", 2511, "like", 2512, 5, true);
            WriteAttributeValue(" ", 2516, "this", 2517, 5, true);
            WriteAttributeValue(" ", 2521, "message\')", 2522, 10, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"text-dark\">");
#nullable restore
#line 41 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                                                                                                                                              Write(m.UsersLikedThisMessage.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </span>\r\n\r\n");
            WriteLiteral("                <a id=\"new-comment\" class=\"col text-success\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2705, "\"", 2774, 5);
            WriteAttributeValue("", 2715, "showModal(\'/newcommentpartial/", 2715, 30, true);
#nullable restore
#line 45 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
WriteAttributeValue("", 2745, m.MessageId, 2745, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2757, "\',", 2757, 2, true);
            WriteAttributeValue(" ", 2759, "\'New", 2760, 5, true);
            WriteAttributeValue(" ", 2764, "Comment\')", 2765, 10, true);
            EndWriteAttribute();
            WriteLiteral("><i style=\"cursor: pointer;\" title=\"Reply\" class=\"fa fa-comment\"></i> <span class=\"text-dark\">");
#nullable restore
#line 45 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                                                                                                                                                                                                                           Write(m.CommentsForMessage.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a>\r\n\r\n");
            WriteLiteral("                <a class=\"col text-warning\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2993, "\"", 3069, 6);
            WriteAttributeValue("", 3003, "showModal(\'/spiralpartial/", 3003, 26, true);
#nullable restore
#line 48 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
WriteAttributeValue("", 3029, m.MessageId, 3029, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3041, "\',", 3041, 2, true);
            WriteAttributeValue(" ", 3043, "\'Retweeting", 3044, 12, true);
            WriteAttributeValue(" ", 3055, "below", 3056, 6, true);
            WriteAttributeValue(" ", 3061, "post:\')", 3062, 8, true);
            EndWriteAttribute();
            WriteLiteral("><i style=\"cursor: pointer;\" title=\"Retweet\" class=\"fas fa-broadcast-tower\"></i> <span class=\"text-dark\">");
#nullable restore
#line 48 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                                                                                                                                                                                                                            Write(m.Spirals.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a>\r\n\r\n");
#nullable restore
#line 51 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                                         
                    if(m.Creator == ViewBag.curuser)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a id=\"edit-message\" class=\"col text-info\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3412, "\"", 3483, 5);
            WriteAttributeValue("", 3422, "showModal(\'/editmessagepartial/", 3422, 31, true);
#nullable restore
#line 54 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
WriteAttributeValue("", 3453, m.MessageId, 3453, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3465, "\',", 3465, 2, true);
            WriteAttributeValue(" ", 3467, "\'Edit", 3468, 6, true);
            WriteAttributeValue(" ", 3473, "Message\')", 3474, 10, true);
            EndWriteAttribute();
            WriteLiteral("><i style=\"cursor: pointer;\" title=\"Edit Message\" class=\"fas fa-pencil-alt\"></i></a>\r\n");
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "25558caf5af531c201226bddaed852be8abe428618978", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 56 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = m;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 57 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <hr>\r\n");
#nullable restore
#line 61 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
            
            if(m.CommentsForMessage.Count>0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"pl-3 font-weight-bold\">Comment:</p>\r\n");
#nullable restore
#line 65 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                foreach(Comment c in m.CommentsForMessage)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"pl-5 font-weight-bold\">\r\n                        <a class=\"text-primary\" style=\"cursor: pointer;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4066, "\"", 4137, 6);
            WriteAttributeValue("", 4076, "showModal(\'/userdetail/", 4076, 23, true);
#nullable restore
#line 68 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
WriteAttributeValue("", 4099, c.Creator.UserId, 4099, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4116, "\',", 4116, 2, true);
            WriteAttributeValue(" ", 4118, "\'", 4119, 2, true);
#nullable restore
#line 68 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
WriteAttributeValue("", 4120, c.Creator.Name, 4120, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4135, "\')", 4135, 2, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 68 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                                                                                                                                            Write(c.Creator.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> - <span class=\"text-secondary\">");
#nullable restore
#line 68 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                                                                                                                                                                                               Write(c.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n                        <div style=\"margin-left: 15px; vertical-align:top;\" class=\"d-inline\">\r\n");
#nullable restore
#line 71 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                          
                            if(c.UserLikedThisComment.Any(l=>l.UserWhoLiked==ViewBag.curuser))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a class=\"text-danger\" style=\"cursor: pointer;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4546, "\"", 4598, 3);
            WriteAttributeValue("", 4556, "likeorunlike(\'unlikecomment/", 4556, 28, true);
#nullable restore
#line 74 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
WriteAttributeValue("", 4584, c.CommentId, 4584, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4596, "\')", 4596, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i title=\"Unlike\" class=\"fas fa-thumbs-up\"></i> </a>\r\n");
#nullable restore
#line 75 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                            }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a class=\"text-secondary\" style=\"cursor: pointer;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4776, "\"", 4826, 3);
            WriteAttributeValue("", 4786, "likeorunlike(\'likecomment/", 4786, 26, true);
#nullable restore
#line 76 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
WriteAttributeValue("", 4812, c.CommentId, 4812, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4824, "\')", 4824, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i title=\"Like\" class=\"far fa-thumbs-up\"></i> </a>\r\n");
#nullable restore
#line 77 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a style=\"cursor:pointer; text-decoration: none;\" class=\"text-dark font-weight-normal\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5052, "\"", 5133, 7);
            WriteAttributeValue("", 5062, "showModal(\'/userslikedcomment/", 5062, 30, true);
#nullable restore
#line 79 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
WriteAttributeValue("", 5092, c.CommentId, 5092, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5104, "\',", 5104, 2, true);
            WriteAttributeValue(" ", 5106, "\'Users", 5107, 7, true);
            WriteAttributeValue(" ", 5113, "like", 5114, 5, true);
            WriteAttributeValue(" ", 5118, "this", 5119, 5, true);
            WriteAttributeValue(" ", 5123, "comment\')", 5124, 10, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 79 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                                                                                                                                                                                                Write(c.UserLikedThisComment.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </div>\r\n\r\n");
#nullable restore
#line 82 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                      

                        if(c.Creator == ViewBag.curuser)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "25558caf5af531c201226bddaed852be8abe428627089", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 86 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = c;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 87 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div class=\"pl-5 py-2 mb-4 text-secondary text-muted\">\r\n                        ");
#nullable restore
#line 91 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                   Write(c.CommentContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <hr>\r\n");
#nullable restore
#line 94 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                }
            }
        }
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message>> Html { get; private set; }
    }
}
#pragma warning restore 1591
