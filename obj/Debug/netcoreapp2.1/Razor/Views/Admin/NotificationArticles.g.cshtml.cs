#pragma checksum "C:\Users\Asus-i5\Desktop\Jebem ti fakultet\OnlineShop\Views\Admin\NotificationArticles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c8a37b12c7175118596c1b5e0c95f17dcd8ec4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_NotificationArticles), @"mvc.1.0.view", @"/Views/Admin/NotificationArticles.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/NotificationArticles.cshtml", typeof(AspNetCore.Views_Admin_NotificationArticles))]
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
#line 3 "C:\Users\Asus-i5\Desktop\Jebem ti fakultet\OnlineShop\Views\_ViewImports.cshtml"
using OnlineShopping.Models;

#line default
#line hidden
#line 4 "C:\Users\Asus-i5\Desktop\Jebem ti fakultet\OnlineShop\Views\_ViewImports.cshtml"
using OnlineShopping.ViewModels;

#line default
#line hidden
#line 5 "C:\Users\Asus-i5\Desktop\Jebem ti fakultet\OnlineShop\Views\_ViewImports.cshtml"
using OnlineShopping.Services;

#line default
#line hidden
#line 6 "C:\Users\Asus-i5\Desktop\Jebem ti fakultet\OnlineShop\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 7 "C:\Users\Asus-i5\Desktop\Jebem ti fakultet\OnlineShop\Views\_ViewImports.cshtml"
using OnlineShopping.HelperUser;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c8a37b12c7175118596c1b5e0c95f17dcd8ec4d", @"/Views/Admin/NotificationArticles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a96f90fb2833102f5d693d20751e04b41939f10f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_NotificationArticles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ArtiklOneViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangeArticle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(66, 299, true);
            WriteLiteral(@"<table class=""table table-striped"">
<thead>
    <tr>
        <td class=""text-center"">Article Name:</td>
        <td class=""text-center"">Article Quantity:</td>
        <td class=""text-center"">Article Price:</td>
        <td class=""text-center"">Action:</td>
    </tr>
</thead>
    <tbody>

");
            EndContext();
#line 14 "C:\Users\Asus-i5\Desktop\Jebem ti fakultet\OnlineShop\Views\Admin\NotificationArticles.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(398, 42, true);
            WriteLiteral("    <tr>\r\n        <td class=\"text-center\">");
            EndContext();
            BeginContext(441, 15, false);
#line 17 "C:\Users\Asus-i5\Desktop\Jebem ti fakultet\OnlineShop\Views\Admin\NotificationArticles.cshtml"
                           Write(item.ImeArtikla);

#line default
#line hidden
            EndContext();
            BeginContext(456, 39, true);
            WriteLiteral("</td>\r\n        <td class=\"text-center\">");
            EndContext();
            BeginContext(496, 13, false);
#line 18 "C:\Users\Asus-i5\Desktop\Jebem ti fakultet\OnlineShop\Views\Admin\NotificationArticles.cshtml"
                           Write(item.NaStanju);

#line default
#line hidden
            EndContext();
            BeginContext(509, 39, true);
            WriteLiteral("</td>\r\n        <td class=\"text-center\">");
            EndContext();
            BeginContext(549, 18, false);
#line 19 "C:\Users\Asus-i5\Desktop\Jebem ti fakultet\OnlineShop\Views\Admin\NotificationArticles.cshtml"
                           Write(item.CijenaArtikla);

#line default
#line hidden
            EndContext();
            BeginContext(567, 42, true);
            WriteLiteral(" KM</td>\r\n        <td class=\"text-center\">");
            EndContext();
            BeginContext(609, 131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5589f94a7a84727ae4a7bb28fb31a80", async() => {
                BeginContext(722, 14, true);
                WriteLiteral("Change Article");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 20 "C:\Users\Asus-i5\Desktop\Jebem ti fakultet\OnlineShop\Views\Admin\NotificationArticles.cshtml"
                                                                                       WriteLiteral(service.GetArticleIDbyName(item.ImeArtikla));

#line default
#line hidden
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
            EndContext();
            BeginContext(740, 18, true);
            WriteLiteral("</td>\r\n    </tr>\r\n");
            EndContext();
#line 22 "C:\Users\Asus-i5\Desktop\Jebem ti fakultet\OnlineShop\Views\Admin\NotificationArticles.cshtml"
}

#line default
#line hidden
            BeginContext(761, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IArtikliService service { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ArtiklOneViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
