#pragma checksum "C:\Users\aleks\Desktop\App2\SEDC.PizzaApp\SEDC.PizzaApp\Views\Order\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ef656eb5f3cb18b589a6a6162ffeaf459fb6a7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Details), @"mvc.1.0.view", @"/Views/Order/Details.cshtml")]
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
#nullable restore
#line 1 "C:\Users\aleks\Desktop\App2\SEDC.PizzaApp\SEDC.PizzaApp\Views\_ViewImports.cshtml"
using SEDC.PizzaApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aleks\Desktop\App2\SEDC.PizzaApp\SEDC.PizzaApp\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\aleks\Desktop\App2\SEDC.PizzaApp\SEDC.PizzaApp\Views\Order\Details.cshtml"
using SEDC.PizzaApp.Models.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aleks\Desktop\App2\SEDC.PizzaApp\SEDC.PizzaApp\Views\Order\Details.cshtml"
using SEDC.PizzaApp.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ef656eb5f3cb18b589a6a6162ffeaf459fb6a7a", @"/Views/Order/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9df46eeb8e9226be8f48cfc38e77ab42cd37ae40", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h2>Order details:</h2>\n<h4>");
#nullable restore
#line 7 "C:\Users\aleks\Desktop\App2\SEDC.PizzaApp\SEDC.PizzaApp\Views\Order\Details.cshtml"
Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n\n");
            WriteLiteral("\n");
            WriteLiteral("<p>Pizza name: ");
#nullable restore
#line 15 "C:\Users\aleks\Desktop\App2\SEDC.PizzaApp\SEDC.PizzaApp\Views\Order\Details.cshtml"
          Write(Model.PizzaName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>User: ");
#nullable restore
#line 16 "C:\Users\aleks\Desktop\App2\SEDC.PizzaApp\SEDC.PizzaApp\Views\Order\Details.cshtml"
    Write(Model.UserFullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>Payment method: ");
#nullable restore
#line 17 "C:\Users\aleks\Desktop\App2\SEDC.PizzaApp\SEDC.PizzaApp\Views\Order\Details.cshtml"
              Write(Model.PaymentMethod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>Order price: ");
#nullable restore
#line 18 "C:\Users\aleks\Desktop\App2\SEDC.PizzaApp\SEDC.PizzaApp\Views\Order\Details.cshtml"
           Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" DEN </p>\n<p>User address: ");
#nullable restore
#line 19 "C:\Users\aleks\Desktop\App2\SEDC.PizzaApp\SEDC.PizzaApp\Views\Order\Details.cshtml"
            Write(Model.UserAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n<h4>The first user in our app is: ");
#nullable restore
#line 21 "C:\Users\aleks\Desktop\App2\SEDC.PizzaApp\SEDC.PizzaApp\Views\Order\Details.cshtml"
                             Write(ViewBag.User.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
