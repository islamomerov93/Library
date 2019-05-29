using Library.Entities;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Controls;

namespace Library.ViewModels
{
    class BookSaleVM : BaseVM
    {
        public BookSaleVM()
        {
        }
        public int NoBook = 1;
        public Button btnAddBook { get; set; }


        ObservableCollection<Book> books;
        public ObservableCollection<Book> Books
        {
            get { return books; }
            set { books = value; OnPropertyChanged(new PropertyChangedEventArgs(nameof(Books))); }
        }

        private Book selectedBook;
        public Book SelectedBook
        {
            get { return selectedBook; }
            set { selectedBook = value;}
        }
    }
}
