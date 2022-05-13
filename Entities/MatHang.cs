using System;

namespace Entities
{
    public class MatHang
    {
        public string MaMH { get; set; }
        public string TenMH { get; set; }
        public string HanDungMH { get; set; }
        public string CongTySX { get; set; }
        public string NgaySX { get; set; }
        public string Loai { get; set; }
        public int Gia { get; set; }
        public MatHang(string ma, string ten, string hanDung, string ctySX, string ngaySX, string loai, int gia)
        {
            this.MaMH = ma;
            this.TenMH = ten;
            this.HanDungMH = hanDung;
            this.CongTySX = ctySX;
            this.NgaySX = ngaySX;
            this.Loai = loai;
            this.Gia = gia;
        }
    }
}
