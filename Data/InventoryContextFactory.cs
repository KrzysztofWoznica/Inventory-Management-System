using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace WPFInventoryManagementSystem.Data
{
    //
    public class InventoryContextFactory : IDesignTimeDbContextFactory<InventoryContext>
    {
        public InventoryContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<InventoryContext>();
            options.UseSqlServer("Data Source = (localDb)\\MSSQLLocalDB; Initial Catalog = InventoryDB; Integrated Security = SSPI;");
            return new InventoryContext(options.Options);
        }
    }
}
