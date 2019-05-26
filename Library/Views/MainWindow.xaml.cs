using Library.Entities;
using Library.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace Library
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LibraryVM LibraryVM;
        DispatcherTimer _timer;
        TimeSpan _time;
        DispatcherTimer _timer2;
        TimeSpan _time2;

        new object objectNew;
        public MainWindow()
        {
            InitializeComponent();
            _time2 = TimeSpan.FromSeconds(3);

            _timer2 = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                if (_time2.Seconds == 3) btnTopMenuShow_Click(objectNew, new RoutedEventArgs()); 
                if (_time2 == TimeSpan.Zero) _timer2.Stop();
                _time2 = _time2.Add(TimeSpan.FromSeconds(-1));
                if (_time2.Seconds == 0) btnTopMenuHide_Click(objectNew, new RoutedEventArgs());
            }, Application.Current.Dispatcher);
            _timer2.Start();

            this.LibraryVM = new LibraryVM();
            //ObservableCollection<Branch> Branches = new ObservableCollection<Branch>();
            //Branch branch1 = new Branch(LibraryVM.NoBranch++, "Upper Education", "Nizami Street", "");
            //Branch branch2 = new Branch(LibraryVM.NoBranch++, "Upper Education", "Koroglu Street", "");
            //Branch branch3 = new Branch(LibraryVM.NoBranch++, "Upper Education", "28 May Street", "");
            //Branch branch4 = new Branch(LibraryVM.NoBranch++, "Upper Education", "N.Narimanov Street", "");
            //Branches.Add(branch1);
            //Branches.Add(branch2);
            //Branches.Add(branch3);
            //Branches.Add(branch4);
            //LibraryVM.Branches = Branches;
            //LibraryVM.btnAddBranch = btnAddBranch;

            //ObservableCollection<Customer> Customers = new ObservableCollection<Customer>();
            //Customer customer1 = new Customer(LibraryVM.NoCustomer++, "Islam", "Omerov", "050-586-67-18", DateTime.Now, "");
            //Customer customer2 = new Customer(LibraryVM.NoCustomer++, "Saleh", "Aghabeyli", "050-586-67-18", DateTime.Now, "");
            //Customer customer3 = new Customer(LibraryVM.NoCustomer++, "Tural", "Mustafayev", "050-586-67-18", DateTime.Now, "");
            //Customer customer4 = new Customer(LibraryVM.NoCustomer++, "Cavid", "Eliyev", "050-586-67-18", DateTime.Now, "");
            //Customers.Add(customer1);
            //Customers.Add(customer2);
            //Customers.Add(customer3);
            //Customers.Add(customer4);
            //LibraryVM.Customers = Customers;
            //LibraryVM.btnAddCustomer = btnAddCustomer;

            //ObservableCollection<Employee> Employees = new ObservableCollection<Employee>();
            //Employee employee1 = new Employee(LibraryVM.NoCustomer++, "Islam", "Omerov", "050-586-67-18", branch1, 1000, "");
            //Employee employee2 = new Employee(LibraryVM.NoCustomer++, "Saleh", "Aghabeyli", "050-586-67-18", branch2, 1100, "");
            //Employee employee3 = new Employee(LibraryVM.NoCustomer++, "Tural", "Mustafayev", "050-586-67-18", branch3, 1200, "");
            //Employee employee4 = new Employee(LibraryVM.NoCustomer++, "Cavid", "Eliyev", "050-586-67-18", branch4, 1300, "");
            //Employees.Add(employee1);
            //Employees.Add(employee2);
            //Employees.Add(employee3);
            //Employees.Add(employee4);
            //LibraryVM.Employees = Employees;
            //LibraryVM.btnAddEmployee = btnAddEmployee;

            //ObservableCollection<Book> Books = new ObservableCollection<Book>();
            //Book book1 = new Book(LibraryVM.NoBook++, "C#",  "Islam", 10, 20, 50, branch1, "");
            //Book book2 = new Book(LibraryVM.NoBook++, "C++", "Tural", 10, 20, 50, branch2, "");
            //Book book3 = new Book(LibraryVM.NoBook++, "C",   "Saleh", 10, 20, 50, branch3, "");
            //Book book4 = new Book(LibraryVM.NoBook++, "F#",  "Cavid", 10, 20, 50, branch4, "");
            //Books.Add(book1);
            //Books.Add(book2);
            //Books.Add(book3);
            //Books.Add(book4);
            //LibraryVM.Books = Books;
            //LibraryVM.btnAddBook = btnAddBook;
            LibraryVM.Grid = MainGrid;
            DataContext = LibraryVM;
        }

        protected void DragWindow(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        bool maximized;
        protected void Double_Click(object sender, MouseButtonEventArgs e)
        {
            if (maximized) this.WindowState = WindowState.Normal;
            else this.WindowState = WindowState.Maximized;
            maximized = !maximized;
        }
        private void btnLeftMenuHide_Click(object sender, RoutedEventArgs e)
        {
            ShowHideMenu("sbHideLeftMenu", btnLeftMenuHide, btnLeftMenuShow, pnlLeftMenu);
        }

        private void btnLeftMenuShow_Click(object sender, RoutedEventArgs e)
        {
            ShowHideMenu("sbShowLeftMenu", btnLeftMenuHide, btnLeftMenuShow, pnlLeftMenu);
        }


        private void btnTopMenuHide_Click(object sender, RoutedEventArgs e)
        {
            ShowHideMenu("sbHideTopMenu", btnTopMenuHide, btnTopMenuShow, pnlTopMenu);
        }

        private void btnTopMenuShow_Click(object sender, RoutedEventArgs e)
        {
            ShowHideMenu("sbShowTopMenu", btnTopMenuHide, btnTopMenuShow, pnlTopMenu);
        }


        private void btnRightMenuHide_Click(object sender, RoutedEventArgs e)
        {
            tbTime.Text = "00:00:03";
            _timer.Stop();
            ShowHideMenu("sbHideRightMenu", btnRightMenuHide, btnRightMenuShow, pnlRightMenu);
        }

        private void btnRightMenuShow_Click(object sender, RoutedEventArgs e)
        {
            _time = TimeSpan.FromSeconds(2);
            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                tbTime.Text = _time.ToString("c");
                if (_time == TimeSpan.Zero) _timer.Stop();
                _time = _time.Add(TimeSpan.FromSeconds(-1));
                if (tbTime.Text == "00:00:00")
                {
                    System.Environment.Exit(1);
                }
            }, Application.Current.Dispatcher);
            _timer.Start();

            ShowHideMenu("sbShowRightMenu", btnRightMenuHide, btnRightMenuShow, pnlRightMenu);
        }

        private void ShowHideMenu(string Storyboard, Button btnHide, Button btnShow, StackPanel pnl)
        {
            Storyboard sb = Resources[Storyboard] as Storyboard;
            sb.Begin(pnl);

            if (Storyboard.Contains("Show"))
            {
                btnHide.Visibility = System.Windows.Visibility.Visible;
                btnShow.Visibility = System.Windows.Visibility.Hidden;
            }
            else if (Storyboard.Contains("Hide"))
            {
                btnHide.Visibility = System.Windows.Visibility.Hidden;
                btnShow.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void BtnRightMenuShow_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

        }
    }
}
