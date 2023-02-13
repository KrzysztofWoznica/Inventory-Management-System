using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WPFInventoryManagementSystem.Domain.Models;

namespace WPFInventoryManagementSystem.Data
{
    public class InventoryContext : DbContext
    {
        public InventoryContext(DbContextOptions options) : base(options) { }

        public DbSet<Address> Adressess { get; set; }
        public DbSet<InventoryItem> InventoryItems { get; set; }
        public DbSet<InventoryLog> InventoryLogs { get; set; }    
        public DbSet<Location> Locations { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<PartCategory> PartCategories { get; set; }
        public DbSet<PartOrder> PartOrders { get; set; }
        public DbSet<PartOrderItem> PartOrderItems { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SupplierPart> SupplierParts { get; set; }
        public DbSet<Uom> Uoms { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserLocation> UserLocations { get; set; }    

     
    }
}
