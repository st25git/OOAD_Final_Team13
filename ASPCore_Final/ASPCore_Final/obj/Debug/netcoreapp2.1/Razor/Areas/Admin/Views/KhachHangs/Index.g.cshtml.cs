#pragma checksum "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ecc3320df1c8e541789759b19dd3d0ac9678574"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_KhachHangs_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/KhachHangs/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/KhachHangs/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_KhachHangs_Index))]
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
#line 1 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\_ViewImports.cshtml"
using ASPCore_Final;

#line default
#line hidden
#line 2 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\_ViewImports.cshtml"
using ASPCore_Final.Models;

#line default
#line hidden
#line 3 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Index.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ecc3320df1c8e541789759b19dd3d0ac9678574", @"/Areas/Admin/Views/KhachHangs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b88735fcb76687533fa848e18cb76dff3784b38", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_KhachHangs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReflectionIT.Mvc.Paging.PagingList<ASPCore_Final.Models.KhachHang>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangeStatus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(252, 112, true);
            WriteLiteral("\r\n\r\n\r\n<div class=\"outer-w3-agile mt-3\">\r\n    <h4 class=\"tittle-w3-agileits mb-4\">Danh sách khách hàng</h4>\r\n    ");
            EndContext();
            BeginContext(364, 354, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e874f572e262410e8b5c697a18dbcb93", async() => {
                BeginContext(403, 81, true);
                WriteLiteral("\r\n        <input name=\"searchString\" class=\"form-control\" placeholder=\"Search...\"");
                EndContext();
                BeginWriteAttribute("value", "\r\n               value=\"", 484, "\"", 541, 1);
#line 16 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Index.cshtml"
WriteAttributeValue("", 508, Model.RouteValue["searchString"], 508, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(542, 169, true);
                WriteLiteral(" />\r\n        <button type=\"submit\" class=\"btn btn-info\">\r\n            <span class=\"glyphicon glyphicon-search\" aria-hidden=\"true\"></span> Search\r\n        </button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
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
            BeginContext(718, 120, true);
            WriteLiteral("\r\n\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th scope=\"col\">\r\n                    ");
            EndContext();
            BeginContext(839, 44, false);
#line 26 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.TaiKhoan));

#line default
#line hidden
            EndContext();
            BeginContext(883, 95, true);
            WriteLiteral("\r\n                </th>\r\n              \r\n                <th scope=\"col\">\r\n                    ");
            EndContext();
            BeginContext(979, 41, false);
#line 30 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(1020, 92, true);
            WriteLiteral("\r\n                </th>\r\n           \r\n                <th scope=\"col\">\r\n                    ");
            EndContext();
            BeginContext(1113, 42, false);
#line 34 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(1155, 79, true);
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
            EndContext();
            BeginContext(1235, 45, false);
#line 37 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.DienThoai));

#line default
#line hidden
            EndContext();
            BeginContext(1280, 79, true);
            WriteLiteral("\r\n                </th>\r\n                <th scope=\"col\">\r\n                    ");
            EndContext();
            BeginContext(1360, 41, false);
#line 40 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1401, 92, true);
            WriteLiteral("\r\n                </th>\r\n           \r\n                <th scope=\"col\">\r\n                    ");
            EndContext();
            BeginContext(1494, 47, false);
#line 44 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.TrangThaiHd));

#line default
#line hidden
            EndContext();
            BeginContext(1541, 106, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 50 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1704, 84, true);
            WriteLiteral("                <tr>\r\n                    <td scope=\"row\">\r\n                        ");
            EndContext();
            BeginContext(1789, 43, false);
#line 54 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TaiKhoan));

#line default
#line hidden
            EndContext();
            BeginContext(1832, 113, true);
            WriteLiteral("\r\n                    </td>\r\n                    \r\n                    <td scope=\"row\">\r\n                        ");
            EndContext();
            BeginContext(1946, 40, false);
#line 58 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(1986, 110, true);
            WriteLiteral("\r\n                    </td>\r\n                 \r\n                    <td scope=\"row\">\r\n                        ");
            EndContext();
            BeginContext(2097, 41, false);
#line 62 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(2138, 91, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td scope=\"row\">\r\n                        ");
            EndContext();
            BeginContext(2230, 44, false);
#line 65 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DienThoai));

#line default
#line hidden
            EndContext();
            BeginContext(2274, 91, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td scope=\"row\">\r\n                        ");
            EndContext();
            BeginContext(2366, 40, false);
#line 68 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2406, 112, true);
            WriteLiteral("\r\n                    </td>\r\n                   \r\n                    <td scope=\"row\">\r\n                        ");
            EndContext();
            BeginContext(2518, 150, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91052ba6f9c94bc2bc1d75a8375d4feb", async() => {
                BeginContext(2592, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(2594, 70, false);
#line 72 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Index.cshtml"
                                                                                              Write(Html.Raw(item.TrangThaiHd == true ? "<strong>True</strong>" : "False"));

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
#line 72 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Index.cshtml"
                                                       WriteLiteral(item.MaKh);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2668, 117, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td scope=\"row\">\r\n                        \r\n                        ");
            EndContext();
            BeginContext(2785, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ef38e3a93d14a788fdc87e799806b43", async() => {
                BeginContext(2859, 12, true);
                WriteLiteral("Xem chi tiết");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 76 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Index.cshtml"
                                                  WriteLiteral(item.MaKh);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2875, 55, true);
            WriteLiteral(" \r\n\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 80 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2945, 101, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <nav class=\"navbar-default justify-content-center\">\r\n\r\n\r\n        ");
            EndContext();
            BeginContext(3047, 135, false);
#line 86 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\KhachHangs\Index.cshtml"
   Write(await this.Component.InvokeAsync("Pager", new { pagingList = this.Model, @searchString = @ViewBag.SearchString, @class = "page-item" }));

#line default
#line hidden
            EndContext();
            BeginContext(3182, 26, true);
            WriteLiteral("\r\n\r\n\r\n    </nav>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReflectionIT.Mvc.Paging.PagingList<ASPCore_Final.Models.KhachHang>> Html { get; private set; }
    }
}
#pragma warning restore 1591
