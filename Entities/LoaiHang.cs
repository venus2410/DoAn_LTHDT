using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class LoaiHang
    {
        public string MaLH { get; set; }
        public string TenLH { get; set; }
        public LoaiHang(string ma, string ten)
        {
            this.MaLH = ma;
            this.TenLH = ten;
        }
    }
}
