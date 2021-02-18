using System.Windows.Controls;

namespace Inventory.WPF.Commands
{
    /// <summary>
    /// Command for printig
    /// </summary>
    public class PrintCommand : ICommand
    {
        private DataGrid dataGrid;
        private string title;

        /// <summary>
        /// Command constructor
        /// </summary>
        /// <param name="dataGrid"></param>
        /// <param name="title"></param>
        public PrintCommand(DataGrid dataGrid, string title)
        {
            this.dataGrid = dataGrid;
            this.title = title;
        }


        /// <summary>
        /// Runs command
        /// </summary>
        public void Run()
        {
            Print(dataGrid, title);
        }

        /// <summary>
        /// Prepare print dialog and execeutes it
        /// Works using DataGrid visual elements
        /// </summary>
        /// <param name="dataGrid"></param>
        /// <param name="title"></param>
        private void Print(DataGrid dataGrid, string title)
        {
            PrintDialog printDialog = new PrintDialog();

            if (printDialog.ShowDialog() == true)
            {
                printDialog.PrintVisual(dataGrid, title);
            }
        }
    }
}
