using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms2.Core.Entities
{
   public class Course
    {
        Title = null!;
        StartTime= null!;
        public Course (string Title, DateTime StartTime)
        {
            Title = Title;
            StartTime = StartTime;
        }
        public int Id { get; set; }
        public string  Title { get; set; } 

        public DateTime StartTime { get; set; }


        public ICollection<Module> Modules { get; set; } = new List<Module>();
    }
}
