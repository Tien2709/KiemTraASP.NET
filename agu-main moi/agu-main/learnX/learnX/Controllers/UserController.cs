using AutoMapper;
using Infrastructure.Entities;
using Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using learnX.Models;

namespace learnX.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;
        private readonly IMapper mapper;
        public UserController(IUserService userService, IMapper mapper)
        {
            this.userService = userService;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            return View(userService.GetUsers());
        }

        public IActionResult AddOrEdit(int id = 0)
        {
            UserViewModel data = new UserViewModel();
            ViewBag.RenderedHtmlTitle = id == 0 ? "THÊM MỚI TÀI KHOẢN" : "CẬP NHẬT TÀI KHOẢN";

            if (id != 0)
            {
                User res = userService.GetUser(id);
                data = mapper.Map<UserViewModel>(res);
                if (data == null)
                {
                    return NotFound();
                }
            }

            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddOrEdit(int id, UserViewModel data)
        {
            ViewBag.RenderedHtmlTitle = id == 0 ? "THÊM MỚI TÀI KHOẢN" : "CẬP NHẬT TÀI KHOẢN";

            if (ModelState.IsValid)
            {
                try
                {
                    User res = mapper.Map<User>(data);
                    if (id != 0)
                    {
                        userService.UpdateUser(res);
                    }
                    else
                    {
                        res.CreatedDate = DateTime.Now;
                        userService.InsertUser(res);
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                }

                return RedirectToAction("Index", "User");
            }

            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            User res = userService.GetUser(id);
            userService.DeleteUser(res);

            return RedirectToAction("Index", "User");
        }
    }
}
