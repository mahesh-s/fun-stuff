using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeSurferModels;

namespace Data.Configuration
{
    public class UserConfiguration:EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            this.Property(p => p.Id).HasColumnOrder(0);
            this.Property(p => p.FirstName).HasMaxLength(100);
            this.Property(p => p.LastName).HasMaxLength(100);
            this.Property(p => p.UserName).HasMaxLength(100);

            this.HasMany(a => a.Roles)
                .WithMany(b => b.Users).Map(m =>
                {
                    m.MapLeftKey("UserId");
                    m.MapRightKey("RoleId");
                    m.ToTable("webpages_UsersInRoles");
                });
        }
    }
}
