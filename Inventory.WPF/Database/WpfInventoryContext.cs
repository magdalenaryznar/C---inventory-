using Inventory.WPF.DbModels;
using System.Configuration;
using System.Data.Entity;

namespace Inventory.WPF.Database
{
    /// <summary>
    /// DbContext 
    /// </summary>
    public class WpfInventoryContext : DbContext
    {
        private static string dbConfig = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=InventoryDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        /// <summary>
        /// Create dbContext 
        /// </summary>
        public WpfInventoryContext() : base(dbConfig)
        {

        }

        /// <summary>
        /// Stores all products
        /// </summary>
        public DbSet<Product> Products { get; set; }

        /// <summary>
        /// Store all product names
        /// </summary>
        public DbSet<ProductName> ProductNames { get; set; }


        /// <summary>
        /// Store all taxes
        /// </summary>
        public DbSet<ProductTax> ProductTaxes { get; set; }


        /// <summary>
        ///  Store all product units
        /// </summary>
        public DbSet<Unit> Units { get; set; }

    }
}
