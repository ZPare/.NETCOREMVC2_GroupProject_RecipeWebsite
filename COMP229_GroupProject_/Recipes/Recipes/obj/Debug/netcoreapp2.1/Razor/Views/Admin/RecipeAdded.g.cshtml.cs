#pragma checksum "D:\Semester 3 --2018\Web Application Development\Assignments\Project\COMP229_GroupProject_\Recipes\Recipes\Views\Admin\RecipeAdded.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d3337534dff1256b368ae92a921025b0826543c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_RecipeAdded), @"mvc.1.0.view", @"/Views/Admin/RecipeAdded.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/RecipeAdded.cshtml", typeof(AspNetCore.Views_Admin_RecipeAdded))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d3337534dff1256b368ae92a921025b0826543c", @"/Views/Admin/RecipeAdded.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4ed5d68036e0b819a13367a9908df691025b5da", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_RecipeAdded : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AddedRecipes>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 317, true);
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-6"">
            <h3>The Following Recipe Has Been Added.</h3>
            <table class=""table table-borderless table-striped"">
                <tr>
                    <td><strong>Recipe Name: </strong></td>
                    <td>");
            EndContext();
            BeginContext(339, 16, false);
#line 10 "D:\Semester 3 --2018\Web Application Development\Assignments\Project\COMP229_GroupProject_\Recipes\Recipes\Views\Admin\RecipeAdded.cshtml"
                   Write(Model.recipename);

#line default
#line hidden
            EndContext();
            BeginContext(355, 142, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td><strong>First Ingredient: </strong></td>\r\n                    <td>");
            EndContext();
            BeginContext(498, 17, false);
#line 14 "D:\Semester 3 --2018\Web Application Development\Assignments\Project\COMP229_GroupProject_\Recipes\Recipes\Views\Admin\RecipeAdded.cshtml"
                   Write(Model.ingredient1);

#line default
#line hidden
            EndContext();
            BeginContext(515, 144, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td><strong>Second Ingredient: </strong></td>\r\n                    <td> ");
            EndContext();
            BeginContext(660, 17, false);
#line 18 "D:\Semester 3 --2018\Web Application Development\Assignments\Project\COMP229_GroupProject_\Recipes\Recipes\Views\Admin\RecipeAdded.cshtml"
                    Write(Model.ingredient2);

#line default
#line hidden
            EndContext();
            BeginContext(677, 143, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td><strong>Third Ingredient: </strong></td>\r\n                    <td> ");
            EndContext();
            BeginContext(821, 17, false);
#line 22 "D:\Semester 3 --2018\Web Application Development\Assignments\Project\COMP229_GroupProject_\Recipes\Recipes\Views\Admin\RecipeAdded.cshtml"
                    Write(Model.ingredient3);

#line default
#line hidden
            EndContext();
            BeginContext(838, 143, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td><strong>Fourth Ingredient: </strong></td>\r\n                    <td>");
            EndContext();
            BeginContext(982, 17, false);
#line 26 "D:\Semester 3 --2018\Web Application Development\Assignments\Project\COMP229_GroupProject_\Recipes\Recipes\Views\Admin\RecipeAdded.cshtml"
                   Write(Model.ingredient4);

#line default
#line hidden
            EndContext();
            BeginContext(999, 143, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td><strong>Fifth Ingredient: </strong></td>\r\n                    <td> ");
            EndContext();
            BeginContext(1143, 17, false);
#line 30 "D:\Semester 3 --2018\Web Application Development\Assignments\Project\COMP229_GroupProject_\Recipes\Recipes\Views\Admin\RecipeAdded.cshtml"
                    Write(Model.ingredient5);

#line default
#line hidden
            EndContext();
            BeginContext(1160, 138, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td><strong>Ingredients: </strong></td>\r\n                    <td> ");
            EndContext();
            BeginContext(1299, 17, false);
#line 34 "D:\Semester 3 --2018\Web Application Development\Assignments\Project\COMP229_GroupProject_\Recipes\Recipes\Views\Admin\RecipeAdded.cshtml"
                    Write(Model.description);

#line default
#line hidden
            EndContext();
            BeginContext(1316, 104, true);
            WriteLiteral("</td>\r\n                </tr>\r\n\r\n            </table>\r\n            \r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
