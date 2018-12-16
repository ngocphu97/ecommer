using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMobileMVC.Models
{
    public class DSThongBao
    {
        public int total { get; set; }
        public List<ThongBao> content { get; set; }
    }
}
