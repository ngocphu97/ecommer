using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMobileMVC.Models
{
    public class KhuyenMai
    {
        public int ID { get; set; }

        public string Ten { get; set; }

        public int IDNguoiTao { get; set; }

        public double PhamTramKM { get; set; }

        public DateTime NgayBatDau { get; set; }

        public DateTime NgayKetThuc { get; set; }

        public bool TinhTrang { get; set; }

        public string LoaiKhuyenMai { get; set; }

        public ICollection<ChiTietKhuyenMai> ChiTietKM { get; set; }
    }
}
