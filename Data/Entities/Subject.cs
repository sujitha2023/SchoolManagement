using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Data.Entities
{
    public class Subject
    {
        public Subject()
        {
            Classes = new HashSet<Class>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Class> Classes { get; set; }
    }
}
