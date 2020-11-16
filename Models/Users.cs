using System;
using System.Collections.Generic;

namespace WpfClient.Models
{
    public partial class Users
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Sname { get; set; }
        public int IdDepartment { get; set; }

        public Departments IdDepartmentNavigation { get; set; }
    }
}
