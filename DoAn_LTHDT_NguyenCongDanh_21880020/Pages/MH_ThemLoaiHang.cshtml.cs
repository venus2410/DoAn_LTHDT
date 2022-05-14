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
    public class MH_ThemLoaiHangModel : PageModel
    {
        public string chuoi = string.Empty;
        IXuLy_LoaiHang xuLy;
        [BindProperty]
        public string Ma { get; set; }
        [BindProperty]
        public string Ten { get; set; }
        public MH_ThemLoaiHangModel()
        {
            xuLy = new XuLy_LoaiHang();
        }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            try
            {
                LoaiHang lh = new LoaiHang();
                lh.MaLH = Ma;
                lh.TenLH = Ten;
                var kq = xuLy.ThemLoaiHang(lh);
                if (kq.IsSuccess)
                {
                    chuoi = "Lưu thành công";
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
