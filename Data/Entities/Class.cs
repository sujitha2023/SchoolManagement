using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Data.Entities
{
    public class Class
    {
        public Class()
        {
            Student_Classes = new HashSet<Student_Classes>();
        }
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public int TeacherId { get; set; }
        public int PeriodNo { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<Student_Classes> Student_Classes { get; set; }

    }
}
