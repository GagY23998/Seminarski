#pragma checksum "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\Admin\ReadMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22719396f4d3701340af50113d8db8004ba565d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ReadMessage), @"mvc.1.0.view", @"/Views/Admin/ReadMessage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/ReadMessage.cshtml", typeof(AspNetCore.Views_Admin_ReadMessage))]
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
#line 3 "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\Admin\ReadMessage.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 5 "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\Admin\ReadMessage.cshtml"
using OnlineShopping.HelperUser;

#line default
#line hidden
#line 2 "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\Admin\ReadMessage.cshtml"
using System.IO;

#line default
#line hidden
#line 4 "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\Admin\ReadMessage.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22719396f4d3701340af50113d8db8004ba565d4", @"/Views/Admin/ReadMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a96f90fb2833102f5d693d20751e04b41939f10f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ReadMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MessageViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SendMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-block margin-bottom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("tooltip"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-container", new global::Microsoft.AspNetCore.Html.HtmlString("body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Reply"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Download", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mailbox-attachment-name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 10 "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\Admin\ReadMessage.cshtml"
   Layout = "~/Views/Shared/_Layout.cshtml";
    var unreadMessages = service.GetUnreadMessages(access.HttpContext.Session.GetUser().Id);
    var imgSrc = string.Format("data:image/png;base64,{0}", Convert.ToBase64String(Model.Attachment));
    

