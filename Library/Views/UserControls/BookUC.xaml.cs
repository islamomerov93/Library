using Library.Domain.Entities;
using Library.ViewModels;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace Library.Views.UserControls
{
    /// <summary>
    /// Interaction logic for BookUC.xaml
    /// </summary>
    public partial class BookUC : UserControl
    {
        public BookVM BookVM;
        public BookUC()
        {
            InitializeComponent();
            BookVM = new BookVM();

            ObservableCollection<Book> Books = new ObservableCollection<Book>();
            Book book1 = new Book(BookVM.NoBook++, "C#", "Islam", 10, 20, 50, null, "");
            Book book2 = new Book(BookVM.NoBook++, "C++", "Tural", 10, 20, 50, null, "");
            Book book3 = new Book(BookVM.NoBook++, "C", "Saleh", 10, 20, 50, null, "");
            Book book4 = new Book(BookVM.NoBook++, "F#", "Cavid", 10, 20, 50, null, "");
            Books.Add(book1);
            Books.Add(book2);
            Books.Add(book3);
            Books.Add(book4);
            BookVM.Books = Books;
            BookVM.btnAddBook = btnAddBook;

            DataContext = BookVM;
        }
        void closeButton_Click(object sender, RoutedEventArgs e)
        {
            LibraryVM.Grid.Children.Remove(this);
        }
    }
}
