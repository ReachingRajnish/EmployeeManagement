using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EmployeeManagement.Models.Mapping
{
    public class tblLoginMap : EntityTypeConfiguration<tblLogin>
    {
        public tblLoginMap()
        {
            // Primary Key
            this.HasKey(t => new { t.LoginId });

            // Properties
            this.Property(t => t.LoginId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.LoginName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Username)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Password)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Rights)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("tblLogin");
            this.Property(t => t.LoginId).HasColumnName("LoginId");
            this.Property(t => t.LoginName).HasColumnName("LoginName");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Username).HasColumnName("Username");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.Rights).HasColumnName("Rights");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
