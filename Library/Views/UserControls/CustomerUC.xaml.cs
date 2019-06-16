using Library.Domain.Entities;
using Library.ViewModels;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

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
            CustomerVM.Customers = new ObservableCollection<Customer>(App.UnitOfWork.Customers.GetAll());
            CustomerVM.Branches = new ObservableCollection<Branch>(App.UnitOfWork.Branches.GetAll());
            CustomerVM.btnAddCustomer = btnAddCustomer;
            DataContext = CustomerVM;
        }
        void closeButton_Click(object sender, RoutedEventArgs e)
        {
            LibraryVM.Grid.Children.Remove(this);
        }
    }
}
