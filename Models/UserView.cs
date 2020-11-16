using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WpfClient.Models
{
    public class UserView
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Sname { get; set; }

        public static implicit operator UserView(Users target)
        {
            if (target == null)
                return new UserView();
            return new UserView { Id = target.Id, Fname = target.Fname, Sname = target.Sname, IdDepartmentNavigation = target.IdDepartmentNavigation };
        }

        public virtual DepartmentView IdDepartmentNavigation { get; set; }
    }
}
