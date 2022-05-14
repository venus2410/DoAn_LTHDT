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
    public class MH_SuaLoaiHangModel : PageModel
    {
        public string chuoi = string.Empty;
        public LoaiHang lh = new LoaiHang();
        IXuLy_LoaiHang xuLy;
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; }
        [BindProperty]
        public string ten { get; set; }
        public MH_SuaLoaiHangModel()
        {
            xuLy = new XuLy_LoaiHang();
        }
        public void OnGet()
        {
            var kq = xuLy.TimKiemTheoID(Id);
            if (kq.IsSuccess)
            {
                lh = kq.Data;
            }
            else
            {
                chuoi = kq.Message;
            }
        }
        public void OnPost()
        {
            LoaiHang lHSua = new LoaiHang(Id, ten);
            var kq = xuLy.SuaLoaiHang(lHSua);
            if (kq.IsSuccess)
            {
                Response.Redirect("/MH_TimKiemLoaiHang");
            }
            else
            {
                chuoi = kq.Message;
                lh = xuLy.TimKiemTheoID(Id).Data;
            }
        }
    }
}
