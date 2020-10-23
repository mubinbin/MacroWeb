#pragma checksum "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ab4e0da6d2ad3af390ec7044b8f67abec6a0db0"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ab4e0da6d2ad3af390ec7044b8f67abec6a0db0", @"/Views/Shared/_ShowMessage.cshtml")]
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
            WriteLiteral("                <div style=\"font-size: 0.8 rem;\" class=\"ml-2 pl-3 font-weight-bold\">\r\n                    <a class=\"text-primary\" style=\"cursor: pointer;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1185, "\"", 1270, 6);
            WriteAttributeValue("", 1195, "showModal(\'/userdetail/", 1195, 23, true);
#nullable restore
#line 21 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
WriteAttributeValue("", 1218, m.Center.Creator.UserId, 1218, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1242, "\',", 1242, 2, true);
            WriteAttributeValue(" ", 1244, "\'", 1245, 2, true);
#nullable restore
#line 21 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
WriteAttributeValue("", 1246, m.Center.Creator.Name, 1246, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1268, "\')", 1268, 2, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 21 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                                                                                                                                                      Write(m.Center.Creator.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> - <span class=\"text-secondary\">");
#nullable restore
#line 21 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                                                                                                                                                                                                                Write(m.Center.UpdatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n                <div style=\"font-size: 0.8 rem;\" class=\"ml-2 pl-3 py-2\">");
#nullable restore
#line 23 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                                                                   Write(m.Center.MessageContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 24 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"my-4 row col-sm-5\">\r\n                <span class=\"col\">\r\n");
#nullable restore
#line 28 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                              
                    if(m.UsersLikedThisMessage.Any(l=>l.UserWhoLiked==ViewBag.curuser))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a class=\"text-danger\" style=\"cursor: pointer;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1823, "\"", 1875, 3);
            WriteAttributeValue("", 1833, "likeorunlike(\'unlikemessage/", 1833, 28, true);
#nullable restore
#line 31 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
WriteAttributeValue("", 1861, m.MessageId, 1861, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1873, "\')", 1873, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i title=\"Unlike\" class=\"fas fa-thumbs-up\"></i> </a>\r\n");
#nullable restore
#line 32 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                    }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a class=\"text-secondary\" style=\"cursor: pointer;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2037, "\"", 2087, 3);
            WriteAttributeValue("", 2047, "likeorunlike(\'likemessage/", 2047, 26, true);
#nullable restore
#line 33 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
WriteAttributeValue("", 2073, m.MessageId, 2073, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2085, "\')", 2085, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i title=\"Like\" class=\"far fa-thumbs-up\"></i> </a>\r\n");
#nullable restore
#line 34 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a style=\"cursor:pointer; text-decoration: none;\" class=\"text-dark\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2270, "\"", 2351, 7);
            WriteAttributeValue("", 2280, "showModal(\'/userslikedmessage/", 2280, 30, true);
