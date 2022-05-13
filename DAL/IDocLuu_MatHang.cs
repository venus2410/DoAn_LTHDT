using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using System.IO;
using Newtonsoft.Json;

namespace DAL
{
    public interface IDocLuu_MatHang
    {
        List<MatHang> DocMatHang();
        void LuuDanhSachMatHang(List<MatHang> ds);
        void LuuMatHang(MatHang mh);
        bool SuaMatHang(MatHang mh);
        bool XoaMatHang(string id);
    }
}
