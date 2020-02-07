using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookieStore.Models
{
    public interface IRepository
    {
        IEnumerable<Cookie> GetAllCookies();
        Cookie GetCookieById(int id);
    }
}
