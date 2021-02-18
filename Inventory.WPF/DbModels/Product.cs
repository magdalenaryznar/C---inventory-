using System.ComponentModel;

namespace Inventory.WPF.DbModels
{
    /// <summary>
    /// Product entity
    /// </summary>
    public class Product
    {
        public int  Id { get; set; }

        public virtual ProductName Name { get; set; }

        public virtual ProductTax ProductTax{ get; set; }

        public virtual Unit ProductUnit { get; set; }
        public decimal ProductQuantity { get;  set; }
        public decimal Cost { get;  set; }
    }
}
