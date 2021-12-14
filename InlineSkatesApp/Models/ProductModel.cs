using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace InlineSkatesApp.Models
{
    public class ProductModel : INotifyPropertyChanged
    {
        private int _productId;
        public int ProductId
        {
            get => _productId;
            set
            {
                _productId = value;
                OnPropertyChanged();
            }
        }

        private string _productName;
        public string ProductName
        {
            get => _productName;
            set
            {
                _productName = value;
                OnPropertyChanged();
            }
        }

        private decimal _productPrice;
        public decimal ProductPrice
        {
            get => _productPrice;
            set
            {
                _productPrice = decimal.Round(value, 2, MidpointRounding.AwayFromZero);
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
