using System;

namespace Academy.Domain.Core
{
    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public Nullable<int> InstructorId { get; set; }
        public virtual Instructor Instructor { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<DateTime> ModifiedDate { get; set; }
    } 
}
