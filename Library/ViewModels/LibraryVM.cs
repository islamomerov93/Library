using Library.Commands.UCAddingCommands;
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
        public LibraryVM()
        {
            AddBookSaleUC = new AddBookSaleUCCMD(this);
            AddBookUC = new AddBookUCCMD(this);
            AddEmployeeUC = new AddEmployeeUCCMD(this);
            AddCustomerUC = new AddCustomerUCCMD(this);
            AddBranchUC = new AddBranchUCCMD(this);
            AddUserUC = new AddUserUCCMD(this);
        }
        public static Grid Grid { get; set; }
    }
}
