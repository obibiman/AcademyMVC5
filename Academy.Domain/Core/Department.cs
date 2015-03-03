using System;
using System.Collections.Generic;

namespace Academy.Domain.Core
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DeptAbbrev { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<DateTime> ModifiedDate { get; set; }
    } 
}
