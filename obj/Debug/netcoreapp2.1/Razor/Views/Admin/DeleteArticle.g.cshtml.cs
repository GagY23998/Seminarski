#pragma checksum "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\Admin\DeleteArticle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ab8d6f31996a0cfbbcdd3019d7127d25bd9e882"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_DeleteArticle), @"mvc.1.0.view", @"/Views/Admin/DeleteArticle.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/DeleteArticle.cshtml", typeof(AspNetCore.Views_Admin_DeleteArticle))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ab8d6f31996a0cfbbcdd3019d7127d25bd9e882", @"/Views/Admin/DeleteArticle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a96f90fb2833102f5d693d20751e04b41939f10f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_DeleteArticle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Artikl>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteArticle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(51, 59, true);
            WriteLiteral("<div class=\"box box-primary\">\r\n    <div class=\"box-body\">\r\n");
            EndContext();
            BeginContext(242, 428, true);
            WriteLiteral(@"
            <table class=""table table-bordered"">
                <thead>
                    <tr class=""text-center"">
                        <td>Article Name</td>
                        <td>Price</td>
                        <td>Register Date</td>
                        <td>Article Quantity</td>
                        <td>Action</td>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 18 "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\Admin\DeleteArticle.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(743, 82, true);
            WriteLiteral("                        <tr class=\"text-center\">\r\n                            <td>");
            EndContext();
            BeginContext(826, 15, false);
#line 21 "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\Admin\DeleteArticle.cshtml"
                           Write(item.ImeArtikla);

#line default
#line hidden
            EndContext();
            BeginContext(841, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(881, 18, false);
#line 22 "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\Admin\DeleteArticle.cshtml"
                           Write(item.CijenaArtikla);

#line default
#line hidden
            EndContext();
            BeginContext(899, 42, true);
            WriteLiteral(" km</td>\r\n                            <td>");
            EndContext();
            BeginContext(942, 23, false);
#line 23 "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\Admin\DeleteArticle.cshtml"
                           Write(item.VrijemePostavlanja);

#line default
#line hidden
            EndContext();
            BeginContext(965, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1005, 13, false);
#line 24 "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\Admin\DeleteArticle.cshtml"
                           Write(item.NaStanju);

#line default
#line hidden
            EndContext();
            BeginContext(1018, 69, true);
            WriteLiteral("</td>\r\n                            <td>\r\n                            ");
            EndContext();
            BeginContext(1087, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff2c8b9f49b7404b954f67a801009488", async() => {
                BeginContext(1177, 6, true);
                WriteLiteral("Delete");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-articleID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 26 "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\Admin\DeleteArticle.cshtml"
                                                                                          WriteLiteral(item.ArtiklID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["articleID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-articleID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["articleID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1187, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 29 "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\Admin\DeleteArticle.cshtml"
                    }

#line default
#line hidden
            BeginContext(1278, 68, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n    </div>\r\n</div>  ");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Artikl artikl { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Artikl>> Html { get; private set; }
    }
}
#pragma warning restore 1591
