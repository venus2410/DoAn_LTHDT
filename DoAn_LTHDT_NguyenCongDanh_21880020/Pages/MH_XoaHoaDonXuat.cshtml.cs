using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entities;
using Services;

namespace DoAn_LTHDT_NguyenCongDanh_21880020.Pages
{
    public class MH_XoaHoaDonXuatModel : PageModel
    {
        public string chuoi = string.Empty;
        public HoaDon hdn;
        IXuLy_HoaDonXuat xuLyHDX;
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; }
        public MH_XoaHoaDonXuatModel()
        {
            xuLyHDX = new XuLy_HoaDonXuat();
        }
        public void OnGet()
        {
            var kq = xuLyHDX.TimKiemTheoID(Id);
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
            var kq = xuLyHDX.XoaHoaDon(Id);
            if (kq.IsSuccess)
            {
                Response.Redirect("/MH_TimKiemHoaDonXuat");
            }
            else
            {
                chuoi = kq.Message;
            }
        }
    }
}
