using Commands.UserCommands;
using Library.Domain.Entities;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Controls;

namespace Library.ViewModels
{
    public class UserVM : BaseVM
    {
        public UserVM()
        {
            AddUser = new AddUserCMD(this);
            EditUser = new EditUserCMD(this);
            RejectUser = new RejectUserCMD(this);
            DeleteUser = new DeleteUserCMD(this);

            CurrentUser = new User();
        }

        public int NoUser = 1;
        public PasswordBox PasswordBox { get; set; }
        public Button btnAddUser { get; set; }
        public AddUserCMD AddUser { get; set; }
        public EditUserCMD EditUser { get; set; }
        public RejectUserCMD RejectUser { get; set; }
        public DeleteUserCMD DeleteUser { get; set; }

        int stateUser;
        public int StateUser
        {
            get { return stateUser; }
            set { stateUser = value; OnPropertyChanged(new PropertyChangedEventArgs(nameof(StateUser))); }
        }

        ObservableCollection<User> users;
        public ObservableCollection<User> Users
        {
            get { return users; }
            set { users = value; OnPropertyChanged(new PropertyChangedEventArgs(nameof(Users))); }
        }

        private User selectedUser;

        public User SelectedUser
        {
            get { return selectedUser; }
            set { selectedUser = value; if (value != null) CurrentUser = value.Clone(); }
        }

        private User currentUser;


        public User CurrentUser
        {
            get { return currentUser; }
            set { currentUser = value; OnPropertyChanged(new PropertyChangedEventArgs(nameof(CurrentUser))); }
        }
    }
}
