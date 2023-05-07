using AutoMapper;
using Infrastructure.Entities;
using Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using learnX.Models;

namespace learnX.Controllers
{
    public class KhachHangController : Controller
    {
        private readonly IKhachHangService khachHangService;
        private readonly IMapper mapper;
        public KhachHangController(IKhachHangService khachHangService, IMapper mapper)
        {
            this.khachHangService = khachHangService;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            return View(khachHangService.GetKhachHangs());
        }

        public IActionResult AddOrEdit(int id = 0)
        {
            KhachHangViewModel data = new KhachHangViewModel();
            ViewBag.RenderedHtmlTitle = id == 0 ? "THÊM MỚI KHÁCH HÀNG" : "CẬP NHẬT KHÁCH HÀNG";

            if (id != 0)
            {
                KhachHang res = khachHangService.GetKhachHang(id);
                data = mapper.Map<KhachHangViewModel>(res);
                if (data == null)
                {
                    return NotFound();
                }
            }

            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddOrEdit(int id, KhachHangViewModel data)
        {
            ViewBag.RenderedHtmlTitle = id == 0 ? "THÊM MỚI KHÁCH HÀNG" : "CẬP NHẬT KHÁCH HÀNG";

            if (ModelState.IsValid)
            {
                try
                {
                    KhachHang res = mapper.Map<KhachHang>(data);
                    if (id != 0)
                    {
                        khachHangService.UpdateKhachHang(res);
                    }
                    else
                    {
                        khachHangService.InsertKhachHang(res);
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                }

                return RedirectToAction("Index", "KhachHang");
            }

            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            KhachHang res = khachHangService.GetKhachHang(id);
            khachHangService.DeleteKhachHang(res);

            return RedirectToAction("Index", "KhachHang");
        }
    }
}
