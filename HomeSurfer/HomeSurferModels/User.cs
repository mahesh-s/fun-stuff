using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSurferModels
{
    public class User
    {
        public User()
        {
            Roles =new Collection<Role>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public ICollection<Role> Roles { get; set; } 
    }
}
