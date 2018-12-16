using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMobileMVC.Models
{
    public class ChiTietHD
    {
        public int IDHoaDon { get; set; }
        public int IDPhanLoaiSP { get; set; }
        public int? Soluong { get; set; }
        public double? Gia { get; set; }
        public double? GiaKM { get; set; }
    }
}
