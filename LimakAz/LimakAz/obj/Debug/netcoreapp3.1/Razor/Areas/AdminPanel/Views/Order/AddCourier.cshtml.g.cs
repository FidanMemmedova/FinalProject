#pragma checksum "C:\Users\ASUS\Desktop\LimakFinall\LimakAz\LimakAz\Areas\AdminPanel\Views\Order\AddCourier.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c5abfaa40239b34b20f795d8a7e10785d06e063"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_Order_AddCourier), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Order/AddCourier.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\LimakFinall\LimakAz\LimakAz\Areas\AdminPanel\Views\_ViewImports.cshtml"
using LimakAz.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\LimakFinall\LimakAz\LimakAz\Areas\AdminPanel\Views\_ViewImports.cshtml"
using LimakAz.Areas.Manage.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\LimakFinall\LimakAz\LimakAz\Areas\AdminPanel\Views\_ViewImports.cshtml"
using LimakAz.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c5abfaa40239b34b20f795d8a7e10785d06e063", @"/Areas/AdminPanel/Views/Order/AddCourier.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55f8fd2a8111212c02e053e956e237eddca5c73f", @"/Areas/AdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_AdminPanel_Views_Order_AddCourier : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CourierViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("outline:none;box-shadow:none;border-color:#808080;margin-bottom:30px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddCourier", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\LimakFinall\LimakAz\LimakAz\Areas\AdminPanel\Views\Order\AddCourier.cshtml"
  
    ViewData["Title"] = "AddCourier";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container-fluid\">\r\n    <h1 style=\"text-decoration:underline;margin-top:20px\">");
#nullable restore
#line 9 "C:\Users\ASUS\Desktop\LimakFinall\LimakAz\LimakAz\Areas\AdminPanel\Views\Order\AddCourier.cshtml"
                                                     Write(Model.Order.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'s Order</h1>\r\n    <div class=\"card\" style=\"border:none;\">\r\n        <div class=\"card-body\">\r\n            <p class=\"card-text\">\r\n                Order url: <span style=\"font-weight:bold\">");
#nullable restore
#line 13 "C:\Users\ASUS\Desktop\LimakFinall\LimakAz\LimakAz\Areas\AdminPanel\Views\Order\AddCourier.cshtml"
                                                     Write(Model.Order.Url);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </p>\r\n            <p class=\"card-text\">\r\n                Shop Name: <span style=\"font-weight:bold\">");
#nullable restore
#line 16 "C:\Users\ASUS\Desktop\LimakFinall\LimakAz\LimakAz\Areas\AdminPanel\Views\Order\AddCourier.cshtml"
                                                     Write(Model.Order.ShopName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </p>\r\n            <p class=\"card-text\">\r\n                Price: <span style=\"font-weight:bold\">");
#nullable restore
#line 19 "C:\Users\ASUS\Desktop\LimakFinall\LimakAz\LimakAz\Areas\AdminPanel\Views\Order\AddCourier.cshtml"
                                                 Write(Model.Order.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("₼</span>\r\n            </p>\r\n            <p class=\"card-text\">\r\n                Count: <span style=\"font-weight:bold\">");
#nullable restore
#line 22 "C:\Users\ASUS\Desktop\LimakFinall\LimakAz\LimakAz\Areas\AdminPanel\Views\Order\AddCourier.cshtml"
                                                 Write(Model.Order.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </p>\r\n            <p class=\"card-text\">\r\n                Order Warehouse: <span style=\"font-weight:bold\">");
#nullable restore
#line 25 "C:\Users\ASUS\Desktop\LimakFinall\LimakAz\LimakAz\Areas\AdminPanel\Views\Order\AddCourier.cshtml"
                                                           Write(Model.Order.AppUser.WareHouse?.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </p>\r\n            <p class=\"card-text\">\r\n                Order Date: <span style=\"font-weight:bold\">");
#nullable restore
#line 28 "C:\Users\ASUS\Desktop\LimakFinall\LimakAz\LimakAz\Areas\AdminPanel\Views\Order\AddCourier.cshtml"
                                                      Write(Model.Order.CreatedAt.AddHours(4).ToString("dd MMM yyyy HH:mm "));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </p>\r\n            <p class=\"card-text\">\r\n                Order Status: <span style=\"font-weight:bold\">");
#nullable restore
#line 31 "C:\Users\ASUS\Desktop\LimakFinall\LimakAz\LimakAz\Areas\AdminPanel\Views\Order\AddCourier.cshtml"
                                                        Write(Model.Order.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </p>\r\n            <p class=\"card-text\">\r\n                <span style=\"text-decoration: underline;color:red\">Total Price</span>: <span style=\"font-weight:bold;\">");
#nullable restore
#line 34 "C:\Users\ASUS\Desktop\LimakFinall\LimakAz\LimakAz\Areas\AdminPanel\Views\Order\AddCourier.cshtml"
                                                                                                                   Write(Model.Order.Count * Model.Order.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("₼</span>\r\n            </p>\r\n        </div>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c5abfaa40239b34b20f795d8a7e10785d06e0639870", async() => {
                WriteLiteral("\r\n            <div class=\"row flex-column\">\r\n                <div class=\"col-md-2\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c5abfaa40239b34b20f795d8a7e10785d06e06310239", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 41 "C:\Users\ASUS\Desktop\LimakFinall\LimakAz\LimakAz\Areas\AdminPanel\Views\Order\AddCourier.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CourierId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 41 "C:\Users\ASUS\Desktop\LimakFinall\LimakAz\LimakAz\Areas\AdminPanel\Views\Order\AddCourier.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList((List<Courier>)ViewBag.Couriers,"Id","FullName"));

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4c5abfaa40239b34b20f795d8a7e10785d06e06312507", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 43 "C:\Users\ASUS\Desktop\LimakFinall\LimakAz\LimakAz\Areas\AdminPanel\Views\Order\AddCourier.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Order.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <div class=\"col-md-4\">\r\n                    <button type=\"submit\" class=\"btn btn-info\">Confirm Courier</button>\r\n                </div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CourierViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
