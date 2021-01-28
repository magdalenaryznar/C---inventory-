using WpfInventory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WpfInventory;

namespace WpfInventory.Factories
{
    public class FileFactory
    {
        private string Delimeter = ";";
        public IFile CreateCsv(List<Product> products)
        {
            var builder = new StringBuilder();
            foreach (var product in products)
            {
                builder.Append(product.ProductName);
                builder.Append(Delimeter);
                builder.Append(product.Cost);
                builder.Append(Delimeter);
                builder.Append(product.Quantity);
                builder.Append(Delimeter);
                builder.Append(product.CostWithVat);
                builder.AppendLine();
            }

            return new CsvFile(builder.ToString());
        }
    }
}
