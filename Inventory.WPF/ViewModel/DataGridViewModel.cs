using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;
using WpfInventory.Commands;
using Inventory.WPF.Services;

namespace WpfInventory
{
    /// <summary>
    /// DataGrid view model
    /// </summary>
    public class DataGridViewModel : ViewModelBase
    {
        ObservableCollection<Product> infos;
        private DataRepository dataService;
        ICommand _command;


        /// <summary>
        /// Creates DataGridViewModel
        /// </summary>
        public DataGridViewModel()
        {
            dataService = new DataRepository();

            GetStoredProducts();

        }

        /// <summary>
        /// Retrieves stored products from database
        /// </summary>
        private void GetStoredProducts()
        {

            var allProducts = dataService.GetAllProduts();

            Products = new ObservableCollection<Product>(allProducts.Select(c => new Product()
            {
                Cost = c.Cost,
                ProductUnit = c.ProductUnit.Name,
                CostWithVat = c.Cost,
                ProductName = c.Name.Name,
                Quantity = (int)c.ProductQuantity,
                Vat = c.ProductTax.Amout
            }));
        }


        /// <summary>
        /// Visible products
        /// </summary>
        public ObservableCollection<Product> Products
        {
            get
            {
                return infos;
            }
            set
            {
                infos = value;
                OnPropertyChanged("Products");
            }
        }

        /// <summary>
        /// Remove product command
        /// </summary>
        public ICommand RemoveCommand
        {
            get
            {
                if (_command == null)
                {
                    _command = new DelegateCommand(CanExecute, Execute);
                }
                return _command;
            }
        }

        private void Execute(object parameter)
        {
            int index = Products.IndexOf(parameter as Product);
            if (index > -1 && index < Products.Count)
            {
                Products.RemoveAt(index);
            }
        }

        private bool CanExecute(object parameter)
        {
            return true;
        }
    }
}
