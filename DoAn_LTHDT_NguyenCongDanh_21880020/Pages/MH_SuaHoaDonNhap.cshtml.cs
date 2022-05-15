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
    public class MH_SuaHoaDonNhapModel : PageModel
    {
        public string chuoi = string.Empty;
        public List<MatHang> lstMH;
        IXuLy_HoaDonNhap xuLyHDN;
        IXuLy_MatHang xuLyMH;
        public HoaDon hoaDon;
        
        [BindProperty(SupportsGet =true)]
        public string Id{ get; set; }
        [BindProperty]
        public string mhChon { get; set; }
        [BindProperty]
        public int soLuong { get; set; }
        public MH_SuaHoaDonNhapModel()
        {
            xuLyHDN = new XuLy_HoaDonNhap();
            xuLyMH = new XuLy_MatHang();
            lstMH = xuLyMH.DocMatHang().Data;
            
        }

        public void OnGet()
        {
            var kq = xuLyHDN.TimKiemTheoID(Id);
            if (kq.IsSuccess)
            {
                hoaDon = kq.Data;
            }
            else
            {
                chuoi = kq.Message;
            }
        }
        public void OnPost()
        {
            HoaDon hoaDonNhap = new HoaDon(Id, mhChon, soLuong);
            var kq = xuLyHDN.SuaHoaDonNhap(hoaDonNhap);
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
