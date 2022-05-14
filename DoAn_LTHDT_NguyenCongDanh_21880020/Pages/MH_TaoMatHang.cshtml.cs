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
    public class MH_TaoMatHangModel : PageModel
    {
        public string chuoi=string.Empty;
        public List<LoaiHang> lstLH;
        IXuLy_MatHang xuLyMH;
        IXuLy_LoaiHang xuLyLH;
        [BindProperty]
        public string Ma { get; set; }
        [BindProperty]
        public string Ten { get; set; }
        [BindProperty]
        public string HanDung { get; set; }
        [BindProperty]
        public string CongTySX { get; set; }
        [BindProperty]
        public string NgaySX{ get; set; }
        [BindProperty]
        public string Loai { get; set; }
        [BindProperty]
        public int Gia { get; set; }
        public MH_TaoMatHangModel()
        {
            xuLyMH = new XuLy_MatHang();
            xuLyLH = new XuLy_LoaiHang();
            lstLH = xuLyLH.DocLoaiHang().Data;
        }
        public void OnGet()
        {

        }
        public void OnPost()
        {
            try
            {
                MatHang matHang = new MatHang();
                matHang.MaMH = Ma;
                matHang.TenMH = Ten;
                matHang.HanDungMH = HanDung;
                matHang.CongTySX = CongTySX;
                matHang.NgaySX = NgaySX;
                if (!string.IsNullOrEmpty(Loai))
                {
                    matHang.Loai = Loai;
                }
                matHang.Gia = Gia;

                var kq = xuLyMH.ThemMatHang(matHang);
                if (kq.IsSuccess)
                {
                    chuoi = "Luu thanh cong";
                }
                else
                {
                    chuoi = kq.Message;
                }
            }
            catch (Exception ex)
            {
                chuoi = ex.Message;
            }
        }
    }
}
