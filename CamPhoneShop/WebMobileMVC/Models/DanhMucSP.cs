using System;
namespace WebMobileMVC.Models
{
    public class DanhMucSP
    {
        public int IDDanhMuc { get; set; }
        public string TenDM { get; set; }
        public string TenKhac { get; set; }
        public bool TinhTrang { get; set; }
        public string Hinh { get; set; }
    }

    public enum TenDanhMuc
    {
        Danhmuc1,
        Danhmuc2,
        Danhmuc3
    }
}
