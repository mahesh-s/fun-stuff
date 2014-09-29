using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Configuration;
using HomeSurferModels;

namespace Data
{
    public class DataContext:DbContext
    {
        
        public DataContext() : base(nameOrConnectionString:DataContext.ConnectionString)
        {
        }

        static DataContext()
        {
            Database.SetInitializer(new CustomDatabaseInitializer());
        }

        public DbSet<Home> Homes { get; set; }
        public DbSet<User> Users { get; set; }

        //custom db config mapper
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new HomeConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());

            //add asp.net web simple security tables
            modelBuilder.Configurations.Add(new MembershipConfiguration());
            modelBuilder.Configurations.Add(new OAuthMembershipConfiguration());
            modelBuilder.Configurations.Add(new RoleConfiguration());
        }

        private void ApplyRules()
        {
            foreach (var entry in this.ChangeTracker.Entries()
                                  .Where(e => e.Entity is IAuditEntity && IsAddedOrModified(e)))
            {
                var e = (IAuditEntity) entry.Entity;

                if (entry.State == EntityState.Added)
                {
                    e.CreatedOn = DateTime.Now;
                }

                e.ModifiedOn = DateTime.Now;
            }
        }

        private bool IsAddedOrModified(DbEntityEntry entity)
        {
            return entity.State == EntityState.Added || entity.State == EntityState.Modified;
        }


        public override int SaveChanges()
        {
            ApplyRules();
            return base.SaveChanges();
        }

        public static string ConnectionString
        {
            get
            {
                if (ConfigurationManager.AppSettings["ConnectionString"] != null)
                {
                    return ConfigurationManager.AppSettings["ConnectionString"].ToString();

                }

                return "DefaultConnection";
            }
        }


    }
}
