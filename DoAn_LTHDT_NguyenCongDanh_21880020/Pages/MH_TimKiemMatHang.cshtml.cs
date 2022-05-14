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
    public class MH_TimKiemMatHangModel : PageModel
    {
        public string chuoi = string.Empty;
        public List<MatHang> lstMH;
        public List<string> lstTenLoai;
        IXuLy_LoaiHang xuLyLH;
        IXuLy_MatHang xuLyMH;
        [BindProperty]
        public string noiDungTimKiem { get; set; }
        public MH_TimKiemMatHangModel()
        {
            xuLyLH = new XuLy_LoaiHang();
            xuLyMH = new XuLy_MatHang();
            lstMH = new List<MatHang>();
            lstTenLoai = new List<string>();
        }
        public void OnGet()
        {
            var kq= xuLyMH.DocMatHang();
            if (kq.IsSuccess)
            {
                lstMH = kq.Data;
                var kq2 = xuLyLH.TimTenLoaiHang(lstMH);
                lstTenLoai = kq2.Data;
                chuoi = kq2.Message;
            }
            else
            {
                chuoi = kq.Message;
            }
        }
        public void OnPost()
        {
            var kq = xuLyMH.TimKiemMatHang(noiDungTimKiem);
            if (kq.IsSuccess)
            {
                if (kq.Data.Count>0)
                {
                    lstMH = kq.Data;
                    var kq2= xuLyLH.TimTenLoaiHang(lstMH);
                    lstTenLoai = kq2.Data;
                    chuoi = kq2.Message;
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
