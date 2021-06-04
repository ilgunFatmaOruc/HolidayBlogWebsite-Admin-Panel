using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Holiday_Travel_Entities;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Holiday_Travel_Data
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext() : base(@"Data Source=USER-PC;Initial Catalog=HolidayTravelProjectEx; Integrated Security=True;")
        {

        }

        public DbSet<About> About { get; set; }

        public DbSet<Contact> Contact { get; set; }

        public DbSet<Admin> Admin { get; set; }

        public DbSet<Address> Address { get; set; }

        public DbSet<Blog> Blog { get; set; }

        public DbSet<Comment> Comment { get; set; }

        public DbSet<HomePage> HomePage { get; set; }




        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);

            //modelBuilder.Configurations.Add(new ItemMapping());

        }
    }
}
