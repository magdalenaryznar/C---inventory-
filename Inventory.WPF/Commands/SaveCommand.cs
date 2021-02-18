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
    /// <summary>
    /// Command for saving as file
    /// </summary>
    public class SaveCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private string path;

        /// <summary>
        /// Creates command using end file path
        /// </summary>
        /// <param name="path"></param>
        public SaveCommand(string path)
        {
            this.path = path;
        }

        /// <summary>
        /// Checks if can execute command
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Execute command and stores file in correct location
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            var products = parameter as ObservableCollection<Product>;

            var fileFactory = new FileFactory();
            var file = fileFactory.CreateCsv(products.ToList());

            File.WriteAllText(path, file.Content);
        }
    }
}
