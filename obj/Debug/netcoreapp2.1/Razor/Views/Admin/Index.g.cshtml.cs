#pragma checksum "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54ebe34ff23677ae56bbcabebc1985f022e446a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Index.cshtml", typeof(AspNetCore.Views_Admin_Index))]
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
#line 3 "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\_ViewImports.cshtml"
using OnlineShopping.Models;

#line default
#line hidden
#line 4 "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\_ViewImports.cshtml"
using OnlineShopping.ViewModels;

#line default
#line hidden
#line 5 "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\_ViewImports.cshtml"
using OnlineShopping.Services;

#line default
#line hidden
#line 6 "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 7 "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\_ViewImports.cshtml"
using OnlineShopping.HelperUser;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54ebe34ff23677ae56bbcabebc1985f022e446a9", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a96f90fb2833102f5d693d20751e04b41939f10f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineShopping.ViewModels.ArtiklViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangeArticle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(50, 285, true);
            WriteLiteral(@"

<table class=""table table-striped"">
    <thead>
        <tr>
            <td>Ime artikla</td>
            <td>Na stanju</td>
            <td>Vrijeme postavljanja</td>
            <td>Cijena artikla</td>
            <td>Akcija</td>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 15 "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\Admin\Index.cshtml"
     foreach (var item in Model.Articles)
    {

#line default
#line hidden
            BeginContext(385, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(416, 15, false);
#line 18 "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\Admin\Index.cshtml"
           Write(item.ImeArtikla);

#line default
#line hidden
            EndContext();
            BeginContext(431, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(455, 13, false);
#line 19 "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\Admin\Index.cshtml"
           Write(item.NaStanju);

#line default
#line hidden
            EndContext();
            BeginContext(468, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(492, 23, false);
#line 20 "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\Admin\Index.cshtml"
           Write(item.VrijemePostavlanja);

#line default
#line hidden
            EndContext();
            BeginContext(515, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(539, 18, false);
#line 21 "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\Admin\Index.cshtml"
           Write(item.CijenaArtikla);

#line default
#line hidden
            EndContext();
            BeginContext(557, 26, true);
            WriteLiteral(" KM</td>\r\n            <td>");
            EndContext();
            BeginContext(583, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a788fbc5209462cbf1c4efbe066fb37", async() => {
                BeginContext(643, 5, true);
                WriteLiteral("Uredi");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 22 "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\Admin\Index.cshtml"
                                                WriteLiteral(item.ArtiklID);

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
            BeginContext(652, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 24 "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\Admin\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(681, 33, true);
            WriteLiteral("    </tbody>\r\n</table>    \r\n\r\n\r\n ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineShopping.ViewModels.ArtiklViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
