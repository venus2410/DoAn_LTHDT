using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Entities;
using Newtonsoft.Json;

namespace DAL
{
    public class DocLuu_HoaDonXuat:IDocLuu_HoaDonXuat
    {
        string DuongDan { get; set; }
        public DocLuu_HoaDonXuat()
        {
            DuongDan= Path.GetFullPath("wwwroot/data/hoadonxuat.json");
        }
        public List<HoaDon> DocHoaDon()
        {
            StreamReader stream = new StreamReader(DuongDan);
            string jSonString = stream.ReadToEnd();
            stream.Close();
            var dSHoaDon = JsonConvert.DeserializeObject<List<HoaDon>>(jSonString);
            return dSHoaDon;
        }
        //ok
        public void LuuDanhSachHoaDon(List<HoaDon> ds)
        {
            StreamWriter writer = new StreamWriter(DuongDan);
            var str = JsonConvert.SerializeObject(ds);
            writer.Write(str);
            writer.Close();
        }
        //ok
        public void LuuHoaDonNhap(HoaDon hoaDon)
        {
            var dSHoaDon = DocHoaDon();
            dSHoaDon.Add(hoaDon);
            LuuDanhSachHoaDon(dSHoaDon);
        }
        //ok
        public bool SuaHoaDon(HoaDon hoaDon)
        {
            List<HoaDon> lstHoaDon = DocHoaDon();
            for (int i = 0; i < lstHoaDon.Count; i++)
            {
                if (lstHoaDon[i].MaHoaDon == hoaDon.MaHoaDon)
                {
                    lstHoaDon[i] = hoaDon;
                    LuuDanhSachHoaDon(lstHoaDon);
                    return true;
                }
            }
            return false;
        }
        //ok
        public bool XoaHoaDon(string id)
        {
            List<HoaDon> lstHoaDon = DocHoaDon();
            for (int i = 0; i < lstHoaDon.Count; i++)
            {
                if (lstHoaDon[i].MaHoaDon == id)
                {
                    lstHoaDon.RemoveAt(i);
                    LuuDanhSachHoaDon(lstHoaDon);
                    return true;
                }
            }
            return false;
        }
    }
}
