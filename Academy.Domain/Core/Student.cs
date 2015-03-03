using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Domain.Core
{
    public class Student : Person
    {
        public Student()
        {
            Address = new Address();
        }
        public int StudentId { get; set; }
        public string Major { get; set; }
        public int? Credit { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public Address Address { get; set; }
        public int ContactInfoId { get; set; }
        public virtual ContactInfo ContactInfo { get; set; }       
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<DateTime> ModifiedDate { get; set; }
    }
}
