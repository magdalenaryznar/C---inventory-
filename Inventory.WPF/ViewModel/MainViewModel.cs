using WpfInventory.Commands;
using System;
using System.Linq;
using System.Windows.Input;
 
namespace WpfInventory.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        ICommand _addCommand;
        ICommand _saveCommand;

        public string Path { get; set; }

        public DataGridViewModel DataGridViewModel { get; set; }

        public MainViewModel()
        {
            Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\data.csv";
            DataGridViewModel = new DataGridViewModel();
        }

        public ICommand AddCommand
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

        public ICommand SaveCommand
        {
            get
            {
                if (_saveCommand == null)
                {
                    _saveCommand = new SaveCommand(Path);
                }
                return _saveCommand;
            }
        }

        private void ExecuteAddProduct(object parameter)
        {
            this.DataGridViewModel.Products.Add(new Product());
        }

        private bool CanExecute(object parameter)
        {
            return true;
        }
    }
}
