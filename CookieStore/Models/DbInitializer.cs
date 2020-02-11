using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookieStore.Models
{
    public class DbInitializer
    {
        public static void Seed(DatabaseContext dbContext)
        {
            if (!dbContext.Cookies.Any())
            {
                dbContext.AddRange(
                    new Cookie
                    {
                        Name = "Choco Chips",
                        Price = 80,
                        TinyDescription = "Dark chocolate overloaded",
                        FullDescription = "This is one of the most moist and flavourful cookie," +
                        "which can make anyone's mood happy.",
                        IsCookieOfTheDay = false,
                        ImageUrl = "Images\\Chocochip.png"
                    },

                    new Cookie
                    {
                        Name = "Nuts & Peanuts",
                        Price = 50,
                        TinyDescription = "Truely healthy",
                        FullDescription = "This cookie is fully loaded with nuts of " +
                        "various types and contain nice amount of peanut butter.",
                        IsCookieOfTheDay = false,
                        ImageUrl = "\\Images\\ChocolateChipWalnut.png"
                    },

                    new Cookie
                    {
                        Name = "Berries & Rasins",
                        Price = 50,
                        TinyDescription = "Amazingly fruity",
                        FullDescription = "This is one of the best ever soft and " +
                        "chewy cookie and also been awarded as the best cookie several times.",
                        IsCookieOfTheDay = false,
                        ImageUrl = "\\Images\\Nuts.png"
                    },
                    new Cookie
                    {
                        Name = "Coconut",
                        Price = 100,
                        TinyDescription = "Truely healthy",
                        FullDescription = "This cookie is best suited for the nut " +
                        "lovers.It's less sweet and gives very elegant taste.",
                        IsCookieOfTheDay = false,
                        ImageUrl = "\\Images\\Coconut.png"
                    }
                );
                dbContext.SaveChanges();
            }
        }
    }
}
