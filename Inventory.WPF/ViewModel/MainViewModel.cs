using WpfInventory.Commands;
using System;
using System.Linq;
using System.Windows.Input;
using Microsoft.Win32;
using System.Windows.Controls;
using Inventory.WPF.Commands;

namespace WpfInventory.ViewModel
{
    /// <summary>
    /// MainView model
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        System.Windows.Input.ICommand _addCommand, _updateDbCommand;

        public string Path { get; set; }

        public DataGridViewModel DataGridViewModel { get; set; }

        /// <summary>
        /// Creates view model 
        /// </summary>
        public MainViewModel()
        {
            Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\data.csv";
            DataGridViewModel = new DataGridViewModel();
        }

        /// <summary>
        /// Add command
        /// </summary>
        public System.Windows.Input.ICommand AddCommand
        {
            get
            {
                if (_addCommand == null)
                {
                    _addCommand = new DelegateCommand(CanExecute, ExecuteAddProduct);
                }
                return _addCommand;
            }
        }

        /// <summary>
        /// Update db command
        /// </summary>
        public System.Windows.Input.ICommand UpdateDbCommand
        {
            get
            {
                if (_updateDbCommand == null)
                {
                    _updateDbCommand = new DelegateCommand(CanExecute, ExecuteUpdateDatabase);
                }
                return _updateDbCommand;
            }
        }

        /// <summary>
        /// Updates database
        /// </summary>
        /// <param name="obj"></param>
        private void ExecuteUpdateDatabase(object obj)
        {
            new UpdateDatabaseCommand(DataGridViewModel.Products.ToList()).Run();
        }

        /// <summary>
        /// Saves file as CSV
        /// </summary>
        /// <param name="fileName"></param>
        public void SaveFile(string fileName)
        {
            new SaveCommand(fileName).Execute(DataGridViewModel.Products);
        }

        /// <summary>
        /// Adds new product to grid
        /// </summary>
        /// <param name="parameter"></param>
        private void ExecuteAddProduct(object parameter)
        {
            DataGridViewModel.Products.Add(new Product());
        }

        private bool CanExecute(object parameter)
        {
            return true;
        }


        /// <summary>
        /// Prints all visible products in table
        /// </summary>
        /// <param name="datagrid"></param>
        public void Print(DataGrid datagrid)
        {
            new PrintCommand(datagrid, "Inwentaryzacja").Run();
        }
    }
}
