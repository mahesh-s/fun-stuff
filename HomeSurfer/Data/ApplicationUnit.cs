using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repository;
using HomeSurferModels;

namespace Data
{
    public class ApplicationUnit:IDisposable
    {
        private readonly DataContext _dataContext =new DataContext();
        private IRepository<Home> _homes;
        private IRepository<User> _users;

        public IRepository<Home> Homes
        {
            get
            {
                if (_homes == null)
                {
                    _homes =new GenericRepository<Home>(_dataContext);
                }

                return _homes;
            }
        }

        public IRepository<User> Users
        {
            get
            {
                if (_users == null)
                {
                    _users =new GenericRepository<User>(_dataContext);
                }
                return _users;
            }
        }

        public void SaveChanges()
        {
            _dataContext.SaveChanges();
        }

        public void Dispose()
        {
            if (_dataContext != null)
            {
                _dataContext.Dispose();
            }
        }
    }
}
