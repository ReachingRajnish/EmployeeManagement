using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EmployeeManagement.Models.Mapping
{
    public class tblEmployeeMap : EntityTypeConfiguration<tblEmployee>
    {
        public tblEmployeeMap()
        {
            // Primary Key
            this.HasKey(t => t.EmployeeId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Degree)
                .HasMaxLength(250);

            this.Property(t => t.Address)
                .IsRequired()
                .HasMaxLength(300);

            this.Property(t => t.City)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.State)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Zip)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Phone)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.Mobile)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Designation)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Bio)
                .IsRequired();

            this.Property(t => t.Photo)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("tblEmployee");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DOB).HasColumnName("DOB");
            this.Property(t => t.Degree).HasColumnName("Degree");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.Zip).HasColumnName("Zip");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.Mobile).HasColumnName("Mobile");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Designation).HasColumnName("Designation");
            this.Property(t => t.DepartmentId).HasColumnName("DepartmentId");
            this.Property(t => t.DOJ).HasColumnName("DOJ");
            this.Property(t => t.DOC).HasColumnName("DOC");
            this.Property(t => t.Bio).HasColumnName("Bio");
            this.Property(t => t.Photo).HasColumnName("Photo");
            this.Property(t => t.Status).HasColumnName("Status");
        }
    }
}
