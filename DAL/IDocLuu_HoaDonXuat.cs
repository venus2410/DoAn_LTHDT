using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Entities;

namespace DAL
{
    public interface IDocLuu_HoaDonXuat
    {
        List<HoaDon> DocHoaDon();
        void LuuDanhSachHoaDon(List<HoaDon> ds);
        void LuuHoaDonNhap(HoaDon hoaDon);
        bool SuaHoaDon(HoaDon hoaDon);
        bool XoaHoaDon(string id);
    }
}
