using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using System.IO;
using Newtonsoft.Json;

namespace DAL
{
    public class DocLuu_HoaDonNhap:DocLuu_HoaDon
    {
        public DocLuu_HoaDonNhap()
        {
            base.DuongDan= Path.GetFullPath("wwwroot/data/hoadonnhap.json");
        }
    }
}
