#pragma checksum "C:\Users\aleks\Desktop\Homework_Class10\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\Pizza\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20ef6bcb360527056f8e61a2884bbc28506f50b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pizza_Details), @"mvc.1.0.view", @"/Views/Pizza/Details.cshtml")]
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
#line 1 "C:\Users\aleks\Desktop\Homework_Class10\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Refactored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aleks\Desktop\Homework_Class10\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Refactored.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\aleks\Desktop\Homework_Class10\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.ViewModels.OrderViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\aleks\Desktop\Homework_Class10\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.ViewModels.HomeViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\aleks\Desktop\Homework_Class10\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.ViewModels.PizzaViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\aleks\Desktop\Homework_Class10\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.ViewModels.FeedbackViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\aleks\Desktop\Homework_Class10\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Domain.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20ef6bcb360527056f8e61a2884bbc28506f50b1", @"/Views/Pizza/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a3792632c3a66cda99795a6eb041e9070e56481", @"/Views/_ViewImports.cshtml")]
    public class Views_Pizza_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzaDetailsViewModel>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""text-center"">
    <h2 class=""display-4"">Pizza Details</h2>
</div>
<br />
<br />


<div class=""card text-white bg-dark mb-3"" style=""max-width: 18rem; margin-left:10px;"">
    <div class=""card-body"">
        <img class=""card-img-top"" src=""https://alternate-takes.com/wp-content/uploads/2021/05/s2.jpg"" alt=""Card image cap"">
        <h5 class=""card-title"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20ef6bcb360527056f8e61a2884bbc28506f50b14826", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 12 "C:\Users\aleks\Desktop\Homework_Class10\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\Pizza\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(": ");
#nullable restore
#line 12 "C:\Users\aleks\Desktop\Homework_Class10\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\Pizza\Details.cshtml"
                                                          Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <h5 class=\"card-title\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20ef6bcb360527056f8e61a2884bbc28506f50b16643", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 13 "C:\Users\aleks\Desktop\Homework_Class10\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\Pizza\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(": ");
#nullable restore
#line 13 "C:\Users\aleks\Desktop\Homework_Class10\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\Pizza\Details.cshtml"
                                                        Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <h6 class=\"card-subtitle mb-2 text-muted\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20ef6bcb360527056f8e61a2884bbc28506f50b18489", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 15 "C:\Users\aleks\Desktop\Homework_Class10\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\Pizza\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IsOnPromotion);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(": ");
#nullable restore
#line 15 "C:\Users\aleks\Desktop\Homework_Class10\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\Pizza\Details.cshtml"
                                                      if (Model.IsOnPromotion)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Yes</span>");
#nullable restore
#line 16 "C:\Users\aleks\Desktop\Homework_Class10\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\Pizza\Details.cshtml"
                             }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>No</span>\r\n");
#nullable restore
#line 20 "C:\Users\aleks\Desktop\Homework_Class10\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\Pizza\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </h6>\r\n            \r\n        <h4>Orders:</h4>\r\n");
#nullable restore
#line 24 "C:\Users\aleks\Desktop\Homework_Class10\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\Pizza\Details.cshtml"
         foreach(OrderListViewModel o in ViewBag.ConnectedOrders)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h5> ");
#nullable restore
#line 26 "C:\Users\aleks\Desktop\Homework_Class10\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\Pizza\Details.cshtml"
    Write(o.UserFullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n        <br />\r\n        Delivered: ");
#nullable restore
#line 28 "C:\Users\aleks\Desktop\Homework_Class10\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\Pizza\Details.cshtml"
              Write(o.Delivered);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n");
#nullable restore
#line 29 "C:\Users\aleks\Desktop\Homework_Class10\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\Pizza\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<br />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
