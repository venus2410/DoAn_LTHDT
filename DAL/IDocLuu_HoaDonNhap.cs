using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace DAL
{
    public interface IDocLuu_HoaDonNhap
    {
        List<HoaDon> DocHoaDon();
        void LuuDanhSachHoaDon(List<HoaDon> ds);
        void TaoHoaDon(HoaDon hoaDon);
        bool SuaHoaDon(HoaDon hoaDon);
        bool XoaHoaDon(string id);
    }
}
