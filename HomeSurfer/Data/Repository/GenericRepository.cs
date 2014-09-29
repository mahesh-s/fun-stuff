using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class GenericRepository<T>:IRepository<T>
            where T:class
    {
        public GenericRepository(DbContext context)
        {
            if (context == null) 
            {
                throw new Exception("DbContext must be provided");
            }

            this.Context = context;
            this.DBSet = context.Set<T>();
        }

        protected DbSet<T> DBSet { get; set; }
        protected DbContext Context { get; set; }

        public IQueryable<T> GetAll()
        {
            return this.DBSet;
        }

        public T GetById(int id)
        {
            return this.DBSet.Find(id);
        }

        public void Add(T entity)
        {
            DbEntityEntry entry = this.Context.Entry(entity);
            if (entry.State != EntityState.Detached)
            {
                entry.State = EntityState.Added;
            }
            else
            {
                this.DBSet.Add(entity);
            }
        }

        public void Update(T entity)
        {
            DbEntityEntry entry = Context.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                this.DBSet.Attach(entity);
            }

            entry.State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            DbEntityEntry entry = Context.Entry(entity);
            if (entry.State != EntityState.Deleted)
            {
                entry.State = EntityState.Deleted;
            }
            else
            {
                DBSet.Attach(entity);
                DBSet.Remove(entity);
            }
        }

        public void Detach(T entity)
        {
            DbEntityEntry entry = this.Context.Entry(entity);
            entry.State = EntityState.Detached;
        }

        public void Delete(int id)
        {
            var entity = DBSet.Find(id);
            Delete(entity);
        }
    }
  
}
