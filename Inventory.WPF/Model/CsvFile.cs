using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfInventory.Model
{
    public class CsvFile : IFile
    {
        public string Type => "csv";
        public string Content { get; set; }

        public CsvFile(string content)
        {
            Content = content;
        }
    }
}
