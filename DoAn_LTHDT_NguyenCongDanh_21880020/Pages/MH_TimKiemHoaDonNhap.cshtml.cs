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
    public class MH_TimKiemHoaDonNhapModel : PageModel
    {
        public string chuoi = string.Empty;
        public List<HoaDon> lstHDN;
        public List<string> lstTenMH;
        IXuLy_HoaDonNhap xuLyHDN;
        [BindProperty]
        public string noiDungTimKiem { get; set; }
        public MH_TimKiemHoaDonNhapModel()
        {
            xuLyHDN = new XuLy_HoaDonNhap();
        }
        public void OnGet()
        {
            var kq = xuLyHDN.DocHoaDonNhap();
            if (kq.IsSuccess)
            {
                lstHDN = kq.Data;
                var kq2= xuLyHDN.TimTenTheoID(lstHDN);
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
            var kq = xuLyHDN.TimKiemHoaDonNhap(noiDungTimKiem);
            if (kq.IsSuccess)
            {
                if (kq.Data.Count > 0)
                {
                    lstHDN = kq.Data;
                    lstTenMH = xuLyHDN.TimTenTheoID(lstHDN).Data;
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
