#pragma checksum "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\EditUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38878c099eeb5290312114861e6c1596edccab59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_EditUser), @"mvc.1.0.view", @"/Views/User/EditUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/EditUser.cshtml", typeof(AspNetCore.Views_User_EditUser))]
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
#line 1 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\_ViewImports.cshtml"
using InterviewTracker;

#line default
#line hidden
#line 2 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\_ViewImports.cshtml"
using InterviewTracker.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38878c099eeb5290312114861e6c1596edccab59", @"/Views/User/EditUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c65db002670eb00f1d552890840cda9fab809fae", @"/Views/_ViewImports.cshtml")]
    public class Views_User_EditUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InterviewTracker.BusinessLayer.ViewModels.UserEditViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("custom-select mr-sm-2 form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\EditUser.cshtml"
  
    ViewData["Title"] = "EditUser";

#line default
#line hidden
            BeginContext(112, 198, true);
            WriteLiteral("\r\n    <div class=\"card\" style=\"width:60%; margin:auto;\">\r\n        <div class=\"card-header bg-success text-white\">\r\n            <h5>Update User</h5>\r\n        </div>\r\n        <div class=\"card-body\">\r\n");
            EndContext();
#line 11 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\EditUser.cshtml"
             using (Html.BeginForm())
            {
                

#line default
#line hidden
            BeginContext(381, 23, false);
#line 13 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\EditUser.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(423, 28, false);
#line 14 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\EditUser.cshtml"
           Write(Html.ValidationSummary(true));

#line default
#line hidden
            EndContext();
            BeginContext(453, 157, true);
            WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"col-md-6\">\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(611, 31, false);
#line 18 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\EditUser.cshtml"
                       Write(Html.LabelFor(m => m.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(642, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(673, 82, false);
#line 19 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\EditUser.cshtml"
                       Write(Html.TextBoxFor(m => m.FirstName, new { autofocus = "", @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(755, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(785, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38878c099eeb5290312114861e6c1596edccab596775", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 20 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\EditUser.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FirstName);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(849, 184, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-md-6\">\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(1034, 30, false);
#line 25 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\EditUser.cshtml"
                       Write(Html.LabelFor(m => m.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1064, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1095, 65, false);
#line 26 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\EditUser.cshtml"
                       Write(Html.TextBoxFor(m => m.LastName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1160, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1190, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38878c099eeb5290312114861e6c1596edccab599502", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 27 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\EditUser.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.LastName);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1253, 243, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-6\">\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(1497, 27, false);
#line 34 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\EditUser.cshtml"
                       Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1524, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1555, 78, false);
#line 35 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\EditUser.cshtml"
                       Write(Html.TextBoxFor(m => m.Email, new { autofocus = "", @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1633, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1663, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38878c099eeb5290312114861e6c1596edccab5912304", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 36 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\EditUser.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Email);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1723, 184, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-md-6\">\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(1908, 33, false);
#line 41 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\EditUser.cshtml"
                       Write(Html.LabelFor(m => m.ReportingTo));

#line default
#line hidden
            EndContext();
            BeginContext(1941, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1972, 68, false);
#line 42 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\EditUser.cshtml"
                       Write(Html.TextBoxFor(m => m.ReportingTo, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2040, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(2070, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38878c099eeb5290312114861e6c1596edccab5915035", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 43 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\EditUser.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ReportingTo);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2136, 243, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-6\">\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(2380, 31, false);
#line 50 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\EditUser.cshtml"
                       Write(Html.LabelFor(m => m.UserTypes));

#line default
#line hidden
            EndContext();
            BeginContext(2411, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2530, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(2558, 293, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38878c099eeb5290312114861e6c1596edccab5917500", async() => {
                BeginContext(2739, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(2773, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38878c099eeb5290312114861e6c1596edccab5917919", async() => {
                    BeginContext(2790, 13, true);
                    WriteLiteral("Please Select");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2812, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 52 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\EditUser.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserTypes);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 52 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\EditUser.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Html.GetEnumSelectList<InterviewTracker.Entities.UserType>();

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2851, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(2881, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38878c099eeb5290312114861e6c1596edccab5921296", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 56 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\EditUser.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserTypes);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2945, 184, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-md-6\">\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(3130, 26, false);
#line 61 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\EditUser.cshtml"
                       Write(Html.LabelFor(m => m.Stat));

#line default
#line hidden
            EndContext();
            BeginContext(3156, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(3186, 286, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38878c099eeb5290312114861e6c1596edccab5923589", async() => {
                BeginContext(3360, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(3394, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38878c099eeb5290312114861e6c1596edccab5924008", async() => {
                    BeginContext(3411, 13, true);
                    WriteLiteral("Please Select");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3433, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 62 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\EditUser.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Stat);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 62 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\EditUser.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Html.GetEnumSelectList<InterviewTracker.Entities.Status>();

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3472, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(3502, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38878c099eeb5290312114861e6c1596edccab5927378", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 66 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\EditUser.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Stat);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3561, 244, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-12\">\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(3806, 34, false);
#line 73 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\EditUser.cshtml"
                       Write(Html.LabelFor(m => m.MobileNumber));

#line default
#line hidden
            EndContext();
            BeginContext(3840, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(3871, 85, false);
#line 74 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\EditUser.cshtml"
                       Write(Html.TextBoxFor(m => m.MobileNumber, new { autofocus = "", @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(3956, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(3986, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38878c099eeb5290312114861e6c1596edccab5930192", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 75 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\EditUser.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MobileNumber);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4053, 271, true);
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <div class=""form-group text-center"">
                    <button type=""submit"" class=""btn btn-primary"">Save</button>
                    <button class=""btn btn-danger""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4324, "\"", 4394, 4);
            WriteAttributeValue("", 4334, "location.href=\'", 4334, 15, true);
#line 81 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\EditUser.cshtml"
WriteAttributeValue("", 4349, Url.Action("AllUser", "User"), 4349, 30, false);

#line default
#line hidden
            WriteAttributeValue("", 4379, "\';return", 4379, 8, true);
            WriteAttributeValue(" ", 4387, "false;", 4388, 7, true);
            EndWriteAttribute();
            BeginContext(4395, 53, true);
            WriteLiteral(">Back To User List</button>\r\n                </div>\r\n");
            EndContext();
#line 83 "D:\IIHT DATA\IIHT\Task_3_4\Project-InMemory\InterviewTracker\Views\User\EditUser.cshtml"
            }

#line default
#line hidden
            BeginContext(4463, 26, true);
            WriteLiteral("        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InterviewTracker.BusinessLayer.ViewModels.UserEditViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
