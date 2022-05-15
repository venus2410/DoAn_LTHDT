using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace Services
{
    public interface IXuLy_HoaDonNhap
    {
        ServiceResult<bool> ThemHoaDonNhap(HoaDon HDN);
        ServiceResult<List<HoaDon>> DocHoaDonNhap();
        ServiceResult<List<HoaDon>> TimKiemHoaDonNhap(string noiDungTimKiem);
        ServiceResult<HoaDon> TimKiemTheoID(string id);
        ServiceResult<List<string>> TimTenTheoID(List<HoaDon> lstHDN);
        ServiceResult<bool> SuaHoaDonNhap(HoaDon HoaDonNhap);
        ServiceResult<bool> XoaHoaDonNhap(string id);
    }
}
