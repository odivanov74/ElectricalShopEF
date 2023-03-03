using ElectricalShopEF.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalDevicesEF.Model
{
    public class AppDbContext:DbContext
    {
        public AppDbContext() : base("DefaultConnection")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Administrators { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Client> Clients { get; set; }

        public DbSet<ModelDevice> Models { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<TypeModel> Types { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Basket> Baskets { get; set; }



    }
}
