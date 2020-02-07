using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookieStore.Models
{
    public class MockRepository : IRepository
    {
        private List<Cookie> _cookies;
        public MockRepository()
        {
            if (_cookies == null)
            {
                InitilizeRepository();
            }
        }

        private void InitilizeRepository()
        {
            _cookies = new List<Cookie>
            {
                new Cookie
                {
                    Id = 1, Name = "Raspberry", Price = 110, TinyDescription = "Dark Chocolate Overloaded",
                    FullDescription = "This is one of the best ever soft and chewy cookie and also been awarded as the best cookie several times.",
                    IsCookieOfTheDay = false, ImageUrl = "\\Images\\1.png"
                },
                new Cookie
                {
                    Id = 2, Name = "Nuts Overloaded", Price = 100, TinyDescription = "Truely healthy",
                    FullDescription = "This cookie is fully loaded with nuts of various types and contains nice amount of peanut butter.",
                    IsCookieOfTheDay = true, ImageUrl = "\\Images\\2.png"
                },
                new Cookie
                {
                    Id = 3, Name = "Chocolate", Price = 70, TinyDescription = "Amazingly fruity",
                    FullDescription = "This cookie is best suited for the chocolate lovers.It's less sweet and gives very elegant taste.",
                    IsCookieOfTheDay = false, ImageUrl = "\\Images\\3.png"
                },
                new Cookie
                {
                    Id = 4, Name = "Delicious Oatmeal", Price = 50, TinyDescription = "Truely healthy",
                    FullDescription = "his is one of the most moist and flavourful cookie, which can make anyone's mood happy.",
                    IsCookieOfTheDay = false, ImageUrl = "\\Images\\4.png"
                }
            };
        }

        public Cookie GetCookieById(int id)
        {
            return _cookies.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Cookie> GetAllCookies()
        {
            return _cookies;
        }

    }
}
