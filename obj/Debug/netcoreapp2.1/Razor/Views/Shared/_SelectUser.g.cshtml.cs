#pragma checksum "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\Shared\_SelectUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf43e9eba609eab3cc08adb7e6844a205914a512"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SelectUser), @"mvc.1.0.view", @"/Views/Shared/_SelectUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_SelectUser.cshtml", typeof(AspNetCore.Views_Shared__SelectUser))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf43e9eba609eab3cc08adb7e6844a205914a512", @"/Views/Shared/_SelectUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a96f90fb2833102f5d693d20751e04b41939f10f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__SelectUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 29, true);
            WriteLiteral("\r\n<ul class=\"list-group\">\r\n\r\n");
            EndContext();
#line 5 "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\Shared\_SelectUser.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(84, 84, true);
            WriteLiteral("    <li class=\"myuser list-group-item\" style=\"display:none\"><p style=\"display:none\">");
            EndContext();
            BeginContext(169, 14, false);
#line 7 "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\Shared\_SelectUser.cshtml"
                                                                               Write(item.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(183, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(185, 13, false);
#line 7 "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\Shared\_SelectUser.cshtml"
                                                                                               Write(item.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(198, 49, true);
            WriteLiteral("</p><p class=\"emailClick\" style=\"cursor:pointer\">");
            EndContext();
            BeginContext(248, 10, false);
#line 7 "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\Shared\_SelectUser.cshtml"
                                                                                                                                                              Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(258, 11, true);
            WriteLiteral("</p></li>\r\n");
            EndContext();
#line 8 "C:\Users\Asus-i5\Desktop\RS1_Seminarski git\OnlineShop\Views\Shared\_SelectUser.cshtml"
}

#line default
#line hidden
            BeginContext(272, 9, true);
            WriteLiteral("</ul>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
