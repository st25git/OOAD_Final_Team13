#pragma checksum "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\EditProfile\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1e2691d05b06408a844e094af403665ce033bbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EditProfile_Delete), @"mvc.1.0.view", @"/Views/EditProfile/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/EditProfile/Delete.cshtml", typeof(AspNetCore.Views_EditProfile_Delete))]
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
#line 1 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\_ViewImports.cshtml"
using ASPCore_Final;

#line default
#line hidden
#line 2 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\_ViewImports.cshtml"
using ASPCore_Final.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1e2691d05b06408a844e094af403665ce033bbd", @"/Views/EditProfile/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cae0022d08f620143d968fa9654a9b9c381b59a0", @"/Views/_ViewImports.cshtml")]
    public class Views_EditProfile_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASPCore_Final.Models.KhachHang>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\EditProfile\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_frontEnd.cshtml";

#line default
#line hidden
            BeginContext(132, 170, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>KhachHang</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(303, 44, false);
#line 16 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\EditProfile\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TaiKhoan));

#line default
#line hidden
            EndContext();
            BeginContext(347, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(391, 40, false);
#line 19 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\EditProfile\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TaiKhoan));

#line default
#line hidden
            EndContext();
            BeginContext(431, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(475, 43, false);
#line 22 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\EditProfile\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MatKhau));

#line default
#line hidden
            EndContext();
            BeginContext(518, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(562, 39, false);
#line 25 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\EditProfile\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MatKhau));

#line default
#line hidden
            EndContext();
            BeginContext(601, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(645, 41, false);
#line 28 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\EditProfile\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(686, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(730, 37, false);
#line 31 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\EditProfile\Delete.cshtml"
       Write(Html.DisplayFor(model => model.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(767, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(811, 44, false);
#line 34 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\EditProfile\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.GioiTinh));

#line default
#line hidden
            EndContext();
            BeginContext(855, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(899, 40, false);
#line 37 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\EditProfile\Delete.cshtml"
       Write(Html.DisplayFor(model => model.GioiTinh));

#line default
#line hidden
            EndContext();
            BeginContext(939, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(983, 44, false);
#line 40 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\EditProfile\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NgaySinh));

#line default
#line hidden
            EndContext();
            BeginContext(1027, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1071, 40, false);
#line 43 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\EditProfile\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NgaySinh));

#line default
#line hidden
            EndContext();
            BeginContext(1111, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1155, 42, false);
#line 46 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\EditProfile\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(1197, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1241, 38, false);
#line 49 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\EditProfile\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(1279, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1323, 45, false);
#line 52 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\EditProfile\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DienThoai));

#line default
#line hidden
            EndContext();
            BeginContext(1368, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1412, 41, false);
#line 55 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\EditProfile\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DienThoai));

#line default
#line hidden
            EndContext();
            BeginContext(1453, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1497, 41, false);
#line 58 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\EditProfile\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1538, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1582, 37, false);
#line 61 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\EditProfile\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1619, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1663, 40, false);
#line 64 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\EditProfile\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Hinh));

#line default
#line hidden
            EndContext();
            BeginContext(1703, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1747, 36, false);
#line 67 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\EditProfile\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Hinh));

#line default
#line hidden
            EndContext();
            BeginContext(1783, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1827, 47, false);
#line 70 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\EditProfile\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TrangThaiHd));

#line default
#line hidden
            EndContext();
            BeginContext(1874, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1918, 43, false);
#line 73 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\EditProfile\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TrangThaiHd));

#line default
#line hidden
            EndContext();
            BeginContext(1961, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1999, 209, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d59eab626f13491a9a93f17616a7c359", async() => {
                BeginContext(2025, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2035, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b23dd3b7dcc7437391c7402a9c617bb7", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 78 "C:\Users\Dell\Downloads\Github\ASPNETCore_Final\ASPCore_Final\ASPCore_Final\Views\EditProfile\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MaKh);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2073, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2157, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aba84a5b7f2a43cb97e8aa7125c03b88", async() => {
                    BeginContext(2179, 12, true);
                    WriteLiteral("Back to List");
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
                BeginContext(2195, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2208, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASPCore_Final.Models.KhachHang> Html { get; private set; }
    }
}
#pragma warning restore 1591
