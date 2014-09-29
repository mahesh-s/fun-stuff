using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSurferModels
{
    public class Home:IAuditEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public decimal? BathRooms { get; set; }
        public int? BedRooms { get; set; }
        public decimal? Price { get; set; }
        public bool Basement { get; set; }
        public string Image { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
