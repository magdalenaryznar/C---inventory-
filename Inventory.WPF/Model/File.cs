using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfInventory.Model
{
    /// <summary>
    /// File interface
    /// </summary>
    public interface IFile
    {
        string Type { get; }

        string Content { get; set; }
    }
}
