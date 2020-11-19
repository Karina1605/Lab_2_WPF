using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Lab_2.models;


namespace Lab_2.viewModels
{
    class OrderViewModel :INotifyPropertyChanged
    {
        private readonly Order order;
        public DateTime Date
        {
            get
            {
                return order.Date;
            }
            set
            {
                order.Date = value;
                OnPropertyChanged("Date");
            }
        }
        public OrderViewModel (Order order)
        {
            this.order = order;
        }
       /* public Dictionary<Product, int> Products
        {
            get
            {
                return order.Products;
            }
            set
            {
                order.Products = value;
                OnPropertyChanged("Products");
            }
        }*/
        public event PropertyChangedEventHandler PropertyChanged;


        private void OnPropertyChanged(string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
