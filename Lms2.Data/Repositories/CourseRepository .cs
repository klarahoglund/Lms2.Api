using Lms2.Core.Entities;
using Lms2.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms2.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        public void Add(Course course)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AnyAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<Course> FindAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Course>> GetAllCourses()
        {
            throw new NotImplementedException();
        }

        public Task<Course> GetCourse(int? id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Course course)
        {
            throw new NotImplementedException();
        }

        public void Update(Course course)
        {
            throw new NotImplementedException();
        }
    }
}
