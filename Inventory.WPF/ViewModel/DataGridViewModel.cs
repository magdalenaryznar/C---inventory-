using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;
using WpfInventory.Commands;

namespace WpfInventory
{
    public class DataGridViewModel : ViewModelBase
    {
        ObservableCollection<Product> infos;
        ICommand _command;

        public DataGridViewModel()
        {
            Products = new ObservableCollection<Product>();

            Products.Add(new Product { ProductName = "AA", Quantity = 24, Cost = 100, Vat = 23 });
        }

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
