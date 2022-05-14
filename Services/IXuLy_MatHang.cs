using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace Services
{
    public interface IXuLy_MatHang
    {
        ServiceResult<bool> ThemMatHang(MatHang mh);
        ServiceResult<List<MatHang>> DocMatHang();
        ServiceResult<List<MatHang>> TimKiemMatHang(string noiDungTimKiem);
        ServiceResult<MatHang> TimKiemTheoID(string id);
        ServiceResult<string> TimTenTheoID(string id);
        ServiceResult<bool> SuaMatHang(MatHang matHang);
        ServiceResult<bool> XoaMatHang(string id);
    }
}
