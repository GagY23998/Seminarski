#pragma checksum "C:\Users\Asus-i5\source\repos\RSI_Seminarski\OnlineShop\Shoppp\Views\Admin\SendMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "910e73d4970c0a187530eeb8304372c179b3c6e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_SendMessage), @"mvc.1.0.view", @"/Views/Admin/SendMessage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/SendMessage.cshtml", typeof(AspNetCore.Views_Admin_SendMessage))]
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
#line 3 "C:\Users\Asus-i5\source\repos\RSI_Seminarski\OnlineShop\Shoppp\Views\_ViewImports.cshtml"
using OnlineShopping.Models;

#line default
#line hidden
#line 4 "C:\Users\Asus-i5\source\repos\RSI_Seminarski\OnlineShop\Shoppp\Views\_ViewImports.cshtml"
using OnlineShopping.ViewModels;

#line default
#line hidden
#line 5 "C:\Users\Asus-i5\source\repos\RSI_Seminarski\OnlineShop\Shoppp\Views\_ViewImports.cshtml"
using OnlineShopping.Services;

#line default
#line hidden
#line 2 "C:\Users\Asus-i5\source\repos\RSI_Seminarski\OnlineShop\Shoppp\Views\Admin\SendMessage.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 7 "C:\Users\Asus-i5\source\repos\RSI_Seminarski\OnlineShop\Shoppp\Views\_ViewImports.cshtml"
using OnlineShopping.HelperUser;

#line default
#line hidden
#line 3 "C:\Users\Asus-i5\source\repos\RSI_Seminarski\OnlineShop\Shoppp\Views\Admin\SendMessage.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"910e73d4970c0a187530eeb8304372c179b3c6e5", @"/Views/Admin/SendMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a96f90fb2833102f5d693d20751e04b41939f10f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_SendMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MessageViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-block margin-bottom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_SelectUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Subject:"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 8 "C:\Users\Asus-i5\source\repos\RSI_Seminarski\OnlineShop\Shoppp\Views\Admin\SendMessage.cshtml"
   Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 9 "C:\Users\Asus-i5\source\repos\RSI_Seminarski\OnlineShop\Shoppp\Views\Admin\SendMessage.cshtml"
   
    var unreadMessages = @service.GetUnreadMessages(access.HttpContext.Session.GetUser().Id);

#line default
#line hidden
            BeginContext(407, 166, true);
            WriteLiteral("<div class=\"content-wrapper\">\r\n    <!-- Content Header (Page header) -->\r\n    <section class=\"content-header\">\r\n        <h1>\r\n            Mailbox\r\n            <small>");
            EndContext();
            BeginContext(574, 14, false);
#line 17 "C:\Users\Asus-i5\source\repos\RSI_Seminarski\OnlineShop\Shoppp\Views\Admin\SendMessage.cshtml"
              Write(unreadMessages);

