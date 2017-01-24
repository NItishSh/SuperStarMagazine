using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SuperStarMagazine.Models
{
    public class SuperStarMagazineContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public SuperStarMagazineContext() : base("name=SuperStarMagazineContext")
        {
            //TODO comment out this if not required
            Database.SetInitializer<SuperStarMagazineContext>(new DropCreateDatabaseAlways<SuperStarMagazineContext>());
        }

        public System.Data.Entity.DbSet<SuperStarMagazine.Models.Publisher> Publishers { get; set; }

        public System.Data.Entity.DbSet<SuperStarMagazine.Models.File> Files { get; set; }

        public System.Data.Entity.DbSet<SuperStarMagazine.Models.Magazine> Magazines { get; set; }

        public System.Data.Entity.DbSet<SuperStarMagazine.Models.User> Users { get; set; }

        public System.Data.Entity.DbSet<SuperStarMagazine.Models.Subscription> Subscriptions { get; set; }
    }
}
