using Commands.CustomerCommands;
using Library.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Library.ViewModels
{
    public class CustomerVM : BaseVM
    {
        public CustomerVM()
        {
            AddCustomer = new AddCustomerCMD(this);
            EditCustomer = new EditCustomerCMD(this);
            RejectCustomer = new RejectCustomerCMD(this);
            DeleteCustomer = new DeleteCustomerCMD(this);

            CurrentCustomer = new Customer();
        }

        public int NoCustomer = 1;
        public Button btnAddCustomer { get; set; }
        public AddCustomerCMD AddCustomer { get; set; }
        public EditCustomerCMD EditCustomer { get; set; }
        public RejectCustomerCMD RejectCustomer { get; set; }
        public DeleteCustomerCMD DeleteCustomer { get; set; }

        int stateCustomer;
        public int StateCustomer
        {
            get { return stateCustomer; }
            set { stateCustomer = value; OnPropertyChanged(new PropertyChangedEventArgs(nameof(StateCustomer))); }
        }

        ObservableCollection<Customer> customers;
        public ObservableCollection<Customer> Customers
        {
            get { return customers; }
            set { customers = value; OnPropertyChanged(new PropertyChangedEventArgs(nameof(Customers))); }
        }

        ObservableCollection<Customer> myFilteredCustomers;
        public ObservableCollection<Customer> MyFilteredCustomers
        {
            get
            {
                if (SearchText == null) return customers;
                return new ObservableCollection<Customer>(customers.Where(x => x.Name.ToLower().Contains(SearchText.ToLower()) ||
                x.Surname.ToLower().Contains(SearchText.ToLower()) ||
                x.PhoneNumber.ToLower().Contains(SearchText.ToLower())).ToList());
            }
            set { myFilteredCustomers = value; OnPropertyChanged(new PropertyChangedEventArgs(nameof(MyFilteredCustomers))); }
        }

        private Customer selectedCustomer;

        public Customer SelectedCustomer
        {
            get { return selectedCustomer; }
            set { selectedCustomer = value; if (value != null) CurrentCustomer = value.Clone(); }
        }

        private Customer currentCustomer;

        
        public Customer CurrentCustomer
        {
            get { return currentCustomer; }
            set { currentCustomer = value; OnPropertyChanged(new PropertyChangedEventArgs(nameof(CurrentCustomer))); }
        }

        private string searchText;
        public string SearchText
        {
            get { return searchText; }
            set
            {
                searchText = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SearchText)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(MyFilteredCustomers)));
            }
        }
    }
}
