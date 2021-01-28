using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.ComponentModel;

namespace WpfInventory
{
    public class Product : ViewModelBase
    {
        string _productName = string.Empty;
        int _quantity = 0;
        string _address = string.Empty;
        private decimal _cost;
        private decimal _vat;
        private decimal _costWithVat;

        public Product()
        {
            Vat = 23;
            CostWithVat = 0;
            Cost = 0;
        }

        public string ProductName
        {
            get
            {
                return _productName;
            }
            set
            {
                _productName = value;
                OnPropertyChanged("ProductName");
            }
        }

        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
                OnPropertyChanged("Quantity");
            }
        }

        public decimal Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                _cost = value;
                UpdateCosts();
                OnPropertyChanged("Cost");
            }
        }

        private void UpdateCosts()
        {
            _costWithVat = (_cost * _vat) + _cost;
            OnPropertyChanged("CostWithVat");
        }

        public decimal Vat
        {
            get
            {
                return _vat;
            }
            set
            {
                _vat = value;
                OnPropertyChanged("Vat");
                UpdateCosts();
            }
        }

        public decimal CostWithVat
        {
            get
            {
                return _costWithVat;
            }
            set
            {
                _costWithVat = value;
                UpdateCosts();
                OnPropertyChanged("CostWithVat");
            }

        }
    }
}
