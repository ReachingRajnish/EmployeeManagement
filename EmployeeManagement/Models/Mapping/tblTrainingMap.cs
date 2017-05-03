using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EmployeeManagement.Models.Mapping
{
    public class tblTrainingMap : EntityTypeConfiguration<tblTraining>
    {
        public tblTrainingMap()
        {
            // Primary Key
            this.HasKey(t => new { t.TrainingId, t.StartDate, t.EndDate, t.TrainingDetails, t.Effectiveness, t.JobType, t.EmployeeId });

            // Properties
            this.Property(t => t.TrainingId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.TrainingDetails)
                .IsRequired();

            this.Property(t => t.Effectiveness)
                .IsRequired();

            this.Property(t => t.JobType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EmployeeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("tblTrainings");
            this.Property(t => t.TrainingId).HasColumnName("TrainingId");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.TrainingDetails).HasColumnName("TrainingDetails");
            this.Property(t => t.Effectiveness).HasColumnName("Effectiveness");
            this.Property(t => t.JobType).HasColumnName("JobType");
            this.Property(t => t.EmployeeId).HasColumnName("EmployeeId");
        }
    }
}
