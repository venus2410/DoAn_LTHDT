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
    public class MH_TimKiemLoaiHangModel : PageModel
    {
        public string chuoi = string.Empty;
        public List<LoaiHang> lstLH = new List<LoaiHang>();
        IXuLy_LoaiHang xuLy;
        [BindProperty]
        public string noiDungTimKiem { get; set; }
        public MH_TimKiemLoaiHangModel()
        {
            xuLy = new XuLy_LoaiHang();
        }
        public void OnGet()
        {
            var kq = xuLy.DocLoaiHang();
            if (kq.IsSuccess)
            {
                lstLH = kq.Data;
            }
            else
            {
                chuoi = kq.Message;
            }
        }
        public void OnPost()
        {
            var kq = xuLy.TimKiemLoaiHang(noiDungTimKiem);
            if (kq.IsSuccess)
            {
                if (kq.Data.Count > 0)
                {
                    lstLH = kq.Data;
                }
                else
                {
                    chuoi = "Không tìm thấy mặt hàng";
                }
            }
            else
            {
                chuoi = kq.Message;
            }
        }
    }
}
