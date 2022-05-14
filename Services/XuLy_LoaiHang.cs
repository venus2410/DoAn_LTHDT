using System;
using Entities;
using DAL;
using System.Collections.Generic;

namespace Services
{
    public class XuLy_LoaiHang:IXuLy_LoaiHang
    {
        IDocLuu_LoaiHang DocLuuLH;
        IXuLy_MatHang XuLyMH;
        public XuLy_LoaiHang()
        {
            DocLuuLH = new DocLuu_LoaiHang();
            XuLyMH = new XuLy_MatHang();
        }
        public ServiceResult<bool> ThemLoaiHang(LoaiHang loaiHang)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(loaiHang.MaLH) ||
                    string.IsNullOrWhiteSpace(loaiHang.TenLH))
                {
                    return new ServiceResult<bool>(false, false, "Vui lòng không bỏ trống các trường");
                }
                if (TonTaiMaLH(DocLoaiHang().Data, loaiHang.MaLH))
                {
                    return new ServiceResult<bool>(false, false, "Mã loại hàng đã tồn tại");
                }

                DocLuuLH.LuuLoaiHang(loaiHang);
                return new ServiceResult<bool>(true, true, null);
            }
            catch (Exception ex)
            {
                return new ServiceResult<bool>(false, false, ex.Message);
            }
        }
        private bool TonTaiMaLH(List<LoaiHang> lst, string maLH)
        {
            foreach (LoaiHang lh in lst)
            {
                if (lh.MaLH == maLH) return true;
            }
            return false;
        }
        public ServiceResult<List<LoaiHang>> DocLoaiHang()
        {
            try
            {
                List<LoaiHang> lst = DocLuuLH.DocLoaiHang();
                return new ServiceResult<List<LoaiHang>>(true, lst, null);
            }
            catch
            {
                throw new Exception("Không tìm thấy file lưu trữ");
            }
        }
        public ServiceResult<List<LoaiHang>> TimKiemLoaiHang(string noiDung)
        {
            try
            {
                List<LoaiHang> lstLH = DocLuuLH.DocLoaiHang();
                if (string.IsNullOrWhiteSpace(noiDung))
                {
                    return new ServiceResult<List<LoaiHang>>(true, lstLH, null);
                }
                List<LoaiHang> lstKQuaTKiem = new List<LoaiHang>();
                foreach (LoaiHang lh in lstLH)
                {
                    if (lh.TenLH.Contains(noiDung) || lh.MaLH.Contains(noiDung))
                    {
                        lstKQuaTKiem.Add(lh);
                    }
                }
                return new ServiceResult<List<LoaiHang>>(true, lstKQuaTKiem, null);
            }
            catch (Exception ex)
            {
                return new ServiceResult<List<LoaiHang>>(false, null, ex.Message);
            }
        }
        public ServiceResult<LoaiHang> TimKiemTheoID(string id)
        {
            try
            {
                List<LoaiHang> lstLH = DocLuuLH.DocLoaiHang();
                foreach (LoaiHang LH in lstLH)
                {
                    if (LH.MaLH == id)
                    {
                        return new ServiceResult<LoaiHang>(true, LH, null);
                    }
                }
                return new ServiceResult<LoaiHang>(false, null, "Không tìm thấy loại hàng");
            }
            catch (Exception ex)
            {
                return new ServiceResult<LoaiHang>(false, null, ex.Message);
            }
        }
        private static bool HopLe(LoaiHang lh)
        {
            if (string.IsNullOrWhiteSpace(lh.MaLH) ||
                    string.IsNullOrWhiteSpace(lh.TenLH))
                return false;
            return true;
        }
        public ServiceResult<bool> SuaLoaiHang(LoaiHang lh)
        {
            try
            {
                if (HopLe(lh))
                {
                    DocLuuLH.SuaLoaiHang(lh);
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
        public List<string> TimTenLoaiHang(List<MatHang> lstMaLH)
        {
            List<string> lstKQ = new List<string>();
            foreach (MatHang mh in lstMaLH)
            {
                LoaiHang lh = TimKiemTheoID(mh.Loai).Data;
                lstKQ.Add(lh.TenLH);
            }
            return lstKQ;
        }
        public ServiceResult<bool> XoaLoaiHang(string id)
        {
            try
            {
                DocLuuLH.XoaLoaiHang(id);
                //cap nhat lai mat hang
                List<MatHang> lstMH = XuLyMH.DocMatHang().Data;
                for (int i = 0; i < lstMH.Count; i++)
                {
                    if (lstMH[i].Loai == id)
                    {
                        MatHang mh = lstMH[i];
                        mh.Loai = null;
                        XuLyMH.SuaMatHang(mh);
                    }
                }
                return new ServiceResult<bool>(true, true, null);
            }
            catch (Exception ex)
            {
                return new ServiceResult<bool>(false, false, ex.Message);
            }
        }
    }
}

