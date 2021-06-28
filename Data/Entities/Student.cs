using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace SchoolManagement.Data.Entities
{
    public class Student
    {
        public Student()
        {
            Student_Classes = new HashSet<Student_Classes>();
            
        }
        public int Id { get; set; }
        public int Age { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        //public DateTime? DOJ { get; set; }
        public virtual ICollection<Student_Classes> Student_Classes { get; set; }
        public virtual ContactInfo ContactInfo { get; set; }
    }
    public class StudentConfig : EntityTypeConfiguration<Student>
    {
        public StudentConfig()
        {
            Property(e => e.Fname).HasMaxLength(40);
            Property(e => e.Lname).HasMaxLength(40);
            HasOptional(e => e.ContactInfo).WithRequired(e => e.Student);
        }
    }
}
