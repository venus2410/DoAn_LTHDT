using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entities;
using Services;

namespace DoAn_LTHDT_NguyenCongDanh_21880020.Pages.Shared
{
    public class MH_XoaHoaDonNhapModel : PageModel
    {
        public string chuoi = string.Empty;
        public HoaDon hdn;
        IXuLy_HoaDonNhap xuLyHDN;
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; }
        public MH_XoaHoaDonNhapModel()
        {
            xuLyHDN = new XuLy_HoaDonNhap();
        }
        public void OnGet()
        {
            var kq = xuLyHDN.TimKiemTheoID(Id);
            if (kq.IsSuccess)
            {
                hdn = kq.Data;
                chuoi = $"Bạn chắc chắn muốn xóa hóa đơn có mã số: {hdn.MaHoaDon}?";
            }
            else
            {
                chuoi = kq.Message;
            }
        }
        public void OnPost()
        {
            var kq = xuLyHDN.XoaHoaDonNhap(Id);
            if (kq.IsSuccess)
            {
                Response.Redirect("/MH_TimKiemHoaDonNhap");
            }
            else
            {
                chuoi = kq.Message;
            }
        }
    }
}
