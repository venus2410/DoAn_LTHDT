using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using DAL;

namespace Services
{
    public class XuLy_HoaDonXuat:IXuLy_HoaDonXuat
    {
        IXuLy_HangTon xuLyHangTon;
        IXuLy_MatHang xuLyMH;
        IDocLuu_HoaDonXuat docLuuHDX;
        public XuLy_HoaDonXuat()
        {
            xuLyHangTon = new XuLy_HangTon();
            xuLyMH = new XuLy_MatHang();
            docLuuHDX = new DocLuu_HoaDonXuat();
        }
        public static bool HopLe(HoaDon HDX)
        {
            if (string.IsNullOrWhiteSpace(HDX.MaHoaDon) ||
                    string.IsNullOrWhiteSpace(HDX.MatHangChon) ||
                    HDX.SoLuong < 0) return false;
            return true;
        }

        public ServiceResult<bool> ThemHoaDon(HoaDon HDX)
        {
            try
            {
                if (!HopLe(HDX))
                {
                    return new ServiceResult<bool>(false, false, "Vui lòng điền dữ liệu hợp lệ");
                }
                if (TonTaiMaHoaDon(DocHoaDon().Data, HDX.MaHoaDon))
                {
                    return new ServiceResult<bool>(false, false, "Mã hóa đơn đã tồn tại, vui lòng chọn mã mặt hàng khác");
                }
                var SLHangTonCuaMH = xuLyHangTon.KiemTraTonKhoMaMH(HDX.MatHangChon).Data;
                if (SLHangTonCuaMH < HDX.SoLuong)
                {
                    return new ServiceResult<bool>(false, false, "Số lượng tồn không đủ");
                }
                docLuuHDX.TaoHoaDon(HDX);
                return new ServiceResult<bool>(true, true, null);
            }
            catch (Exception ex)
            {
                return new ServiceResult<bool>(false, false, ex.Message);
            }
        }
        //ok
        public ServiceResult<List<HoaDon>> DocHoaDon()
        {
            try
            {
                List<HoaDon> lst = docLuuHDX.DocHoaDon();
                return new ServiceResult<List<HoaDon>>(true, lst, null);
            }
            catch (Exception ex)
            {
                return new ServiceResult<List<HoaDon>>(false, null, ex.Message);
            }
        }
        //ok
        public static bool TonTaiMaHoaDon(List<HoaDon> lst, string MaHoaDon)
        {
            foreach (HoaDon lh in lst)
            {
                if (lh.MaHoaDon == MaHoaDon) return true;
            }
            return false;
        }
        public ServiceResult<List<HoaDon>> TimKiemHoaDon(string noiDungTimKiem)
        {
            try
            {
                List<HoaDon> lstHDN = docLuuHDX.DocHoaDon();
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
        public ServiceResult<List<string>> TimTenTheoID(List<HoaDon> lstHDN)
        {
            if (lstHDN != null)
            {
                List<string> lstTenMH = new List<string>();
                try
                {
                    foreach (HoaDon HDN in lstHDN)
                    {
                        lstTenMH.Add(xuLyMH.TimTenTheoID(HDN.MatHangChon).Data);
                    }
                    return new ServiceResult<List<string>>(true, lstTenMH, null);
                }
                catch (Exception ex)
                {
                    return new ServiceResult<List<string>>(false, null, ex.Message);
                }
            }
            else
            {
                return new ServiceResult<List<string>>(false, null, "Không tìm thấy hóa đơn");
            }
        }
        public ServiceResult<HoaDon> TimKiemTheoID(string id)
        {
            try
            {
                List<HoaDon> lstHDN = docLuuHDX.DocHoaDon();
                foreach (HoaDon HDN in lstHDN)
                {
                    if (HDN.MaHoaDon == id)
                    {
                        return new ServiceResult<HoaDon>(true, HDN, null);
                    }
                }
                return new ServiceResult<HoaDon>(false, null, "Không tìm thấy hóa đơn");
            }
            catch (Exception ex)
            {
                return new ServiceResult<HoaDon>(false, null, ex.Message);
            }
        }
        public ServiceResult<bool> SuaHoaDon(HoaDon hoaDonXuat)
        {
            try
            {
                if (HopLe(hoaDonXuat))
                {

                    HoaDon hdCu = TimKiemTheoID(hoaDonXuat.MaHoaDon).Data;
                    int chenhLech, slCu;
                    if (hdCu.MatHangChon == hoaDonXuat.MatHangChon)
                    {
                        chenhLech = hoaDonXuat.SoLuong - hdCu.SoLuong;
                        slCu = xuLyHangTon.KiemTraTonKhoMaMH(hdCu.MatHangChon).Data;
                    }
                    else
                    {
                        chenhLech = hoaDonXuat.SoLuong;
                        slCu = xuLyHangTon.KiemTraTonKhoMaMH(hoaDonXuat.MatHangChon).Data;
                    }
                    if (slCu >= chenhLech)
                    {
                        docLuuHDX.SuaHoaDon(hoaDonXuat);
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
        public ServiceResult<bool> XoaHoaDon(string id)
        {
            try
            {
                docLuuHDX.XoaHoaDon(id);
                return new ServiceResult<bool>(true, true, null);
            }
            catch (Exception ex)
            {
                return new ServiceResult<bool>(false, false, ex.Message);
            }
        }
    }
}
