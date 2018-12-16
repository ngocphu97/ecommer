using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using WebMobileMVC.Dtos;
using WebMobileMVC.Models;

namespace WebMobileMVC.Controllers
{
    public class ProductController : Controller
    {

        public IActionResult Index()
        {
            DanhSachSanPham listSP = new DanhSachSanPham();
            using (WebClient webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString("http://localhost:57233/api/sanpham/get?idnguoitao=1");
                string valueOriginal = Convert.ToString(json);
                listSP = JsonConvert.DeserializeObject<DanhSachSanPham>(valueOriginal);
            }

            ViewBag.giaBan = listSP.content[0].PhanLoaiSP[0].GiaBan;
            ViewBag.giaGoc = listSP.content[0].PhanLoaiSP[0].GiaGoc;
            ViewBag.giaKM = listSP.content[0].PhanLoaiSP[0].GiaKM;
            ViewBag.slton = listSP.content[0].PhanLoaiSP[0].SoLuong;

            ViewBag.trangthai = listSP.content[0].TinhTrangHang;
            if (ViewBag.trangthai == true)
            {
                ViewBag.trangthai = "Còn hàng";
            }
            else
            {
                ViewBag.trangthai = "Hết hàng";
            }
            return View(listSP);
        }

        public IActionResult Detail(int? id)
        {
            DanhSachSanPham listSP = new DanhSachSanPham();
            using (WebClient webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString("http://localhost:57233/api/sanpham/get/" + id);
                string valueOriginal = Convert.ToString(json);
                listSP = JsonConvert.DeserializeObject<DanhSachSanPham>(valueOriginal);
            }
            
            ViewBag.giaBan = listSP.content[0].PhanLoaiSP[0].GiaBan;
            ViewBag.giaGoc = listSP.content[0].PhanLoaiSP[0].GiaGoc;
            ViewBag.giaKM = listSP.content[0].PhanLoaiSP[0].GiaKM;
            ViewBag.slton = listSP.content[0].PhanLoaiSP[0].SoLuong;
            ViewBag.mau = listSP.content[0].PhanLoaiSP[0].Mau;

            ViewBag.thuonghieu = listSP.content[0].CauHinh.ThuongHieu;
            ViewBag.bonho = listSP.content[0].CauHinh.BoNho;
            ViewBag.mang = listSP.content[0].CauHinh.Mang;
            ViewBag.sim = listSP.content[0].CauHinh.Sim;
            ViewBag.chongthamnuoc = listSP.content[0].CauHinh.ChongThamNuoc;
            ViewBag.manhinh = listSP.content[0].CauHinh.KTManHinh;
            ViewBag.hedieuhanh = listSP.content[0].CauHinh.HeDieuHanh;
            ViewBag.ram = listSP.content[0].CauHinh.Ram;
            ViewBag.cmrtruoc = listSP.content[0].CauHinh.CMRTruoc;
            ViewBag.cmrsau = listSP.content[0].CauHinh.CMRSau;
            ViewBag.bluetooth = listSP.content[0].CauHinh.Bluetooth;
            ViewBag.pin = listSP.content[0].CauHinh.Pin;

            ViewBag.trangthai = listSP.content[0].TinhTrangHang;
            if (ViewBag.trangthai == true)
            {
                ViewBag.trangthai = "Còn hàng";
            }
            else
            {
                ViewBag.trangthai = "Hết hàng";
            }
            return View(listSP);
        }

        public IActionResult Create()
        {
            return View();
        }
        
        public void Tao(
            string productName,
            string description,
            string information,
            string danhmucsp,
            string guaranteeTime,
            string productStatus,
            string brand,
            string memory,
            string network,
            string sim,
            string waterproof,
            string screen,
            string system,
            string ram,
            string frontCam,
            string behindCam,
            string bluetooth,
            string battery,
            string color,
            string sellPrice,
            string price,
            string discountPrice
            )
        {

            CauHinhDto cauhinh = new CauHinhDto();
            cauhinh.ThuongHieu = brand;
            cauhinh.BoNho = memory;
            cauhinh.Mang = network;
            cauhinh.Sim = sim;
            cauhinh.ChongThamNuoc = waterproof;
            cauhinh.KTManHinh = screen;
            cauhinh.HeDieuHanh = system;
            cauhinh.Ram = ram;
            cauhinh.CMRTruoc = frontCam;
            cauhinh.CMRSau = behindCam;
            cauhinh.GPS = "co";
            cauhinh.Bluetooth = bluetooth;
            cauhinh.Pin = battery;

            List<PhanLoaiSPDto> dsphanloaisp = new List<PhanLoaiSPDto>();
            PhanLoaiSPDto phanloaisp = new PhanLoaiSPDto();
            phanloaisp.SoLuong = 1;
            phanloaisp.GiaKM = Double.Parse(discountPrice);
            phanloaisp.GiaBan = Double.Parse(sellPrice);
            phanloaisp.GiaGoc = Double.Parse(price);
            phanloaisp.Mau = color;

            dsphanloaisp.Add(phanloaisp);

            SanPhamDto sp = new SanPhamDto();

            sp.Ten = productName;
            sp.IDDanhMuc = 1;
            sp.Mota = description;
            sp.NoiDung = information;
            sp.Hinh = "";
            sp.HinhCT = "";
            sp.ThoiGianBH = 12;
            sp.TinhTrangHang = true;
            sp.CauHinh = cauhinh;
            sp.PhanLoaiSP = dsphanloaisp;
            
            var sp1 = JsonConvert.SerializeObject(sp);
            var uri = "http://localhost:57233/api/sanpham/add";

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:57233/api/sanpham/add");

                //HTTP POST
                var postTask = client.PostAsJsonAsync<SanPhamDto>("product", sp);
                postTask.Wait();

                var result = postTask.Result;
            }
            
            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
        }
    }
}

