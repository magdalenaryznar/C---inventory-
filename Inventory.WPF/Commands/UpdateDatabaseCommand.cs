using Inventory.WPF.Services;
using System.Collections.Generic;
using System.Windows;
using WpfInventory;

namespace Inventory.WPF.Commands
{
    /// <summary>
    /// Command for updating products in database
    /// </summary>
    public class UpdateDatabaseCommand : ICommand
    {
        private List<Product> products;
        private DataRepository dataRepository;

        /// <summary>
        /// Creates command
        /// </summary>
        /// <param name="products"></param>
        public UpdateDatabaseCommand(List<Product> products)
        {
            this.products = products;
            this.dataRepository = new DataRepository();
        }


        /// <summary>
        /// Runs all internal methods and execute command.
        /// Saving all new data in database.
        /// </summary>
        public void Run()
        {

            this.dataRepository.UpdateProducts(GetProductsModel(products));
             MessageBox.Show("Baza zaktualizowana!");
        }

        /// <summary>
        /// Generates product model for database to store
        /// </summary>
        /// <param name="productsToSave"></param>
        /// <returns></returns>
        private List<DbModels.Product> GetProductsModel(List<Product> productsToSave)
        {
            List<DbModels.Product> products = new List<DbModels.Product>();


            foreach(var product in productsToSave)
            {
                var unit = dataRepository.GetUnitByName(product.ProductUnit);
                var name = dataRepository.GetProductName(product.ProductName);
                var tax = dataRepository.GetTax(product.Vat);

                products.Add(new DbModels.Product()
                {
                    Cost = product.Cost,
                    ProductQuantity = product.Quantity,
                    Name = name,
                    ProductTax = tax,
                    ProductUnit = unit
                });
            }

            
            return products;
        }
    }
}
