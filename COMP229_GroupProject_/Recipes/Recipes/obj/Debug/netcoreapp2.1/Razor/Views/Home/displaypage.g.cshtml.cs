#pragma checksum "D:\Semester 3 --2018\Web Application Development\Assignments\Project\COMP229_GroupProject_\Recipes\Recipes\Views\Home\displaypage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef06f52121858d3687c572780bdc7a4bf8a64f5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_displaypage), @"mvc.1.0.view", @"/Views/Home/displaypage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/displaypage.cshtml", typeof(AspNetCore.Views_Home_displaypage))]
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
#line 1 "D:\Semester 3 --2018\Web Application Development\Assignments\Project\COMP229_GroupProject_\Recipes\Recipes\Views\_ViewImports.cshtml"
using Recipes.Models;

#line default
#line hidden
#line 2 "D:\Semester 3 --2018\Web Application Development\Assignments\Project\COMP229_GroupProject_\Recipes\Recipes\Views\_ViewImports.cshtml"
using Recipes.Models.ViewModels;

#line default
#line hidden
#line 3 "D:\Semester 3 --2018\Web Application Development\Assignments\Project\COMP229_GroupProject_\Recipes\Recipes\Views\_ViewImports.cshtml"
using Recipes.Infrastructure;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef06f52121858d3687c572780bdc7a4bf8a64f5f", @"/Views/Home/displaypage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4ed5d68036e0b819a13367a9908df691025b5da", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_displaypage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AddedRecipes>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddReview", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 3, true);
            WriteLiteral(" \r\n");
            EndContext();
            BeginContext(25, 2602, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ca8d77250534b8ab95921416d9baf20", async() => {
                BeginContext(31, 251, true);
                WriteLiteral("\r\n    <div class=\"container-fluid\">\r\n        <div class=\"row\">\r\n            <div class=\"col-6\">\r\n                <table class=\"table table-bordered\">\r\n\r\n                    <tr>\r\n                        <td>Recipe Id</td>\r\n                        <td>");
                EndContext();
                BeginContext(283, 14, false);
#line 11 "D:\Semester 3 --2018\Web Application Development\Assignments\Project\COMP229_GroupProject_\Recipes\Recipes\Views\Home\displaypage.cshtml"
                       Write(Model.RecipeID);

#line default
#line hidden
                EndContext();
                BeginContext(297, 129, true);
                WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Rating</td>\r\n                        <td>");
                EndContext();
                BeginContext(427, 27, false);
#line 15 "D:\Semester 3 --2018\Web Application Development\Assignments\Project\COMP229_GroupProject_\Recipes\Recipes\Views\Home\displaypage.cshtml"
                       Write(Math.Round(Model.Rating, 2));

#line default
#line hidden
                EndContext();
                BeginContext(454, 139, true);
                WriteLiteral(" / 5</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td> Recipe Name</td>\r\n                        <td>");
                EndContext();
                BeginContext(594, 16, false);
#line 19 "D:\Semester 3 --2018\Web Application Development\Assignments\Project\COMP229_GroupProject_\Recipes\Recipes\Views\Home\displaypage.cshtml"
                       Write(Model.recipename);

#line default
#line hidden
                EndContext();
                BeginContext(610, 135, true);
                WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Ingredient 1</td>\r\n                        <td>");
                EndContext();
                BeginContext(746, 17, false);
#line 23 "D:\Semester 3 --2018\Web Application Development\Assignments\Project\COMP229_GroupProject_\Recipes\Recipes\Views\Home\displaypage.cshtml"
                       Write(Model.ingredient1);

#line default
#line hidden
                EndContext();
                BeginContext(763, 136, true);
                WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Ingredient 2</td>\r\n                        <td> ");
                EndContext();
                BeginContext(900, 17, false);
#line 27 "D:\Semester 3 --2018\Web Application Development\Assignments\Project\COMP229_GroupProject_\Recipes\Recipes\Views\Home\displaypage.cshtml"
                        Write(Model.ingredient2);

#line default
#line hidden
                EndContext();
                BeginContext(917, 136, true);
                WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Ingredient 3</td>\r\n                        <td> ");
                EndContext();
                BeginContext(1054, 17, false);
#line 31 "D:\Semester 3 --2018\Web Application Development\Assignments\Project\COMP229_GroupProject_\Recipes\Recipes\Views\Home\displaypage.cshtml"
                        Write(Model.ingredient3);

#line default
#line hidden
                EndContext();
                BeginContext(1071, 135, true);
                WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Ingredient 4</td>\r\n                        <td>");
                EndContext();
                BeginContext(1207, 17, false);
#line 35 "D:\Semester 3 --2018\Web Application Development\Assignments\Project\COMP229_GroupProject_\Recipes\Recipes\Views\Home\displaypage.cshtml"
                       Write(Model.ingredient4);

#line default
#line hidden
                EndContext();
                BeginContext(1224, 136, true);
                WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Ingredient 5</td>\r\n                        <td> ");
                EndContext();
                BeginContext(1361, 17, false);
#line 39 "D:\Semester 3 --2018\Web Application Development\Assignments\Project\COMP229_GroupProject_\Recipes\Recipes\Views\Home\displaypage.cshtml"
                        Write(Model.ingredient5);

#line default
#line hidden
                EndContext();
                BeginContext(1378, 136, true);
                WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>Instructions</td>\r\n                        <td> ");
                EndContext();
                BeginContext(1515, 17, false);
#line 43 "D:\Semester 3 --2018\Web Application Development\Assignments\Project\COMP229_GroupProject_\Recipes\Recipes\Views\Home\displaypage.cshtml"
                        Write(Model.description);

#line default
#line hidden
                EndContext();
                BeginContext(1532, 78, true);
                WriteLiteral("</td>\r\n                    </tr>\r\n\r\n                </table>\r\n                ");
                EndContext();
                BeginContext(1610, 109, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "974b8abccf6b4f0795b7c84e541bdc1c", async() => {
                    BeginContext(1705, 10, true);
                    WriteLiteral("Add Review");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 47 "D:\Semester 3 --2018\Web Application Development\Assignments\Project\COMP229_GroupProject_\Recipes\Recipes\Views\Home\displaypage.cshtml"
                                                                  WriteLiteral(Model.RecipeID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1719, 122, true);
                WriteLiteral("\r\n                <table>\r\n                    <tr>\r\n                        <th>\r\n                            Reviews of ");
                EndContext();
                BeginContext(1842, 16, false);
#line 51 "D:\Semester 3 --2018\Web Application Development\Assignments\Project\COMP229_GroupProject_\Recipes\Recipes\Views\Home\displaypage.cshtml"
                                  Write(Model.recipename);

#line default
#line hidden
                EndContext();
                BeginContext(1858, 61, true);
                WriteLiteral(":\r\n                        </th>\r\n                    </tr>\r\n");
                EndContext();
#line 54 "D:\Semester 3 --2018\Web Application Development\Assignments\Project\COMP229_GroupProject_\Recipes\Recipes\Views\Home\displaypage.cshtml"
                     if (Model.Reviews == null)
                    {

                    }
                    else
                    {
                        

#line default
#line hidden
#line 60 "D:\Semester 3 --2018\Web Application Development\Assignments\Project\COMP229_GroupProject_\Recipes\Recipes\Views\Home\displaypage.cshtml"
                         foreach (var r in Model.Reviews)
                        {

#line default
#line hidden
                BeginContext(2151, 108, true);
                WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
                EndContext();
                BeginContext(2260, 23, false);
#line 64 "D:\Semester 3 --2018\Web Application Development\Assignments\Project\COMP229_GroupProject_\Recipes\Recipes\Views\Home\displaypage.cshtml"
                               Write(Math.Round(r.Rating, 2));

#line default
#line hidden
                EndContext();
                BeginContext(2283, 119, true);
                WriteLiteral(" / 5\r\n                                </td>\r\n                                <td>\r\n                                    ");
                EndContext();
                BeginContext(2403, 11, false);
#line 67 "D:\Semester 3 --2018\Web Application Development\Assignments\Project\COMP229_GroupProject_\Recipes\Recipes\Views\Home\displaypage.cshtml"
                               Write(r.addreview);

#line default
#line hidden
                EndContext();
                BeginContext(2414, 78, true);
                WriteLiteral("\r\n                                </td>\r\n\r\n                            </tr>\r\n");
                EndContext();
#line 71 "D:\Semester 3 --2018\Web Application Development\Assignments\Project\COMP229_GroupProject_\Recipes\Recipes\Views\Home\displaypage.cshtml"
                        }

#line default
#line hidden
#line 71 "D:\Semester 3 --2018\Web Application Development\Assignments\Project\COMP229_GroupProject_\Recipes\Recipes\Views\Home\displaypage.cshtml"
                         
                    }

#line default
#line hidden
                BeginContext(2542, 78, true);
                WriteLiteral("\r\n\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AddedRecipes> Html { get; private set; }
    }
}
#pragma warning restore 1591
