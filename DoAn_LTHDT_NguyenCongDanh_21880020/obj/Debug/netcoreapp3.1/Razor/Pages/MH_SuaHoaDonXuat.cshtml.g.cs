#pragma checksum "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_SuaHoaDonXuat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ddbc6bb191f4d84c56410b5d81b5425f857c1fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DoAn_LTHDT_NguyenCongDanh_21880020.Pages.Pages_MH_SuaHoaDonXuat), @"mvc.1.0.razor-page", @"/Pages/MH_SuaHoaDonXuat.cshtml")]
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
#line 3 "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_SuaHoaDonXuat.cshtml"
using Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ddbc6bb191f4d84c56410b5d81b5425f857c1fb", @"/Pages/MH_SuaHoaDonXuat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52ea825a3a477a20c3e70c1745eb7fd0096a33d6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MH_SuaHoaDonXuat : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            WriteLiteral("<h2>S???a h??a ????n xu???t</h2>\r\n");
#nullable restore
#line 5 "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_SuaHoaDonXuat.cshtml"
 if (Model.hdBanDau!=null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ddbc6bb191f4d84c56410b5d81b5425f857c1fb4327", async() => {
                WriteLiteral("\r\n        <div class=\"row\">\r\n            <div class=\"col-4\">\r\n                <label>M?? h??a ????n xu???t</label>\r\n                <input name=\"maHD\" class=\"float-right\"");
                BeginWriteAttribute("value", " value=\"", 341, "\"", 373, 1);
#nullable restore
#line 11 "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_SuaHoaDonXuat.cshtml"
WriteAttributeValue("", 349, Model.hdBanDau.MaHoaDon, 349, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly /><br />\r\n                <label>M???t h??ng</label>\r\n                <select name=\"mhChon\" id=\"mhChon\" class=\"float-right w-50\">\r\n");
#nullable restore
#line 14 "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_SuaHoaDonXuat.cshtml"
                     foreach (MatHang mh in Model.lstMH)
                    {
                        if (mh.MaMH == Model.hdBanDau.MatHangChon)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ddbc6bb191f4d84c56410b5d81b5425f857c1fb5868", async() => {
#nullable restore
#line 18 "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_SuaHoaDonXuat.cshtml"
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
#line 18 "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_SuaHoaDonXuat.cshtml"
                               WriteLiteral(mh.MaMH);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 19 "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_SuaHoaDonXuat.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ddbc6bb191f4d84c56410b5d81b5425f857c1fb8636", async() => {
#nullable restore
#line 22 "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_SuaHoaDonXuat.cshtml"
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
#line 22 "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_SuaHoaDonXuat.cshtml"
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
#line 23 "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_SuaHoaDonXuat.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </select><br />\r\n                <label>S??? l?????ng</label>\r\n                <input name=\"soLuong\" type=\"number\" id=\"soLuong\" required min=\"0\" class=\"float-right\"");
                BeginWriteAttribute("value", " value=\"", 1152, "\"", 1183, 1);
#nullable restore
#line 27 "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_SuaHoaDonXuat.cshtml"
WriteAttributeValue("", 1160, Model.hdBanDau.SoLuong, 1160, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n                <button type=\"submit\">S???a</button>\r\n                <a href=\"/MH_TimKiemHoaDonXuat\">Quay l???i</a>\r\n            </div>\r\n        </div>\r\n    ");
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
#line 33 "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_SuaHoaDonXuat.cshtml"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_SuaHoaDonXuat.cshtml"
Write(Model.chuoi);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <a");
            BeginWriteAttribute("href", " href=\"", 1389, "\"", 1426, 2);
            WriteAttributeValue("", 1396, "/MH_SuaHoaDonXuat?id=", 1396, 21, true);
#nullable restore
#line 36 "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_SuaHoaDonXuat.cshtml"
WriteAttributeValue("", 1417, Model.Id, 1417, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Quay l???i</a>\r\n");
#nullable restore
#line 37 "D:\Hoc Tap\HK2 2021-2022\LTHDT\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\DoAn_LTHDT_NguyenCongDanh_21880020\Pages\MH_SuaHoaDonXuat.cshtml"
}

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoAn_LTHDT_NguyenCongDanh_21880020.Pages.MH_SuaHoaDonXuatModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DoAn_LTHDT_NguyenCongDanh_21880020.Pages.MH_SuaHoaDonXuatModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DoAn_LTHDT_NguyenCongDanh_21880020.Pages.MH_SuaHoaDonXuatModel>)PageContext?.ViewData;
        public DoAn_LTHDT_NguyenCongDanh_21880020.Pages.MH_SuaHoaDonXuatModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
