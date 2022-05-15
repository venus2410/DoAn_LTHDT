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
    public class MH_TimKiemHoaDonXuatModel : PageModel
    {
        public string chuoi = string.Empty;
        public List<HoaDon> lstHDX;
        public List<string> lstTenMH;
        IXuLy_HoaDonXuat xuLyHDX;
        [BindProperty]
        public string noiDungTimKiem { get; set; }
        public MH_TimKiemHoaDonXuatModel()
        {
            xuLyHDX = new XuLy_HoaDonXuat();
        }
        public void OnGet()
        {
            var kq = xuLyHDX.DocHoaDon();
            if (kq.IsSuccess)
            {
                lstHDX = kq.Data;
                var kq2= xuLyHDX.TimTenTheoID(lstHDX);
                if (kq2.IsSuccess)
                {
                    lstTenMH = kq2.Data;
                }
                else
                {
                    chuoi = kq2.Message;
                }
                
            }
            else
            {
                chuoi = kq.Message;
            }
        }
        public void OnPost()
        {
            var kq = xuLyHDX.TimKiemHoaDon(noiDungTimKiem);
            if (kq.IsSuccess)
            {
                if (kq.Data.Count > 0)
                {
                    lstHDX = kq.Data;
                    lstTenMH = xuLyHDX.TimTenTheoID(lstHDX).Data;
                }
                else
                {
                    chuoi = "Không tìm thấy hóa đơn";
                }
            }
            else
            {
                chuoi = kq.Message;
            }
        }
    }
}
