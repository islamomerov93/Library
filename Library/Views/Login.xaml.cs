﻿using Library.Domain.Entities;
using System;
using System.Data.SqlClient;
using System.Windows;

namespace Library.Views
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        static String connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Library;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public Login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click_1(object sender, RoutedEventArgs e)
        {
            String message = "Invalid Credentials";
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                cmd = new SqlCommand("Select * from Users where Username=@Username and Password=@Password", con);
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text.ToString());
                cmd.Parameters.AddWithValue("@PassWord", txtPassword.Password.ToString());
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (reader["Password"].ToString().Equals(txtPassword.Password.ToString(), StringComparison.InvariantCulture))
                    {
                        message = "1";
                        UserInfo.Username = txtUsername.Text.ToString();
                        UserInfo.Username = reader["Username"].ToString();
                    }
                }

                reader.Close();
                reader.Dispose();
                cmd.Dispose();
                con.Close();
                MessageBox.Show("asdadasdsadasda");
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
            else
                MessageBox.Show(message, "Info");
        }

        private void btnClose_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}