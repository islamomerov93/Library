using Library.Domain.Entities;
using Library.ViewModels;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Library.Views.UserControls
{
    /// <summary>
    /// Interaction logic for BookSalesUC.xaml
    /// </summary>
    public partial class BookSalesUC : UserControl
    {
        BookSaleVM BookSaleVM;
        public BookSalesUC()
        {
            InitializeComponent();
            BookSaleVM = new BookSaleVM();

            ObservableCollection<Book> Books = new ObservableCollection<Book>();
            Book book1 = new Book(BookSaleVM.NoBook++, "C#", "Islam", 10, 20, 50, null, "");
            Book book2 = new Book(BookSaleVM.NoBook++, "C++", "Tural", 10, 20, 50, null, "");
            Book book3 = new Book(BookSaleVM.NoBook++, "C", "Saleh", 10, 20, 50, null, "");
            Book book4 = new Book(BookSaleVM.NoBook++, "F#", "Cavid", 10, 20, 50, null, "");
            Books.Add(book1);
            Books.Add(book2);
            Books.Add(book3);
            Books.Add(book4);
            BookSaleVM.Books = Books;
            BookCmBx.ItemsSource = Books;
            BookCmBx.
            DataContext = BookSaleVM;
        }
        void closeButton_Click(object sender, RoutedEventArgs e)
        {
            LibraryVM.Grid.Children.Remove(this);
        }


        private void BookCmBx_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            BookCmBx.IsDropDownOpen = true;
            BookCmBx.ItemsSource = BookSaleVM.Books.ToList().Where(x => x.Title.ToLower().Contains(BookCmBx.Text.ToLower()));
        }

        private void CustomerCmBx_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            CustomerCmBx.IsDropDownOpen = true;
            CustomerCmBx.ItemsSource = BookSaleVM.Customers.Where(x => x.Fullname.ToLower().Contains(CustomerCmBx.Text.ToLower()));
        }
    }
}
