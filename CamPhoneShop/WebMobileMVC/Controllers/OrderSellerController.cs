using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Newtonsoft.Json;
using WebMobileMVC.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebMobileMVC.Controllers
{
    public class OrderSellerController : Controller
    {
        // GET: /<controller>/
        public IActionResult Detail(int? id)
        {
            DSHoadon listHD = new DSHoadon();
            using (WebClient webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString("http://localhost:57233/api/hoadon/getall?id=" + id);
                string valueOriginal = Convert.ToString(json);
                listHD = JsonConvert.DeserializeObject<DSHoadon>(valueOriginal);
            }
            return View(listHD);
        }
        public IActionResult Index(int? id)
        {
            DSHoadon listHD = new DSHoadon();
            using (WebClient webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString("http://localhost:57233/api/hoadon/getall");
                string valueOriginal = Convert.ToString(json);
                listHD = JsonConvert.DeserializeObject<DSHoadon>(valueOriginal);
            }
            return View(listHD);
        }
    }
}
