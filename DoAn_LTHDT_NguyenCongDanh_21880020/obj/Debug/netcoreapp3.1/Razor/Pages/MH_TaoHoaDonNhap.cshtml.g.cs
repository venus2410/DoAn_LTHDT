#pragma checksum "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_TaoHoaDonNhap.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16a6f5f64d6ba2a0f4aa37ece55507366ebb6526"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DoAn_LTHDT_NguyenCongDanh_21880020.Pages.Pages_MH_TaoHoaDonNhap), @"mvc.1.0.razor-page", @"/Pages/MH_TaoHoaDonNhap.cshtml")]
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
#line 3 "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_TaoHoaDonNhap.cshtml"
using Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16a6f5f64d6ba2a0f4aa37ece55507366ebb6526", @"/Pages/MH_TaoHoaDonNhap.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52ea825a3a477a20c3e70c1745eb7fd0096a33d6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MH_TaoHoaDonNhap : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>Tạo hóa đơn nhập</h2>\r\n");
#nullable restore
#line 7 "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_TaoHoaDonNhap.cshtml"
 if (Model.lstMH != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16a6f5f64d6ba2a0f4aa37ece55507366ebb65264326", async() => {
                WriteLiteral(@"
        <div class=""row"">
            <div class=""col-4"">
                <label>Mã hóa đơn nhập</label>
                <input name=""maHD"" class=""float-right"" /><br />
                <label>Mặt hàng</label>
                <select name=""mhChon"" id=""mhChon""class=""float-right w-50"">
");
#nullable restore
#line 16 "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_TaoHoaDonNhap.cshtml"
                     foreach (MatHang mh in Model.lstMH)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16a6f5f64d6ba2a0f4aa37ece55507366ebb65265274", async() => {
#nullable restore
#line 18 "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_TaoHoaDonNhap.cshtml"
                                            Write(mh.TenMH);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_TaoHoaDonNhap.cshtml"
                           WriteLiteral(mh.MaMH);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 19 "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_TaoHoaDonNhap.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </select><br />
                <label>Số lượng</label>
                <input name=""soLuong"" type=""number"" id=""soLuong"" required min=""0"" class=""float-right"" /><br />
                <button type=""submit"">Thêm</button><br />
            </div>
        </div>
    ");
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
            WriteLiteral("\r\n");
#nullable restore
#line 27 "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_TaoHoaDonNhap.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_TaoHoaDonNhap.cshtml"
Write(Model.chuoi);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoAn_LTHDT_NguyenCongDanh_21880020.Pages.MH_TaoHoaDonNhapModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DoAn_LTHDT_NguyenCongDanh_21880020.Pages.MH_TaoHoaDonNhapModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DoAn_LTHDT_NguyenCongDanh_21880020.Pages.MH_TaoHoaDonNhapModel>)PageContext?.ViewData;
        public DoAn_LTHDT_NguyenCongDanh_21880020.Pages.MH_TaoHoaDonNhapModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591