using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ThuongMaiDienTuAPI.Dtos.Queries;
using ThuongMaiDienTuAPI.Helpers;
using ThuongMaiDienTuAPI.Interfaces;

namespace ThuongMaiDienTuAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    public class PhanLoaiSPController : Controller
    {
        private IPhanLoaiSP PhanLoaiSPService;
        private IMapper mapper;

        public PhanLoaiSPController(IPhanLoaiSP phanLoaiSPService, IMapper mapper)
        {
            this.PhanLoaiSPService = phanLoaiSPService;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("get")]
        [AllowAnonymous]
        public async Task<IActionResult> Get([FromQuery]PhanLoaiSPQuery query)
        {
            GetResult rs = (ThuongMaiDienTuAPI.Helpers.GetResult)await PhanLoaiSPService.Get(query);
            //rs.Content = mapper.Map<List<SanPhamCommonViewDto>>((List<SanPham>)rs.Content);
            return Ok(rs.Get());
        }
    }
}