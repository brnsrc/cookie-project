using CookieStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookieStore.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Cookie> Cookies { get; set; }
    }
}
