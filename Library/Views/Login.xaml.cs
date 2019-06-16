using Library.ViewModels;
using System;
using System.Data.SqlClient;
using System.Windows;

namespace Library.Views
{
    public partial class Login : Window
    {
        LogInVM LogInVM;
        public Login()
        {
            InitializeComponent();
            LogInVM = new LogInVM();
            DataContext = LogInVM;
        }

        private void btnClose_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
