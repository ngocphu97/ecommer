using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebMobileMVC.Models;

namespace WebMobileMVC.Controllers
{
    public class KhuyenMaiController : Controller
    {
        // GET: KhuyenMai
        public ActionResult Index()
        {
            DanhSachKhuyenMai listKM = new DanhSachKhuyenMai();
            using (WebClient webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString("http://localhost:57233/api/khuyenmai/ok?idnguoitao=1");
                string valueOriginal = Convert.ToString(json);
                listKM = JsonConvert.DeserializeObject<DanhSachKhuyenMai>(valueOriginal);
            }
            
            return View(listKM);
        }

        // GET: KhuyenMai/Details/5
        public ActionResult Detail()
        {
            DanhSachKhuyenMai listKM = new DanhSachKhuyenMai();
            using (WebClient webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString("http://localhost:57233/api/khuyenmai/ok?idnguoitao=1");
                string valueOriginal = Convert.ToString(json);
                listKM = JsonConvert.DeserializeObject<DanhSachKhuyenMai>(valueOriginal);
            }
            //ViewBag.chitiet = listKM.content[0].ChiTietKM;
            return View(listKM);
        }

        // GET: KhuyenMai/Create
        public ActionResult Create()
        {
            return View();
        }

        public void createKhuyenMai()
        {
            Redirect("/khuyenmai/Index");
        }

        // POST: KhuyenMai/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: KhuyenMai/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: KhuyenMai/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: KhuyenMai/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: KhuyenMai/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}