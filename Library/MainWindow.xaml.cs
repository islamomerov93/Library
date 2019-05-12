using Library.Entities;
using Library.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace Library
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LibraryVM LibraryVM;
        public MainWindow()
        {
            InitializeComponent();
            this.LibraryVM = new LibraryVM();
            ObservableCollection<Branch> Branches = new ObservableCollection<Branch>();
            Branch branch1 = new Branch(LibraryVM.NoBranch++, "Upper Education", "Nizami Street", "");
            Branch branch2 = new Branch(LibraryVM.NoBranch++, "Upper Education", "Koroglu Street", "");
            Branch branch3 = new Branch(LibraryVM.NoBranch++, "Upper Education", "28 May Street", "");
            Branch branch4 = new Branch(LibraryVM.NoBranch++, "Upper Education", "N.Narimanov Street", "");
            Branches.Add(branch1);
            Branches.Add(branch2);
            Branches.Add(branch3);
            Branches.Add(branch4);
            LibraryVM.Branches = Branches;

            DateTime dateTime = new DateTime();
            ObservableCollection<Customer> Customers = new ObservableCollection<Customer>();
            Customer customer1 = new Customer(LibraryVM.NoCustomer++, "Islam", "Omerov", "050-586-67-18", dateTime,"");
            Customer customer2 = new Customer(LibraryVM.NoCustomer++, "Saleh", "Aghabeyli", "050-586-67-18", dateTime,"");
            Customer customer3 = new Customer(LibraryVM.NoCustomer++, "Tural", "Mustafayev", "050-586-67-18", dateTime,"");
            Customer customer4 = new Customer(LibraryVM.NoCustomer++, "Cavid", "Eliyev", "050-586-67-18", dateTime,"");
            Customers.Add(customer1);
            Customers.Add(customer2);
            Customers.Add(customer3);
            Customers.Add(customer4);
            LibraryVM.Customers = Customers;
            LibraryVM.btnAddCustomer = btnAddCustomer;
            DataContext = LibraryVM;

            ObservableCollection<Book> Books = new ObservableCollection<Book>();
            Book book1 = new Book(LibraryVM.NoBook++, "C#",  "Islam", 10, 20, 50, branch1, "");
            Book book2 = new Book(LibraryVM.NoBook++, "C++", "Tural", 10, 20, 50, branch2, "");
            Book book3 = new Book(LibraryVM.NoBook++, "C",   "Saleh", 10, 20, 50, branch3, "");
            Book book4 = new Book(LibraryVM.NoBook++, "F#",  "Cavid", 10, 20, 50, branch4, "");
            Books.Add(book1);
            Books.Add(book2);
            Books.Add(book3);
            Books.Add(book4);
            LibraryVM.Books = Books;
            LibraryVM.btnAddBook = btnAddBook;
            DataContext = LibraryVM;
        }
    }
}
