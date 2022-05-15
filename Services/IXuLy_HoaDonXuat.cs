using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Entities;

namespace Services
{
    public interface IXuLy_HoaDonXuat
    {
        ServiceResult<bool> ThemHoaDon(HoaDon HDX);
        ServiceResult<List<HoaDon>> DocHoaDon();
        ServiceResult<List<HoaDon>> TimKiemHoaDon(string noiDungTimKiem);
        ServiceResult<List<string>> TimTenTheoID(List<HoaDon> lstHDN);
        ServiceResult<HoaDon> TimKiemTheoID(string id);
        ServiceResult<bool> SuaHoaDon(HoaDon hoaDonXuat);
        ServiceResult<bool> XoaHoaDon(string id);
    }
}
