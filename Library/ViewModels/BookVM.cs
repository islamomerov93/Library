using Commands.BookCommands;
using Library.Domain.Entities;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
            Customers = new List<Customer>();

            CurrentBook = new Book();
        }  
        public int NoBook = 1;
        public Button btnAddBook { get; set; }
        public AddBookCMD AddBook { get; set; }
        public EditBookCMD EditBook { get; set; }
        public RejectBookCMD RejectBook { get; set; }
        public DeleteBookCMD DeleteBook { get; set; }
        public List<Customer> Customers{ get; set; }

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

        ObservableCollection<Branch> branches;
        public ObservableCollection<Branch> Branches
        {
            get { return branches; }
            set { branches = value; OnPropertyChanged(new PropertyChangedEventArgs(nameof(Branches))); }
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
    }
}
