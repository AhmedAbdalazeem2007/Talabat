#pragma checksum "E:\Courses\C#\Courses\ROOT\06 ASP Core API\session 08 Talabat Admin Panal\Talabat.Demo.Solution\AdminPanal\Views\User\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a28e8dd2db070bf591b02495f850aa006b2bd90df6dcc4281f55a4cb1ed11a25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\Courses\C#\Courses\ROOT\06 ASP Core API\session 08 Talabat Admin Panal\Talabat.Demo.Solution\AdminPanal\Views\_ViewImports.cshtml"
using AdminPanal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Courses\C#\Courses\ROOT\06 ASP Core API\session 08 Talabat Admin Panal\Talabat.Demo.Solution\AdminPanal\Views\_ViewImports.cshtml"
using AdminPanal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Courses\C#\Courses\ROOT\06 ASP Core API\session 08 Talabat Admin Panal\Talabat.Demo.Solution\AdminPanal\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Courses\C#\Courses\ROOT\06 ASP Core API\session 08 Talabat Admin Panal\Talabat.Demo.Solution\AdminPanal\Views\_ViewImports.cshtml"
using Talabat.APIs.Dtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a28e8dd2db070bf591b02495f850aa006b2bd90df6dcc4281f55a4cb1ed11a25", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4d054df9d3534703568e7f48fae172b6aeb3dc330b863b48d5e9f6fe20476d5b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UserViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Courses\C#\Courses\ROOT\06 ASP Core API\session 08 Talabat Admin Panal\Talabat.Demo.Solution\AdminPanal\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>All Users</h1>\r\n<hr />\r\n");
#nullable restore
#line 8 "E:\Courses\C#\Courses\ROOT\06 ASP Core API\session 08 Talabat Admin Panal\Talabat.Demo.Solution\AdminPanal\Views\User\Index.cshtml"
 if(Model.Count() >0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n        <table class=\"table table table-hover table-striped table-bordered\">\r\n            <thead>\r\n                <tr>\r\n                    <th>");
#nullable restore
#line 14 "E:\Courses\C#\Courses\ROOT\06 ASP Core API\session 08 Talabat Admin Panal\Talabat.Demo.Solution\AdminPanal\Views\User\Index.cshtml"
                   Write(Html.DisplayNameFor(u=>u.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 15 "E:\Courses\C#\Courses\ROOT\06 ASP Core API\session 08 Talabat Admin Panal\Talabat.Demo.Solution\AdminPanal\Views\User\Index.cshtml"
                   Write(Html.DisplayNameFor(u=>u.DisplayName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 16 "E:\Courses\C#\Courses\ROOT\06 ASP Core API\session 08 Talabat Admin Panal\Talabat.Demo.Solution\AdminPanal\Views\User\Index.cshtml"
                   Write(Html.DisplayNameFor(u=>u.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 17 "E:\Courses\C#\Courses\ROOT\06 ASP Core API\session 08 Talabat Admin Panal\Talabat.Demo.Solution\AdminPanal\Views\User\Index.cshtml"
                   Write(Html.DisplayNameFor(u=>u.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>Roles</th>\r\n                    <th>Actions</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 23 "E:\Courses\C#\Courses\ROOT\06 ASP Core API\session 08 Talabat Admin Panal\Talabat.Demo.Solution\AdminPanal\Views\User\Index.cshtml"
                 foreach(var user in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 26 "E:\Courses\C#\Courses\ROOT\06 ASP Core API\session 08 Talabat Admin Panal\Talabat.Demo.Solution\AdminPanal\Views\User\Index.cshtml"
                       Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 27 "E:\Courses\C#\Courses\ROOT\06 ASP Core API\session 08 Talabat Admin Panal\Talabat.Demo.Solution\AdminPanal\Views\User\Index.cshtml"
                       Write(user.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 28 "E:\Courses\C#\Courses\ROOT\06 ASP Core API\session 08 Talabat Admin Panal\Talabat.Demo.Solution\AdminPanal\Views\User\Index.cshtml"
                       Write(user.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 29 "E:\Courses\C#\Courses\ROOT\06 ASP Core API\session 08 Talabat Admin Panal\Talabat.Demo.Solution\AdminPanal\Views\User\Index.cshtml"
                       Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 30 "E:\Courses\C#\Courses\ROOT\06 ASP Core API\session 08 Talabat Admin Panal\Talabat.Demo.Solution\AdminPanal\Views\User\Index.cshtml"
                       Write(string.Join(",",user.Roles.ToList()));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a28e8dd2db070bf591b02495f850aa006b2bd90df6dcc4281f55a4cb1ed11a259288", async() => {
                WriteLiteral("<i class=\"fas fa-pen\"></i>Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "E:\Courses\C#\Courses\ROOT\06 ASP Core API\session 08 Talabat Admin Panal\Talabat.Demo.Solution\AdminPanal\Views\User\Index.cshtml"
                                                                                   WriteLiteral(user.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 35 "E:\Courses\C#\Courses\ROOT\06 ASP Core API\session 08 Talabat Admin Panal\Talabat.Demo.Solution\AdminPanal\Views\User\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
#nullable restore
#line 39 "E:\Courses\C#\Courses\ROOT\06 ASP Core API\session 08 Talabat Admin Panal\Talabat.Demo.Solution\AdminPanal\Views\User\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"mt-3 p-3 alert-warning\">\r\n        <h2>There is no Rocords</h2>\r\n    </div>\r\n");
#nullable restore
#line 45 "E:\Courses\C#\Courses\ROOT\06 ASP Core API\session 08 Talabat Admin Panal\Talabat.Demo.Solution\AdminPanal\Views\User\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a28e8dd2db070bf591b02495f850aa006b2bd90df6dcc4281f55a4cb1ed11a2512715", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UserViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591