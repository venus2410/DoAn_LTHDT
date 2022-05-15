using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Entities;

namespace Services
{
    public class XuLy_HangTon:IXuLy_HangTon
    {
        IDocLuu_MatHang docLuuMH;
        IDocLuu_HoaDonNhap docLuuHDN;
        IDocLuu_HoaDonXuat docLuuHDX;

        public XuLy_HangTon()
        {
            docLuuMH = new DocLuu_MatHang();
            docLuuHDN = new DocLuu_HoaDonNhap();
            docLuuHDX = new DocLuu_HoaDonXuat();
        }
        public ServiceResult<List<HangTon>> ThongKeHangTon()
        {
            try
            {
                List<HangTon> lstHangTon = new List<HangTon>();
                List<MatHang> lstMH = docLuuMH.DocMatHang();
                foreach (MatHang mh in lstMH)
                {
                    HangTon ht = new HangTon(mh.MaMH, mh.TenMH, 0, mh.HanDungMH);
                    lstHangTon.Add(ht);
                }
                List<HoaDon> lstHoaDonNhap = docLuuHDN.DocHoaDon();
                for (int i = 0; i < lstHoaDonNhap.Count; i++)
                {
                    for (int j = 0; j < lstHangTon.Count; j++)
                    {
                        if (lstHoaDonNhap[i].MatHangChon == lstHangTon[j].MaMH)
                        {
                            HangTon hangTon = lstHangTon[j];
                            int sl = hangTon.SoLuongTon;
                            hangTon.SoLuongTon += lstHoaDonNhap[i].SoLuong;
                            lstHangTon[j] = hangTon;
                        }
                    }
                }
                List<HoaDon> lstHoaDonXuat = docLuuHDX.DocHoaDon();
                for (int i = 0; i < lstHoaDonXuat.Count; i++)
                {
                    for (int j = 0; j < lstHangTon.Count; j++)
                    {
                        if (lstHoaDonXuat[i].MatHangChon == lstHangTon[j].MaMH)
                        {
                            HangTon hangTon = lstHangTon[j];
                            int sl = hangTon.SoLuongTon;
                            hangTon.SoLuongTon -= lstHoaDonXuat[i].SoLuong;
                            lstHangTon[j] = hangTon;
                        }
                    }
                }
                return new ServiceResult<List<HangTon>>(true, lstHangTon, null);
            }
            catch (Exception ex)
            {
                return new ServiceResult<List<HangTon>>(false, null, ex.Message);
            }
        }
        public ServiceResult<int> KiemTraTonKhoMaMH(string maMH)
        {
            try
            {
                List<HangTon> lstHangTon = ThongKeHangTon().Data;
                foreach (HangTon ht in lstHangTon)
                {
                    if (ht.MaMH == maMH)
                    {
                        return new ServiceResult<int>(true, ht.SoLuongTon, null);
                    }
                }
                return new ServiceResult<int>(false, 0, "Không tìm thấy mã mặt hàng");
            }
            catch (Exception ex)
            {
                return new ServiceResult<int>(false, 0, ex.Message);
            }
        }
        public ServiceResult<List<HangTon>> ThongKeHangHetHan()
        {
            try
            {
                List<HangTon> lstHangHetHan = new List<HangTon>();
                var lstHangTon = ThongKeHangTon().Data;
                if (lstHangTon == null)
                {
                    return new ServiceResult<List<HangTon>>(false, null, "Không tìm thấy file lưu trữ");
                }
                DateTime now = DateTime.Now;
                foreach (HangTon ht in lstHangTon)
                {
                    DateTime hd = DateTime.ParseExact(ht.HanSD, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                    if (DateTime.Compare(now, hd) > 0)
                    {
                        lstHangHetHan.Add(ht);
                    }
                }
                if (lstHangHetHan.Count > 0)
                {
                    return new ServiceResult<List<HangTon>>(true, lstHangHetHan, null);
                }
                else
                {
                    return new ServiceResult<List<HangTon>>(false, null, "Không có mặt hàng nào hết hạn");
                }
            }
            catch (Exception ex)
            {
                return new ServiceResult<List<HangTon>>(false, null, ex.Message);
            }
        }
    }
}
