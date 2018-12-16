using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMobileMVC.Models
{
    public class PhanLoaiSP
    {
        public int ID { get; set; }
        public int IDSanPham { get; set; }
        public int SoLuong { get; set; }
        public double? GiaKM { get; set; }
        public double GiaBan { get; set; }
        public double GiaGoc { get; set; }
        public string Mau { get; set; }
        public int SLMua { get; set; }
    }
}
