using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeSurferModels;

namespace Data.Repository
{
    public class HomesRepository : GenericRepository<Home>
    {
        public HomesRepository(DbContext context) : base(context)
        {
        }
    }
}
