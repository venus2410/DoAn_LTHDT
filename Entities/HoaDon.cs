using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class HoaDon
    {
        public string MaHoaDon{get;set;}
        public string MatHangChon { get; set; }
        public int SoLuong { get; set; }
        public HoaDon(string ma, string mh, int sl)
        {
            MaHoaDon = ma;
            MatHangChon = mh;
            SoLuong = sl;
        }
    }
}
