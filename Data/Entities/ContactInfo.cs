using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace SchoolManagement.Data.Entities
{
    public class ContactInfo
    {
        public int StudentId { get; set; }
        public string MobileNo { get; set; }
        public string City { get; set; }
        public virtual Student Student { get; set; }
    }
    public class ContactConfig:EntityTypeConfiguration<ContactInfo>
    {
        public ContactConfig()
        {
            HasKey(e => e.StudentId);
        }
    }
}
