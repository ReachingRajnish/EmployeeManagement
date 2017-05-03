using System;
using System.Collections.Generic;

namespace EmployeeManagement.Models
{
    public partial class tblTraining
    {
        public int TrainingId { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string TrainingDetails { get; set; }
        public string Effectiveness { get; set; }
        public int JobType { get; set; }
        public int EmployeeId { get; set; }
    }
}
