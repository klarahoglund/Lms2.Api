using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable disable
namespace Lms2.Core.Entities
{
    public class Course
    {

        //private Course()
        //{
        //    Title = string.Empty;
        //    StartTime = null;
        //}

        public Course(string title, DateTime startTime)
        {
            Title = title;
            StartTime = startTime;
        }

        public int Id { get; set; }
        public string? Title { get; set; } 

        public DateTime StartTime { get; set; }


        public ICollection<Module> Modules { get; set; } = new List<Module>();

      
    }
}
