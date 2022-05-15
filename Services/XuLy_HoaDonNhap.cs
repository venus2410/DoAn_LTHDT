using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Entities;

namespace Services
{
    public class XuLy_HoaDonNhap:IXuLy_HoaDonNhap
    {
        IDocLuu_HoaDonNhap docLuuHDN;
        IXuLy_MatHang xuLyMH;
        IXuLy_HangTon xuLyHangTon;
        public XuLy_HoaDonNhap()
        {
            docLuuHDN = new DocLuu_HoaDonNhap();
            xuLyMH = new XuLy_MatHang();
            xuLyHangTon = new XuLy_HangTon();
        }
        public static bool HopLe(HoaDon HDN)
        {
            if (string.IsNullOrWhiteSpace(HDN.MaHoaDon) ||
                    string.IsNullOrWhiteSpace(HDN.MatHangChon) ||
                    HDN.SoLuong < 0) return false;
            return true;
        }
        //ok
        public ServiceResult<bool> ThemHoaDonNhap(HoaDon HDN)
        {
            try
            {
                if (!HopLe(HDN))
                {
                    return new ServiceResult<bool>(false, false, "Vui lòng điền dữ liệu hợp lệ");
                }
                if (TonTaiMaHDN(DocHoaDonNhap().Data, HDN.MaHoaDon))
                {
                    return new ServiceResult<bool>(false, false, "Mã hóa đơn đã tồn tại, vui lòng chọn mã mặt hàng khác");
                }
                docLuuHDN.LuuHoaDonNhap(HDN);
                return new ServiceResult<bool>(true, true, null);
            }
            catch (Exception ex)
            {
                return new ServiceResult<bool>(false, false, ex.Message);
            }
        }
        //ok
        public ServiceResult<List<HoaDon>> DocHoaDonNhap()
        {
            try
            {
                List<HoaDon> lst = docLuuHDN.DocHoaDon();
                return new ServiceResult<List<HoaDon>>(true, lst, null);
            }
            catch (Exception ex)
            {
                return new ServiceResult<List<HoaDon>>(false, null, ex.Message);
            }
        }
        //ok
        public static bool TonTaiMaHDN(List<HoaDon> lst, string maHDN)
        {
            foreach (HoaDon lh in lst)
            {
                if (lh.MaHoaDon == maHDN) return true;
            }
            return false;
        }
        public ServiceResult<List<HoaDon>> TimKiemHoaDonNhap(string noiDungTimKiem)
        {
            try
            {
                List<HoaDon> lstHDN = docLuuHDN.DocHoaDon();
                if (string.IsNullOrWhiteSpace(noiDungTimKiem))
                {
                    return new ServiceResult<List<HoaDon>>(true, lstHDN, null);
                }
                List<HoaDon> lstKQuaTKiem = new List<HoaDon>();
                foreach (HoaDon HDN in lstHDN)
                {
                    if (HDN.MatHangChon.Contains(noiDungTimKiem) || HDN.MaHoaDon.Contains(noiDungTimKiem))
                    {
                        lstKQuaTKiem.Add(HDN);
                    }
                }
                return new ServiceResult<List<HoaDon>>(true, lstKQuaTKiem, null);
            }
            catch (Exception ex)
            {
                return new ServiceResult<List<HoaDon>>(false, null, ex.Message);
            }
        }

        public ServiceResult<HoaDon> TimKiemTheoID(string id)
        {
            try
            {
                List<HoaDon> lstHDN = docLuuHDN.DocHoaDon();
                foreach (HoaDon HDN in lstHDN)
                {
                    if (HDN.MaHoaDon == id)
                    {
                        return new ServiceResult<HoaDon>(true, HDN, null);
                    }
                }
                return new ServiceResult<HoaDon>(false, null, "Không tìm thấy mặt hàng");
            }
            catch (Exception ex)
            {
                return new ServiceResult<HoaDon>(false, null, ex.Message);
            }
        }
        public ServiceResult<List<string>> TimTenTheoID(List<HoaDon> lstHDN)
        {
            List<string> lstTenMH = new List<string>();
            try
            {
                if (lstHDN != null)
                {
                    foreach (HoaDon HDN in lstHDN)
                    {
                        lstTenMH.Add(xuLyMH.TimTenTheoID(HDN.MatHangChon).Data);
                    }
                    return new ServiceResult<List<string>>(true, lstTenMH, null);
                }
                else
                {
                    return new ServiceResult<List<string>>(false, null, "Không tìm thấy hóa đơn");
                }
            }
            catch (Exception ex)
            {
                return new ServiceResult<List<string>>(false, lstTenMH, ex.Message);
            }
        }

        public ServiceResult<bool> SuaHoaDonNhap(HoaDon HoaDonNhap)
        {
            try
            {
                if (HopLe(HoaDonNhap))
                {

                    HoaDon hdCu = TimKiemTheoID(HoaDonNhap.MaHoaDon).Data;
                    int chenhLech;
                    if (hdCu.MatHangChon == HoaDonNhap.MatHangChon)
                    {
                        chenhLech = hdCu.SoLuong - HoaDonNhap.SoLuong;
                    }
                    else
                    {
                        chenhLech = hdCu.SoLuong;
                    }
                    if (xuLyHangTon.KiemTraTonKhoMaMH(hdCu.MatHangChon).Data >= chenhLech)
                    {
                        docLuuHDN.SuaHoaDon(HoaDonNhap);
                        return new ServiceResult<bool>(true, true, null);
                    }
                    else
                    {
                        return new ServiceResult<bool>(false, false, "Số lượng hàng sửa làm tồn kho âm");
                    }
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
        public ServiceResult<bool> XoaHoaDonNhap(string id)
        {
            try
            {
                HoaDon hdn = TimKiemTheoID(id).Data;
                if (HopLe(hdn))
                {
                    int hangTon = xuLyHangTon.KiemTraTonKhoMaMH(hdn.MatHangChon).Data - hdn.SoLuong;

                    if (hangTon >= 0)
                    {
                        docLuuHDN.XoaHoaDon(hdn.MaHoaDon);
                        return new ServiceResult<bool>(true, true, null);
                    }
                    else
                    {
                        return new ServiceResult<bool>(false, false, "Số lượng hàng sửa làm tồn kho âm");
                    }
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
    }
}
