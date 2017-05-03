using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using EmployeeManagement.Models.Mapping;

namespace EmployeeManagement.Models
{
    public partial class EmplManageContext : DbContext
    {
        static EmplManageContext()
        {
            Database.SetInitializer<EmplManageContext>(null);
        }

        public EmplManageContext()
            : base("Name=EmplManageContext")
        {
        }

        public DbSet<tblDepartment> Departments { get; set; }

        public DbSet<tblEmployee> Employees { get; set; }

        public DbSet<tblLogin> Logins { get; set; }

        public DbSet<tblTraining> Trainings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new tblDepartmentMap());
            modelBuilder.Configurations.Add(new tblEmployeeMap());
            modelBuilder.Configurations.Add(new tblLoginMap());
            modelBuilder.Configurations.Add(new tblTrainingMap());
        }
    }
}