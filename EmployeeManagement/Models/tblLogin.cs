using System;
using System.Collections.Generic;

namespace EmployeeManagement.Models
{
    public partial class tblLogin
    {
        public int LoginId { get; set; }
        public string LoginName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Rights { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    }
}
