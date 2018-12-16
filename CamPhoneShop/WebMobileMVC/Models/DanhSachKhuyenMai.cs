using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMobileMVC.Models
{
    public class DanhSachKhuyenMai
    {
        public int total { get; set; }
        public List<KhuyenMai> content { get; set; }
    }
}
