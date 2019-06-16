using Library.Commands.UCAddingCommands;
using Library.Domain.Entities;
using System.Windows.Controls;

namespace Library.ViewModels
{
    public class LibraryVM : BaseVM
    {
        public AddUserUCCMD AddUserUC { get; set; }
        public AddBookSaleUCCMD AddBookSaleUC { get; set; }
        public AddBookUCCMD AddBookUC { get; set; }
        public AddEmployeeUCCMD AddEmployeeUC { get; set; }
        public AddCustomerUCCMD AddCustomerUC { get; set; }
        public AddBranchUCCMD AddBranchUC { get; set; }
        public AddSaleReportsUCCMD AddSaleReportsUC { get; set; }
        public AddRentalReportsUCCMD AddRentalReportsUC { get; set; }

        public LibraryVM()
        {
            AddBookSaleUC = new AddBookSaleUCCMD(this);
            AddBookUC = new AddBookUCCMD(this);
            AddEmployeeUC = new AddEmployeeUCCMD(this);
            AddCustomerUC = new AddCustomerUCCMD(this);
            AddBranchUC = new AddBranchUCCMD(this);
            AddUserUC = new AddUserUCCMD(this);
            AddSaleReportsUC = new AddSaleReportsUCCMD(this);
            AddRentalReportsUC = new AddRentalReportsUCCMD(this);
        }

        public string Username
        {
            get
            {
                return App.CurrentUser.Username;
            }
        }
        public static Grid Grid { get; set; }
    }
}
