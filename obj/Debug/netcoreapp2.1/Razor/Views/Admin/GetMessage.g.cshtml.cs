#pragma checksum "C:\Users\Asus-i5\Desktop\Jebem ti fakultet\OnlineShop\Views\Admin\GetMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77c2a2f7c99fc4c684dbffd6203f9ff1b31f7373"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_GetMessage), @"mvc.1.0.view", @"/Views/Admin/GetMessage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/GetMessage.cshtml", typeof(AspNetCore.Views_Admin_GetMessage))]
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
#line 3 "C:\Users\Asus-i5\Desktop\Jebem ti fakultet\OnlineShop\Views\Admin\GetMessage.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 9 "C:\Users\Asus-i5\Desktop\Jebem ti fakultet\OnlineShop\Views\Admin\GetMessage.cshtml"
using OnlineShopping.HelperUser;

#line default
#line hidden
#line 4 "C:\Users\Asus-i5\Desktop\Jebem ti fakultet\OnlineShop\Views\Admin\GetMessage.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77c2a2f7c99fc4c684dbffd6203f9ff1b31f7373", @"/Views/Admin/GetMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a96f90fb2833102f5d693d20751e04b41939f10f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_GetMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MessageBox>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SendMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-block margin-bottom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ReadMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Asus-i5\Desktop\Jebem ti fakultet\OnlineShop\Views\Admin\GetMessage.cshtml"
   Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 10 "C:\Users\Asus-i5\Desktop\Jebem ti fakultet\OnlineShop\Views\Admin\GetMessage.cshtml"
   
    var unreadMessages = service.GetUnreadMessages(access.HttpContext.Session.GetUser().Id);

#line default
#line hidden
            BeginContext(441, 168, true);
            WriteLiteral("\r\n<div class=\"content-wrapper\">\r\n    <!-- Content Header (Page header) -->\r\n    <section class=\"content-header\">\r\n        <h1>\r\n            Mailbox\r\n            <small>");
            EndContext();
            BeginContext(610, 14, false);
#line 19 "C:\Users\Asus-i5\Desktop\Jebem ti fakultet\OnlineShop\Views\Admin\GetMessage.cshtml"
              Write(unreadMessages);

