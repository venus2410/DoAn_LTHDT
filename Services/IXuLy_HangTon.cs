using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace Services
{
    public interface IXuLy_HangTon
    {
        ServiceResult<List<HangTon>> ThongKeHangTon();
        ServiceResult<int> KiemTraTonKhoMaMH(string maMH);
        ServiceResult<List<HangTon>> ThongKeHangHetHan();
    }
}
