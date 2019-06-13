﻿using System;
using System.Data.SqlClient;
using System.Windows;

namespace Library.Views
{
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click_1(object sender, RoutedEventArgs e)
        {
            String message = "Invalid Credentials";
            try
            {
                using (SqlConnection con = new SqlConnection(/*connectionString*/))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("Select * from Users where Username=@Username and Password=@Password", con))
                    {
                        cmd.Parameters.AddWithValue("@Username", txtUsername.Text.ToString());
                        cmd.Parameters.AddWithValue("@PassWord", txtPassword.Password.ToString());
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            if (reader["Password"].ToString().Equals(txtPassword.Password.ToString(), StringComparison.InvariantCulture))
                            {
                                message = "1";
                                //UserInfo.Username = txtUsername.Text.ToString();
                                //UserInfo.Username = reader["Username"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                message = ex.Message.ToString();
            }
            if (message == "1")
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else MessageBox.Show(message, "Info");
        }

        private void btnClose_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
