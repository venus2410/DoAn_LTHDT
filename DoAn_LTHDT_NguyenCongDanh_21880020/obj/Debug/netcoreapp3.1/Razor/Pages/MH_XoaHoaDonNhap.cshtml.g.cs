#pragma checksum "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_XoaHoaDonNhap.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edbed6814fd6db6351e31e9d591c5e02c7f91077"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DoAn_LTHDT_NguyenCongDanh_21880020.Pages.Pages_MH_XoaHoaDonNhap), @"mvc.1.0.razor-page", @"/Pages/MH_XoaHoaDonNhap.cshtml")]
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
#line 3 "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_XoaHoaDonNhap.cshtml"
using Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edbed6814fd6db6351e31e9d591c5e02c7f91077", @"/Pages/MH_XoaHoaDonNhap.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52ea825a3a477a20c3e70c1745eb7fd0096a33d6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MH_XoaHoaDonNhap : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            WriteLiteral("<h2>Xóa hóa đơn nhập</h2>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edbed6814fd6db6351e31e9d591c5e02c7f910773883", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 6 "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_XoaHoaDonNhap.cshtml"
Write(Model.chuoi);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_XoaHoaDonNhap.cshtml"
     if (Model.hdn!=null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <button type=\"submit\">Xóa</button>\r\n");
#nullable restore
#line 10 "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_XoaHoaDonNhap.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <a href=\"/MH_TimKiemHoaDonNhap\">Quay lại</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoAn_LTHDT_NguyenCongDanh_21880020.Pages.Shared.MH_XoaHoaDonNhapModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DoAn_LTHDT_NguyenCongDanh_21880020.Pages.Shared.MH_XoaHoaDonNhapModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DoAn_LTHDT_NguyenCongDanh_21880020.Pages.Shared.MH_XoaHoaDonNhapModel>)PageContext?.ViewData;
        public DoAn_LTHDT_NguyenCongDanh_21880020.Pages.Shared.MH_XoaHoaDonNhapModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591