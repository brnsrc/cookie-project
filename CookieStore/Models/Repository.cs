using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookieStore.Models
{
    public class Repository : IRepository
    {
        private readonly DatabaseContext _dbcontext;
        public Repository(DatabaseContext databaseContext)
        {
            _dbcontext = databaseContext;
        }

        public IEnumerable<Cookie> GetAllCookies()
        {
            return _dbcontext.Cookies;
        }

        public Cookie GetCookieById(int id)
        {
            return _dbcontext.Cookies.FirstOrDefault(x => x.Id == id);
        }
    }
}
