using System;
using System.Collections.Generic;
using System.Text;
using Entities;
namespace DAL
{
    public interface IDocLuu_LoaiHang
    {
        List<LoaiHang> DocLoaiHang();
        void LuuDanhSachLoaiHang(List<LoaiHang> ds);
        void LuuLoaiHang(LoaiHang loaiHang);
        bool SuaLoaiHang(LoaiHang lh);
        bool XoaLoaiHang(string id);

    }
}
