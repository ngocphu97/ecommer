using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMobileMVC.Models
{
    public class DanhSachSanPham
    {
        public int total { get; set; }
        public List<SanPham> content { get; set; }
    }
}
