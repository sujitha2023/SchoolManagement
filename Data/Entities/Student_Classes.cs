using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace SchoolManagement.Data.Entities
{
    public class Student_Classes
    {
        public int ClassId { get; set; }
        public int StudentId { get; set; }
        public virtual Class Class { get; set; }
        public virtual Student Student { get; set; }
        
    }
    public class Student_Classes_Config:EntityTypeConfiguration<Student_Classes>
    {
        public Student_Classes_Config()
        {
            HasKey(e => new { e.ClassId, e.StudentId });
        }
    }
}
