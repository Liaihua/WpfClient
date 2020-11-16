using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WpfClient.Models
{
    public class DepartmentView
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static implicit operator DepartmentView(Departments target)
        {
            if (target == null)
                return new DepartmentView();
            return new DepartmentView { Id = target.Id, Name = target.Name };
        }
    }
}
