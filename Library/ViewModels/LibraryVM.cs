using Commands;
using Commands.BookCommands;
using Commands.BranchCommands;
using Commands.CustomerCommands;
using Commands.EmployeeCommands;
using Library.Entities;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Controls;

namespace Library.ViewModels
{
    public class LibraryVM : BaseVM
    {
        # region Book
        public int NoBook = 1;
        public Button btnAddBook { get; set; }
        public AddBookCMD AddBook { get; set; }
        public EditBookCMD EditBook { get; set; }
        public RejectBookCMD RejectBook { get; set; }
        public DeleteBookCMD DeleteBook { get; set; }

        int stateBook;
        public int StateBook
        {
            get { return stateBook; }
            set { stateBook = value; OnPropertyChanged(new PropertyChangedEventArgs(nameof(StateBook))); }
        }

        ObservableCollection<Book> books;
        public ObservableCollection<Book> Books
        {
            get { return books; }
            set { books = value; OnPropertyChanged(new PropertyChangedEventArgs(nameof(Books))); }
        }

        ObservableCollection<Book> myFilteredBooks;
        public ObservableCollection<Book> MyFilteredBooks
        {
            get
            {
                if (SearchText == null) return books;
                return new ObservableCollection<Book>(books.Where(x => x.Title.ToLower().Contains(SearchText.ToLower()) || x.AuthorName.ToLower().Contains(SearchText.ToLower()) ||
                x.Branch.Address.ToLower().Contains(SearchText.ToLower())).ToList());
            }
            set { myFilteredBooks = value; OnPropertyChanged(new PropertyChangedEventArgs(nameof(MyFilteredBooks))); }
        }

        private Book selectedBook;

        public Book SelectedBook
        {
            get { return selectedBook; }
            set { selectedBook = value; if (value != null) CurrentBook = value.Clone(); }
        }

        private Book currentBook;

        public Book CurrentBook
        {
            get { return currentBook; }
            set { currentBook = value; OnPropertyChanged(new PropertyChangedEventArgs(nameof(CurrentBook))); }
        }
        #endregion

        #region Branch
        public int NoBranch = 1;
        public Button btnAddBranch { get; set; }
        public AddBranchCMD AddBranch { get; set; }
        public EditBranchCMD EditBranch { get; set; }
        public RejectBranchCMD RejectBranch { get; set; }
        public DeleteBranchCMD DeleteBranch { get; set; }

        int stateBranch;
        public int StateBranch
        {
            get { return stateBranch; }
            set { stateBranch = value; OnPropertyChanged(new PropertyChangedEventArgs(nameof(StateBranch))); }
        }

        ObservableCollection<Branch> branches;
        public ObservableCollection<Branch> Branches
        {
            get { return branches; }
            set { branches = value; OnPropertyChanged(new PropertyChangedEventArgs(nameof(Branches))); }
        }

        ObservableCollection<Branch> myFilteredBranches;
        public ObservableCollection<Branch> MyFilteredBranches
        {
            get
            {
                if (SearchText == null) return branches;
                return new ObservableCollection<Branch>(branches.Where(x => x.Name.ToLower().Contains(SearchText.ToLower()) || x.Address.ToLower().Contains(SearchText.ToLower())).ToList());
            }
            set { myFilteredBranches = value; OnPropertyChanged(new PropertyChangedEventArgs(nameof(MyFilteredBranches))); }
        }

        private Branch selectedBranch;

        public Branch SelectedBranch
        {
            get { return selectedBranch; }
            set { selectedBranch = value; if (value != null) CurrentBranch = value.Clone(); }
        }

        private Branch currentBranch;

        public Branch CurrentBranch
        {
            get { return currentBranch; }
            set { currentBranch = value; OnPropertyChanged(new PropertyChangedEventArgs(nameof(CurrentBranch))); }
        }
        #endregion

        #region Customer
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
        #endregion

        #region Employee
        public int NoEmployee = 1;
        public Button btnAddEmployee { get; set; }
        public AddEmployeeCMD AddEmployee { get; set; }
        public EditEmployeeCMD EditEmployee { get; set; }
        public RejectEmployeeCMD RejectEmployee { get; set; }
        public DeleteEmployeeCMD DeleteEmployee { get; set; }

        int stateEmployee;
        public int StateEmployee
        {
            get { return stateEmployee; }
            set { stateEmployee = value; OnPropertyChanged(new PropertyChangedEventArgs(nameof(StateEmployee))); }
        }

        ObservableCollection<Employee> employees;
        public ObservableCollection<Employee> Employees
        {
            get { return employees; }
            set { employees = value; OnPropertyChanged(new PropertyChangedEventArgs(nameof(Employees))); }
        }

        ObservableCollection<Employee> myFilteredEmployees;
        public ObservableCollection<Employee> MyFilteredEmployees
        {
            get
            {
                if (SearchText == null) return employees;
                return new ObservableCollection<Employee>(employees.Where(x => x.Name.ToLower().Contains(SearchText.ToLower()) ||
                                                                          x.Surname.ToLower().Contains(SearchText.ToLower()) ||
                                                                          x.PhoneNumber.ToLower().Contains(SearchText.ToLower()) ||
                                                                          x.Branch.Address.ToLower().Contains(SearchText.ToLower()) ||
                                                                          x.Branch.Name.ToLower().Contains(SearchText.ToLower())).ToList());
            }
            set { myFilteredEmployees = value; OnPropertyChanged(new PropertyChangedEventArgs(nameof(MyFilteredEmployees))); }
        }

        private Employee selectedEmployee;

        public Employee SelectedEmployee
        {
            get { return selectedEmployee; }
            set { selectedEmployee = value; if (value != null) CurrentEmployee = value.Clone(); }
        }

        private Employee currentEmployee;

        public Employee CurrentEmployee
        {
            get { return currentEmployee; }
            set { currentEmployee = value; OnPropertyChanged(new PropertyChangedEventArgs(nameof(CurrentEmployee))); }
        }
        #endregion

        public LibraryVM()
        {
            AddBook = new AddBookCMD(this);
            EditBook = new EditBookCMD(this);
            RejectBook = new RejectBookCMD(this);
            DeleteBook = new DeleteBookCMD(this);

            AddCustomer = new AddCustomerCMD(this);
            EditCustomer = new EditCustomerCMD(this);
            RejectCustomer = new RejectCustomerCMD(this);
            DeleteCustomer = new DeleteCustomerCMD(this);

            AddEmployee = new AddEmployeeCMD(this);
            EditEmployee = new EditEmployeeCMD(this);
            RejectEmployee = new RejectEmployeeCMD(this);
            DeleteEmployee = new DeleteEmployeeCMD(this);

            AddBranch = new AddBranchCMD(this);
            EditBranch = new EditBranchCMD(this);
            RejectBranch = new RejectBranchCMD(this);
            DeleteBranch = new DeleteBranchCMD(this);

            CurrentBook = new Book();
            CurrentCustomer = new Customer();
            CurrentEmployee = new Employee();
            CurrentBranch = new Branch();
        }

        
        private string searchText;

        public string SearchText
        {
            get { return searchText; }
            set
            {
                searchText = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SearchText)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(MyFilteredBooks)));
            }
        }
    }
}
