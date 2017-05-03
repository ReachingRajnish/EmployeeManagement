using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EmployeeManagement.Models.Mapping
{
    public class tblDepartmentMap : EntityTypeConfiguration<tblDepartment>
    {
        public tblDepartmentMap()
        {
            // Primary Key
            this.HasKey(t => new { t.DepartmentId, t.DepartmentName });

            // Properties
            this.Property(t => t.DepartmentId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.DepartmentName)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("tblDepartment");
            this.Property(t => t.DepartmentId).HasColumnName("DepartmentId");
            this.Property(t => t.DepartmentName).HasColumnName("DepartmentName");
        }
    }
}
