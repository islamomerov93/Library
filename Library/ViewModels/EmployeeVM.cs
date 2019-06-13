using Commands.EmployeeCommands;
using Library.Domain.Entities;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Controls;

namespace Library.ViewModels
{
    public class EmployeeVM : BaseVM
    {
        public EmployeeVM()
        {
            AddEmployee = new AddEmployeeCMD(this);
            EditEmployee = new EditEmployeeCMD(this);
            RejectEmployee = new RejectEmployeeCMD(this);
            DeleteEmployee = new DeleteEmployeeCMD(this);

            CurrentEmployee = new Employee();
        }

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
                //if (SearchText == null)
                return employees;
                //return new ObservableCollection<Customer>(customers.Where(x => x.Name.ToLower().Contains(SearchText.ToLower()) ||
                //x.Surname.ToLower().Contains(SearchText.ToLower()) ||
                //x.PhoneNumber.ToLower().Contains(SearchText.ToLower())).ToList());
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

        private string searchText;
        public string SearchText
        {
            get { return searchText; }
            set
            {
                searchText = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SearchText)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(MyFilteredEmployees)));
            }
        }
    }
}
