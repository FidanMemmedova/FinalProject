#pragma checksum "C:\Users\ASUS\Desktop\LimakFinall\LimakAz\LimakAz\Views\UserPanel\Courier.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a2ae8e73eb587decb20fdf3d40adff433edfe2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserPanel_Courier), @"mvc.1.0.view", @"/Views/UserPanel/Courier.cshtml")]
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
#line 1 "C:\Users\ASUS\Desktop\LimakFinall\LimakAz\LimakAz\Views\_ViewImports.cshtml"
using LimakAz;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\LimakFinall\LimakAz\LimakAz\Views\_ViewImports.cshtml"
using LimakAz.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\LimakFinall\LimakAz\LimakAz\Views\_ViewImports.cshtml"
using LimakAz.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ASUS\Desktop\LimakFinall\LimakAz\LimakAz\Views\_ViewImports.cshtml"
using LimakAz.Models.Settings;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a2ae8e73eb587decb20fdf3d40adff433edfe2f", @"/Views/UserPanel/Courier.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10a6eeb31fee36ad6100b089d6d3f557358b4cc8", @"/Views/_ViewImports.cshtml")]
    public class Views_UserPanel_Courier : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CourierViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\LimakFinall\LimakAz\LimakAz\Views\UserPanel\Courier.cshtml"
  
    ViewData["Title"] = "Courier";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\ASUS\Desktop\LimakFinall\LimakAz\LimakAz\Views\UserPanel\Courier.cshtml"
  
    ViewData["Title"] = "Address";
    Layout = "~/Views/Shared/_LayoutUser.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-sm-12 col-md-8 col-lg-9"">
                <div>
                    <div class=""content"">
                        <div class=""row"">
                            <div>
                                <ul id=""headerList"" class=""nav nav nav-tabs card-tabs-nav"">
                                    <li class=""nav-item"">
                                        <a href=""#"" class=""nav-link active"" data-target=""1"">
                                            <span class=""card-tabs-nav-title"">
                                                Yeni kuryer
                                            </span>
                                        </a>
                                    </li>
                                    <li class=""nav-item card-tabs"">
                                        <a href=""#"" class=""nav-link"" data-target=""2"">
                                            <span class=""card-tabs-nav-title"">Kuryer izl??</span>
                                        </");
            WriteLiteral(@"a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                        <div class=""tab-content card-tabs-body"">
                            <div class=""tab-pane active active-tab"" data-id=""1"">
                                <div class=""card order-item order-item-safety"">
                                    <div class=""card-body"">
                                        <div class=""card-step"">
                                            <h3 class=""step-title upper"">Anbar Se??in</h3>
                                            <fieldset class=""form-group"" style=""border: 0;"">
                                                <div>
                                                    <div class=""check-custom custom-control custom-radio"">
                                                        <input type=""radio"" name=""depo-radios"" value=""1""
                                                             ");
            WriteLiteral(@"  class=""custom-control-input"" id=""1"">
                                                        <label class=""custom-control-label ccl"" for=""1"">
                                                            Bak?? - ??????ri????h??r
                                                        </label>
                                                    </div>
                                                    <div class=""check-custom custom-control custom-radio"">
                                                        <input type=""radio"" name=""depo-radios"" value=""1""
                                                               class=""custom-control-input"" id=""2"">
                                                        <label class=""custom-control-label ccl"" for=""2"">
                                                            Bak?? - Xalqlar Dostlu??u
                                                        </label>
                                                    </div>
                                         ");
            WriteLiteral(@"           <div class=""check-custom custom-control custom-radio"">
                                                        <input type=""radio"" name=""depo-radios"" value=""1""
                                                               class=""custom-control-input"" id=""3"">
                                                        <label class=""custom-control-label ccl"" for=""3"">
                                                            Sumqay??t
                                                        </label>
                                                    </div>
                                                    <div class=""check-custom custom-control custom-radio"">
                                                        <input type=""radio"" name=""depo-radios"" value=""1""
                                                               class=""custom-control-input"" id=""4"">
                                                        <label class=""custom-control-label ccl"" for=""4"">
                           ");
            WriteLiteral(@"                                 G??nc??
                                                        </label>
                                                    </div>
                                                    <div class=""check-custom custom-control custom-radio"">
                                                        <input type=""radio"" name=""depo-radios"" value=""1""
                                                               class=""custom-control-input "" id=""5"">
                                                        <label class=""custom-control-label ccl"" for=""5"">
                                                            Zaqatala
                                                        </label>
                                                    </div>
                                                    <div class=""check-custom custom-control custom-radio"">
                                                        <input type=""radio"" name=""depo-radios"" value=""1""
                          ");
            WriteLiteral(@"                                     class=""custom-control-input "" id=""5"">
                                                        <label class=""custom-control-label ccl"" for=""5"">
                                                            Balak??n
                                                        </label>
                                                    </div>
                                                </div>
                                            </fieldset>
                                        </div>
                                        <div class=""card-step"">
                                            <h3 class=""step-title upper"">??RAZ?? SE????N</h3>
                                            <fieldset class=""form-group"" style=""border: 0;"">
                                                <div>
                                                    <div class=""check-custom check-custom-block custom-control custom-radio-2"">
                                                    ");
            WriteLiteral(@"    <input type=""radio"" name=""loc-radios"" value=""1""
                                                               class=""custom-control-input-2"" id=""loc1"">
                                                        <label class=""custom-control-label ccl-2"" for=""loc1"">
                                                            S??bail, Yasamal, N??simi, Bin??q??di, N??rimanov - 3 AZN
                                                            <strong>3 AZN</strong>
                                                        </label>
                                                    </div>
                                                    <div class=""check-custom check-custom-block custom-control custom-radio"">
                                                        <input type=""radio"" name=""loc-radios"" value=""1""
                                                               class=""custom-control-input-2"" id=""loc2"">
                                                        <label class=""custom-control-label c");
            WriteLiteral(@"cl-2"" for=""loc2"">
                                                            X??tai, Nizami, Sabun??u, Suraxan?? - 4 AZN
                                                            <strong>4 AZN</strong>
                                                        </label>
                                                    </div>
                                                    <div class=""check-custom check-custom-block custom-control custom-radio"">
                                                        <input type=""radio"" name=""loc-radios"" value=""1""
                                                               class=""custom-control-input-2"" id=""loc3"">
                                                        <label class=""custom-control-label ccl-2"" for=""loc3"">
                                                            X??rdalan,Masaz??r,L??kbatan - 5 AZN
                                                            <strong>5 AZN</strong>
                                                        </label>");
            WriteLiteral(@"
                                                    </div>
                                                    <div class=""check-custom check-custom-block custom-control custom-radio"">
                                                        <input type=""radio"" name=""loc-radios"" value=""1""
                                                               class=""custom-control-input-2 "" id=""loc4"">
                                                        <label class=""custom-control-label ccl-2"" for=""loc4"">
                                                            Bak?? ??traf?? k??nd v?? q??s??b??l??r - 5 AZN
                                                            <strong>5 AZN</strong>
                                                        </label>
                                                    </div>
                                                </div>
                                            </fieldset>
                                        </div>
                                        <bu");
            WriteLiteral(@"tton type=""button"" disabled=""disabled""
                                                class=""btn btn-submit btn-primary disabled"">
                                            <span>
                                                Yadda saxla
                                            </span>
                                        </button>
                                    </div>
                                </div>
                            </div>
                            <div class=""tab-pane active-tab"" data-id=""2"">
                                <div class=""card order-item order-item-courier"">
                                    <div class=""card-body"">
                                        <div class=""table-responsive"">
                                            <table class=""table b-table order-table responsive_table"">
                                                <thead role=""rowgroup"">
                                                    <tr role=""row""");
            BeginWriteAttribute("class", " class=\"", 10388, "\"", 10396, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        <th role=\"columnheader\" scope=\"col\" aria-colindex=\"1\"");
            BeginWriteAttribute("class", "\r\n                                                            class=\"", 10509, "\"", 10578, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                            <div>???</div>\r\n                                                        </th>\r\n                                                        <th role=\"columnheader\" scope=\"col\" aria-colindex=\"2\"");
            BeginWriteAttribute("class", "\r\n                                                            class=\"", 10828, "\"", 10897, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                            <div>Kuryer</div>\r\n                                                        </th>\r\n                                                        <th role=\"columnheader\" scope=\"col\" aria-colindex=\"3\"");
            BeginWriteAttribute("class", "\r\n                                                            class=\"", 11152, "\"", 11221, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                            <div>Qiym??t</div>\r\n                                                        </th>\r\n                                                        <th role=\"columnheader\" scope=\"col\" aria-colindex=\"4\"");
            BeginWriteAttribute("class", "\r\n                                                            class=\"", 11476, "\"", 11545, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                            <div>Status</div>\r\n                                                        </th>\r\n                                                        <th role=\"columnheader\" scope=\"col\" aria-colindex=\"5\"");
            BeginWriteAttribute("class", "\r\n                                                            class=\"", 11800, "\"", 11869, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                            <div>??m??liyyat</div>
                                                        </th>
                                                    </tr>
                                                </thead>
                                                <tbody role=""rowgroup"">
                                                    <tr role=""row""");
            BeginWriteAttribute("class", " class=\"", 12274, "\"", 12282, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        <td aria-colindex=\"1\"");
            BeginWriteAttribute("class", " class=\"", 12363, "\"", 12371, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                            <p>
                                                                57419
                                                            </p>
                                                        </td>
                                                        <td aria-colindex=""2""");
            BeginWriteAttribute("class", " class=\"", 12717, "\"", 12725, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                            <p class=""order-item-courier-location""
                                                               style=""overflow: hidden;"">
                                                                Bak?? 2ci zona,
                                                                Suraxan??, Qara??uxur
                                                            </p>
                                                        </td>
                                                        <td aria-colindex=""3""");
            BeginWriteAttribute("class", " class=\"", 13291, "\"", 13299, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                            <span>3.00 AZN</span>\r\n                                                        </td>\r\n                                                        <td aria-colindex=\"4\"");
            BeginWriteAttribute("class", " class=\"", 13526, "\"", 13534, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                            <span data-v-4faa5138="""" class=""upper text-success""
                                                                  style=""cursor: initial; font-weight: bold;"">
                                                                <span style=""color: red;"">
                                                                    T??hvil verildi
                                                                </span>
                                                            </span>
                                                        </td>
                                                        <td aria-colindex=""5""");
            BeginWriteAttribute("class", " class=\"", 14221, "\"", 14229, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                            <div class=""courier-btns"">
                                                                <button type=""button""
                                                                        class=""btn btn-action btn-orange btn-secondary"">
                                                                    Bax
                                                                </button>
                                                                <button type=""button""
                                                                        class=""btn btn-action btn-green btn-secondary"">
                                                                    ??d??nilib
                                                                </button>
                                                            </div>
                                                        </td>
                                                    </tr>
                         ");
            WriteLiteral(@"                       </tbody>
                                            </table>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
");
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
