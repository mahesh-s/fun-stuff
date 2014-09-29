using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeSurferModels;

namespace Data.Configuration
{
    public class CustomDatabaseInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
           SeedHomes(context);

            base.Seed(context);
        }

        private static void SeedHomes(DataContext context)
        {
            var descriptions = new string[5]
            {
                "Nice neighborhood with friendly neighbors",
                "A truely beautiful home",
                "Freeway accesible with a huge green lawn",
                "Lots of storage and big bedrooms",
                "Includes pool,spa and basketball hoop"
            };

            for (int i = 0; i < 5; i++)
            {
                Home home = new Home();
                home.Address1 = string.Format("12{0} state st", i);
                home.Address2 = string.Empty;
                home.City = "AnyCity";
                home.ZipCode = (1234 + i).ToString();
                home.Basement = (i%2 == 0);
                home.BedRooms = i + 1;
                home.BathRooms = i;
                home.Price = 275000 + (i*1000);
                home.Image = string.Format("home-{0}.jpg", i%2==1?1:2);
                home.Description = descriptions[i];

                context.Homes.Add(home);
            }
        }
    }
}
