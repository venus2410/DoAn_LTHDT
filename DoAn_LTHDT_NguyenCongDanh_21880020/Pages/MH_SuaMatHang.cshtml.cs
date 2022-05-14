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
    public class MH_SuaMatHangModel : PageModel
    {
        public string chuoi = string.Empty;
        public MatHang mh;
        public string maLHChon;
        public List<LoaiHang> lstLH;
        IXuLy_MatHang xuLyMH;
        IXuLy_LoaiHang xuLyLH;
        [BindProperty(SupportsGet =true)]
        public string Id { get; set; }
        [BindProperty]
        public string ten { get; set; }
        [BindProperty]
        public string hanDung { get; set; }
        [BindProperty]
        public string ctySX { get; set; }
        [BindProperty]
        public string ngaySX { get; set; }
        [BindProperty]
        public string loai { get; set; }
        [BindProperty]
        public int gia { get; set; }
        public MH_SuaMatHangModel()
        {
            xuLyMH=new XuLy_MatHang();
            xuLyLH =new XuLy_LoaiHang();
            lstLH = xuLyLH.DocLoaiHang().Data;
        }
        public void OnGet()
        {
            var kq = xuLyMH.TimKiemTheoID(Id);
            if (kq.IsSuccess)
            {
                maLHChon = kq.Data.Loai;
                mh = kq.Data;
            }
            else
            {
                chuoi = kq.Message;
            }
        }
        public void OnPost()
        {
            MatHang matHang = new MatHang(Id, ten, hanDung, ctySX, ngaySX, loai, gia);
            var kq = xuLyMH.SuaMatHang(matHang);
            if(kq.IsSuccess)
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
