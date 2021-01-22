using System;
using System.ComponentModel;

namespace Tabular
{
    public class CustomerInfo : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected string _CustomerNumber;
        protected string _CustomerName;

        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, e);
        }

        protected void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        public string CustomerNumber
        {
            get => _CustomerNumber;
            set
            {
                if (value != _CustomerNumber)
                {
                    OnPropertyChanged("CustomerNumber");
                }
            }
        }
        public string CustomerName
        {
            get => _CustomerName;
            set
            {
                if (value != _CustomerName)
                {
                    OnPropertyChanged("CustomerName");
                }
            }
        }

        public CustomerInfo()
        {
            _CustomerNumber = string.Empty;
            _CustomerName = string.Empty;
        }

    }
}
