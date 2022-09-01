using Bogus;
using Lms2.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms2.Data.Data
{
    public static class SeedData
    {
        private static Lms2ApiContext db = default!;

        private static Faker faker = null;

        public static async Task InitAsync(Lms2ApiContext context)
        {
            if (context is null) throw new ArgumentNullException(nameof(context));
            db = context;

            if (await db.Course.AnyAsync()) return; // om det redan finns data i den tabellen

            faker = new Faker("sv");

            var courses = GenerateCourses(5);
            await db.AddRangeAsync(courses); //tillfällig spot på förändringar på objekt som ska addas
            await db.SaveChangesAsync(); //Läggs till i klump


        }

        private static IEnumerable<Course> GenerateCourses(int nrOfCourses)
        {
            var courses = new List<Course>();  
            
            for (int i = 0; i < nrOfCourses; i++)
            {
                //behöver inte ange id
                var title = faker.Hacker.Verb();
                var start = DateTime.Now.AddDays(faker.Random.Int(0, 30));

                var course = new Course(title, start);  

                courses.Add(course);    
            }
            return courses;
            
        }
    }
}
