using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Entities;

namespace Services
{
    public class XuLy_MatHang:IXuLy_MatHang
    {
        IDocLuu_MatHang DocLuuMH;
        DocLuu_HoaDon DocLuuHD;
        public XuLy_MatHang()
        {
            DocLuuMH = new DocLuu_MatHang();
        }
        public static bool HopLe(MatHang mh)
        {
            if (string.IsNullOrWhiteSpace(mh.MaMH) ||
                    string.IsNullOrWhiteSpace(mh.TenMH) ||
                    string.IsNullOrWhiteSpace(mh.HanDungMH) ||
                    string.IsNullOrWhiteSpace(mh.CongTySX) ||
                    string.IsNullOrWhiteSpace(mh.NgaySX) ||
                    mh.Gia < 0) return false;
            return true;
        }
        public ServiceResult<bool> ThemMatHang(MatHang mh)
        {
            try
            {
                if (!HopLe(mh))
                {
                    return new ServiceResult<bool>(false, false, "Vui lòng điền dữ liệu hợp lệ");
                }
                if (TonTaiMaMH(DocMatHang().Data, mh.MaMH))
                {
                    return new ServiceResult<bool>(false, false, "Mã mặt hàng đã tồn tại, vui lòng chọn mã mặt hàng khác");
                }
                DocLuuMH.LuuMatHang(mh);
                return new ServiceResult<bool>(true, true, null);
            }
            catch (Exception ex)
            {
                return new ServiceResult<bool>(false, false, ex.Message);
            }
        }
        public ServiceResult<List<MatHang>> DocMatHang()
        {
            try
            {
                List<MatHang> lst = DocLuuMH.DocMatHang();
                return new ServiceResult<List<MatHang>>(true, lst, null);
            }
            catch (Exception ex)
            {
                return new ServiceResult<List<MatHang>>(true, null, ex.Message);
            }
        }
        public static bool TonTaiMaMH(List<MatHang> lst, string maMH)
        {
            foreach (MatHang lh in lst)
            {
                if (lh.MaMH == maMH) return true;
            }
            return false;
        }
        public ServiceResult<List<MatHang>> TimKiemMatHang(string noiDungTimKiem)
        {
            try
            {
                List<MatHang> lstMH = DocLuuMH.DocMatHang();
                if (string.IsNullOrWhiteSpace(noiDungTimKiem))
                {
                    return new ServiceResult<List<MatHang>>(true, lstMH, null);
                }
                List<MatHang> lstKQuaTKiem = new List<MatHang>();
                foreach (MatHang mh in lstMH)
                {
                    if (mh.TenMH.Contains(noiDungTimKiem) || mh.MaMH.Contains(noiDungTimKiem)
                        || mh.HanDungMH.Contains(noiDungTimKiem) || mh.CongTySX.Contains(noiDungTimKiem)
                        || mh.NgaySX.Contains(noiDungTimKiem) || mh.Loai.Contains(noiDungTimKiem))
                    {
                        lstKQuaTKiem.Add(mh);
                    }
                }
                return new ServiceResult<List<MatHang>>(true, lstKQuaTKiem, null);
            }
            catch (Exception ex)
            {
                return new ServiceResult<List<MatHang>>(false, null, ex.Message);
            }
        }
        public ServiceResult<MatHang> TimKiemTheoID(string id)
        {
            try
            {
                List<MatHang> lstMH =DocLuuMH.DocMatHang();
                foreach (MatHang mh in lstMH)
                {
                    if (mh.MaMH == id)
                    {
                        return new ServiceResult<MatHang>(true, mh, null);
                    }
                }
                return new ServiceResult<MatHang>(false, null, "Không tìm thấy mặt hàng");
            }
            catch (Exception ex)
            {
                return new ServiceResult<MatHang>(false, null, ex.Message);
            }
        }
        public ServiceResult<string> TimTenTheoID(string id)
        {
            try
            {
                List<MatHang> lstMH = DocLuuMH.DocMatHang();
                foreach (MatHang mh in lstMH)
                {
                    if (mh.MaMH == id)
                    {
                        return new ServiceResult<string>(true, mh.TenMH, null);
                    }
                }
                return new ServiceResult<string>(false, null, "Không tìm thấy mặt hàng");
            }
            catch (Exception ex)
            {
                return new ServiceResult<string>(false, null, ex.Message);
            }
        }
        public ServiceResult<bool> SuaMatHang(MatHang matHang)
        {
            try
            {
                if (HopLe(matHang))
                {
                    DocLuuMH.SuaMatHang(matHang);
                    return new ServiceResult<bool>(true, true, null);
                }
                else
                {
                    return new ServiceResult<bool>(false, false, "Vui lòng nhập dữ liệu hợp lệ");
                }
            }
            catch (Exception ex)
            {
                return new ServiceResult<bool>(false, false, ex.Message);
            }
        }
        public ServiceResult<bool> XoaMatHang(string id)
        {
            try
            {
                //xoa hoa don nhap xuat co mat hang
                DocLuuHD = new DocLuu_HoaDonXuat();
                List<HoaDon> lstHDX = DocLuuHD.DocHoaDon();
                foreach (HoaDon hdx in lstHDX)
                {
                    if (hdx.MatHangChon == id)
                    {
                        DocLuuHD.XoaHoaDon(hdx.MaHoaDon);
                    }
                }
                DocLuuHD = new DocLuu_HoaDonNhap();
                List<HoaDon> lstHDN = DocLuuHD.DocHoaDon();
                foreach (HoaDon hdn in lstHDN)
                {
                    if (hdn.MatHangChon == id)
                    {
                        DocLuuHD.XoaHoaDon(hdn.MaHoaDon);
                    }
                }

                //xoa mat hang khoi tap tin
                DocLuuMH.XoaMatHang(id);
                return new ServiceResult<bool>(true, true, null);
            }
            catch (Exception ex)
            {
                return new ServiceResult<bool>(false, false, ex.Message);
            }
        }
    }
}
