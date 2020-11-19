using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Lab_2.models;

namespace Lab_2.viewModels
{
    class CustomerViewModel :INotifyPropertyChanged
    {
        private readonly Customer customer;
        public CustomerViewModel(Customer customer)
        {
            this.customer = customer;
        }
        public string Name
        {
            get
            {
                return customer.Name;
            }
            set
            {
                customer.Name = value;
                OnPropertyChanged("Name");
            }
        }
        public string Email
        {
            get
            {
                return customer.Email;
            }
            set
            {
                customer.Email = value;
                OnPropertyChanged("Email");
            }
        }
        public string Phone
        {
            get
            {
                return customer.PhoneNumber;
            }
            set
            {
                customer.PhoneNumber = value;
                OnPropertyChanged("Phone");
            }
        }
        public int CountOfOrders {
            get {

               return customer.Orders.Count();

            }
        }
        public List<Order> Orders
        {
            get
            {
                return customer.Orders;
            }
            set
            {
                customer.Orders = value;
                OnPropertyChanged("Orders");
            }
        }
        public City City
        {
            get
            {
                return customer.City;
            }
            set
            {
                customer.City = City;
                OnPropertyChanged("City");
            }
        }
       

        public event PropertyChangedEventHandler PropertyChanged;


        private void OnPropertyChanged(string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
