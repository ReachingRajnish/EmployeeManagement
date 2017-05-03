using System;
using System.Collections.Generic;

namespace EmployeeManagement.Models
{
    public partial class tblEmployee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public System.DateTime DOB { get; set; }
        public string Degree { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Designation { get; set; }
        public int DepartmentId { get; set; }
        public System.DateTime DOJ { get; set; }
        public System.DateTime DOC { get; set; }
        public string Bio { get; set; }
        public string Photo { get; set; }
        public int Status { get; set; }
    }
}
