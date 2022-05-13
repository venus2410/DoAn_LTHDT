using System;
using Entities;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DAL
{
    public class DocLuu_MatHang:IDocLuu_MatHang
    {
        public static string path = Path.GetFullPath("wwwroot/data/mathang.json");
        public List<MatHang> DocMatHang()
        {
            StreamReader stream = new StreamReader(path);
            string jSonString = stream.ReadToEnd();
            stream.Close();
            var dSSP = JsonConvert.DeserializeObject<List<MatHang>>(jSonString);
            return dSSP;
        }
        public void LuuDanhSachMatHang(List<MatHang> ds)
        {
            StreamWriter writer = new StreamWriter(path);
            var str = JsonConvert.SerializeObject(ds);
            writer.Write(str);
            writer.Close();
        }
        public void LuuMatHang(MatHang mh)
        {
            var dSMatHang = DocMatHang();
            dSMatHang.Add(mh);
            LuuDanhSachMatHang(dSMatHang);
        }
        public bool SuaMatHang(MatHang mh)
        {
            List<MatHang> lstMH = DocMatHang();
            for (int i = 0; i < lstMH.Count; i++)
            {
                if (lstMH[i].MaMH == mh.MaMH)
                {
                    lstMH[i] = mh;
                    LuuDanhSachMatHang(lstMH);
                    return true;
                }
            }
            return false;
        }
        public bool XoaMatHang(string id)
        {
            List<MatHang> lstMH = DocMatHang();
            for (int i = 0; i < lstMH.Count; i++)
            {
                if (lstMH[i].MaMH == id)
                {
                    lstMH.RemoveAt(i);
                    LuuDanhSachMatHang(lstMH);
                    return true;
                }
            }
            return false;
        }
    }
}
