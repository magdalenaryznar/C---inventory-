using System.Collections.Generic;
using System.Linq;
using Inventory.WPF.Database;
using Inventory.WPF.DbModels;

namespace Inventory.WPF.Services
{
    /// <summary>
    /// Repository for stored data
    /// </summary>
    public class DataRepository
    {
        private readonly WpfInventoryContext inventoryContext;

        /// <summary>
        /// Create repository
        /// </summary>
        public DataRepository()
        {
            inventoryContext = new WpfInventoryContext();
        }

        /// <summary>
        /// Retrieves all products from database
        /// </summary>
        /// <returns></returns>
        public List<Product> GetAllProduts()
        {
            return inventoryContext.Products.ToList();
        }

        /// <summary>
        /// Update all products in database.
        /// Warning! Deletes all previous one!
        /// </summary>
        /// <param name="updatedProducts"></param>
        public void UpdateProducts(List<Product> updatedProducts)
        {
            inventoryContext.Database.ExecuteSqlCommand("TRUNCATE TABLE Products");
            inventoryContext.SaveChanges();

            inventoryContext.Products.AddRange(updatedProducts);

            inventoryContext.SaveChanges();
        }

        /// <summary>
        /// Get unit by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Unit GetUnitByName(string name)
        {
            var unit = inventoryContext.Units.FirstOrDefault(c => c.Name.Contains(name));

            return unit ?? new Unit() { Name = name };
        }

        /// <summary>
        /// Get tax by amount
        /// </summary>
        /// <param name="taxAmount"></param>
        /// <returns></returns>
        public ProductTax GetTax(decimal taxAmount)
        {
            var unit = inventoryContext.ProductTaxes.FirstOrDefault(c => c.Amout== taxAmount);

            return unit ?? new ProductTax() { Amout = taxAmount};
        }


        /// <summary>
        /// Get product name by ist name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public ProductName GetProductName(string name)
        {
            var unit = inventoryContext.ProductNames.FirstOrDefault(c => c.Name.Contains(name));

            return unit ?? new ProductName() { Name = name };
        }
    }
}
