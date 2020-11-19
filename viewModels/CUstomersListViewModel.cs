using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;

using Lab_2.models;
using Lab_2.Commands;
namespace Lab_2.viewModels
{
    class CustomersListViewModel :INotifyPropertyChanged
    {
        public ObservableCollection<CustomerViewModel> Customers 
        {
            get;
            set;
        }
        public ICollectionView CustomerView
        {
            get;
            set;
        }
        private CustomerViewModel selectedCustomer;
        
        public CustomerViewModel SelectedCustomer
        {
            get { return selectedCustomer; }
            set
            {
                selectedCustomer = value;
                OnPropertyChanged("SelectedCustomer");
            }
        }
        public CustomersListViewModel()
        {
            Customers = new ObservableCollection<CustomerViewModel>();
            Initialize();
            InitializeGrouppedView();
            InitializeCommands();
        }

        private void InitializeCommands()
        {
            DeleteCommand =new RelayCommand(DeleteCustomer, CanExecuteDeleteStudent);
        }

        public ICommand DeleteCommand { get; set; }
        public void DeleteCustomer(object customer)
        {

            Customers.Remove(customer as CustomerViewModel);
            SelectedCustomer = Customers.FirstOrDefault();
        }

        public bool CanExecuteDeleteStudent(object customer)
        {
            return customer != null && customer is CustomerViewModel;
        }
        private bool isGroupped;
        public bool IsGroupped
        {
            get
            {
                return isGroupped;
            }
            set
            {
                isGroupped = value;
                OnPropertyChanged("IsGroupped");
                GroupUnGroup();
            }
        }
        private void InitializeGrouppedView()
        {
            CustomerView = CollectionViewSource.GetDefaultView(Customers);
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void GroupUnGroup()
        {
            CustomerView.GroupDescriptions.Clear();
            if (IsGroupped)
                CustomerView.GroupDescriptions.Add(new PropertyGroupDescription("City"));
        }
        private void Initialize()
        {
            Customers = new ObservableCollection<CustomerViewModel>();
            Customers.Add(new CustomerViewModel(new Customer() 
            {
                Name="Aaa",
                Email = "bbb@mail.ru",
                City = City.Moscow,
                Id =1,
                PhoneNumber="89601852366",
                Orders =new List<Order>() { 
                    new Order() {Id=1, Date =new DateTime(2020, 4, 12) }, 
                    new Order() {Id =2, Date =new DateTime(2019, 5, 20) }, 
                    new Order() {Id=3, Date=new DateTime(2020, 10, 10)}, 
                    new Order() {Id =5, Date =new DateTime(2020, 1, 1) } }
            }));
            Customers.Add(new CustomerViewModel(new Customer()
            {
                Name = "BBb",
                Email = "ccc@yandex.ru",
                City = City.Kazan,
                Id = 2,
                PhoneNumber = "89105438912",
                Orders = new List<Order>() { 
                    new Order() {Id =4, Date=new DateTime(2020, 12, 2) },  
                    new Order() {Id =7, Date =new DateTime(2019, 7, 24) }, 
                    new Order() {Id= 12, Date=new DateTime(2020, 6, 6) } }
            }));
            Customers.Add(new CustomerViewModel(new Customer()
            {
                Name = "Ccc c",
                Email = "aaa@mail.ru",
                City = City.Norilsk,
                Id = 3,
                PhoneNumber = "99501632751",
                Orders = new List<Order>() { 
                    new Order() {Id =20, Date=new DateTime() }, 
                    new Order() {Id =13, Date =new DateTime(2020, 2, 24) }, 
                    new Order() { Id =10, Date =new DateTime(2020, 3, 8)}, 
                    new Order() {Id = 17, Date =new DateTime(2020, 9, 10) } }

            }));
            Customers.Add(new CustomerViewModel(new Customer()
            {
                Name = "Zz",
                Email = "zz@mail.ru",
                City = City.Voronezh,
                Id = 4,
                PhoneNumber = "89601082630",
                Orders = new List<Order>() { 
                    new Order() {Id =14, Date =new DateTime() }, 
                    new Order() {Id =18, Date =new DateTime(2020, 3, 19) }, 
                    new Order() {Id= 33, Date =new DateTime(2019, 4, 4) }}
            }));
            Customers.Add(new CustomerViewModel(new Customer()
            {
                Name = "Kkk k",
                Email = "Kk@mail.ru",
                City = City.Norilsk,
                Id = 5,
                PhoneNumber = "89601852366",
                Orders = new List<Order>() { 
                    new Order() {Id =55, Date =new DateTime() }, 
                    new Order() {Id =81, Date =new DateTime(2020, 10, 2) }}
            }));
            Customers.Add(new CustomerViewModel(new Customer()
            {
                Name = "OOo",
                Email = "p@mail.ru",
                City = City.Kazan,
                Id = 6,
                PhoneNumber = "89572107425",
                Orders = new List<Order>() { 
                    new Order() {Id=100, Date =new DateTime(2020, 11, 15) }}
            }));
            Customers.Add(new CustomerViewModel(new Customer()
            {
                Name = "L l",
                Email = "ll@mail.ru",
                City = City.Saratov,
                Id = 7,
                PhoneNumber = "89951284105",
                Orders = new List<Order>() { 
                    new Order() {Id =51, Date =new DateTime(2018, 3, 3) }, 
                    new Order() {Id =47, Date = new DateTime(2019, 6, 8) }, 
                    new Order() {Id=56, Date =new DateTime(2019, 1, 1) }, 
                    new Order() {Id =28, Date =new DateTime() } }
            }));
            Customers.Add(new CustomerViewModel(new Customer()
            {
                Name = "II I",
                Email = "iii@mail.ru",
                City = City.StPeterburg,
                Id = 8,
                PhoneNumber = "89051842904",
                Orders = new List<Order>() { 
                    new Order() {Id =49, Date = new DateTime(2018, 12, 11) }, 
                    new Order() {Id =41, Date =new DateTime(2019, 11, 11) }, 
                    new Order() {Id= 31, Date =new DateTime()}}

            }));
            

        }

        private void OnPropertyChanged(string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