#nullable restore
#line 36 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
WriteAttributeValue("", 2310, m.MessageId, 2310, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2322, "\',", 2322, 2, true);
            WriteAttributeValue(" ", 2324, "\'Users", 2325, 7, true);
            WriteAttributeValue(" ", 2331, "like", 2332, 5, true);
            WriteAttributeValue(" ", 2336, "this", 2337, 5, true);
            WriteAttributeValue(" ", 2341, "message\')", 2342, 10, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 36 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                                                                                                                                                                     Write(m.UsersLikedThisMessage.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </span>\r\n\r\n");
            WriteLiteral("                <a id=\"new-comment\" class=\"col text-success\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2507, "\"", 2576, 5);
            WriteAttributeValue("", 2517, "showModal(\'/newcommentpartial/", 2517, 30, true);
#nullable restore
#line 40 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
WriteAttributeValue("", 2547, m.MessageId, 2547, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2559, "\',", 2559, 2, true);
            WriteAttributeValue(" ", 2561, "\'New", 2562, 5, true);
            WriteAttributeValue(" ", 2566, "Comment\')", 2567, 10, true);
            EndWriteAttribute();
            WriteLiteral("><i style=\"cursor: pointer;\" title=\"Reply\" class=\"fa fa-comment\"></i> <span class=\"text-dark\">");
#nullable restore
#line 40 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                                                                                                                                                                                                                           Write(m.CommentsForMessage.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a>\r\n\r\n");
            WriteLiteral("                <a class=\"col text-success\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2795, "\"", 2871, 6);
            WriteAttributeValue("", 2805, "showModal(\'/spiralpartial/", 2805, 26, true);
#nullable restore
#line 43 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
WriteAttributeValue("", 2831, m.MessageId, 2831, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2843, "\',", 2843, 2, true);
            WriteAttributeValue(" ", 2845, "\'Retweeting", 2846, 12, true);
            WriteAttributeValue(" ", 2857, "below", 2858, 6, true);
            WriteAttributeValue(" ", 2863, "post:\')", 2864, 8, true);
            EndWriteAttribute();
            WriteLiteral("><i style=\"cursor: pointer;\" title=\"Retweet\" class=\"fas fa-broadcast-tower\"></i> <span class=\"text-dark\">");
#nullable restore
#line 43 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                                                                                                                                                                                                                            Write(m.Spirals.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a>\r\n\r\n");
#nullable restore
#line 46 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                                         
                    if(m.Creator == ViewBag.curuser)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a id=\"edit-message\" class=\"col text-info\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3214, "\"", 3285, 5);
            WriteAttributeValue("", 3224, "showModal(\'/editmessagepartial/", 3224, 31, true);
#nullable restore
#line 49 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
WriteAttributeValue("", 3255, m.MessageId, 3255, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3267, "\',", 3267, 2, true);
            WriteAttributeValue(" ", 3269, "\'Edit", 3270, 6, true);
            WriteAttributeValue(" ", 3275, "Message\')", 3276, 10, true);
            EndWriteAttribute();
            WriteLiteral("><i style=\"cursor: pointer;\" title=\"Edit Message\" class=\"fas fa-pencil-alt\"></i></a>\r\n");
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2ab4e0da6d2ad3af390ec7044b8f67abec6a0db018412", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 51 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
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
#line 52 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <hr>\r\n");
#nullable restore
#line 56 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
            
            if(m.CommentsForMessage.Count>0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"pl-3 font-weight-bold\">Comment:</p>\r\n");
#nullable restore
#line 60 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                foreach(Comment c in m.CommentsForMessage)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"pl-5 font-weight-bold\">\r\n                        <a class=\"text-primary\" style=\"cursor: pointer;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3868, "\"", 3939, 6);
            WriteAttributeValue("", 3878, "showModal(\'/userdetail/", 3878, 23, true);
#nullable restore
#line 63 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
WriteAttributeValue("", 3901, c.Creator.UserId, 3901, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3918, "\',", 3918, 2, true);
            WriteAttributeValue(" ", 3920, "\'", 3921, 2, true);
#nullable restore
#line 63 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
WriteAttributeValue("", 3922, c.Creator.Name, 3922, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3937, "\')", 3937, 2, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 63 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                                                                                                                                            Write(c.Creator.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> - <span class=\"text-secondary\">");
#nullable restore
#line 63 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                                                                                                                                                                                               Write(c.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n                        <div style=\"margin-left: 15px; vertical-align:top;\" class=\"d-inline\">\r\n");
#nullable restore
#line 66 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                          
                            if(c.UserLikedThisComment.Any(l=>l.UserWhoLiked==ViewBag.curuser))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a class=\"text-danger\" style=\"cursor: pointer;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4348, "\"", 4400, 3);
            WriteAttributeValue("", 4358, "likeorunlike(\'unlikecomment/", 4358, 28, true);
#nullable restore
#line 69 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
WriteAttributeValue("", 4386, c.CommentId, 4386, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4398, "\')", 4398, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i title=\"Unlike\" class=\"fas fa-thumbs-up\"></i> </a>\r\n");
#nullable restore
#line 70 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                            }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a class=\"text-secondary\" style=\"cursor: pointer;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4578, "\"", 4628, 3);
            WriteAttributeValue("", 4588, "likeorunlike(\'likecomment/", 4588, 26, true);
#nullable restore
#line 71 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
WriteAttributeValue("", 4614, c.CommentId, 4614, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4626, "\')", 4626, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i title=\"Like\" class=\"far fa-thumbs-up\"></i> </a>\r\n");
#nullable restore
#line 72 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a style=\"cursor:pointer; text-decoration: none;\" class=\"text-dark font-weight-normal\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4854, "\"", 4935, 7);
            WriteAttributeValue("", 4864, "showModal(\'/userslikedcomment/", 4864, 30, true);
#nullable restore
#line 74 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
WriteAttributeValue("", 4894, c.CommentId, 4894, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4906, "\',", 4906, 2, true);
            WriteAttributeValue(" ", 4908, "\'Users", 4909, 7, true);
            WriteAttributeValue(" ", 4915, "like", 4916, 5, true);
            WriteAttributeValue(" ", 4920, "this", 4921, 5, true);
            WriteAttributeValue(" ", 4925, "comment\')", 4926, 10, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 74 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                                                                                                                                                                                                Write(c.UserLikedThisComment.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </div>\r\n\r\n");
#nullable restore
#line 77 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                      

                        if(c.Creator == ViewBag.curuser)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2ab4e0da6d2ad3af390ec7044b8f67abec6a0db026523", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 81 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
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
#line 82 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div class=\"pl-5 py-2 mb-4\">\r\n                        ");
#nullable restore
#line 86 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
                   Write(c.CommentContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <hr>\r\n");
#nullable restore
#line 89 "D:\Dojo_Assignments\C#\ORM\MacroWeb\Views\Shared\_ShowMessage.cshtml"
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
