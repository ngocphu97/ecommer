using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebMobileMVC.Models
{
    public class ThongBao
    {
        [Key]
        public int ID { get; set; }
        public int IDUser { get; set; }
        public DateTime Ngay { get; set; }
        public string NoiDung { get; set; }
        [MaxLength(256)]
        public string URL { get; set; }
        public bool TinhTrang { get; set; }
    }
}
