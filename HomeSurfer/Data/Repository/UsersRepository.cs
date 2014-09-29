using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeSurferModels;

namespace Data.Repository
{
    public class UsersRepository:GenericRepository<User>
    {
        public UsersRepository(DbContext context) : base(context)
        {
        }

        // additional business rules around CRUD can go here
    }
}
