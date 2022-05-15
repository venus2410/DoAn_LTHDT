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
    public class MH_SuaHoaDonXuatModel : PageModel
    {
        public string chuoi = string.Empty;
        public string duongDanManHinh = string.Empty;
        public List<MatHang> lstMH;
        public HoaDon hdBanDau;
        IXuLy_HoaDonXuat xuLyHDX;
        IXuLy_MatHang xuLyMH;

        [BindProperty(SupportsGet = true)]
        public string Id { get; set; }
        [BindProperty]
        public string mhChon { get; set; }
        [BindProperty]
        public int soLuong { get; set; }
        public MH_SuaHoaDonXuatModel()
        {
            xuLyHDX = new XuLy_HoaDonXuat();
            xuLyMH = new XuLy_MatHang();
            
        }
        public void OnGet()
        {
            var kq = xuLyHDX.TimKiemTheoID(Id);
            if (kq.IsSuccess)
            {
                hdBanDau = kq.Data;
                lstMH = xuLyMH.DocMatHang().Data;
            }
            else
            {
                chuoi = kq.Message;
            }
        }
        public void OnPost()
        {
            HoaDon hdx = new HoaDon(Id, mhChon, soLuong);
            var kq = xuLyHDX.SuaHoaDon(hdx);
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
