﻿using System;
using System.Collections.Generic;

namespace WpfClient.Models
{
    public partial class Departments
    {
        public Departments()
        {
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Users> Users { get; set; }
    }
}