#line default
#line hidden
            EndContext();
            BeginContext(588, 362, true);
            WriteLiteral(@" new messages</small>
        </h1>
        <ol class=""breadcrumb"">
            <li><a href=""#""><i class=""fa fa-dashboard""></i> Home</a></li>
            <li class=""active"">Mailbox</li>
        </ol>
    </section>
    <!-- Main content -->
    <section class=""content"">
        <div class=""row"">   
            <div class=""col-md-3"">
                ");
            EndContext();
            BeginContext(950, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11d0bcd96eb140398825c173b3f181b6", async() => {
                BeginContext(1025, 13, true);
                WriteLiteral("Back to Inbox");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1042, 836, true);
            WriteLiteral(@"
                <div class=""box box-solid"">
                    <div class=""box-header with-border"">
                        <h3 class=""box-title"">Folders</h3>
                        <div class=""box-tools"">
                            <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"">
                                <i class=""fa fa-minus""></i>
                            </button>
                        </div>
                    </div>
                    <div class=""box-body no-padding"">
                        <ul class=""nav nav-pills nav-stacked"">
                            <li>
                                <a href=""mailbox.html"">
                                    <i class=""fa fa-inbox""></i> Inbox
                                    <span class=""label label-primary pull-right"">");
            EndContext();
            BeginContext(1879, 14, false);
#line 43 "C:\Users\Asus-i5\source\repos\RSI_Seminarski\OnlineShop\Shoppp\Views\Admin\SendMessage.cshtml"
                                                                            Write(unreadMessages);

#line default
#line hidden
            EndContext();
            BeginContext(1893, 2184, true);
            WriteLiteral(@"</span>
                                </a>
                            </li>
                            <li><a href=""#""><i class=""fa fa-envelope-o""></i> Sent</a></li>
                            <li><a href=""#""><i class=""fa fa-file-text-o""></i> Drafts</a></li>
                            <li>
                                <a href=""#""><i class=""fa fa-filter""></i> Junk <span class=""label label-warning pull-right"">65</span></a>
                            </li>
                            <li><a href=""#""><i class=""fa fa-trash-o""></i> Trash</a></li>
                        </ul>
                    </div>
                    <!-- /.box-body -->
                </div>
                <!-- /. box -->
                <div class=""box box-solid"">
                    <div class=""box-header with-border"">
                        <h3 class=""box-title"">Labels</h3>
                        <div class=""box-tools"">
                            <button type=""button"" class=""btn btn-box-tool"" data-widget=""co");
            WriteLiteral(@"llapse"">
                                <i class=""fa fa-minus""></i>
                            </button>
                        </div>
                    </div>
                    <!-- /.box-header -->
                    <div class=""box-body no-padding"">
                        <ul class=""nav nav-pills nav-stacked"">
                            <li><a href=""#""><i class=""fa fa-circle-o text-red""></i> Important</a></li>
                            <li><a href=""#""><i class=""fa fa-circle-o text-yellow""></i> Promotions</a></li>
                            <li><a href=""#""><i class=""fa fa-circle-o text-light-blue""></i> Social</a></li>
                        </ul>
                    </div>
                    <!-- /.box-body -->
                </div>
                <!-- /.box -->
            </div>
            <!-- /.col -->
            <div class=""col-md-9"">
                <div class=""box box-primary"">
                    <div class=""box-header with-border"">
                        <h3");
            WriteLiteral(" class=\"box-title\">Compose New Message</h3>\r\n                    </div>\r\n                    <!-- /.box-header -->\r\n                    ");
            EndContext();
            BeginContext(4077, 1404, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4251ff27bb945c1b5f22d81bfd13f90", async() => {
                BeginContext(4127, 268, true);
                WriteLiteral(@"

                    <div class=""box-body"">
                        <div class=""form-group"">
                            <input class=""form-control"" placeholder=""To:"" name=""Email"">
                            <div class=""users"">
                                ");
                EndContext();
                BeginContext(4395, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "944cf2f2f07e44e3b3b36aca879e3bd0", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 91 "C:\Users\Asus-i5\source\repos\RSI_Seminarski\OnlineShop\Shoppp\Views\Admin\SendMessage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = service.GetUsers();

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4453, 148, true);
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            ");
                EndContext();
                BeginContext(4601, 76, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cfd235ebeaf843a98395892a49329374", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 95 "C:\Users\Asus-i5\source\repos\RSI_Seminarski\OnlineShop\Shoppp\Views\Admin\SendMessage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Subject);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4677, 797, true);
                WriteLiteral(@"
                        </div>
                        <div class=""form-group"">
                            <textarea id=""compose-textarea"" class=""form-control"" name=""Message"" style=""height: 300px"">
</textarea>
                        </div>
                        <div class=""form-group"">
                            <div class=""btn btn-default btn-file"">
                                <i class=""fa fa-paperclip""></i> Attachment
                                <input type=""file"" name=""attachment"">
                            </div>
                            <p class=""help-block"">Max. 32MB</p>
                        </div>
                    </div>
                    <!-- /.box-body -->
                    
                    <!-- /.box-footer -->
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5481, 681, true);
            WriteLiteral(@"
                </div>
                <!-- /. box -->
            </div>
            <!-- /.col -->
        </div>
        <!-- /.row -->
    </section>
    <!-- /.content -->
</div>
<script>
    $(""input[name='Email']"").blur(function () {

        $("".myuser"").each((i, item) => {
            console.log($(item));
            if ($(item).find(""p"").first().html() == $(this).val()) {
                $(item).show();
            } else {
                $(item).hide();
            }
        });

    });
    $("".emailClick"").click(function () {
        $(""input[name='Email']"").val($(this).html());
        $("".myuser"").hide();
    });
    
</script>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor access { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<AppUser> userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<AppUser> signInManager { get; private set; }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MessageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
