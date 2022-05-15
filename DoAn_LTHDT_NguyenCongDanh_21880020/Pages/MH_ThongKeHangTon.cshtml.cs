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
    public class MH_ThongKeHangTonModel : PageModel
    {
        public string chuoi = string.Empty;
        public List<HangTon> lstHangTon;
        IXuLy_HangTon xuLyHangTon;
        public MH_ThongKeHangTonModel()
        {
            xuLyHangTon = new XuLy_HangTon();
        }
        public void OnGet()
        {
            var kq = xuLyHangTon.ThongKeHangTon();
            if (kq.IsSuccess)
            {
                lstHangTon = kq.Data;
            }
            else
            {
                chuoi = kq.Message;
            }
        }
    }
}
