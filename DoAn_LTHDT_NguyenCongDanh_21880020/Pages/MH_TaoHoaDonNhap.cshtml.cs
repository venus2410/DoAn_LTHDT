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
    public class MH_TaoHoaDonNhapModel : PageModel
    {
        public string chuoi = string.Empty;
        public List<MatHang> lstMH;
        IXuLy_MatHang xuLyMH;
        IXuLy_HoaDonNhap xuLyHDN;
        [BindProperty]
        public string maHD { get; set; }
        [BindProperty]
        public string mhChon { get; set; }
        [BindProperty]
        public int soLuong { get; set; }
        public MH_TaoHoaDonNhapModel()
        {
            xuLyMH = new XuLy_MatHang();
            xuLyHDN = new XuLy_HoaDonNhap();
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
            HoaDon hdn = new HoaDon(maHD, mhChon, soLuong);
            var kq = xuLyHDN.ThemHoaDonNhap(hdn);
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
