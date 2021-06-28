using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Data.Entities
{
    public class Teacher
    {
        public Teacher()
        {
            Classes = new HashSet<Class>();
        }
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Subjects_handling { get; set; }
        public virtual ICollection<Class> Classes { get; set; }

    }
}
