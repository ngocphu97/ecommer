using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThuongMaiDienTuAPI.Dtos.Queries;

namespace ThuongMaiDienTuAPI.Interfaces
{
    public interface IPhanLoaiSP
    {
        Task<object> Get(PhanLoaiSPQuery phanloaisp);
        Task<object> Get(int idSanpham, PhanLoaiSPQuery query);

    }
}
