#pragma checksum "C:\Users\home\Desktop\ASPCore\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\PhieuNhapHang\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbfa24f6379444b8f8927dd1535fd057c4b63f83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_PhieuNhapHang_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/PhieuNhapHang/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/PhieuNhapHang/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_PhieuNhapHang_Index))]
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
#line 1 "C:\Users\home\Desktop\ASPCore\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\_ViewImports.cshtml"
using ASPCore_Final;

#line default
#line hidden
#line 2 "C:\Users\home\Desktop\ASPCore\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\_ViewImports.cshtml"
using ASPCore_Final.Models;

#line default
#line hidden
#line 2 "C:\Users\home\Desktop\ASPCore\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\PhieuNhapHang\Index.cshtml"
using ReflectionIT.Mvc.Paging;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbfa24f6379444b8f8927dd1535fd057c4b63f83", @"/Areas/Admin/Views/PhieuNhapHang/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b88735fcb76687533fa848e18cb76dff3784b38", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_PhieuNhapHang_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReflectionIT.Mvc.Paging.PagingList<ASPCore_Final.Models.PhieuNhapHang>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ThemMoi", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChitietPhieuHang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LayThongTin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\home\Desktop\ASPCore\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\PhieuNhapHang\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(254, 5, true);
            WriteLiteral("<div>");
            EndContext();
            BeginContext(259, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4193de874674f8bb7ca65072ce46e63", async() => {
                BeginContext(283, 56, true);
                WriteLiteral("<span class=\"glyphicon glyphicon-plus\"></span> Thêm mới");
                EndContext();
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
            EndContext();
            BeginContext(343, 23, true);
            WriteLiteral("</div>\r\n<br />\r\n<div>\r\n");
            EndContext();
#line 11 "C:\Users\home\Desktop\ASPCore\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\PhieuNhapHang\Index.cshtml"
     if (Model != null)
    {

#line default
#line hidden
            BeginContext(398, 272, true);
            WriteLiteral(@"        <table class=""table table-bordered"">
            <tr>
                <th>STT</th>
                <th>Mã phiếu nhập</th>
                <th>Ngày nhập</th>
                <th>Tổng tiền</th>
                <th>Xem chi tiết</th>
            </tr>
");
            EndContext();
#line 21 "C:\Users\home\Desktop\ASPCore\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\PhieuNhapHang\Index.cshtml"
              
                var STT = 1;
            

#line default
#line hidden
            BeginContext(731, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 24 "C:\Users\home\Desktop\ASPCore\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\PhieuNhapHang\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(788, 42, true);
            WriteLiteral("                <tr>\r\n                    ");
            EndContext();
            BeginContext(830, 506, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbe9d08c3a254247954826b6d4669f07", async() => {
                BeginContext(875, 30, true);
                WriteLiteral("\r\n                        <td>");
                EndContext();
                BeginContext(906, 3, false);
#line 28 "C:\Users\home\Desktop\ASPCore\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\PhieuNhapHang\Index.cshtml"
                       Write(STT);

#line default
#line hidden
                EndContext();
                BeginContext(909, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(945, 9, false);
#line 29 "C:\Users\home\Desktop\ASPCore\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\PhieuNhapHang\Index.cshtml"
                       Write(item.MaPn);

#line default
#line hidden
                EndContext();
                BeginContext(954, 87, true);
                WriteLiteral("</td>\r\n                        <td><input type=\"datetime\" name=\"ngaynhap\" id=\"ngaynhap\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1041, "\"", 1092, 1);
#line 30 "C:\Users\home\Desktop\ASPCore\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\PhieuNhapHang\Index.cshtml"
WriteAttributeValue("", 1049, item.NgayNhap.ToString("dd/MM/yyyy hh:mm"), 1049, 43, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1093, 66, true);
                WriteLiteral(" class=\"form-control\" /></td>\r\n                        <td><label>");
                EndContext();
                BeginContext(1160, 49, false);
#line 31 "C:\Users\home\Desktop\ASPCore\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\PhieuNhapHang\Index.cshtml"
                              Write(Convert.ToDouble(item.TongTien).ToString("#,##0"));

#line default
#line hidden
                EndContext();
                BeginContext(1209, 43, true);
                WriteLiteral("</label></td>\r\n                        <td>");
                EndContext();
                BeginContext(1252, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b1ad9ff7ea040db8d3c72cda812a638", async() => {
                    BeginContext(1285, 13, true);
                    WriteLiteral("Xem chi tiết");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1302, 27, true);
                WriteLiteral("</td>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1336, 25, true);
            WriteLiteral("\r\n                </tr>\r\n");
            EndContext();
#line 35 "C:\Users\home\Desktop\ASPCore\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\PhieuNhapHang\Index.cshtml"
                STT = STT + 1;
            }

#line default
#line hidden
            BeginContext(1408, 91, true);
            WriteLiteral("        </table>\r\n        <nav class=\"navbar-default justify-content-center\">\r\n            ");
            EndContext();
            BeginContext(1500, 135, false);
#line 39 "C:\Users\home\Desktop\ASPCore\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\PhieuNhapHang\Index.cshtml"
       Write(await this.Component.InvokeAsync("Pager", new { pagingList = this.Model, @searchString = @ViewBag.SearchString, @class = "page-item" }));

#line default
#line hidden
            EndContext();
            BeginContext(1635, 18, true);
            WriteLiteral("\r\n        </nav>\r\n");
            EndContext();
#line 41 "C:\Users\home\Desktop\ASPCore\ASPCore_Final\ASPCore_Final\Areas\Admin\Views\PhieuNhapHang\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1660, 10, true);
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReflectionIT.Mvc.Paging.PagingList<ASPCore_Final.Models.PhieuNhapHang>> Html { get; private set; }
    }
}
#pragma warning restore 1591