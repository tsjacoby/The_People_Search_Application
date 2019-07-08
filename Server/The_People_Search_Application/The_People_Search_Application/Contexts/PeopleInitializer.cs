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
                new Models.Person() { Name = "Billy", Address = "1 Foo Rd, Bellingham, WA", Age = 45, Interests = "Billy enjoys running and eating.", PictureURL = "https://www.imagemagick.org/Usage/canvas/gradient_bilinear.jpg" },
                new Models.Person() { Name = "Bob", Address = "2 Foo Rd, Bellingham, WA", Age = 2, Interests = "Bob enjoys sleeping, crying, and eating.", PictureURL = "https://www.imagemagick.org/Usage/canvas/gradient_bilinear.jpg" },
                new Models.Person() { Name = "Jan", Address = "3 Foo Rd, Bellingham, WA", Age = 89, Interests = "Jan enjoys reading.", PictureURL = "https://www.imagemagick.org/Usage/canvas/gradient_bilinear.jpg" },
                new Models.Person() { Name = "Erin", Address = "4 Foo Rd, Bellingham, WA", Age = 32, Interests = "Erin enjoys sleeping and jumping around.", PictureURL = "https://www.imagemagick.org/Usage/canvas/gradient_bilinear.jpg" }
            };
            context.People.AddRange(allPeople);
            context.SaveChanges();
        }
    }
}