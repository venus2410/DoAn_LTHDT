#pragma checksum "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_TimKiemHoaDonNhap.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b21c78aeafabc449bf27b8d8059defb990e26501"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DoAn_LTHDT_NguyenCongDanh_21880020.Pages.Pages_MH_TimKiemHoaDonNhap), @"mvc.1.0.razor-page", @"/Pages/MH_TimKiemHoaDonNhap.cshtml")]
namespace DoAn_LTHDT_NguyenCongDanh_21880020.Pages
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
#line 1 "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\_ViewImports.cshtml"
using DoAn_LTHDT_NguyenCongDanh_21880020;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_TimKiemHoaDonNhap.cshtml"
using Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b21c78aeafabc449bf27b8d8059defb990e26501", @"/Pages/MH_TimKiemHoaDonNhap.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52ea825a3a477a20c3e70c1745eb7fd0096a33d6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MH_TimKiemHoaDonNhap : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>Tìm kiếm hóa đơn nhập</h2>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b21c78aeafabc449bf27b8d8059defb990e265013916", async() => {
                WriteLiteral("\r\n    <input name=\"noiDungTimKiem\" />\r\n    <button type=\"submit\">Tìm kiếm</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<table>\r\n    <tr>\r\n        <th>Mã hóa đơn</th>\r\n        <th>Mã mặt hàng</th>\r\n        <th>Tên mặt hàng</th>\r\n        <th>Số lượng</th>\r\n        <th></th>\r\n    </tr>\r\n");
#nullable restore
#line 18 "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_TimKiemHoaDonNhap.cshtml"
     if (Model.lstHDN != null)
    {               
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_TimKiemHoaDonNhap.cshtml"
         for (int i = 0; i < Model.lstHDN.Count; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 23 "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_TimKiemHoaDonNhap.cshtml"
               Write(Model.lstHDN[i].MaHoaDon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_TimKiemHoaDonNhap.cshtml"
               Write(Model.lstHDN[i].MatHangChon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_TimKiemHoaDonNhap.cshtml"
               Write(Model.lstTenMH[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_TimKiemHoaDonNhap.cshtml"
               Write(Model.lstHDN[i].SoLuong);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 798, "\"", 851, 2);
            WriteAttributeValue("", 805, "/MH_SuaHoaDonNhap?id=", 805, 21, true);
#nullable restore
#line 28 "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_TimKiemHoaDonNhap.cshtml"
WriteAttributeValue("", 826, Model.lstHDN[i].MaHoaDon, 826, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sửa</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 884, "\"", 937, 2);
            WriteAttributeValue("", 891, "/MH_XoaHoaDonNhap?id=", 891, 21, true);
#nullable restore
#line 29 "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_TimKiemHoaDonNhap.cshtml"
WriteAttributeValue("", 912, Model.lstHDN[i].MaHoaDon, 912, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xóa</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 32 "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_TimKiemHoaDonNhap.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_TimKiemHoaDonNhap.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
#nullable restore
#line 35 "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_TimKiemHoaDonNhap.cshtml"
Write(Model.chuoi);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoAn_LTHDT_NguyenCongDanh_21880020.Pages.MH_TimKiemHoaDonNhapModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DoAn_LTHDT_NguyenCongDanh_21880020.Pages.MH_TimKiemHoaDonNhapModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DoAn_LTHDT_NguyenCongDanh_21880020.Pages.MH_TimKiemHoaDonNhapModel>)PageContext?.ViewData;
        public DoAn_LTHDT_NguyenCongDanh_21880020.Pages.MH_TimKiemHoaDonNhapModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
