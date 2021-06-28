using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SchoolManagement.Data.Entities;

namespace SchoolManagement.Data
{
    public class SchoolContext:DbContext
    {
        public SchoolContext():base ("SchoolDB")
        {
             
        }
        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Configurations.Add(new Student_Classes_Config());
            builder.Configurations.Add(new StudentConfig());
            builder.Configurations.Add(new ContactConfig());

        }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Class> Classes{ get; set; }
        public virtual DbSet<Student_Classes> Student_Classes { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<ContactInfo> Contacts { get; set; }
        
    }
}
