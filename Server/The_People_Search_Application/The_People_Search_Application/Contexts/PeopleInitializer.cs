using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace The_People_Search_Application.Contexts
{
    public static class PeopleInitializer
    {
        public static void Initialize(PeopleContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            context.SaveChanges();

            if (context.People.Any())
            {
                // If there are any people in the DB, do not seed.
                return;
            }

            Models.Person[] allPeople = new Models.Person[] {
                new Models.Person() { Name = "Billy", Address = "1 Foo Rd, Bellingham, WA", Age = 45, Interests = "Billy enjoys running and eating.", PictureURL = "http://www.iconhot.com/icon/png/emoji/100/emoji-1.png" },
                new Models.Person() { Name = "Bob", Address = "2 Foo Rd, Bellingham, WA", Age = 2, Interests = "Bob enjoys sleeping, crying, and eating.", PictureURL = "http://www.iconhot.com/icon/png/emoji/100/emoji-2.png" },
                new Models.Person() { Name = "Bob", Address = "8 Bar Ln, Seattle, WA", Age = 35, Interests = "Bob enjoys entertaining.", PictureURL = "http://www.iconhot.com/icon/png/emoji/100/emoji-3.png" },
                new Models.Person() { Name = "Bobby", Address = "14 Fir Rd, Bellingham, WA", Age = 24, Interests = "Bobby enjoys sleeping.", PictureURL = "http://www.iconhot.com/icon/png/emoji/100/emoji-4.png" },
                new Models.Person() { Name = "Jen", Address = "18 Baz St, Seattle, WA", Age = 62, Interests = "Jen enjoys jumping.", PictureURL = "http://www.iconhot.com/icon/png/emoji/100/emoji-5.png" },
                new Models.Person() { Name = "Jan", Address = "3 Foo Rd, Bellingham, WA", Age = 89, Interests = "Jan enjoys reading.", PictureURL = "http://www.iconhot.com/icon/png/emoji/100/emoji-6.png" },
                new Models.Person() { Name = "Fred", Address = "9 Foo Rd, Bellingham, WA", Age = 71, Interests = "Fred enjoys gardening.", PictureURL = "http://www.iconhot.com/icon/png/emoji/100/emoji-7.png" },
                new Models.Person() { Name = "Erin", Address = "4 Foo Rd, Bellingham, WA", Age = 32, Interests = "Erin enjoys sleeping and jumping around.", PictureURL = "http://www.iconhot.com/icon/png/emoji/100/emoji-8.png" }
            };
            context.People.AddRange(allPeople);
            context.SaveChanges();
        }
    }
}