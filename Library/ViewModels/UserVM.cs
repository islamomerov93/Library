﻿using Commands.UserCommands;
using Library.Domain.Entities;
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

        ObservableCollection<User> myFilteredUsers;
        public ObservableCollection<User> MyFilteredUsers
        {
            get
            {
                //if (SearchText == null)
                return users;
                //return new ObservableCollection<Customer>(customers.Where(x => x.Name.ToLower().Contains(SearchText.ToLower()) ||
                //x.Surname.ToLower().Contains(SearchText.ToLower()) ||
                //x.PhoneNumber.ToLower().Contains(SearchText.ToLower())).ToList());
            }
            set { myFilteredUsers = value; OnPropertyChanged(new PropertyChangedEventArgs(nameof(MyFilteredUsers))); }
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

        private string searchText;
        public string SearchText
        {
            get { return searchText; }
            set
            {
                searchText = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SearchText)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(MyFilteredUsers)));
            }
        }
    }
}
