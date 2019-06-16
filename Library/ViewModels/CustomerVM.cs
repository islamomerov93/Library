using Commands.CustomerCommands;
using Library.Domain.Entities;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

        ObservableCollection<Branch> branches;
        public ObservableCollection<Branch> Branches
        {
            get { return branches; }
            set { branches = value; OnPropertyChanged(new PropertyChangedEventArgs(nameof(Branches))); }
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
    }
}
