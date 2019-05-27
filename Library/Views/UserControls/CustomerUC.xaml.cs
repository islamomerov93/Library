using Library.Entities;
using Library.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Library.Views.UserControls
{
    /// <summary>
    /// Interaction logic for CustomerUC.xaml
    /// </summary>
    public partial class CustomerUC : UserControl
    {
        CustomerVM CustomerVM;
        public CustomerUC()
        {
            InitializeComponent();
            CustomerVM = new CustomerVM();

            ObservableCollection<Customer> Customers = new ObservableCollection<Customer>();
            Customer customer1 = new Customer(CustomerVM.NoCustomer++, "Islam", "Omerov", "050-586-67-18", DateTime.Now, "");
            Customer customer2 = new Customer(CustomerVM.NoCustomer++, "Saleh", "Aghabeyli", "050-586-67-18", DateTime.Now, "");
            Customer customer3 = new Customer(CustomerVM.NoCustomer++, "Tural", "Mustafayev", "050-586-67-18", DateTime.Now, "");
            Customer customer4 = new Customer(CustomerVM.NoCustomer++, "Cavid", "Eliyev", "050-586-67-18", DateTime.Now, "");
            Customers.Add(customer1);
            Customers.Add(customer2);
            Customers.Add(customer3);
            Customers.Add(customer4);
            CustomerVM.Customers = Customers;
            CustomerVM.btnAddCustomer = btnAddCustomer;

            DataContext = CustomerVM;
        }
    }
}
