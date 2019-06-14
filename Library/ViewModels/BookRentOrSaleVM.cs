using Library.Models;
using System.Collections.ObjectModel;

namespace Library.ViewModels
{
    class BookRentOrSaleVM : BaseVM
    {
        public BookRentOrSaleVM()
        {
        }

        ObservableCollection<BookState> books;
        public ObservableCollection<BookState> AllBooks {
            get { return books; }
            set { books = value; OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(AllBooks))); }
        }
    }
}
