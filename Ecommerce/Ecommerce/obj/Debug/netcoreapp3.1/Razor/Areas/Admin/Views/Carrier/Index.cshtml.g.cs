#pragma checksum "C:\Users\H\Desktop\ASP.NET\Ecommerce\Ecommerce\Areas\Admin\Views\Carrier\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c49b2eed4d2afefc2f4ba31728dd5d55b31043aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Carrier_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Carrier/Index.cshtml")]
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
#line 1 "C:\Users\H\Desktop\ASP.NET\Ecommerce\Ecommerce\Areas\Admin\Views\_ViewImports.cshtml"
using Ecommerce.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\H\Desktop\ASP.NET\Ecommerce\Ecommerce\Areas\Admin\Views\_ViewImports.cshtml"
using Ecommerce.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c49b2eed4d2afefc2f4ba31728dd5d55b31043aa", @"/Areas/Admin/Views/Carrier/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"feffe933301ccd7f8f1eba43fbe6062f5089a17a", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Carrier_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ecommerce.Areas.Admin.Models.CarriersModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\H\Desktop\ASP.NET\Ecommerce\Ecommerce\Areas\Admin\Views\Carrier\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""main-content"">

    <div class=""page-content"">
        <div class=""container-fluid"">

            <!-- start page title -->
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""page-title-box d-flex align-items-center justify-content-between"">
                        <h4 class=""mb-0 font-size-18"">Orders</h4>
                        <div class=""page-title-right"">
                            <ol class=""breadcrumb m-0"">
                                <li class=""breadcrumb-item""><a href=""javascript: void(0);"">Ecommerce</a></li>
                                <li class=""breadcrumb-item active"">Orders</li>
                            </ol>
                        </div>

                    </div>
                </div>
            </div>
            <!-- end page title -->

            <div class=""row"">
                <div class=""col-12"">
                    <div class=""card"">
                        <div class=""card-body"">
    ");
            WriteLiteral(@"                        <div class=""row mb-2"">
                                <div class=""col-sm-4"">
                                    <div class=""search-box mr-2 mb-2 d-inline-block"">
                                        <div class=""position-relative"">
                                            <input type=""text"" class=""form-control"" placeholder=""Search..."">
                                            <i class=""bx bx-search-alt search-icon""></i>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-sm-8"">
                                    <div class=""text-sm-right"">
                                        <button type=""button"" class=""btn btn-success btn-rounded waves-effect waves-light mb-2 mr-2""><i class=""mdi mdi-plus mr-1""></i>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c49b2eed4d2afefc2f4ba31728dd5d55b31043aa6657", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</button>
                                    </div>
                                </div><!-- end col-->
                            </div>

                            <div class=""table-responsive"">
                                <table class=""table table-centered table-nowrap"">
                                    <thead class=""thead-light"">
                                        <tr>
                                            <th style=""width: 20px;"">
                                                <div class=""custom-control custom-checkbox"">
                                                    <input type=""checkbox"" class=""custom-control-input"" id=""customCheck1"">
                                                    <label class=""custom-control-label"" for=""customCheck1"">&nbsp;</label>
                                                </div>
                                            </th>
                                            <th>
                                                ");
#nullable restore
#line 59 "C:\Users\H\Desktop\ASP.NET\Ecommerce\Ecommerce\Areas\Admin\Views\Carrier\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.CarrierID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 62 "C:\Users\H\Desktop\ASP.NET\Ecommerce\Ecommerce\Areas\Admin\Views\Carrier\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.CarrierName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </th>\r\n                                            <th>\r\n                                                ");
#nullable restore
#line 65 "C:\Users\H\Desktop\ASP.NET\Ecommerce\Ecommerce\Areas\Admin\Views\Carrier\Index.cshtml"
                                           Write(Html.DisplayNameFor(model => model.CarrierStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </th>
                                            <th>View Details</th>
                                            <th>Action</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 72 "C:\Users\H\Desktop\ASP.NET\Ecommerce\Ecommerce\Areas\Admin\Views\Carrier\Index.cshtml"
                                         foreach (var item in Model)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <tr>
                                                <td>
                                                    <div class=""custom-control custom-checkbox"">
                                                        <input type=""checkbox"" class=""custom-control-input"" id=""customCheck2"">
                                                        <label class=""custom-control-label"" for=""customCheck2"">&nbsp;</label>
                                                    </div>
                                                </td>
                                                <td>");
#nullable restore
#line 81 "C:\Users\H\Desktop\ASP.NET\Ecommerce\Ecommerce\Areas\Admin\Views\Carrier\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.CarrierID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 83 "C:\Users\H\Desktop\ASP.NET\Ecommerce\Ecommerce\Areas\Admin\Views\Carrier\Index.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.CarrierName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    <span class=\"badge badge-pill badge-soft-success font-size-12\">");
#nullable restore
#line 86 "C:\Users\H\Desktop\ASP.NET\Ecommerce\Ecommerce\Areas\Admin\Views\Carrier\Index.cshtml"
                                                                                                              Write(Html.DisplayFor(modelItem => item.CarrierStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                </td>\r\n                                                <td>\r\n                                                    <!-- Button trigger modal -->\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c49b2eed4d2afefc2f4ba31728dd5d55b31043aa12906", async() => {
                WriteLiteral("\r\n                                                        View Details\r\n                                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 90 "C:\Users\H\Desktop\ASP.NET\Ecommerce\Ecommerce\Areas\Admin\Views\Carrier\Index.cshtml"
                                                                              WriteLiteral(item.CarrierID);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c49b2eed4d2afefc2f4ba31728dd5d55b31043aa15395", async() => {
                WriteLiteral("<i class=\"mdi mdi-pencil font-size-18\"></i>");
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
#nullable restore
#line 95 "C:\Users\H\Desktop\ASP.NET\Ecommerce\Ecommerce\Areas\Admin\Views\Carrier\Index.cshtml"
                                                                           WriteLiteral(item.CarrierID);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c49b2eed4d2afefc2f4ba31728dd5d55b31043aa17685", async() => {
                WriteLiteral("<i class=\"mdi mdi-close font-size-18\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 96 "C:\Users\H\Desktop\ASP.NET\Ecommerce\Ecommerce\Areas\Admin\Views\Carrier\Index.cshtml"
                                                                             WriteLiteral(item.CarrierID);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                                                </td>\r\n                                            </tr>\r\n");
#nullable restore
#line 99 "C:\Users\H\Desktop\ASP.NET\Ecommerce\Ecommerce\Areas\Admin\Views\Carrier\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </tbody>
                                </table>
                            </div>
                            <ul class=""pagination pagination-rounded justify-content-end mb-2"">
                                <li class=""page-item disabled"">
                                    <a class=""page-link"" href=""javascript: void(0);"" aria-label=""Previous"">
                                        <i class=""mdi mdi-chevron-left""></i>
                                    </a>
                                </li>
                                <li class=""page-item active""><a class=""page-link"" href=""javascript: void(0);"">1</a></li>
                                <li class=""page-item""><a class=""page-link"" href=""javascript: void(0);"">2</a></li>
                                <li class=""page-item""><a class=""page-link"" href=""javascript: void(0);"">3</a></li>
                                <li class=""page-item""><a class=""page-link"" href=""javascript: void(0);"">4</a></li>
   ");
            WriteLiteral(@"                             <li class=""page-item""><a class=""page-link"" href=""javascript: void(0);"">5</a></li>
                                <li class=""page-item"">
                                    <a class=""page-link"" href=""javascript: void(0);"" aria-label=""Next"">
                                        <i class=""mdi mdi-chevron-right""></i>
                                    </a>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
            <!-- end row -->
        </div> <!-- container-fluid -->
    </div>
    <!-- End Page-content -->
    <!-- Modal -->
    <div class=""modal fade exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-centered"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""mo");
            WriteLiteral(@"dal-title"" id=""exampleModalLabel"">Order Details</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">×</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <p class=""mb-2"">Product id: <span class=""text-primary"">#SK2540</span></p>
                    <p class=""mb-4"">Billing Name: <span class=""text-primary"">Neal Matthews</span></p>

                    <div class=""table-responsive"">
                        <table class=""table table-centered table-nowrap"">
                            <thead>
                                <tr>
                                    <th scope=""col"">Product</th>
                                    <th scope=""col"">Product Name</th>
                                    <th scope=""col"">Price</th>
                                </tr>
                            </thead>
                            <tbody>");
            WriteLiteral("\n                                <tr>\r\n                                    <th scope=\"row\">\r\n                                        <div>\r\n                                            <img src=\"assets\\images\\product\\img-7.png\"");
            BeginWriteAttribute("alt", " alt=\"", 9353, "\"", 9359, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""avatar-sm"">
                                        </div>
                                    </th>
                                    <td>
                                        <div>
                                            <h5 class=""text-truncate font-size-14"">Wireless Headphone (Black)</h5>
                                            <p class=""text-muted mb-0"">$ 225 x 1</p>
                                        </div>
                                    </td>
                                    <td>$ 255</td>
                                </tr>
                                <tr>
                                    <th scope=""row"">
                                        <div>
                                            <img src=""assets\images\product\img-4.png""");
            BeginWriteAttribute("alt", " alt=\"", 10170, "\"", 10176, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""avatar-sm"">
                                        </div>
                                    </th>
                                    <td>
                                        <div>
                                            <h5 class=""text-truncate font-size-14"">Hoodie (Blue)</h5>
                                            <p class=""text-muted mb-0"">$ 145 x 1</p>
                                        </div>
                                    </td>
                                    <td>$ 145</td>
                                </tr>
                                <tr>
                                    <td colspan=""2"">
                                        <h6 class=""m-0 text-right"">Sub Total:</h6>
                                    </td>
                                    <td>
                                        $ 400
                                    </td>
                                </tr>
                                <tr>
                        ");
            WriteLiteral(@"            <td colspan=""2"">
                                        <h6 class=""m-0 text-right"">Shipping:</h6>
                                    </td>
                                    <td>
                                        Free
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan=""2"">
                                        <h6 class=""m-0 text-right"">Total:</h6>
                                    </td>
                                    <td>
                                        $ 400
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                </div>
            </d");
            WriteLiteral(@"iv>
        </div>
    </div>


    <footer class=""footer"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-sm-6"">
                    <script>document.write(new Date().getFullYear())</script>2020 © Skote.
                </div>
                <div class=""col-sm-6"">
                    <div class=""text-sm-right d-none d-sm-block"">
                        Design &amp; Develop by Themesbrand
                    </div>
                </div>
            </div>
        </div>
    </footer>
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 232 "C:\Users\H\Desktop\ASP.NET\Ecommerce\Ecommerce\Areas\Admin\Views\Carrier\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Ecommerce.Areas.Admin.Models.CarriersModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
