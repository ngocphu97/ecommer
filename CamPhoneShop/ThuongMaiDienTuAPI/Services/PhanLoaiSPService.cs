using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ThuongMaiDienTuAPI.Dtos.Queries;
using ThuongMaiDienTuAPI.Entities;
using ThuongMaiDienTuAPI.Helpers;

namespace ThuongMaiDienTuAPI.Services
{
    public class PhanLoaiSPService
    {
        private DataContext db;
        public PhanLoaiSPService(DataContext db)
        {
            this.db = db;
        }

        public async Task<object> Get(PhanLoaiSPQuery query)
        {
            var phanloaisp = Sorting<PhanLoaiSP>.Get(db.PhanLoaiSP, query);

            return new GetResult(
                phanloaisp.Count(),
                await Sorting<PhanLoaiSP>.Get(phanloaisp, query)
                    .ToListAsync());
        }
    }
}
