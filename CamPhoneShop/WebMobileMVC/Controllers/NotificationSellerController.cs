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
    public class NotificationSellerController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            DSThongBao listTB = new DSThongBao();
            using (WebClient webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString("http://localhost:57233/api/ThongBao/getall");
                string valueOriginal = Convert.ToString(json);
                listTB = JsonConvert.DeserializeObject<DSThongBao>(valueOriginal);
            }
            return View(listTB);
        }
        public IActionResult Detail(int? id)
        {
            DSThongBao listTB = new DSThongBao();
            using (WebClient webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString("http://localhost:57233/api/thongbao/getall?idThongbao="+id);
                string valueOriginal = Convert.ToString(json);
                listTB = JsonConvert.DeserializeObject<DSThongBao>(valueOriginal);
            }
            return View(listTB);
        }
    }
}
