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
    public class MH_XoaLoaiHangModel : PageModel
    {
        public string chuoi = string.Empty;
        IXuLy_LoaiHang xuLy;
        public LoaiHang lh=new LoaiHang();
        public bool timThay;
        [BindProperty(SupportsGet =true)]
        public string Id { get; set; }
        public MH_XoaLoaiHangModel()
        {
            xuLy = new XuLy_LoaiHang();
        }
        public void OnGet()
        {
            var kq = xuLy.TimKiemTheoID(Id);
            if (kq.IsSuccess)
            {
                lh = kq.Data;
                timThay = true;
                chuoi = $"Bạn chắc chắn muốn xóa loại hàng: {lh.TenLH}?";
            }
            else
            {
                chuoi = kq.Message;
            }
        }
        public void OnPost()
        {
            var kq = xuLy.XoaLoaiHang(Id);
            if (kq.IsSuccess)
            {
                Response.Redirect("/MH_TimKiemLoaiHang");
            }
            else
            {
                chuoi = kq.Message;
            }
        }
    }
}
