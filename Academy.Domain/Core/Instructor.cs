using System;
using System.Collections.Generic;

namespace Academy.Domain.Core
{
    public class Instructor : Person
    {
        public int InstructorId { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public int ContactInfoId { get; set; }
        public DateTime HireDate { get; set; }
        public virtual ContactInfo ContactInfo { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<DateTime> ModifiedDate { get; set; }
    }
}