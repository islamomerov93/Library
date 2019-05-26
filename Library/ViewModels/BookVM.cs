using Commands.BookCommands;
using Library.Entities;
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
    public class BookVM : BaseVM
    {
        public BookVM()
        {
            AddBook = new AddBookCMD(this);
            EditBook = new EditBookCMD(this);
            RejectBook = new RejectBookCMD(this);
            DeleteBook = new DeleteBookCMD(this);

            CurrentBook = new Book();
        }  
        public int NoBook = 1;
        public Button btnAddBook { get; set; }
        public AddBookCMD AddBook { get; set; }
        public EditBookCMD EditBook { get; set; }
        public RejectBookCMD RejectBook { get; set; }
        public DeleteBookCMD DeleteBook { get; set; }

        int stateBook;
        public int StateBook
        {
            get { return stateBook; }
            set { stateBook = value; OnPropertyChanged(new PropertyChangedEventArgs(nameof(StateBook))); }
        }

        ObservableCollection<Book> books;
        public ObservableCollection<Book> Books
        {
            get { return books; }
            set { books = value; OnPropertyChanged(new PropertyChangedEventArgs(nameof(Books))); }
        }

        ObservableCollection<Book> myFilteredBooks;
        public ObservableCollection<Book> MyFilteredBooks
        {
            get
            {
                if (SearchText == null) return books;
                return new ObservableCollection<Book>(books.Where(x => x.Title.ToLower().Contains(SearchText.ToLower()) || x.AuthorName.ToLower().Contains(SearchText.ToLower()) ||
                x.Branch.Address.ToLower().Contains(SearchText.ToLower())).ToList());
            }
            set { myFilteredBooks = value; OnPropertyChanged(new PropertyChangedEventArgs(nameof(MyFilteredBooks))); }
        }

        private Book selectedBook;
        public Book SelectedBook
        {
            get { return selectedBook; }
            set { selectedBook = value; if (value != null) CurrentBook = value.Clone(); }
        }

        private Book currentBook;
        public Book CurrentBook
        {
            get { return currentBook; }
            set { currentBook = value; OnPropertyChanged(new PropertyChangedEventArgs(nameof(CurrentBook))); }
        }

        private string searchText;
        public string SearchText
        {
            get { return searchText; }
            set
            {
                searchText = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SearchText)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(MyFilteredBooks)));
            }
        }
    }
}
