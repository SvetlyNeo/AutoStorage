using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Auto_Storage.AutoContext
{
    public class AutoStorageContext : DbContext
    {
        static AutoStorageContext()
        {
            Database.SetInitializer<AutoStorageContext>(new AutoStorageInitializer());
        }

        public AutoStorageContext(): base("DefaultConnection")
        { }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
    }
}
