using WpfInventory.Factories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Input;
using WpfInventory;
using System.Linq;
using System.Collections.ObjectModel;

namespace WpfInventory.Commands
{
    public class SaveCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private string path;

        public SaveCommand(string path)
        {
            this.path = path;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var products = parameter as ObservableCollection<Product>;

            var fileFactory = new FileFactory();
            var file = fileFactory.CreateCsv(products.ToList());

            File.WriteAllText(path, file.Content);
        }
    }
}
