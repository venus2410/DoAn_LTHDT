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
    public class MH_TaoHoaDonXuatModel : PageModel
    {
        public string chuoi = string.Empty;
        public List<MatHang> lstMH;
        IXuLy_HoaDonXuat xuLyHDX;
        IXuLy_MatHang xuLyMH;
        [BindProperty]
        public string maHD { get; set; }
        [BindProperty]
        public string mhChon { get; set; }
        [BindProperty]
        public int soLuong { get; set; }
        public MH_TaoHoaDonXuatModel()
        {
            xuLyHDX = new XuLy_HoaDonXuat();
            xuLyMH = new XuLy_MatHang();
            var kq1 = xuLyMH.DocMatHang();
            if (kq1.IsSuccess)
            {
                lstMH = kq1.Data;
            }
            else
            {
                chuoi = kq1.Message;
            }
        }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            HoaDon hdx = new HoaDon(maHD, mhChon, soLuong);
            var kq = xuLyHDX.ThemHoaDon(hdx);
            if (kq.IsSuccess)
            {
                chuoi = "Thêm thành công";
            }
            else
            {
                chuoi = kq.Message;
            }
        }
    }
}