#line default
#line hidden
            BeginContext(562, 215, true);
            WriteLiteral("\r\n<div class=\"content-wrapper\">\r\n    <!-- Content Header (Page header) -->\r\n    <section class=\"content-header\">\r\n        <h1>\r\n            Read Mail\r\n        </h1>\r\n        <ol class=\"breadcrumb\">\r\n            <li>");
            EndContext();
            BeginContext(777, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39309db2eb444b4e8b5040aefc0c41b6", async() => {
                BeginContext(821, 36, true);
                WriteLiteral("<i class=\"fa fa-dashboard\"></i> Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(861, 220, true);
            WriteLiteral("</li>\r\n            <li class=\"active\">Mailbox</li>\r\n        </ol>\r\n    </section>\r\n    <!-- Main content -->\r\n    <section class=\"content\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-3\">\r\n                ");
            EndContext();
            BeginContext(1081, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd051f34147145149e2620cb67ebc5c5", async() => {
                BeginContext(1157, 7, true);
                WriteLiteral("Compose");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1168, 659, true);
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
                                ");
            EndContext();
            BeginContext(1827, 241, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "034f6b67f62b48afa9c4a4fbec8da908", async() => {
                BeginContext(1854, 154, true);
                WriteLiteral("\r\n                                    <i class=\"fa fa-inbox\"></i> Inbox\r\n                                    <span class=\"label label-primary pull-right\">");
                EndContext();
                BeginContext(2009, 14, false);
#line 45 "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\Admin\ReadMessage.cshtml"
                                                                            Write(unreadMessages);

#line default
#line hidden
                EndContext();
                BeginContext(2023, 41, true);
                WriteLiteral("</span>\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2068, 2106, true);
            WriteLiteral(@"
                            </li>
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
                            <li><a href=""#""><i class=""fa fa-circle-o text-yellow""></i> Promotions</a></li>
                         ");
            WriteLiteral(@"   <li><a href=""#""><i class=""fa fa-circle-o text-light-blue""></i> Social</a></li>
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
                        <h3 class=""box-title"">Read Mail</h3>
                        <div class=""box-tools pull-right"">
                            <a href=""#"" class=""btn btn-box-tool"" data-toggle=""tooltip"" title=""Previous""><i class=""fa fa-chevron-left""></i></a>
                            <a href=""#"" class=""btn btn-box-tool"" data-toggle=""tooltip"" title=""Next""><i class=""fa fa-chevron-right""></i></a>
                        </div>
                    </div>
                    <!-- /.box-header -->
                    <div class=""box-body no-padding"">
                        <div cl");
            WriteLiteral("ass=\"mailbox-read-info\">\r\n                            <h3>");
            EndContext();
            BeginContext(4175, 13, false);
#line 86 "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\Admin\ReadMessage.cshtml"
                           Write(Model.Subject);

#line default
#line hidden
            EndContext();
            BeginContext(4188, 79, true);
            WriteLiteral("</h3>\r\n                            <h5>\r\n                                From: ");
            EndContext();
            BeginContext(4268, 15, false);
#line 88 "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\Admin\ReadMessage.cshtml"
                                 Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(4283, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(4285, 14, false);
#line 88 "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\Admin\ReadMessage.cshtml"
                                                  Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(4299, 77, true);
            WriteLiteral("\r\n                                <span class=\"mailbox-read-time pull-right\">");
            EndContext();
            BeginContext(4377, 18, false);
#line 89 "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\Admin\ReadMessage.cshtml"
                                                                      Write(Model.CreationDate);

#line default
#line hidden
            EndContext();
            BeginContext(4395, 551, true);
            WriteLiteral(@"</span>
                            </h5>
                        </div>
                        <!-- /.mailbox-read-info -->
                        <div class=""mailbox-controls with-border text-center"">
                            <div class=""btn-group"">
                                <button type=""button"" class=""btn btn-default btn-sm"" data-toggle=""tooltip"" data-container=""body"" title=""Delete"">
                                    <i class=""fa fa-trash-o""></i>
                                </button>
                                ");
            EndContext();
            BeginContext(4946, 244, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02baf19637254f9db2025afbd12c6f46", async() => {
                BeginContext(5082, 99, true);
                WriteLiteral("\r\n                                    <i class=\"fa fa-reply\"></i>\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5190, 735, true);
            WriteLiteral(@"
                                <button type=""button"" class=""btn btn-default btn-sm"" data-toggle=""tooltip"" data-container=""body"" title=""Forward"">
                                    <i class=""fa fa-share""></i>
                                </button>
                            </div>
                            <!-- /.btn-group -->
                            <button type=""button"" class=""btn btn-default btn-sm"" data-toggle=""tooltip"" title=""Print"">
                                <i class=""fa fa-print""></i>
                            </button>
                        </div>
                        <!-- /.mailbox-controls -->
                        <div class=""mailbox-read-message"">
                            ");
            EndContext();
            BeginContext(5926, 13, false);
#line 112 "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\Admin\ReadMessage.cshtml"
                       Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(5939, 372, true);
            WriteLiteral(@"
                        </div>
                        <!-- /.mailbox-read-message -->
                    </div>
                    <!-- /.box-body -->
                    <div class=""box-footer"">
                        <ul class=""mailbox-attachments clearfix"">
                            <div class=""mailbox-attachment-info"">
                                ");
            EndContext();
            BeginContext(6311, 252, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "481b954380ed458b8971bea4910414de", async() => {
                BeginContext(6488, 71, true);
                WriteLiteral("<i class=\"fa fa-camera\"></i>\r\n                                 Download");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-subject", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 120 "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\Admin\ReadMessage.cshtml"
                                                                WriteLiteral(Model.Subject);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["subject"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-subject", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["subject"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 120 "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\Admin\ReadMessage.cshtml"
                                                                                                    WriteLiteral(Model.UserName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["username"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-username", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["username"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 120 "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\Admin\ReadMessage.cshtml"
                                                                                                                                     WriteLiteral(Model.CreationDate.ToString());

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["date"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-date", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["date"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6563, 958, true);
            WriteLiteral(@"
                                <span class=""mailbox-attachment-size"">
                                    1.9 MB
                                    <a href=""#"" class=""btn btn-default btn-xs pull-right""><i class=""fa fa-cloud-download""></i></a>
                                </span>
                            </div>
                        </ul>
                    </div>
                    <!-- /.box-footer -->
                    <div class=""box-footer"">
                        <button type=""button"" id=""delete"" class=""btn btn-default""><i class=""fa fa-trash-o""></i> Delete</button>
                                         </div>
                    <!-- /.box-footer -->
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
    $(""#delete"").click(function () {
        var mydata = ");
            EndContext();
            BeginContext(7522, 60, false);
#line 145 "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\Admin\ReadMessage.cshtml"
                Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(Model)));

#line default
#line hidden
            EndContext();
            BeginContext(7582, 360, true);
            WriteLiteral(@";
        $.ajax({
            url:""/Admin/DeleteMessage"",
            type: ""POST"",
            data: { model: mydata },
            success: function () {
                console.log(""success"");
            },
            error: function () {
                console.log(""Something went wrong"");
            }
        });
    });

</script>

");
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