#line default
#line hidden
            EndContext();
            BeginContext(624, 359, true);
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
            BeginContext(983, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "483aab89b47a47acb8c9e4908b821cc8", async() => {
                BeginContext(1059, 7, true);
                WriteLiteral("Compose");
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
            BeginContext(1070, 840, true);
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
                            <li class=""active"">
                                <a href=""#"">
                                    <i class=""fa fa-inbox""></i> Inbox
                                    <span class=""label label-primary pull-right"">");
            EndContext();
            BeginContext(1911, 66, false);
#line 45 "C:\Users\Asus-i5\Desktop\Jebem ti fakultet\OnlineShop\Views\Admin\GetMessage.cshtml"
                                                                            Write(service.GetMessages(access.HttpContext.Session.GetUser().Id).Count);

#line default
#line hidden
            EndContext();
            BeginContext(1977, 269, true);
            WriteLiteral(@"</span>
                                </a>
                            </li>
                            <li><a href=""#""><i class=""fa fa-envelope-o""></i> Sent</a></li>
                            <li><a href=""#""><i class=""fa fa-file-text-o""></i> Drafts</a></li>
");
            EndContext();
            BeginContext(2457, 3899, true);
            WriteLiteral(@"                            <li><a href=""#""><i class=""fa fa-trash-o""></i> Trash</a></li>
                        </ul>
                    </div>
                    <!-- /.box-body -->
                </div>
                <!-- /. box -->
                <div class=""box box-solid"">
                    <div class=""box-header with-border"">
                        <h3 class=""box-title"">Labels</h3>
                        <div class=""box-tools"">
                            <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"">
                                <i class=""fa fa-minus""></i>
                            </button>
                        </div>
                    </div>
                    <div class=""box-body no-padding"">
                        <ul class=""nav nav-pills nav-stacked"">
                            <li><a href=""#""><i class=""fa fa-circle-o text-red""></i> Important</a></li>
                            <li><a href=""#""><i class=""fa fa-circle-o text-yellow""><");
            WriteLiteral(@"/i> Promotions</a></li>
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
                        <h3 class=""box-title"">Inbox</h3>
                        <div class=""box-tools pull-right"">
                            <div class=""has-feedback"">
                                <input type=""text"" class=""form-control input-sm"" placeholder=""Search Mail"">
                                <span class=""glyphicon glyphicon-search form-control-feedback""></span>
                            </div>
                        </div>
                        <!-- /.box-tools -->
                    </div>
                 ");
            WriteLiteral(@"   <!-- /.box-header -->
                    <div class=""box-body no-padding"">
                        <div class=""mailbox-controls"">
                            <!-- Check all button -->
                            <button type=""button"" class=""btn btn-default btn-sm checkbox-toggle"">
                                <i class=""fa fa-square-o""></i>
                            </button>
                            <div class=""btn-group"">
                                <button type=""button"" class=""btn btn-default btn-sm""><i class=""fa fa-trash-o""></i></button>
                                <button type=""button"" class=""btn btn-default btn-sm""><i class=""fa fa-reply""></i></button>
                                <button type=""button"" class=""btn btn-default btn-sm""><i class=""fa fa-share""></i></button>
                            </div>
                            <!-- /.btn-group -->
                            <button type=""button"" class=""btn btn-default btn-sm""><i class=""fa fa-refresh""></i></button>");
            WriteLiteral(@"
                            <div class=""pull-right"">
                                1-50/200
                                <div class=""btn-group"">
                                    <button type=""button"" class=""btn btn-default btn-sm""><i class=""fa fa-chevron-left""></i></button>
                                    <button type=""button"" class=""btn btn-default btn-sm""><i class=""fa fa-chevron-right""></i></button>
                                </div>
                                <!-- /.btn-group -->
                            </div>
                            <!-- /.pull-right -->
                        </div>
                        <div class=""table-responsive mailbox-messages"">
                            <table class=""table table-hover table-striped"">
                                <tbody>
");
            EndContext();
#line 119 "C:\Users\Asus-i5\Desktop\Jebem ti fakultet\OnlineShop\Views\Admin\GetMessage.cshtml"
                                     for (int i = 0; i < Model.Count; i++)
                                    {
                                        var myVar = new DateSent().Calculate(Model[i].CreationDate);

#line default
#line hidden
            BeginContext(6573, 373, true);
            WriteLiteral(@"                                        <tr>
                                            <td><input type=""checkbox""></td>
                                            <td class=""mailbox-star""><a href=""#""><i class=""fa fa-star text-yellow""></i></a></td>
                                            <td class=""mailbox-name"">
                                                ");
            EndContext();
            BeginContext(6946, 267, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0d9d24274f346afad9e532873518b68", async() => {
                BeginContext(7062, 49, true);
                WriteLiteral("\r\n                                               ");
                EndContext();
                BeginContext(7112, 48, false);
#line 128 "C:\Users\Asus-i5\Desktop\Jebem ti fakultet\OnlineShop\Views\Admin\GetMessage.cshtml"
                                          Write(service.GetUserByID(Model[i].SenderID).FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(7160, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(7162, 47, false);
#line 128 "C:\Users\Asus-i5\Desktop\Jebem ti fakultet\OnlineShop\Views\Admin\GetMessage.cshtml"
                                                                                            Write(service.GetUserByID(Model[i].SenderID).LastName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 127 "C:\Users\Asus-i5\Desktop\Jebem ti fakultet\OnlineShop\Views\Admin\GetMessage.cshtml"
                                                  WriteLiteral(Model[i].MessageBoxID);

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
            BeginContext(7213, 132, true);
            WriteLiteral("</td>\r\n                                            <td class=\"mailbox-subject\">\r\n                                                <b>");
            EndContext();
            BeginContext(7346, 16, false);
#line 130 "C:\Users\Asus-i5\Desktop\Jebem ti fakultet\OnlineShop\Views\Admin\GetMessage.cshtml"
                                              Write(Model[i].Subject);

#line default
#line hidden
            EndContext();
            BeginContext(7362, 7, true);
            WriteLiteral("</b> - ");
            EndContext();
            BeginContext(7370, 84, false);
#line 130 "C:\Users\Asus-i5\Desktop\Jebem ti fakultet\OnlineShop\Views\Admin\GetMessage.cshtml"
                                                                      Write(Model[i].Message.Substring(0, Model[i].Message.Length<30?Model[i].Message.Length:30));

#line default
#line hidden
            EndContext();
            BeginContext(7454, 208, true);
            WriteLiteral("...\r\n                                            </td>\r\n                                            <td class=\"mailbox-attachment\"></td>\r\n                                            <td class=\"mailbox-date\"> ");
            EndContext();
            BeginContext(7663, 14, false);
#line 133 "C:\Users\Asus-i5\Desktop\Jebem ti fakultet\OnlineShop\Views\Admin\GetMessage.cshtml"
                                                                 Write(myVar.intValue);

#line default
#line hidden
            EndContext();
            BeginContext(7677, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(7679, 17, false);
#line 133 "C:\Users\Asus-i5\Desktop\Jebem ti fakultet\OnlineShop\Views\Admin\GetMessage.cshtml"
                                                                                 Write(myVar.stringValue);

#line default
#line hidden
            EndContext();
            BeginContext(7696, 58, true);
            WriteLiteral(" ago</td>\r\n                                        </tr>\r\n");
            EndContext();
#line 135 "C:\Users\Asus-i5\Desktop\Jebem ti fakultet\OnlineShop\Views\Admin\GetMessage.cshtml"
                                    }

#line default
#line hidden
            BeginContext(7793, 5250, true);
            WriteLiteral(@"                                </tbody>
                            </table>
                            <!-- /.table -->
                        </div>
                        <!-- /.mail-box-messages -->
                    </div>
                    <!-- /.box-body -->
                    <div class=""box-footer no-padding"">
                        <div class=""mailbox-controls"">
                            <!-- Check all button -->
                            <button type=""button"" class=""btn btn-default btn-sm checkbox-toggle"">
                                <i class=""fa fa-square-o""></i>
                            </button>
                            <div class=""btn-group"">
                                <button type=""button"" class=""btn btn-default btn-sm""><i class=""fa fa-trash-o""></i></button>
                                <button type=""button"" class=""btn btn-default btn-sm""><i class=""fa fa-reply""></i></button>
                                <button type=""button"" class=""btn btn-def");
            WriteLiteral(@"ault btn-sm""><i class=""fa fa-share""></i></button>
                            </div>
                            <!-- /.btn-group -->
                            <button type=""button"" class=""btn btn-default btn-sm""><i class=""fa fa-refresh""></i></button>
                            <div class=""pull-right"">
                                1-50/200
                                <div class=""btn-group"">
                                    <button type=""button"" class=""btn btn-default btn-sm""><i class=""fa fa-chevron-left""></i></button>
                                    <button type=""button"" class=""btn btn-default btn-sm""><i class=""fa fa-chevron-right""></i></button>
                                </div>
                                <!-- /.btn-group -->
                            </div>
                            <!-- /.pull-right -->
                        </div>
                    </div>
                </div>
                <!-- /. box -->
            </div>
            <!-- /.col -->");
            WriteLiteral(@"
        </div>
        <!-- /.row -->
    </section>
    <!-- ./wrapper -->
    <!-- jQuery 3 -->
    <script src=""../../bower_components/jquery/dist/jquery.min.js""></script>
    <!-- Bootstrap 3.3.7 -->
    <script src=""../../bower_components/bootstrap/dist/js/bootstrap.min.js""></script>
    <!-- Slimscroll -->
    <script src=""../../bower_components/jquery-slimscroll/jquery.slimscroll.min.js""></script>
    <!-- FastClick -->
    <script src=""../../bower_components/fastclick/lib/fastclick.js""></script>
    <!-- AdminLTE App -->
    <script src=""../../dist/js/adminlte.min.js""></script>
    <!-- iCheck -->
    <script src=""../../plugins/iCheck/icheck.min.js""></script>
    <!-- Page Script -->
    <script>
        $(function () {
            //Enable iCheck plugin for checkboxes
            //iCheck for checkbox and radio inputs
            $('.mailbox-messages input[type=""checkbox""]').iCheck({
                checkboxClass: 'icheckbox_flat-blue',
                radioClass: 'iradio_fla");
            WriteLiteral(@"t-blue'
            });

            //Enable check and uncheck all functionality
            $("".checkbox-toggle"").click(function () {
                var clicks = $(this).data('clicks');
                if (clicks) {
                    //Uncheck all checkboxes
                    $("".mailbox-messages input[type='checkbox']"").iCheck(""uncheck"");
                    $("".fa"", this).removeClass(""fa-check-square-o"").addClass('fa-square-o');
                } else {
                    //Check all checkboxes
                    $("".mailbox-messages input[type='checkbox']"").iCheck(""check"");
                    $("".fa"", this).removeClass(""fa-square-o"").addClass('fa-check-square-o');
                }
                $(this).data(""clicks"", !clicks);
            });

            //Handle starring for glyphicon and font awesome
            $("".mailbox-star"").click(function (e) {
                e.preventDefault();
                //detect type
                var $this = $(this).find(""a > i"");
 ");
            WriteLiteral(@"               var glyph = $this.hasClass(""glyphicon"");
                var fa = $this.hasClass(""fa"");

                //Switch states
                if (glyph) {
                    $this.toggleClass(""glyphicon-star"");
                    $this.toggleClass(""glyphicon-star-empty"");
                }

                if (fa) {
                    $this.toggleClass(""fa-star"");
                    $this.toggleClass(""fa-star-o"");
                }
            });
        });
    </script>
    <script>
        $(""button[type='Button']"").click(function (e) {
            $(this).siblings(""textarea"").toggle();

        });
        $(""input[name='FullName']"").keyup(function () {
            $.ajax({
                url: ""/Admin/GetUser"",
                method: ""GET"",
                data: { name: $(this).val() },
                success: function () {
                    $(""#target"").val(""Found"");
                },
                error: function () {
                    $(""#target"").");
            WriteLiteral("val(\"Unknown\");\r\n                }\r\n\r\n            });\r\n\r\n        });</script>\r\n    <script src=\"../../dist/js/demo.js\"></script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MessageBox>> Html { get; private set; }
    }
}
#pragma warning restore 1591
