#pragma checksum "C:\Users\aleks\Desktop\Coding\GitHub\asp_net_mvc_homework\Homework_Class02\SEDC.PizzaApp\SEDC.PizzaApp\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99b6cb8a65d9b2af5d48a8868257a7d15c158481"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
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
#line 1 "C:\Users\aleks\Desktop\Coding\GitHub\asp_net_mvc_homework\Homework_Class02\SEDC.PizzaApp\SEDC.PizzaApp\Views\_ViewImports.cshtml"
using SEDC.PizzaApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aleks\Desktop\Coding\GitHub\asp_net_mvc_homework\Homework_Class02\SEDC.PizzaApp\SEDC.PizzaApp\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99b6cb8a65d9b2af5d48a8868257a7d15c158481", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9df46eeb8e9226be8f48cfc38e77ab42cd37ae40", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SEDC.PizzaApp.Models.Domain.Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h2>List of orders</h2>\n\n");
#nullable restore
#line 5 "C:\Users\aleks\Desktop\Coding\GitHub\asp_net_mvc_homework\Homework_Class02\SEDC.PizzaApp\SEDC.PizzaApp\Views\Order\Index.cshtml"
 for (int i = 0; i < Model.Count(); i++) //Model == List<Order>
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 7 "C:\Users\aleks\Desktop\Coding\GitHub\asp_net_mvc_homework\Homework_Class02\SEDC.PizzaApp\SEDC.PizzaApp\Views\Order\Index.cshtml"
Write(Model[i].Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 7 "C:\Users\aleks\Desktop\Coding\GitHub\asp_net_mvc_homework\Homework_Class02\SEDC.PizzaApp\SEDC.PizzaApp\Views\Order\Index.cshtml"
             Write(Model[i].Customer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
#nullable restore
#line 7 "C:\Users\aleks\Desktop\Coding\GitHub\asp_net_mvc_homework\Homework_Class02\SEDC.PizzaApp\SEDC.PizzaApp\Views\Order\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SEDC.PizzaApp.Models.Domain.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
