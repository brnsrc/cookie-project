using CookieStore.Models;
using CookieStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookieStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository _repository;
        public HomeController(IRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            //ViewBag.Title = "Cookies and only Cookies";
            //var cookies = _repository.GetAllCookies().OrderByDescending(x => x.Price);
            //return View(cookies);
            HomeViewModel viewModel = new HomeViewModel
            {
                Title = "Cookies and only Cookies",
                Cookies = _repository.GetAllCookies().OrderByDescending(x => x.Price).ToList()               
            };

            return View(viewModel);
        }

        public IActionResult Details(int id)
        {
            var cookie = _repository.GetCookieById(id);
            return View(cookie);
        }
    }
}
