using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DAL
{
    public class DocLuu_HoaDonXuat:DocLuu_HoaDon
    {
        public DocLuu_HoaDonXuat()
        {
            base.DuongDan = Path.GetFullPath("wwwroot/data/hoadonnhap.json");
        }
    }
}
