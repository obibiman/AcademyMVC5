using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Domain.Core;
using Academy.DataAccess.Mapping;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Academy.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext() : base("Academy")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DataContext>());
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Telephone> Telephones { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
            .HasMany(c => c.Instructors).WithMany(i => i.Courses)
            .Map(t => t.MapLeftKey("CourseId")
                .MapRightKey("InstructorId")
                .ToTable("CourseInstructor"));

            //modelBuilder.Entity<Course>()
            //.HasMany(c => c.Enrollments).WithMany(i => i.Enrollments)
            //.Map(t => t.MapLeftKey("EnrollmentId")
            //.MapRightKey("StudentId")
            //.ToTable("CourseStudent"));

            //modelBuilder.Entity<Student>()
            //.HasMany(c => c.Courses).WithMany(i => i.Students)
            //.Map(t => t.MapLeftKey("StudentId")
            //.MapRightKey("CourseId")
            //.ToTable("CourseStudent"));

            //
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();



            //
            modelBuilder.Configurations.Add(new StudentMap());
            //
            base.OnModelCreating(modelBuilder);
        }

    }
}
