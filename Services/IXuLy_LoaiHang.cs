using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Entities;

namespace Services
{
    public interface IXuLy_LoaiHang
    {
        ServiceResult<bool> ThemLoaiHang(LoaiHang loaiHang);
        ServiceResult<List<LoaiHang>> DocLoaiHang();
        ServiceResult<List<LoaiHang>> TimKiemLoaiHang(string noiDung);
        ServiceResult<LoaiHang> TimKiemTheoID(string id);
        ServiceResult<bool> SuaLoaiHang(LoaiHang lh);
        ServiceResult<List<string>> TimTenLoaiHang(List<MatHang> lstMaLH);

        ServiceResult<bool> XoaLoaiHang(string id);
    }
}
