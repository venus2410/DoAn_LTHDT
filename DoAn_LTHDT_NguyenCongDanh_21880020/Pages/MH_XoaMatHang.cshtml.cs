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
    public class MH_XoaMatHangModel : PageModel
    {
        public string chuoi = string.Empty;
        public MatHang mh;
        IXuLy_MatHang xuLyMH;
        [BindProperty(SupportsGet =true)]
        public string Id { get; set; }
        public MH_XoaMatHangModel()
        {
            xuLyMH = new XuLy_MatHang();
        }
        public void OnGet()
        {
            var kq = xuLyMH.TimKiemTheoID(Id);
            if (kq.IsSuccess)
            {
                mh = kq.Data;
            }
            else
            {
                chuoi = kq.Message;
            }
        }
        public void OnPost()
        {
            var kq = xuLyMH.XoaMatHang(Id);
            if (kq.IsSuccess)
            {
                Response.Redirect("/MH_TimKiemMatHang");
            }
            else
            {
                chuoi = kq.Message;
            }
        }
    }
}
